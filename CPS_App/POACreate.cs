using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPS_App.Services;
using Krypton.Toolkit;
using Newtonsoft.Json;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class POACreate : KryptonForm
    {
        public ClaimsIdentity userIden;
        private DbServices _dbServices;
        private POATableObj obj;
        private List<PoaItemList> itemList;
        public POACreate(DbServices dbServices)
        {
            InitializeComponent();
            obj = new POATableObj();
            itemList = new List<PoaItemList>();
            _dbServices = dbServices;
        }

        private async void POACreate_Load(object sender, EventArgs e)
        {
            pn2.Hide();
            pn2.Enabled = false;
            userIden = AuthService._userClaim;
            if (userIden != null)
            {
                //throw new Exception("user claim is null");                
            }

            disableValidation();

            var type = await _dbServices.SelectAllAsync<lut_poa_type>();
            List<lut_poa_type> poatype = JsonConvert.DeserializeObject<List<lut_poa_type>>(JsonConvert.SerializeObject(type.result));
            poatype.ForEach(x => cbxtype.Items.Add($"{x.ti_poa_type_id}: {x.vc_poa_type_desc}"));

            var locType = await _dbServices.SelectAllAsync<tb_location>();
            List<tb_location> loc = JsonConvert.DeserializeObject<List<tb_location>>(JsonConvert.SerializeObject(locType.result));
            loc.ForEach(x => cbxloc.Items.Add($"{x.bi_location_id}: {x.vc_location_desc}"));

            var supType = await _dbServices.SelectAllAsync<tb_supplier>();
            List<tb_supplier> sup = JsonConvert.DeserializeObject<List<tb_supplier>>(JsonConvert.SerializeObject(supType.result));
            sup.ForEach(x => cbxsup.Items.Add($"{x.bi_supp_id}: {x.vc_supp_desc}"));

            var tcType = await _dbServices.SelectAllAsync<lut_term_and_con>();
            List<lut_term_and_con> tc = JsonConvert.DeserializeObject<List<lut_term_and_con>>(JsonConvert.SerializeObject(tcType.result));
            tc.ForEach(x => cbxtc.Items.Add($"{x.ti_tc_id}: {x.vc_tc_desc}"));

            var deliscType = await _dbServices.SelectAllAsync<lut_deli_schedule_type>();
            List<lut_deli_schedule_type> sc = JsonConvert.DeserializeObject<List<lut_deli_schedule_type>>(JsonConvert.SerializeObject(deliscType.result));
            sc.ForEach(x => cbxselisc.Items.Add($"{x.ti_deli_sched_id}: {x.vc_deli_sched_desc}"));

            //var uomType = await _dbServices.SelectAllAsync<lut_uom_type>();
            //List<lut_uom_type> uom = JsonConvert.DeserializeObject<List<lut_uom_type>>(JsonConvert.SerializeObject(uomType.result));
            //uom.ForEach(x => cbxuom.Items.Add($"{x.i_uom_id}: {x.vc_uom_desc}"));

            var itemType = await _dbServices.SelectAllAsync<tb_item>();
            List<tb_item> itid = JsonConvert.DeserializeObject<List<tb_item>>(JsonConvert.SerializeObject(itemType.result));
            itid.ForEach(x => cbxitid.Items.Add($"{x.bi_item_id}: {x.vc_item_desc}"));

        

        }
        public void enableValidation()
        {
            btnsubmit.Enabled = true;

        }
        public void disableValidation()
        {
            btnsubmit.Enabled = false;

        }
        //private void requiredFieldCheck(object sender, EventArgs e)
        //{
        //    var idtype = cbxitid.SelectedItem;
        //    if (idtype != null) { idtype = idtype.ToString().Split(":").ElementAt(0); }
        //    var uomtype = cbxuom.SelectedItem;
        //    if (uomtype != null) { uomtype = uomtype.ToString().Split(":").ElementAt(0); }


        //    var availableItem = pn2.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();

        //    if (availableItem != 7 || idtype == null || uomtype == null || templist.Count() <= 0)
        //    {
        //        disableValidation();
        //    }
        //    else
        //    {
        //        enableValidation();
        //    }

        //}
        private async Task InsertTableHeader()
        {
            //insert tb_poa
            var tb_poa = new insertObj()
            {
                table = "tb_poa",
                inserter = new Dictionary<string, string>
                    {
                        {nameof(obj.ti_poa_type_id),obj.ti_poa_type_id.ToString() },
                        {nameof(obj.bi_poa_status_id), obj.bi_poa_status_id.ToString() }
                    },
            };
            var respoa = await _dbServices.InsertAsync(tb_poa);
            if (respoa.resCode != 1 || respoa.result == null)
            {
                MessageBox.Show("insert tb_poa error");
                return;
            }

            obj.bi_poa_id = GenUtil.ConvertObjtoType<int>(respoa.result);

            //insert tb_poa_header
            var tb_boa_header = new insertObj()
            {
                table = "tb_poa_header",
                inserter = new Dictionary<string, string>
                {
                        { nameof(obj.bi_poa_id), obj.bi_poa_id.ToString() },
                        { "vc_order_revision", "0" },
                        { nameof(obj.bi_supp_id), obj.bi_supp_id.ToString() },
                        { nameof(obj.bi_deli_loc_id), obj.bi_deli_loc_id.ToString() },
                        { nameof(obj.vc_currency), obj.vc_currency },
                        { nameof(obj.ti_tc_id), obj.ti_tc_id.ToString() },
                        { nameof(obj.ti_deli_sched_id), obj.ti_deli_sched_id.ToString() },
                        { nameof(obj.dt_effect_date), obj.dt_effect_date.ToString() },
                        { nameof(obj.bi_contract_no), obj.bi_contract_no },
                }
            };
            var resheader = await _dbServices.InsertAsync(tb_boa_header);
            if (resheader.resCode != 1 || resheader.result == null)
            {
                MessageBox.Show("insert db_poa_header error");
                return;
            }
            obj.bi_poa_header_id = GenUtil.ConvertObjtoType<int>(resheader.result);
            MessageBox.Show($"insert completed, poa_id: {obj.bi_poa_id}, poa_header_id: {obj.bi_poa_header_id}");

        }
        private async void btnsubmit_Click(object sender, EventArgs e)
        {
            await InsertTableHeader();
            ////insert tb_poa
            //var tb_poa = new insertObj()
            //{
            //    table = "tb_poa",
            //    inserter = new Dictionary<string, string>
            //        {
            //            {nameof(obj.ti_poa_type_id),obj.ti_poa_type_id.ToString() },
            //            {nameof(obj.bi_poa_status_id), obj.bi_poa_status_id.ToString() }
            //        },
            //};
            //var respoa = await _dbServices.InsertAsync(tb_poa);
            //if (respoa.resCode != 1 || respoa.result == null)
            //{
            //    MessageBox.Show("insert tb_poa error");
            //    return;
            //}

            //obj.bi_poa_id = GenUtil.ConvertObjtoType<int>(respoa.result);

            ////insert tb_poa_header
            //var tb_boa_header = new insertObj()
            //{
            //    table = "tb_poa_header",
            //    inserter = new Dictionary<string, string>
            //    {
            //            { nameof(obj.bi_poa_id), obj.bi_poa_id.ToString() },
            //            { "vc_order_revision", "0" },
            //            { nameof(obj.bi_supp_id), obj.bi_supp_id.ToString() },
            //            { nameof(obj.bi_deli_loc_id), obj.bi_deli_loc_id.ToString() },
            //            { nameof(obj.vc_currency), obj.vc_currency },
            //            { nameof(obj.ti_tc_id), obj.ti_tc_id.ToString() },
            //            { nameof(obj.ti_deli_sched_id), obj.ti_deli_sched_id.ToString() },
            //            { nameof(obj.dt_effect_date), obj.dt_effect_date.ToString("yyyy-MM-dd HH:mm:ss") },
            //            { nameof(obj.bi_contract_no), obj.bi_contract_no },
            //    }
            //};
            //var resheader = await _dbServices.InsertAsync(tb_boa_header);
            //if (resheader.resCode != 1 || resheader.result == null)
            //{
            //    MessageBox.Show("insert db_poa_header error");
            //    return;
            //}
            //obj.bi_poa_header_id = GenUtil.ConvertObjtoType<int>(resheader.result);
            //MessageBox.Show($"insert completed, poa_id: {obj.bi_poa_id}, poa_header_id: {obj.bi_poa_header_id}");


            //insert poa_line
            obj.itemLists = itemList;
            obj.itemLists.ForEach(async row =>
            {
                var poa_line = new insertObj()
                {
                    table = "tb_poa_line",
                    inserter = new Dictionary<string, string>
                    {
                        {nameof(row.bi_poa_header_id), obj.bi_poa_header_id.ToString() },
                        {nameof(row.bi_item_id), row.bi_item_id.ToString() },
                        {nameof(row.bi_supp_item_id),row.bi_supp_item_id.ToString() },
                        {nameof(row.dc_promise_qty), row.dc_promise_qty.ToString() },
                        {nameof(row.i_uom_id),row.i_uom_id.ToString() },
                        {nameof(row.dc_min_qty),row.dc_min_qty.ToString() },
                        {nameof(row.dc_price), row.dc_price.ToString() },
                        {nameof(row.dc_amount), row.dc_amount.ToString() },
                        {nameof(row.vc_reference), row.vc_reference.ToString() },
                        {nameof(row.bi_quot_no),row.bi_quot_no.ToString() },
                    }
                };
                var resitem = await _dbServices.InsertAsync(poa_line);
                if (resitem.resCode != 1 || resitem.result == null)
                {
                    //_logger.LogDebug("insert error");
                    MessageBox.Show("insert error");
                }
                else
                {
                    MessageBox.Show($"poa line id: {resitem.result}");
                }
            });
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            var itemidtype = cbxitid.SelectedItem;
            if (itemidtype != null) { itemidtype = itemidtype.ToString().Split(":").ElementAt(0); }
            //var uomtype = cbxuom.SelectedItem;
            //if (uomtype != null) { uomtype = uomtype.ToString().Split(":").ElementAt(0); }

            var availableItem = pn2.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (availableItem != 7 || itemidtype == null)
            {
                MessageBox.Show("Please completed the POA form");
                return;
            }
            PoaItemList req = new PoaItemList()
            {
                bi_item_id = GenUtil.ConvertObjtoType<int>(itemidtype),
                bi_supp_item_id = GenUtil.ConvertObjtoType<int>(txtsupitid.Text),
                dc_promise_qty = GenUtil.ConvertObjtoType<decimal>(txtproqty.Text),
                // i_uom_id = GenUtil.ConvertObjtoType<int>(uomtype),
                dc_min_qty = GenUtil.ConvertObjtoType<decimal>(txtminqty.Text),
                dc_price = GenUtil.ConvertObjtoType<decimal>(txtpri.Text),
                dc_amount = GenUtil.ConvertObjtoType<decimal>(txtam.Text),
                vc_reference = txtref.Text,
                bi_quot_no = txtquot.Text,

            };
            if (itemList.Count > 0 && itemList.Select(x => x.bi_item_id == req.bi_item_id).FirstOrDefault())
            {
                MessageBox.Show("Item duplicate entry");
                return;
            }
            itemList.Add(req);
            MessageBox.Show("Item added");
            pn2.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            pn2.Controls.OfType<ComboBox>().ToList().ForEach(t => t.SelectedIndex = 0);
        }



        private async void btnclear_Click(object sender, EventArgs e)
        {
            await ClearContent();
        }
        private async Task ClearContent()
        {
            pn1.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            pn1.Controls.OfType<ComboBox>().ToList().ForEach(t => t.SelectedIndex = 0);
            pn2.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            pn2.Controls.OfType<ComboBox>().ToList().ForEach(t => t.SelectedIndex = 0);
        }



        private async void btnnext_Click(object sender, EventArgs e)
        {

            var poatype = cbxtype.SelectedItem;
            if (poatype != null) { poatype = poatype.ToString().Split(":").ElementAt(0); }
            var loc = cbxloc.SelectedItem;
            if (loc != null) { loc = loc.ToString().Split(":").ElementAt(0); }
            var tc = cbxtc.SelectedItem;
            if (tc != null) { tc = tc.ToString().Split(":").ElementAt(0); }
            var delisc = cbxselisc.SelectedItem;
            if (delisc != null) { delisc = delisc.ToString().Split(":").ElementAt(0); }
            var sup = cbxsup.SelectedItem;
            if (sup != null) { sup = sup.ToString().Split(":").ElementAt(0); }
            var ecdate = kryptonDateTimePickerec.Value;
            if (ecdate < DateTime.Now)
            {
                MessageBox.Show("Effective date error");
                return;
            }
            var selectedComboBoxpn1 = pn1.Controls.OfType<KryptonComboBox>().Where(n => !GenUtil.isNull(n.SelectedItem.ToString())).Count();
            var availableItem = pn1.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();

            if (availableItem != 2 || selectedComboBoxpn1 != 5)
            {
                MessageBox.Show("Please enter correct info");
                return;
            }
            else
            {
                await GenUtil.AddingInputToObject<POATableObj>(pn1, obj);
                //obj = new POATableObj()
                //{
                //    ti_poa_type_id = GenUtil.ConvertObjtoType<int>(poatype),
                //    bi_poa_status_id = 1,
                //    bi_deli_loc_id = GenUtil.ConvertObjtoType<int>(loc),
                //    bi_supp_id = GenUtil.ConvertObjtoType<int>(sup),
                //    vc_currency = txtcur.Text,
                //    ti_tc_id = GenUtil.ConvertObjtoType<int>(tc),
                //    ti_deli_sched_id = GenUtil.ConvertObjtoType<int>(delisc),
                //    dt_effect_date = ecdate,
                //    bi_contract_no = txtcont.Text,
                //};
            }

            if (obj.ti_poa_type_id != 1)
            {
                await InsertTableHeader();

                return;
            }

            pn1.Hide();
            pn2.Show();
            pn2.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            pn2.Hide();
            pn1.Show();
        }

        private void requiredFieldCheck(object sender, CancelEventArgs e)
        {
            ValidateCheck();

        }
        private void ValidateCheck()
        {
            var idtype = cbxitid.SelectedItem;
            if (idtype != null) { idtype = idtype.ToString().Split(":").ElementAt(0); }

            var selectedComboBoxpn1 = pn1.Controls.OfType<KryptonComboBox>().Where(n => !GenUtil.isNull(n.SelectedItem.ToString())).Count();
            var selectedComboBoxpn2 = pn2.Controls.OfType<KryptonComboBox>().Where(n => !GenUtil.isNull(n.SelectedItem.ToString())).Count();
            var availablePn1 = pn1.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            var availablePn2 = pn2.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();

            if (availablePn1 != 2 || availablePn2 != 6 || selectedComboBoxpn1 != 7 || selectedComboBoxpn2 != 2 || itemList.Count() <= 0)
            {
                disableValidation();
            }
            else
            {
                enableValidation();
            }
        }
    }
}

