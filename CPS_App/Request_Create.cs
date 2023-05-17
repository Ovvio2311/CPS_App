using CPS_App.Helpers;
using CPS_App.Services;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.RegisterModel;
using static CPS_App.Models.DbModels;
using System.Security.Claims;
using System.Security.Cryptography;

namespace CPS_App
{
    public partial class Request_Create : Form
    {
        private DbServices _dbServices;
        private Validator _validator = new Validator();
        public static RequestCreationReq req;

        public ClaimsIdentity userIden;
        public Request_Create(DbServices dbServices)
        {
            InitializeComponent();
            _dbServices = dbServices;
            req = new RequestCreationReq();
            _validator = new Validator();

        }

        private async void RequestCreate_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden != null)
            {
                txtStaff.Text = userIden.Claims.FirstOrDefault(x => x.Type == "staff_id").Value.ToString();
                
                var locdesc = await _dbServices.GetLocationDesc<int>(Convert.ToInt32(userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value));
                if (locdesc.resCode != 1 || locdesc.result == null)
                {
                    //_logger.LogDebug("uom Id not find");
                    MessageBox.Show("locdesc not find");
                }
                tb_location loca = locdesc.result[0] ;
                txtloc.Text = loca.vc_location_desc.ToString();
            }
            disableValidation();
            //var res = await _dbServices.SelectAllAsync<tb_location>();
            //List<tb_location> loc = JsonConvert.DeserializeObject<List<tb_location>>(JsonConvert.SerializeObject(res.result));
            //loc.ForEach(x => cbxLoc.Items.Add(x.vc_location_desc));
        }

        public void enableValidation()
        {
            btnSubmit.Enabled = true;
        }
        public void disableValidation()
        {
            btnSubmit.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            dateTimePicker.ResetText();
            txtItemId.Clear();
            txtItemName.Clear();
            txtQty.Clear();
            txtremark.Clear();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtItemId.Text, out var a) || !int.TryParse(txtQty.Text, out var b) || dateTimePicker.Value <= DateTime.Now)
            {
                //_logger.LogDebug("Please Enter Correct Format");
                MessageBox.Show("Please Enter Correct Format");
                return;
            }

            var item = new RequestionCreationItem
            {
                bi_item_vid = GenUtil.ConvertObjtoType<int>(txtItemId.Text),
                i_item_req_qty = GenUtil.ConvertObjtoType<int>(txtQty.Text),
                vc_remark = txtremark.Text,
                dt_exp_deli_date = dateTimePicker.Value,
            };
            var selectObj = new selectObj();

            selectObj.table = "tb_item_vid_mapping";
            selectObj.selecter.Add("bi_item_vid", txtItemId.Text);


            var result = await _dbServices.SelectWhereAsync(selectObj);
            if (result.resCode == 1 && result.result.Count > 0)
            {
                if (req.items.Count > 0 && req.items.Select(x => x.bi_item_vid == item.bi_item_vid).FirstOrDefault())
                {
                    MessageBox.Show("Duplicated ID");
                }
                else
                {
                    req.items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Item ID is not Correct");
            }
            txtItemId.Clear();
            txtItemName.Clear();
            txtQty.Clear();

        }
        private void requiredFieldCheck(object sender, EventArgs e)
        {
            var datepick = dateTimePicker.Value;

            var avaliableItemBox = panelItem.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            var availableTxtBox = panelInfo.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (availableTxtBox != 2 || avaliableItemBox != 4 || datepick < DateTime.Now)
            {

                disableValidation();
            }
            else
            {
                enableValidation();
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            req.i_staff_id = GenUtil.ConvertObjtoType<int>(txtStaff.Text);
            //var res = await _dbServices.GetLocationDesc<string>(cbxLoc.SelectedItem.ToString());
            //tb_location re = JsonConvert.DeserializeObject<tb_location>(JsonConvert.SerializeObject(res.result));
            //req.bi_location_id = re.bi_location_id;

            await CreateRequestAsync(req);
        }
        private async Task CreateRequestAsync(RequestCreationReq req)
        {
            //insert tb_request
            var tb_req = new insertObj();
            tb_req.table = "tb_request";
            tb_req.inserter = new Dictionary<string, string>
            {
                { req.i_staff_id.GetType().Name, req.i_staff_id.ToString() },

            };
            var res1 = await _dbServices.InsertAsync(tb_req);
            if (res1.resCode != 1 || res1.result == null)
            {
                //_logger.LogDebug("insert error");
                MessageBox.Show("insert error");
            }

            //insert tb_request_detail

            req.items.ForEach(async row =>
            {
                //find item id

                var idFinder = new selectObj();
                idFinder.selecter = new Dictionary<string, string>
                {
                    {row.bi_item_vid.GetType().Name, row.bi_item_vid.ToString() }
                };
                var id = await _dbServices.SelectWhereAsync<tb_item_vid_mapping>(idFinder);
                if (id.resCode != 1 || id.result == null)
                {
                    //_logger.LogDebug("item Id not find");
                    MessageBox.Show("item Id not find");
                }
                tb_item_vid_mapping itemid = id.result[0];

                //find uom id
                var uomFinder = new selectObj();
                uomFinder.table = "tb_item_unit";
                uomFinder.selecter = new Dictionary<string, string>
                {
                    {row.bi_item_id.GetType().Name, itemid.bi_item_id.ToString()}
                };
                var uomid = await _dbServices.SelectWhereAsync<tb_item_unit>(uomFinder);
                if (uomid.resCode != 1 || uomid.result == null)
                {
                    //_logger.LogDebug("uom Id not find");
                    MessageBox.Show("uom Id not find");
                }
                tb_item_unit uomId = uomid.result[0];
                var tb_detail = new insertObj();
                tb_detail.table = "tb_request_detail";
                tb_detail.inserter = new Dictionary<string, string>
                {
                    {row.bi_req_id.GetType().Name, res1.result},
                    {row.bi_item_id.GetType().Name,  itemid.bi_item_id.ToString()},
                    {row.i_item_req_qty.GetType().Name, row.i_item_req_qty.ToString() },
                    {row.i_remain_req_qty.GetType().Name,row.i_item_req_qty.ToString() },
                    {row.i_uom_id.GetType().Name, uomId.i_uom_id.ToString() },
                    {row.vc_req_status.GetType().Name, "pending" },
                    {row.vc_remark.GetType().Name,row.vc_remark !=null? row.vc_remark:""}
                };

                var res2 = await _dbServices.InsertAsync(tb_detail);
                if (res2.resCode != 1 || res2.result == null)
                {
                    //_logger.LogDebug("insert error");
                    MessageBox.Show("insert error");
                }
            });
        }
    }
}

