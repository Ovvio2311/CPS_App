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
using System.Xml.Linq;
using System.Net.WebSockets;

namespace CPS_App
{
    public partial class ItemCreate : KryptonForm
    {
        private DbServices _dbServices;
        private Validator _validator;
        public ClaimsIdentity userIden;
        public StockLevelViewObj req;
        public List<CreateStockObj> createStock;
        public ItemCreate(DbServices dbServices)
        {
            InitializeComponent();
            _dbServices = dbServices;
            req = new StockLevelViewObj();
            _validator = new Validator();
            createStock = new List<CreateStockObj>();

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

            cbxloc.Items.Add("None");
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
        public void enableValidation()
        {
            btnitsb.Enabled = true;
        }
        public void disableValidation()
        {
            btnitsb.Enabled = false;
        }

        private async void btnitsb_Click(object sender, EventArgs e)
        {
            var temp = new CreateStockObj();
            //insert input value to createStock
            if (txtqty.Text.Trim() != string.Empty)
            {
                if (!int.TryParse(txtqty.Text, out int output))
                {
                    MessageBox.Show("Please enter integer in quantity field");
                    return;
                }
            }
            pnit.Controls.OfType<KryptonTextBox>().ToList().ForEach(x =>
            {
                temp.GetType().GetProperties().ToList().ForEach(p =>
                {
                    if (x.Tag != null && p.Name == x.Tag.ToString() && x.Text.Trim() != string.Empty)
                    {
                        p.SetValue(temp, Convert.ChangeType(x.Text, p.PropertyType, null));
                    }

                });
            });
            pnit.Controls.OfType<KryptonComboBox>().ToList().ForEach(x =>
            {
                temp.GetType().GetProperties().ToList().ForEach(p =>
                {
                    if (x.Tag != null && x.Tag.ToString().Contains(":"))
                    {
                        var id = x.Tag.ToString().Split(":").ElementAt(0);
                        var name = x.Tag.ToString().Split(":").ElementAt(1);
                        if (id == p.Name)
                        {
                            var idValue = x.SelectedItem.ToString().Split(":").ElementAt(0);
                            p.SetValue(temp, Convert.ChangeType(idValue, p.PropertyType, null));
                        }
                        else if (name == p.Name)
                        {
                            var nameValue = x.SelectedItem.ToString().Split(":").ElementAt(1);
                            p.SetValue(temp, Convert.ChangeType(nameValue, p.PropertyType, null));
                        }
                    }
                    else if (x.Tag != null && p.Name == x.Tag.ToString())
                    {
                        var value = x.SelectedItem.ToString().Split(":").ElementAt(0);
                        p.SetValue(temp, Convert.ChangeType(value, p.PropertyType, null));
                    }

                });
            });
            createStock.Add(temp);
            //confirmation
            if (await GenUtil.ConfirmListAttach(pnit, createStock))
            {
                foreach (var i in createStock)
                {
                    try
                    {
                        //insert tb_item
                        var itemObj = new insertObj()
                        {
                            table = typeof(tb_item).Name,
                            inserter = new Dictionary<string, string>
                        {
                            {"bi_category_id", i.bi_category_id.ToString()},
                            {"vc_item_desc" ,i.vc_item_desc},
                            {"i_uom_id", i.i_uom_id.ToString() }
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
                            bi_item_vid = GenUtil.ConvertObjtoType<int>(i.bi_item_vid),
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
                            bi_location_id = GenUtil.ConvertObjtoType<int>(i.bi_location_id),
                            i_uom_id = GenUtil.ConvertObjtoType<int>(i.i_uom_id),
                            bi_supp_id = GenUtil.ConvertObjtoType<int>(i.bi_supp_id),
                            i_item_qty = GenUtil.ConvertObjtoType<int>(i.i_item_qty),
                            dt_created_date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
                        };
                        var iUnitres = await _dbServices.InsertAsync<tb_item_unit>(itemUnit);
                        if (iUnitres.resCode != 1)
                        {
                            MessageBox.Show("insert tb_item_unit error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //DialogResult dialogResult = MessageBox.Show("Are you confirm the information to create", "Confirm", MessageBoxButtons.YesNo);
            //if (!(dialogResult == DialogResult.Yes))
            //{
            //    return;

            //}
            //insert tb_item use insertasync<T> cannot get id successfully



        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnitcr_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<KryptonTextBox>().ToList().ForEach(t => { t.Text = string.Empty; });
            this.Controls.OfType<KryptonComboBox>().ToList().ForEach(x => x.SelectedIndex = 0);
        }

        private void requiredFieldCheck(object sender, CancelEventArgs e)
        {
            ValidationCheck();
        }
        private void ValidationCheck()
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

            var availableItem = pnit.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (txtitname.Text == string.Empty || cat == null || loc == null || uom == null || vid == null || sup == null)
            {
                //MessageBox.Show("Please completed the item form");
                disableValidation();
            }
            else
            {
                enableValidation();
            }
            //var datepick = dateTimePicker.Value;
            //var id = cbxname.SelectedItem;
            //if (id != null) { id = id.ToString().Split(":").ElementAt(0); }
            //var avaliableItemBox = panelItem.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            //var availableTxtBox = panelInfo.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            //if (availableTxtBox != 2 || avaliableItemBox != 2 || datepick < DateTime.Now || id == null)
            //{

            //    disableValidation();
            //}
            //else
            //{
            //    enableValidation();
            //}
        }

        private void requiredFieldCheck(object sender, EventArgs e)
        {
            ValidationCheck();
        }
    }
}
