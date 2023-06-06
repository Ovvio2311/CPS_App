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
using Krypton.Toolkit;

namespace CPS_App
{
    public partial class ItemCreate : KryptonForm
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

            var supType = await _dbServices.SelectAllAsync<tb_supplier>();
            List<tb_supplier> sup = JsonConvert.DeserializeObject<List<tb_supplier>>(JsonConvert.SerializeObject(supType.result));
            sup.ForEach(x => cbxsup.Items.Add($"{x.bi_supp_id}: {x.vc_supp_desc}"));

            var vidType = await _dbServices.GetVidMappingObj();
            List<VidMappingObj> vid = JsonConvert.DeserializeObject<List<VidMappingObj>>(JsonConvert.SerializeObject(vidType.result));
            vid.ForEach(x => cbxvid.Items.Add($"{x.bi_item_vid}: {x.items_group}"));
        }

        private void requiredFieldCheck(object sender, EventArgs e)
        {




        }

        private async void btncatsb_Click(object sender, EventArgs e)
        {
            //if (txtcatname.Text == String.Empty)
            //{
            //    MessageBox.Show("Please enter Category name");
            //}
            //else
            //{
            //    var obj = new selectObj();
            //    obj.table = "tb_item_category";
            //    obj.selecter.Add("vc_category_desc", txtcatname.Text);
            //    var res = await _dbServices.SelectWhereAsync(obj);
            //    if (res.resCode != 1)
            //    {
            //        //_logger.LogDebug("item Id not find");
            //        MessageBox.Show("error");
            //        return;
            //    }
            //    else if (res.resCode == 1 && res.result.Count > 0)
            //    {
            //        MessageBox.Show("Category Name has been used");
            //        return;
            //    }
            //    else
            //    {
            //        //insert into tb_caterogy
            //        var tb_cat = new insertObj();
            //        tb_cat.table = "tb_item_category";
            //        tb_cat.inserter = new Dictionary<string, string>
            //        {
            //            { nameof(req.vc_category_desc), txtcatname.Text },
            //        };
            //        var tb_cat_res = await _dbServices.InsertAsync(tb_cat);
            //        if (tb_cat_res.resCode != 1 || tb_cat_res.result.Count <= 0)
            //        {
            //            //_logger.LogDebug("insert error");
            //            MessageBox.Show("insert error");
            //        }
            //        else
            //        {
            //            MessageBox.Show($"New Category created, ID: {tb_cat_res.result}");
            //        }
            //    }
            //}
        }

        private async void btnitsb_Click(object sender, EventArgs e)
        {
            var cat = cbxcat.SelectedItem;
            if (cat != null) { cat = cat.ToString().Split(":").ElementAt(0); }
            var loc = cbxloc.SelectedItem;
            if (loc != null) { loc = loc.ToString().Split(":").ElementAt(0); }
            var uom = cbxuom.SelectedItem;
            if (uom != null) { uom = uom.ToString().Split(":").ElementAt(0); }
            var sup = cbxsup.SelectedItem;
            if (sup != null) { sup = sup.ToString().Split(":").ElementAt(0); }
            var vid = cbxvid.SelectedItem;
            if (vid != null) { vid = vid.ToString().Split(":").ElementAt(0); }

            if (!int.TryParse(txtqty.Text, out int output))
            {
                MessageBox.Show("Please enter integer in quantity field");
                return;
            }
            var availableItem = pnit.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (availableItem != 2 || cat == null || loc == null || uom == null || vid == null || sup == null)
            {
                MessageBox.Show("Please completed the item form");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm the information to create", "Confirm", MessageBoxButtons.YesNo);
                if (!(dialogResult == DialogResult.Yes))
                {
                    return;

                }
                //insert tb_item use insertasync<T> cannot get id successfully

                var itemObj = new insertObj()
                {
                    table = typeof(tb_item).Name,
                    inserter = new Dictionary<string, string>
                    {
                        {"bi_category_id", cat.ToString()},
                        { "vc_item_desc" ,txtitname.Text },
                        {"i_uom_id", uom.ToString() }
                    }
                };

                var res = await _dbServices.InsertAsync(itemObj);
                if (res.resCode != 1 || res.result == null)
                {
                    MessageBox.Show("tb_item error");
                }

                //insert tb_vid
                //var vidObj = new insertObj()
                //{
                //    table = typeof(tb_item_vid_mapping).Name,
                //    inserter = new Dictionary<string, string>
                //    {
                //        {"bi_item_id",res.result.ToString() },
                //        { "bi_item_vid", vid.ToString()},
                //    }
                //};
                var vidObj = new tb_item_vid_mapping()
                {
                    bi_item_id = GenUtil.ConvertObjtoType<int>(res.result),
                    bi_item_vid = GenUtil.ConvertObjtoType<int>(vid),
                    dt_created_date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
                };
                var vidres = await _dbServices.InsertAsync<tb_item_vid_mapping>(vidObj);
                if (vidres.resCode != 1 || res.result == null)
                {
                    MessageBox.Show("vid mapping error");
                }
                MessageBox.Show($"New Item has been created with ID: {res.result}");

                //insert tb_item_unit
                var itemUnit = new tb_item_unit()
                {
                    bi_item_id = GenUtil.ConvertObjtoType<int>(res.result),
                    bi_location_id = GenUtil.ConvertObjtoType<int>(loc),
                    i_uom_id = GenUtil.ConvertObjtoType<int>(uom),
                    bi_supp_id = GenUtil.ConvertObjtoType<int>(sup),
                    i_item_qty = GenUtil.ConvertObjtoType<int>(txtqty.Text),
                    dt_created_date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
                };
                var iUnitres = await _dbServices.InsertAsync<tb_item_unit>(itemUnit);
                if (iUnitres.resCode != 1)
                {
                    MessageBox.Show("insert tb_item_unit error");
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnitcr_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<KryptonTextBox>().ToList().ForEach(t => { t.Text = string.Empty; });
            this.Controls.OfType<KryptonComboBox>().ToList().ForEach(x=>x.SelectedIndex = 0);
        }
    }
}
