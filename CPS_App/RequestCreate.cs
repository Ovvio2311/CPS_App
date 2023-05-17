using CPS_App.Helpers;
using CPS_App.Services;
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

namespace CPS_App
{
    public partial class RequestCreate : Form
    {
        private DbServices _dbServices { get; set; }
        private Validator _validator;
        public static RequestCreationReq req { get; set; }
        public RequestCreate(DbServices dbServices, Validator validator)
        {
            InitializeComponent();
            _dbServices = dbServices;
            _validator = validator;
            req= new RequestCreationReq();
        }

        private async void RequestCreate_Load(object sender, EventArgs e)
        {
            disableValidation();
            var res = await _dbServices.SelectAllAsync<tb_location>();
            List<tb_location> loc = JsonConvert.DeserializeObject<List<tb_location>>(JsonConvert.SerializeObject(res.result));
            loc.ForEach(x => cbxLoc.Items.Add(x.vc_location_desc));
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
            txtStaff.Clear();
            cbxLoc.SelectionLength = 0;
            dateTimePicker.ResetText();
            txtItemId.Clear();
            txtItemName.Clear();
            txtQty.Clear();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            //dynamic request = new
            //{
            //    bi_item_vid = txtItemId.Text,
            //    i_item_req_qty = txtQty.Text,
            //    vc_item_desc = txtItemName.Text,

            //};
            //Validator validator = new Validator();
            //validator.make(request,
            //new
            //{
            //    bi_item_vid /*key*/= "int" /*fieldRule*/,
            //    i_item_req_qty = "int",
            //    vc_item_desc = "Required",

            //});
            //if (!validator.passes())
            //{
            //    MessageBox.Show(GenUtil.ArrayToString(validator.errors()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            int.TryParse(txtItemId.Text, out var a) ? GenUtil.ConvertObjtoType<int>(txtItemId.Text) : null;
            int.TryParse(txtQty.Text, out var b) ? GenUtil.ConvertObjtoType<int>(txtQty.Text) : null;
                var item = new ItemRequest
                {
                    bi_item_vid = int.TryParse(txtItemId.Text, out var a)?GenUtil.ConvertObjtoType<int>(txtItemId.Text):null,
                    vc_item_desc = txtItemName.Text,
                    i_item_req_qty = int.TryParse(txtQty.Text,out var b)? GenUtil.ConvertObjtoType<int>(txtQty.Text):null,
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
            //}
            
        }
        private void requiredFieldCheck(object sender, EventArgs e)
        {
            var datepick = dateTimePicker.Value;
            var Loc = cbxLoc.SelectedItem;
            var avaliableItemBox = panelItem.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            var availableTxtBox = panelInfo.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (availableTxtBox != 2 || avaliableItemBox != 3 || Loc == null || datepick < DateTime.Now)
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
            var res = await _dbServices.GetLocationDesc<string>(cbxLoc.SelectedItem.ToString());
            tb_location re = JsonConvert.DeserializeObject<tb_location>(JsonConvert.SerializeObject(res.result));
            req.bi_location_id = re.bi_location_id;
            req.dt_exp_deli_date = dateTimePicker.Value;
            await CreateRequestAsync(req);
        }
        private async Task CreateRequestAsync(RequestCreationReq req)
        {

        }
    }
}
