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
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using System.Linq.Dynamic.Core;

namespace CPS_App
{
    public partial class ItemCreate : KryptonForm
    {
        private DbServices _dbServices;
        private Validator _validator;
        public ClaimsIdentity userIden;
        public StockLevelViewObj req;
        public List<CreateStockObj> createStock;
        private GenericTableViewWorker _genericTableViewWorker;
        public ItemCreate(DbServices dbServices, GenericTableViewWorker genericTableViewWorker)
        {
            InitializeComponent();
            _dbServices = dbServices;
            req = new StockLevelViewObj();
            _validator = new Validator();
            createStock = new List<CreateStockObj>();
            _genericTableViewWorker = genericTableViewWorker;
        }

        private async void ItemCreate_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden != null)
            {


            }
            cbxitid.Hide();
            pnit.Controls.OfType<KryptonComboBox>().ToList().ForEach(x => x.Validating += requiredFieldCheck);
            pnit.Controls.OfType<KryptonTextBox>().ToList().ForEach(x => x.Validating += requiredFieldCheck);



            var itemType = await _dbServices.SelectAllAsync<tb_item>();
            List<tb_item> itid = JsonConvert.DeserializeObject<List<tb_item>>(JsonConvert.SerializeObject(itemType.result));
            itid.ForEach(x => cbxitid.Items.Add($"{x.bi_item_id}: {x.vc_item_desc}"));

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
            if (chkstock.Checked && txtqty.Text.Trim() != null)
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
                    if (x.Tag != null && p.Name == x.Tag.ToString() && x.Text.Trim() != string.Empty && x.Enabled)
                    {
                        p.SetValue(temp, Convert.ChangeType(x.Text, p.PropertyType, null));
                    }

                });
            });
            pnit.Controls.OfType<KryptonComboBox>().ToList().ForEach(x =>
            {
                temp.GetType().GetProperties().ToList().ForEach(p =>
                {
                    if (x.Tag != null && x.Tag.ToString().Contains(":") && x.Enabled)
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
                    else if (x.Tag != null && p.Name == x.Tag.ToString() && x.Enabled)
                    {
                        var value = x.SelectedItem.ToString().Split(":").ElementAt(0);
                        p.SetValue(temp, Convert.ChangeType(value, p.PropertyType, null));
                    }

                });
            });
            temp.bi_item_vid =GenUtil.ConvertObjtoType<int>( cbxvid.SelectedItem.ToString().Split(':').ElementAt(0));
            temp.i_uom_id = GenUtil.ConvertObjtoType<int>(cbxuom.SelectedItem.ToString().Split(':').ElementAt(0));
            temp.bi_category_id = GenUtil.ConvertObjtoType<int>(cbxcat.SelectedItem.ToString().Split(':').ElementAt(0));

            createStock.Add(temp);
            //confirmation
            string confirmStr = await GenUtil.ConfirmListAttach(pnit, createStock);
            if (confirmStr != string.Empty)
            {
                DialogResult response = MessageBox.Show(confirmStr, "Confirm", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes ? true : false)
                {
                    if (chkcrloc.Checked)
                    {
                       await InsertItemUnit();
                        return;
                    }
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
                                return;
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
                                return;
                            }
                            MessageBox.Show($"New Item has been created with ID: {res.result}");
                            if (!chkstock.Checked)
                            {
                                return;
                            }
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
                                return;
                            }
                            MessageBox.Show("item unit insert into location");
                            await GenUtil.ResumeBlankPage(pnit, createStock);
                            createStock = new List<CreateStockObj>();
                            req = new StockLevelViewObj();
                            cbxvid.SelectedIndex = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("confirmStr is null");
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

        private async void btnitcr_Click(object sender, EventArgs e)
        {
            await GenUtil.ResumeBlankPage(pnit, createStock);
            this.Controls.OfType<KryptonTextBox>().ToList().ForEach(t => { t.Text = string.Empty; });
            this.Controls.OfType<KryptonComboBox>().ToList().ForEach(x => x.SelectedIndex = 0);
        }

        private void requiredFieldCheck(object sender, CancelEventArgs e)
        {
            CheckBoxChange();
            itemNameCheckBoxChange();
            ValidationCheck();
        }

        private void ValidationCheck()
        {
            if (chkstock.Checked)
            {
                if (!CheckBoxValidate())
                {
                    disableValidation();
                    return;
                }
            }


            var itname = chkcrloc.Checked ? cbxcat.SelectedItem != null ? cbxcat.SelectedItem.ToString() : null : txtitname.Text;

            var cat = cbxcat.SelectedItem;
            if (cat != null) { cat = cat.ToString().Split(":").ElementAt(0); }

            var uom = cbxuom.SelectedItem;
            if (uom != null) { uom = uom.ToString().Split(":").ElementAt(0); }

            var vid = cbxvid.SelectedItem;
            if (vid != null) { vid = vid.ToString().Split(":").ElementAt(0); }

            //var availableItem = pnit.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (itname == string.Empty || itname == null || cat == null || uom == null || vid == null)
            {
                //MessageBox.Show("Please completed the item form");
                disableValidation();
            }
            else
            {
                enableValidation();
            }

        }
        private bool CheckBoxValidate()
        {
            var loc = cbxloc.SelectedItem;
            if (loc != null) { loc = loc.ToString().Split(":").ElementAt(0); }
            var sup = cbxsup.SelectedItem;
            if (sup != null) { sup = sup.ToString().Split(":").ElementAt(0); }
            var qty = GenUtil.ConvertObjtoType<int>(txtqty.Text);
            return qty != null && loc != null && sup != null && qty > 0 ? true : false;

        }
        private void requiredFieldCheck(object sender, EventArgs e)
        {
            ValidationCheck();
        }

        private void chkstock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkstock.Checked)
            {
                disableValidation();
            }
            CheckBoxChange();
        }
        private void CheckBoxChange()
        {
            if (chkstock.Checked)
            {
                txtqty.Enabled = true;
                cbxsup.Enabled = true;
                cbxloc.Enabled = true;
            }
            else
            {
                txtqty.Enabled = false;
                cbxsup.Enabled = false;
                cbxloc.Enabled = false;
            }
        }

        private void chkcrloc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcrloc.Checked)
            {
                disableValidation();
            }
            itemNameCheckBoxChange();
        }
        private void itemNameCheckBoxChange()
        {
            if (chkcrloc.Checked)
            {
                cbxitid.Show();
                cbxitid.Enabled = true;
                txtitname.Hide();
                txtitname.Enabled = false;
                cbxcat.Enabled = false;
                cbxvid.Enabled = false;
                cbxuom.Enabled = false;
                chkstock.Checked = true;
                chkstock.Hide();
            }
            else
            {
                cbxitid.Hide();
                cbxitid.Enabled = false;
                txtitname.Show();
                txtitname.Enabled = true;
                cbxcat.Enabled = true;
                cbxvid.Enabled = true;
                cbxuom.Enabled = true;
                chkstock.Show();
            }
        }

        private async void cbxitid_SelectedIndexChanged(object sender, EventArgs e)
        {
            await AutoAddItemInfo();
        }
        private async Task AutoAddItemInfo()
        {
            try
            {
                if (cbxitid.SelectedItem != null)
                {
                    var id = cbxitid.SelectedItem.ToString().Split(':').ElementAt(0);
                    var name = cbxitid.SelectedItem.ToString().Split(':').ElementAt(1);
                    StockLevelViewObj viewObj = new StockLevelViewObj();
                    searchObj selObj = new searchObj();
                    selObj.searchWords.Add(nameof(viewObj.bi_item_id), new List<string>() { id.ToString() });
                    List<StockLevelViewObj> result = await _genericTableViewWorker.GetGenericWorker<StockLevelViewObj, StockLevelSubItem>(viewObj.sql, nameof(viewObj.bi_item_id), null, selObj);
                    if (result.Count > 0)
                    {
                        await GenUtil.AutoLabelAddingTextBox(pnit, result);
                        cbxvid.SelectedItem = cbxvid.Items.ToDynamicList<string>().Where(c => c.ToString().Contains(result[0].bi_item_vid.ToString())).FirstOrDefault();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
       
        private async Task InsertItemUnit()
        {
            foreach (var i in createStock)
            {
                //insert tb_item_unit
                var itemUnit = new tb_item_unit()
                {
                    bi_item_id = GenUtil.ConvertObjtoType<int>(i.bi_item_id),
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
                    return;
                }
                MessageBox.Show("item unit insert into location");
                await GenUtil.ResumeBlankPage(pnit,createStock);
                createStock = new List<CreateStockObj>();
                req = new StockLevelViewObj();
                cbxvid.SelectedIndex = -1;
            }
                
        }
    }
}
