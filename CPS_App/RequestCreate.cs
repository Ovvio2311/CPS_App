﻿using CPS_App.Helpers;
using CPS_App.Services;
using Newtonsoft.Json;
using System.Data;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;
using System.Security.Claims;
using Krypton.Toolkit;
using System.Data.Common;

namespace CPS_App
{
    public partial class RequestCreate : KryptonForm
    {
        private DbServices _dbServices;
        private Validator _validator = new Validator();
        public RequestCreationReq req;
        public List<RequestionCreationItem> itemList;
        public ClaimsIdentity userIden;
        private DbGeneralServices _dbGeneralServices;
        public RequestCreate(DbServices dbServices, DbGeneralServices dbGeneralServices)
        {
            InitializeComponent();
            _dbServices = dbServices;
            req = new RequestCreationReq();
            itemList = new List<RequestionCreationItem>();
            _validator = new Validator();
            _dbGeneralServices = dbGeneralServices;
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
                tb_location loca = locdesc.result[0];
                txtloc.Text = loca.vc_location_desc.ToString();
            }
            disableValidation();

            var itemType = await _dbServices.SelectAllAsync<tb_item>();
            List<tb_item> it = JsonConvert.DeserializeObject<List<tb_item>>(JsonConvert.SerializeObject(itemType.result));
            it.ForEach(x => cbxname.Items.Add($"{x.bi_item_id}: {x.vc_item_desc}"));

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
            txtQty.Clear();
            txtremark.Clear();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            //dynamic request = new
            //{
            //    name = cbxname.SelectedItem,
            //    quantity = txtQty.Text,

            //};
            //Validator validator = new Validator();
            //validator.make(request,
            //new
            //{
            //    name /*key*/= "required" /*fieldRule*/,
            //    quantity = "int",

            //});
            //if (!validator.passes())
            //{
            //    MessageBox.Show(GenUtil.ArrayToString(validator.errors()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (cbxname.SelectedItem == null || !int.TryParse(txtQty.Text, out var b) || dateTimePicker.Value <= DateTime.Now ||
                GenUtil.ConvertObjtoType<int>(txtQty.Text.Trim()) <= 0)
            {
                //_logger.LogDebug("Please Enter Correct Format");
                MessageBox.Show("Please Enter Correct Format");
                return;
            }
            var itemId = cbxname.SelectedItem;
            if (itemId != null) { itemId = itemId.ToString().Split(":").ElementAt(0); }
            var itemName = cbxname.SelectedItem.ToString().Split(":").ElementAt(1);
            var item = new RequestionCreationItem
            {
                bi_item_id = GenUtil.ConvertObjtoType<int>(itemId),
                vc_item_desc = itemName,
                i_item_req_qty = GenUtil.ConvertObjtoType<int>(txtQty.Text),
                vc_remark = txtremark.Text,
                dt_exp_deli_date = dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"),

            };
            var selectObj = new selectObj();

            selectObj.table = "tb_item_vid_mapping";
            selectObj.selecter.Add("bi_item_id", itemId.ToString());


