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
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;
using static CPS_App.Models.RegisterModel;

namespace CPS_App
{
    public partial class ItemCreate : Form
    {
        private DbServices _dbServices;
        private Validator _validator;
        public ClaimsIdentity userIden;
        public StockLevelViewObj req;
        public ItemCreate(DbServices dbServices)
        {
            InitializeComponent();
            _dbServices = dbServices;
            req = new StockLevelViewObj();
            _validator = new Validator();

        }

        private void pnit_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void ItemCreate_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden != null)
            {

                if (!(userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToLower() == "admin"))//warehouse admin
                {
                    MessageBox.Show("You are not the warehouse admin");
                    return;
                }
            }
            var catType = await _dbServices.SelectAllAsync<tb_item_category>();
            List<tb_item_category> cat = JsonConvert.DeserializeObject<List<tb_item_category>>(JsonConvert.SerializeObject(catType.result));
            cat.ForEach(x => cbxcat.Items.Add($"{x.bi_category_id}: {x.vc_category_desc}"));

            var locType = await _dbServices.SelectAllAsync<tb_location>();
            List<tb_location> loc = JsonConvert.DeserializeObject<List<tb_location>>(JsonConvert.SerializeObject(locType.result));
            loc.ForEach(x => cbxloc.Items.Add($"{x.bi_location_id}: {x.vc_location_desc}"));

            var uomType = await _dbServices.SelectAllAsync<lut_uom_type>();
            List<lut_uom_type> uom = JsonConvert.DeserializeObject<List<lut_uom_type>>(JsonConvert.SerializeObject(uomType.result));
            uom.ForEach(x => cbxuom.Items.Add($"{x.i_uom_id}: {x.vc_uom_desc}"));

            var vidType = await _dbServices.GetVidMappingObj();
            List<StockLevelViewObj> vid = JsonConvert.DeserializeObject<List<StockLevelViewObj>>(JsonConvert.SerializeObject(vidType.result));
            vid.ForEach(x => cbxvid.Items.Add($"{x.bi_item_vid}: {x.items_group}"));
        }

        private void requiredFieldCheck(object sender, EventArgs e)
        {




        }

        private async void btncatsb_Click(object sender, EventArgs e)
        {
            if (txtcatname.Text == String.Empty)
            {
                MessageBox.Show("Please enter Category name");
            }
            else
            {
                var obj = new selectObj();
                obj.table = "tb_item_category";
                obj.selecter.Add("vc_category_desc", txtcatname.Text);
                var res = await _dbServices.SelectWhereAsync(obj);
                if (res.resCode != 1)
                {
                    //_logger.LogDebug("item Id not find");
                    MessageBox.Show("error");
                    return;
                }
                else if (res.resCode == 1 && res.result.Count > 0)
                {
                    MessageBox.Show("Category Name has been used");
                    return;
                }
                else
                {
                    //insert into tb_caterogy
                    var tb_cat = new insertObj();
                    tb_cat.table = "tb_item_category";
                    tb_cat.inserter = new Dictionary<string, string>
                    {
                        { nameof(req.vc_category_desc), txtcatname.Text },
                    };
                    var tb_cat_res = await _dbServices.InsertAsync(tb_cat);
                    if (tb_cat_res.resCode != 1 || tb_cat_res.result.Count <= 0)
                    {
                        //_logger.LogDebug("insert error");
                        MessageBox.Show("insert error");
                    }
                    else
                    {
                        MessageBox.Show($"New Category created, ID: {tb_cat_res.result}");
                    }
                }
            }
        }

        private async void btnitsb_Click(object sender, EventArgs e)
        {
            var cat = cbxcat.SelectedItem;
            if (cat != null) { cat = cat.ToString().Split(":").ElementAt(0); }
            var loc = cbxloc.SelectedItem;
            if (loc != null) { loc = loc.ToString().Split(":").ElementAt(0); }
            var uom = cbxuom.SelectedItem;
            if (uom != null) { uom = uom.ToString().Split(":").ElementAt(0); }
            var vid = cbxvid.SelectedItem;
            if (vid != null) { vid = vid.ToString().Split(":").ElementAt(0); }


            var availableItem = pnit.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (availableItem != 5 || cat == null || loc == null || uom == null || vid == null)
            {
                MessageBox.Show("Please completed the item form");
            }
            else
            {
                //insert tb_item
                var itemObj = new tb_item()
                {
                    bi_category_id = GenUtil.ConvertObjtoType<int>(cat),
                    vc_item_desc = txtitname.Text,
                    i_uom_id = GenUtil.ConvertObjtoType<int>(uom),
                };
                var res = await _dbServices.InsertAsync<tb_item>(itemObj);
                if(res.resCode != 1)
                {
                    MessageBox.Show("error");
                }

                //insert tb_vid
                var vidObj = new tb_item_vid_mapping()
                {
                    bi_item_id = res.result,
                    bi_item_vid = GenUtil.ConvertObjtoType<int>(vid),
                };
                var vidres = await _dbServices.InsertAsync<tb_item_vid_mapping>(vidObj);
                if (vidres.resCode != 1)
                {
                    MessageBox.Show("error");
                }
                MessageBox.Show($"New Item has been created with ID: {res.result}");

            }
        }
    }
}
