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
using Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot;
using Newtonsoft.Json;
using Pomelo.EntityFrameworkCore.MySql.Query.ExpressionTranslators.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class POCreate : KryptonForm
    {
        public ClaimsIdentity userIden;
        private DbServices _dbServices;
        private POTableObj obj;
        private List<PoItemList> itemList;
        private Validator _validator;
        private GenericTableViewWorker _genericTableViewWorker;
        private PoCreateRefList preHandleList;
        private CreatePoServices _createPoServices;
        private List<RequestMappingReqObj> _requestMappingReqObj;
        private ManualMappingProcess _manualMappingProcess;
        private List<POTableObj> PPO;

        public POCreate(DbServices dbServices, GenericTableViewWorker genericTableViewWorker,
            CreatePoServices createPoServices, ManualMappingProcess manualMappingProcess,
            List<RequestMappingReqObj> requestMappingReqObj = null)
        {
            InitializeComponent();
            obj = new POTableObj();
            itemList = new List<PoItemList>();
            _dbServices = dbServices;
            _validator = new Validator();
            // poaRefType = new Dictionary<string, string>();
            _genericTableViewWorker = genericTableViewWorker;
            preHandleList = new PoCreateRefList();
            _createPoServices = createPoServices;
            _requestMappingReqObj = requestMappingReqObj;
            _manualMappingProcess = manualMappingProcess;
            PPO = new List<POTableObj>();
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
            if (_requestMappingReqObj.Count() > 0)
            {
                PPO = await _manualMappingProcess.CheckforOtherPurchaseOrder(_requestMappingReqObj);
                if (PPO.Count() > 0)
                {
                    //cbxreffrom.Items.Add("New");
                    cbxreffrom.Items.Add("Contract Purchase Agreement");
                    cbxreffrom.Items.Add("Planned Purchase Order");
                    cbxtype.Items.Add($"3: Standard Purchase Order");
                    cbxtype.Items.Add($"4: Schedule Release");
                }
                else
                {
                    cbxreffrom.Items.Add("Contract Purchase Agreement");
                    cbxtype.Items.Add($"3: Standard Purchase Order");
                }
            }
            else
            {
                cbxreffrom.Items.Add("New");
                var poa_type = await _dbServices.SelectAllAsync<lut_poa_type>();
                List<lut_poa_type> poatype = JsonConvert.DeserializeObject<List<lut_poa_type>>(JsonConvert.SerializeObject(poa_type.result));
                poatype.ForEach(x =>
                {
                    if (x.b_is_ref_type)
                        cbxreffrom.Items.Add(x.vc_poa_type_desc);
                });

                var po_type = await _dbServices.SelectAllAsync<tb_po_type>();
                List<tb_po_type> potype = JsonConvert.DeserializeObject<List<tb_po_type>>(JsonConvert.SerializeObject(po_type.result));
                potype.ForEach(x =>
                {
                    if (x.b_is_ref_type)
                        cbxreffrom.Items.Add(x.vc_po_type_desc);
                    cbxtype.Items.Add($"{x.ti_po_type_id}: {x.vc_po_type_desc}");
                });
            }

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
        //next btn
        private async void btnnext_Click(object sender, EventArgs e)
        {
            if (!Checkpn1Validate())
            {
                MessageBox.Show("Please Complete the form");
                return;
            }
            var potype = cbxtype.SelectedItem;
            if (potype != null) { potype = potype.ToString().Split(":").ElementAt(0); }
            var loc = cbxloc.SelectedItem;
            if (loc != null) { loc = loc.ToString().Split(":").ElementAt(0); }
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
                //MessageBox.Show("Effective date error");
                //return;
            }
            var selectedComboBoxpn1 = pn1.Controls.OfType<KryptonComboBox>().Where(n => n.Text != string.Empty).Count(); //error to do update all 
            //var selectedComboBoxpn2 = pn2.Controls.OfType<KryptonComboBox>().Where(n => GenUtil.ConvertObjtoType<string>(n.SelectedItem) != null).Count();

            var availableItem = pn1.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();

            if (availableItem != 1 || (selectedComboBoxpn1 > 8 && selectedComboBoxpn1 < 7))
            {
                MessageBox.Show("Please enter correct info");
                return;
            }
            else
            {
                await GenUtil.AddingInputToObject<POTableObj>(pn1, obj);
                switch (obj.ti_po_type_id)
                {
                    case 1:
                        obj.bi_po_status_id = 1;
                        break;
                    case 2:
                    case 3:
                        obj.bi_po_status_id = 3;
                        break;
                    case 4:
                        obj.bi_po_status_id = 4;
                        break;
                    default:
                        obj.bi_po_status_id = 3;
                        break;
                }                
            }

            //if (obj.ti_po_type_id != 1)
            //{
            //    await InsertTableHeader();

            //    return;
            //}

            pn1.Hide();
            pn2.Show();
            pn2.Enabled = true;
        }
        //add btn
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!await ValidateCheck())
            {
                MessageBox.Show("item form not complete");
                return;
            }

            dynamic request = new
            {
                supid = txtsupitid.Text,
                quantity = txtactqty.Text,
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

            PoItemList req = new PoItemList();
            await GenUtil.AddingInputToObject<PoItemList>(pn2, req);
            req.vc_contract_no = obj.vc_contract_no;
            if (itemList.Count > 0 && itemList.Select(x => x.bi_item_id == req.bi_item_id).FirstOrDefault())
            {
                MessageBox.Show("Item duplicate entry");
                return;
            }
            itemList.Add(req);
            MessageBox.Show("Item added");

            if (await ValidateCheck() && itemList.Count() > 0)
            {
                enableValidation();

            }
            else
            {
                disableValidation();
            }
            pn2.Controls.OfType<KryptonTextBox>().ToList().ForEach(t => t.Clear());
            pn2.Controls.OfType<KryptonComboBox>().ToList().ForEach(t => t.SelectedIndex = -1);
            await GenUtil.ResumeBlankPage<PoItemList>(pn2);
            cbxuom.Enabled = false;
            txtam.Enabled = false;
        }
        //submit btn
        private async void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                obj.itemLists = itemList;
                var newlst = new List<POTableObj>();
                newlst.Add(obj);
                string confirmStr1 = await GenUtil.ConfirmListAttach<POTableObj>(pn1, newlst);
                string confirmStr2 = await GenUtil.ConfirmListAttach<PoItemList>(pn2, obj.itemLists);
                DialogResult response = MessageBox.Show(confirmStr1 + confirmStr2, "Confirm", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes ? true : false)
                {
                    resObj res = await _createPoServices.CreatePoASync(obj);
                    if (res.resCode != 1 && res.result != true && res.err_msg == null)
                    {
                        MessageBox.Show("Cannot insert Po");
                        return;
                    }
                    else if (res.resCode != 1 && res.result != true && res.err_msg != null)
                    {
                        MessageBox.Show(res.err_msg);
                        return;
                    }
                    //await ClearContent();
                    await ReturnToAddNewPage();
                    pn2.Hide();
                    pn1.Show();
                    //await InsertTableHeader();                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //clear btn
        private async void btnclear_Click(object sender, EventArgs e)
        {
            await ReturnToAddNewPage();
        }

        //cancel btn
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        //panel 1 check data
        private bool Checkpn1Validate()
        {
            try
            {
                var availableItem = pn1.Controls.OfType<KryptonTextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
                var selectedComboBoxpn1 = pn1.Controls.OfType<KryptonComboBox>().Where(n => n.Text != string.Empty).Count();

                return cbxreforderid.SelectedIndex == -1 ? availableItem == 1 && selectedComboBoxpn1 == 7 ? true : false : availableItem == 1 && selectedComboBoxpn1 == 8 ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private async Task<bool> ValidateCheck()
        {
            try
            {
                if (txtpri.Text != string.Empty && txtactqty.Text != string.Empty)
                {
                    var dec = GenUtil.ConvertObjtoType<int>(txtpri.Text) * GenUtil.ConvertObjtoType<int>(txtactqty.Text);
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
            return availablePn1 == 1 && availablePn2 == 6 && selectedComboBoxpn1 <= 8 && selectedComboBoxpn1 >= 7 && selectedComboBoxpn2 == 2;

        }
        //ref from 
        private async void cbxreffrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxreforderid.FormattingEnabled = true;
            cbxreforderid.SelectedIndex = -1;
            cbxreforderid.Items.Clear();
            await GenUtil.ResumeBlankPage<POTableObj>(pn1);
            await GenUtil.ResumeBlankPage<PoItemList>(pn2);
            if (cbxreffrom.Text == "New")
            {
                cbxitid.FormattingEnabled = true;
                cbxitid.SelectedIndex = -1;
                cbxitid.Items.Clear();
                cbxreforderid.Enabled = false;
                var itemType = await _dbServices.SelectAllAsync<tb_item>();
                List<tb_item> itid = JsonConvert.DeserializeObject<List<tb_item>>(JsonConvert.SerializeObject(itemType.result));
                itid.ForEach(x => cbxitid.Items.Add($"{x.bi_item_id}: {x.vc_item_desc}"));
                await ReturnToAddNewPage();
                return;
            }
            string selectedRef = cbxreffrom.Text;
            cbxreforderid.Enabled = true;

            DbResObj poaRes = await selectWhere(nameof(lut_poa_type), new Dictionary<string, string> { { "vc_poa_type_desc", selectedRef } });
            //search po type table  have value
            if (poaRes.resCode == 1 && poaRes.result.Count == 1)
            {
                List<List<KeyValuePair<string, object>>> kvp = poaRes.result;
                kvp.ElementAt(0).FirstOrDefault(x => x.Key == "ti_poa_type_id");

                DbResObj poaIdRes = await selectWhere("tb_poa", new Dictionary<string, string> { { "ti_poa_type_id",
                        kvp.ElementAt(0).FirstOrDefault(x => x.Key == "ti_poa_type_id").Value.ToString() } });

                if (poaIdRes.resCode == 1 && poaIdRes.result.Count > 0)
                {
                    List<List<KeyValuePair<string, object>>> kvppoaId = poaIdRes.result;
                    kvppoaId.ToList().ForEach(row =>
                    {
                        cbxreforderid.Items.Add($"Poa Id: {row.FirstOrDefault(col => col.Key == "bi_poa_id").Value}");
                    });
                }
            }
            //search po type table have no value
            else if (poaRes.resCode == 1 && poaRes.result.Count == 0)
            {
                if (PPO.Count > 0)
                {
                    PPO.ForEach(x =>
                    {
                        cbxreforderid.Items.Add($"Po Id: {x.bi_po_id}");
                    });
                }
                else
                {
                    var pores = await selectWhere(nameof(tb_po_type), new Dictionary<string, string> { { "vc_po_type_desc", selectedRef } });
                    if (pores.resCode == 1 && pores.result.Count == 1)
                    {
                        List<List<KeyValuePair<string, object>>> kvp = pores.result;
                        DbResObj poIdRes = await selectWhere("tb_po", new Dictionary<string, string> { { "ti_po_type_id",
                            kvp.ElementAt(0).FirstOrDefault(x => x.Key == "ti_po_type_id").Value.ToString() } });
                        if (poIdRes.resCode == 1 && poIdRes.result.Count > 0)
                        {
                            List<List<KeyValuePair<string, object>>> kvppoId = poIdRes.result;
                            kvppoId.ToList().ForEach(row =>
                            {
                                cbxreforderid.Items.Add($"Po Id: {row.FirstOrDefault(col => col.Key == "bi_po_id").Value}");
                            });
                        }
                    }
                }

            }
            cbxtype.Items.Clear();
            var po_type = await _dbServices.SelectAllAsync<tb_po_type>();
            List<tb_po_type> potype = JsonConvert.DeserializeObject<List<tb_po_type>>(JsonConvert.SerializeObject(po_type.result));
            potype.ForEach(x =>
            {

                if (cbxreffrom.SelectedIndex != -1 && x.vc_derive_order.Contains(selectedRef))
                {
                    cbxtype.Items.Add($"{x.ti_po_type_id}: {x.vc_po_type_desc}");
                }

            });
        }

        //reference order id
        private async void cbxRefOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxreforderid.SelectedIndex != -1)
            {
                var refType = cbxreforderid.SelectedItem.ToString().Split(":").ElementAt(0);
                var refId = cbxreforderid.SelectedItem.ToString().Split(":").ElementAt(1);

                var refid_value = cbxreforderid.SelectedItem;
                if (refType.Contains("Poa"))
                {
                    POATableObj obj = new POATableObj();
                    preHandleList.poaList = await _genericTableViewWorker.GetGenericWorker<POATableObj, PoaItemList>(obj.GetSqlQuery(), nameof(obj.bi_poa_header_id), null,
                       new searchObj() { searchWords = new Dictionary<string, List<string>> { { nameof(obj.bi_poa_id), new List<string>() { refId } } } });
                    await AllocatePrehandleList<POATableObj>(preHandleList.poaList);
                    cbxitid.Items.Clear();
                    preHandleList.poaList.ForEach(p =>
                    {
                        p.itemLists.ForEach(i =>
                        {
                            cbxitid.Items.Add($"{i.bi_item_id}: {i.vc_item_desc}");
                        });
                    });
                }
                else if (refType.Contains("Po"))
                {
                    POTableObj obj = new POTableObj();
                    preHandleList.poList = await _genericTableViewWorker.GetGenericWorker<POTableObj, PoItemList>(obj.GetSqlQuery(), nameof(obj.bi_po_header_id), null,
                       new searchObj() { searchWords = new Dictionary<string, List<string>> { { nameof(obj.bi_po_id), new List<string>() { refId } } } });
                    // preHandleList.poList.ForEach(x=>x.ti_po_type_id== )
                    await AllocatePrehandleList<POTableObj>(preHandleList.poList);
                    cbxreforderid.Enabled = true;
                    cbxtype.Enabled = true;

                    cbxitid.Items.Clear();
                    preHandleList.poList.ForEach(p =>
                    {
                        p.itemLists.ForEach(i =>
                        {
                            cbxitid.Items.Add($"{i.bi_item_id}: {i.vc_item_desc}");
                        });
                    });
                }
            }
        }

        //item id reference
        private async void cbxitid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxitid.SelectedIndex != -1 && cbxreffrom.SelectedIndex != -1 && cbxreforderid.SelectedIndex != -1)
            {
                var refType = cbxreforderid.SelectedItem.ToString()!.Split(":").ElementAt(0);

                var id = cbxitid.SelectedItem.ToString()!.Split(":").ElementAt(0);

                if (refType.Contains("Poa"))
                {
                    foreach (POATableObj i in preHandleList.poaList)
                    {
                        var itemRef = i.itemLists.Where(x => x.bi_item_id.ToString() == id).ToList();
                        await GenUtil.AutoLabelAddingTextBox<PoaItemList>(pn2, itemRef);
                        txtref.Enabled = true;
                        break;
                    }
                }
                else if (refType.Contains("Po"))
                {
                    foreach (POTableObj i in preHandleList.poList)
                    {
                        var itemRef = i.itemLists.Where(x => x.bi_item_id.ToString() == id).ToList();
                        await GenUtil.AutoLabelAddingTextBox<PoItemList>(pn2, itemRef);
                        txtref.Enabled = true;
                        txtactqty.Enabled = true;

                        break;
                    }
                }
            }
        }
        //Po type
        private async void cbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxreforderid.SelectedIndex != -1 && cbxtype.SelectedIndex != -1)
            {
                var Type = cbxtype.SelectedItem.ToString()!.Split(":").ElementAt(1);

                var id = cbxtype.SelectedItem.ToString()!.Split(":").ElementAt(0);

                if (id.Contains("1") || id.Contains("3"))
                {
                    cbxitid.Items.Clear();
                    var itemType = await _dbServices.SelectAllAsync<tb_item>();
                    List<tb_item> itid = JsonConvert.DeserializeObject<List<tb_item>>(JsonConvert.SerializeObject(itemType.result));
                    itid.ForEach(x => cbxitid.Items.Add($"{x.bi_item_id}: {x.vc_item_desc}"));

                }
            }
            if (cbxreffrom.SelectedItem.ToString().Contains("Planned Purchase Order"))
            {
                cbxloc.Enabled = true;
            }
        }
        private async Task ReturnToAddNewPage()
        {
            await GenUtil.ResumeBlankPage<POTableObj>(pn1);
            await GenUtil.ResumeBlankPage<PoItemList>(pn2);
            cbxuom.Enabled = false;
            txtam.Enabled = false;
            itemList.Clear();
            obj = new POTableObj();
        }
        private async Task AllocatePrehandleList<T>(List<T> obj)
        {
            await GenUtil.AutoLabelAddingTextBox<T>(pn1, obj, "vc_ref_id");
        }
        public async Task<DbResObj> selectWhere(string table, Dictionary<string, string> obj)
        {
            DbResObj res = new DbResObj()
            {
                resCode = 0,
                result = null,
                err_msg = null
            };
            try
            {
                var selectObj = new selectObj();
                selectObj.table = table;
                selectObj.selecter = obj;
                res = await _dbServices.SelectWhereAsync(selectObj);
                if (res.resCode == 1 && res.result.Count > 0)
                {
                    res.result = GenUtil.DbResulttoKVP(res.result);
                }
                return res;
            }
            catch (Exception ex)
            {
                return res;
            }
        }
    }
}