            var result = await _dbServices.SelectWhereAsync(selectObj);
            if (result.resCode == 1 && result.result.Count > 0)
            {
                if (itemList.Count > 0 && itemList.Select(x => x.bi_item_id == item.bi_item_id).FirstOrDefault())
                {
                    MessageBox.Show("Duplicated Item Id");
                }
                else
                {
                    itemList.Add(item);
                    MessageBox.Show("item added");
                }
            }
            else
            {
                MessageBox.Show("Item ID is not Correct");
            }
            txtremark.Clear();
            txtQty.Clear();
            cbxname.SelectedIndex = 0;
            ValidationCheck();
        }


        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string confirmStr = await GenUtil.ConfirmListAttach<RequestionCreationItem>(panelItem, itemList);

            if (confirmStr != string.Empty)
            {
                DialogResult response = MessageBox.Show(confirmStr, "Confirm", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes ? true : false)
                {
                    req.i_staff_id = GenUtil.ConvertObjtoType<int>(txtStaff.Text);
                    //var res = await _dbServices.GetLocationDesc<string>(cbxLoc.SelectedItem.ToString());
                    //tb_location re = JsonConvert.DeserializeObject<tb_location>(JsonConvert.SerializeObject(res.result));
                    //req.bi_location_id = re.bi_location_id;

                    if (!await CreateRequestAsync())
                    {
                        MessageBox.Show("Request creation error\nPlease create again");
                    };
                    itemList.Clear();
                    disableValidation();
                }
            }
            else
            {
                MessageBox.Show("confirmStr is null");
            }




        }
        private async Task AddUomIdToReqObj()
        {
            foreach (var row in itemList)
            {
                try
                {
                    tb_item_vid_mapping vid = await _dbGeneralServices.GetVidAsync(row.bi_item_id.ToString());
                    row.bi_item_vid = GenUtil.ConvertObjtoType<int>(vid.bi_item_vid);

                    //find uom id
                    tb_item uom = await _dbGeneralServices.GetUomAsync(vid.bi_item_id.ToString());
                    row.i_uom_id = GenUtil.ConvertObjtoType<int>(uom.i_uom_id);

                    req.items.Add(row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }
        private async Task<bool> CreateRequestAsync()
        {
            //Checking insert tb_request_detail data correct
            await AddUomIdToReqObj();

            DbResObj res1 = new DbResObj();
            try
            {
                //insert tb_request
                var tb_req = new insertObj();
                tb_req.table = "tb_request";
                tb_req.inserter = new Dictionary<string, string>
            {
                { nameof(req.i_staff_id), req.i_staff_id.ToString() },
                {"i_map_stat_id", "1"}
            };
                res1 = await _dbServices.InsertAsync(tb_req);
                if (res1.resCode != 1 || res1.result == null)
                {
                    //_logger.LogDebug("insert error");
                    throw new Exception("insert tb_request error");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;

            }
            //insert tb_request_detail
            req.items.ForEach(async row =>
            {
                try
                {
                    var tb_detail = new insertObj();
                    tb_detail.table = "tb_request_detail";
                    tb_detail.inserter = new Dictionary<string, string>
                    {
                        {nameof(row.bi_req_id), res1.result.ToString()},
                        {nameof(row.bi_item_id),  row.bi_item_id.ToString()},
                        {nameof(row.i_item_req_qty), row.i_item_req_qty.ToString() },
                        {nameof(row.i_remain_req_qty),row.i_item_req_qty.ToString() },
                        {nameof(row.i_uom_id), row.i_uom_id.ToString() },
                        {nameof(row.i_hd_map_stat_id), "1" },
                        {nameof(row.bi_po_status_id), "1" },
                        {nameof(row.vc_remark),row.vc_remark != ""? row.vc_remark:null},
                        {nameof(row.dt_exp_deli_date),row.dt_exp_deli_date.ToString()}
                    };

                    var res2 = await _dbServices.InsertAsync(tb_detail);
                    if (res2.resCode != 1 || res2.result == null)
                    {
                        //_logger.LogDebug("insert error");
                        //MessageBox.Show("insert error");
                        throw new Exception("insert error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });

            MessageBox.Show($"Your Request has been created!\nRequest Id: {res1.result}");
            return true;
        }


        private void requiredFieldCheck(object sender, System.ComponentModel.CancelEventArgs e)
        {

            ValidationCheck();

        }
        private void ValidationCheck()
        {

            if (itemList.Count > 0)
            {
                enableValidation();
                //MessageBox.Show($"confirm Submit with {req.items.Count} item?");
                return;
            }
            var datepick = dateTimePicker.Value;
            var id = cbxname.SelectedItem;
            if (id != null) { id = id.ToString().Split(":").ElementAt(0); }
            var avaliableItemBox = panelItem.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            var availableTxtBox = panelInfo.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (availableTxtBox != 2 || avaliableItemBox != 2 || datepick < DateTime.Now || id == null)
            {

                disableValidation();
            }
            else
            {
                enableValidation();
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

