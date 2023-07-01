using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection.PortableExecutable;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPS_App.Helpers;
using CPS_App.Services;
using Krypton.Toolkit;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
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
        private Validator _validator;
        public POACreate(DbServices dbServices)
        {
            InitializeComponent();
            obj = new POATableObj();
            itemList = new List<PoaItemList>();
            _dbServices = dbServices;
            _validator = new Validator();
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

            //var locType = await _dbServices.SelectAllAsync<tb_location>();
            //List<tb_location> loc = JsonConvert.DeserializeObject<List<tb_location>>(JsonConvert.SerializeObject(locType.result));
            //loc.ForEach(x => cbxloc.Items.Add($"{x.bi_location_id}: {x.vc_location_desc}"));

            var supType = await _dbServices.SelectAllAsync<tb_supplier>();
            List<tb_supplier> sup = JsonConvert.DeserializeObject<List<tb_supplier>>(JsonConvert.SerializeObject(supType.result));
            sup.ForEach(x => cbxsup.Items.Add($"{x.bi_supp_id}: {x.vc_supp_desc}"));

            var tcType = await _dbServices.SelectAllAsync<lut_term_and_con>();
            List<lut_term_and_con> tc = JsonConvert.DeserializeObject<List<lut_term_and_con>>(JsonConvert.SerializeObject(tcType.result));
            tc.ForEach(x => cbxtc.Items.Add($"{x.ti_tc_id}: {x.vc_tc_desc}"));

            var deliscType = await _dbServices.SelectAllAsync<lut_deli_schedule_type>();
            List<lut_deli_schedule_type> sc = JsonConvert.DeserializeObject<List<lut_deli_schedule_type>>(JsonConvert.SerializeObject(deliscType.result));
            sc.ForEach(x => cbxselisc.Items.Add($"{x.ti_deli_sched_id}: {x.vc_deli_sched_desc}"));

            var uomType = await _dbServices.SelectAllAsync<lut_uom_type>();
            List<lut_uom_type> uom = JsonConvert.DeserializeObject<List<lut_uom_type>>(JsonConvert.SerializeObject(uomType.result));
            uom.ForEach(x => cbxuom.Items.Add($"{x.i_uom_id}: {x.vc_uom_desc}"));

            var curType = await _dbServices.SelectAllAsync<lut_currency>();
            List<lut_currency> cur = JsonConvert.DeserializeObject<List<lut_currency>>(JsonConvert.SerializeObject(curType.result));
            cur.ForEach(x => cbxcur.Items.Add($"{x.i_cur_id}: {x.vc_cur_desc}"));

            var itemType = await _dbServices.SelectAllAsync<tb_item>();
            List<tb_item> itid = JsonConvert.DeserializeObject<List<tb_item>>(JsonConvert.SerializeObject(itemType.result));
            itid.ForEach(x => cbxitid.Items.Add($"{x.bi_item_id}: {x.vc_item_desc}"));

            pn1.Controls.OfType<KryptonTextBox>().ToList().ForEach(x => x.Validating += requiredFieldCheck);
            pn2.Controls.OfType<KryptonTextBox>().ToList().ForEach(x => x.Validating += requiredFieldCheck);
            pn1.Controls.OfType<KryptonComboBox>().ToList().ForEach(x => x.Validating += requiredFieldCheck);
            pn2.Controls.OfType<KryptonComboBox>().ToList().ForEach(x => x.Validating += requiredFieldCheck);
        }
        public void enableValidation()
        {
            btnsubmit.Enabled = true;

        }
        public void disableValidation()
        {
            btnsubmit.Enabled = false;

        }


        private async void btnnext_Click(object sender, EventArgs e)
        {

            var poatype = cbxtype.SelectedItem;
            if (poatype != null) { poatype = poatype.ToString().Split(":").ElementAt(0); }
            //var loc = cbxloc.SelectedItem;
            //if (loc != null) { loc = loc.ToString().Split(":").ElementAt(0); }
            var tc = cbxtc.SelectedItem;
            if (tc != null) { tc = tc.ToString().Split(":").ElementAt(0); }
            var delisc = cbxselisc.SelectedItem;
            if (delisc != null) { delisc = delisc.ToString().Split(":").ElementAt(0); }
            var sup = cbxsup.SelectedItem;
            if (sup != null) { sup = sup.ToString().Split(":").ElementAt(0); }
            var cur = cbxcur.SelectedItem;
            if (cur != null) { cur = cur.ToString().Split(":").ElementAt(0); }
            var ecdate = kryptonDateTimePickerec.Value;
            if (ecdate < DateTime.Now)
            {
                MessageBox.Show("Effective date error");
                return;
            }
            var selectedComboBoxpn1 = pn1.Controls.OfType<KryptonComboBox>().Where(n => n.Text != string.Empty).Count();
            //var selectedComboBoxpn2 = pn2.Controls.OfType<KryptonComboBox>().Where(n => GenUtil.ConvertObjtoType<string>(n.SelectedItem) != null).Count();


            var availableItem = pn1.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();

            if (availableItem != 1 || selectedComboBoxpn1 != 5)
            {
                MessageBox.Show("Please enter correct info");
                return;
            }
            else
            {
                await GenUtil.AddingInputToObject<POATableObj>(pn1, obj);
                obj.bi_poa_status_id = 1;
            }

            if (obj.ti_poa_type_id != 1)
            {
                await InsertTableHeader();
                await ClearContent();
                return;
            }

            pn1.Hide();
            pn2.Show();
            pn2.Enabled = true;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!await ValidateCheck())
            {
                MessageBox.Show("itemLists form not complete");
                return;
            }

            dynamic request = new
            {
                supid = txtsupitid.Text,
                quantity = txtproqty.Text,
                minqty = txtminqty.Text,
                price = txtpri.Text,
                reference = txtref.Text,
                quot = txtquot.Text,

            };
            Validator validator = new Validator();
            validator.make(request,
            new
            {
                supid /*key*/= "required" /*fieldRule*/,
                quantity = "int",
                minqty = "int",
                price = "int",
                reference = "required",
                quot = "required",

            });
            if (!validator.passes())
            {
                MessageBox.Show(GenUtil.ArrayToString(validator.errors()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var itemidtype = cbxitid.SelectedItem;
            if (itemidtype != null) { itemidtype = itemidtype.ToString().Split(":").ElementAt(0); }
            //var uomtype = cbxuom.SelectedItem;
            //if (uomtype != null) { uomtype = uomtype.ToString().Split(":").ElementAt(0); }
            PoaItemList req = new PoaItemList();
            await GenUtil.AddingInputToObject<PoaItemList>(pn2, req);
            if (req.i_promise_qty < req.i_min_qty)
            {
                MessageBox.Show("Min Qty must smaller than Promise Qty");
                return;
            }
            if (itemList.Count > 0 && itemList.Select(x => x.bi_item_id == req.bi_item_id).FirstOrDefault())
            {
                MessageBox.Show("Item duplicate entry");
                return;
            }
            itemList.Add(req);
            MessageBox.Show("Item added");
            pn2.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            pn2.Controls.OfType<ComboBox>().ToList().ForEach(t => t.SelectedIndex = 0);
            if (await ValidateCheck() && itemList.Count() > 0)
            {
                enableValidation();

            }
            else
            {
                disableValidation();
            }
        }
        private async void btnsubmit_Click(object sender, EventArgs e)
        {
            obj.itemLists = itemList;
            var newlst = new List<POATableObj>();
            newlst.Add(obj);
            string confirmStr1 = await GenUtil.ConfirmListAttach<POATableObj>(pn1, newlst);
            string confirmStr2 = await GenUtil.ConfirmListAttach<PoaItemList>(pn2, obj.itemLists);
            DialogResult response = MessageBox.Show(confirmStr1 + confirmStr2, "Confirm", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes ? true : false)
            {

                await InsertTableHeader();

                //insert poa_line

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
                        {nameof(row.i_promise_qty), row.i_promise_qty.ToString() },
                        {nameof(row.i_remain_qty),row.i_promise_qty.ToString() },
                        {nameof(row.i_uom_id),row.i_uom_id.ToString() },
                        {nameof(row.i_min_qty),row.i_min_qty.ToString() },
                        {nameof(row.i_price), row.i_price.ToString() },
                        {nameof(row.i_amount), row.i_amount.ToString() },
                        {nameof(row.vc_reference), row.vc_reference.ToString() },
                        {nameof(row.vc_quot_no),row.vc_quot_no.ToString() },
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
                        await ClearContent();
                    }
                });
            }
        }

        private async void btnclear_Click(object sender, EventArgs e)
        {
            await ClearContent();
        }
        private async Task ClearContent()
        {
            await GenUtil.ResumeBlankPage<POATableObj>(pn1);
            await GenUtil.ResumeBlankPage<POATableObj>(pn2);
            await GenUtil.ResumeBlankPage<PoaItemList>(pn1);
            await GenUtil.ResumeBlankPage<PoaItemList>(pn2);
            //pn1.Controls.OfType<KryptonTextBox>().ToList().ForEach(t => t.Clear());
            //pn1.Controls.OfType<KryptonComboBox>().ToList().ForEach(t => t.SelectedIndex = 0);
            //pn2.Controls.OfType<KryptonTextBox>().ToList().ForEach(t => t.Clear());
            //pn2.Controls.OfType<KryptonComboBox>().ToList().ForEach(t => t.SelectedIndex = 0);
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

        private async void requiredFieldCheck(object sender, CancelEventArgs e)
        {
            if (await ValidateCheck() && itemList.Count() > 0)
            {
                enableValidation();

            }
            else
            {
                disableValidation();
            }

        }
        private async Task<bool> ValidateCheck()
        {
            try
            {
                if (GenUtil.ConvertObjtoType<int>(txtpri.Text) != null && GenUtil.ConvertObjtoType<int>(txtpri.Text) > 0 &&
                    GenUtil.ConvertObjtoType<int>(txtproqty.Text) != null && GenUtil.ConvertObjtoType<int>(txtproqty.Text) > 0)
                {
                    var dec = GenUtil.ConvertObjtoType<int>(txtpri.Text) * GenUtil.ConvertObjtoType<int>(txtproqty.Text);
                    txtam.Text = dec.ToString();
                }
                if (cbxitid.SelectedItem != null)
                {
                    var itid = cbxitid.SelectedItem;
                    itid = itid.ToString().Split(":").ElementAt(0);
                    var uomFinder = new selectObj();
                    uomFinder.table = "tb_item";
                    uomFinder.selecter = new Dictionary<string, string>
                    {
                        {"bi_item_id", itid.ToString()}
                    };
                    var uomid = await _dbServices.SelectWhereAsync<tb_item>(uomFinder);
                    if (uomid.resCode != 1 || uomid.result == null)
                    {
                        //_logger.LogDebug("uom Id not find");
                        MessageBox.Show("uom Id not find");
                    }
                    tb_item uomId = uomid.result[0];
                    var temp = GenUtil.ConvertObjtoType<int>(uomId.i_uom_id);
                    cbxuom.SelectedItem = cbxuom.Items.ToDynamicList<string>()
                        .Where(x => x.Contains(temp.ToString())).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            var idtype = cbxitid.SelectedItem;
            if (idtype != null) { idtype = idtype.ToString().Split(":").ElementAt(0); }

            var selectedComboBoxpn1 = pn1.Controls.OfType<KryptonComboBox>().Where(n => n.Text != string.Empty).Count();
            var selectedComboBoxpn2 = pn2.Controls.OfType<KryptonComboBox>().Where(n => n.Text != string.Empty).Count();
            var availablePn1 = pn1.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            var availablePn2 = pn2.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            return availablePn1 == 1 && availablePn2 == 7 && selectedComboBoxpn1 == 5 && selectedComboBoxpn2 == 2 &&
                GenUtil.ConvertObjtoType<int>(txtproqty.Text.Trim()) != null && GenUtil.ConvertObjtoType<int>(txtproqty.Text.Trim()) > 0 &&
                GenUtil.ConvertObjtoType<int>(txtminqty.Text.Trim()) != null && GenUtil.ConvertObjtoType<int>(txtminqty.Text.Trim()) > 0 &&
                GenUtil.ConvertObjtoType<int>(txtpri.Text.Trim()) != null && GenUtil.ConvertObjtoType<int>(txtpri.Text.Trim()) > 0 ; 

        }

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
                MessageBox.Show("insert poa error");
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
                        //{ nameof(obj.bi_deli_loc_id), obj.bi_deli_loc_id.ToString() },
                        { nameof(obj.i_cur_id), obj.i_cur_id.ToString()},
                        { nameof(obj.ti_tc_id), obj.ti_tc_id.ToString() },
                        { nameof(obj.ti_deli_sched_id), obj.ti_deli_sched_id.ToString() },
                        { nameof(obj.dt_effect_date), obj.dt_effect_date.ToString() },
                        { nameof(obj.vc_contract_no), obj.vc_contract_no },
                }
            };
            var resheader = await _dbServices.InsertAsync(tb_boa_header);
            if (resheader.resCode != 1 || resheader.result == null)
            {
                MessageBox.Show("insert poa header error");
                return;
            }
            obj.bi_poa_header_id = GenUtil.ConvertObjtoType<int>(resheader.result);
            MessageBox.Show($"insert completed, poa id: {obj.bi_poa_id}, poa header id: {obj.bi_poa_header_id}");

        }

        private void cbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxtype.SelectedItem != null)
                {
                    if (cbxtype.SelectedItem.ToString().Contains("1"))
                    {
                        txtcont.Enabled = false;
                        txtquot.Enabled = false;
                        txtcont.Text = "Nil";
                        txtquot.Text = "Nil";
                    }
                    else
                    {
                        txtcont.Enabled = true;
                        txtquot.Enabled = true;
                        txtcont.Text = string.Empty;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

