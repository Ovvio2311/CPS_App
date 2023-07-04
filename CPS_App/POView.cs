using CPS_App.Services;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class POView : Krypton.Toolkit.KryptonForm
    {
        public ClaimsIdentity userIden;
        private readonly DbServices _dbServices;
        public List<POTableObj> poObj;
        private Dictionary<string, string> searchWords;
        private SearchFunc _searchFunc;
        private GenericTableViewWorker _genericTableViewWorker;
        private CreatePoServices _createPoServices;
        private ManualMappingProcess _manualMappingProcess;
        private string userLoc;
        private List<POTableObj> _confirmSchRelease;
        private DbGeneralServices _generalServices;
        private int selectId;
        private CreateDNServices _CreateDNServices;
        public POView(DbServices dbServices, POAWorker pOAWorker, SearchFunc searchFunc, GenericTableViewWorker genericTableViewWorker,
            CreatePoServices createPoServices, ManualMappingProcess manualMappingProcess, DbGeneralServices generalServices, CreateDNServices createDNServices)
        {
            InitializeComponent();
            _dbServices = dbServices;
            poObj = new List<POTableObj>();
            searchWords = new Dictionary<string, string>();
            _searchFunc = searchFunc;
            _genericTableViewWorker = genericTableViewWorker;
            _createPoServices = createPoServices;
            _manualMappingProcess = manualMappingProcess;
            _confirmSchRelease = new List<POTableObj>();
            _generalServices = generalServices;
            _CreateDNServices = createDNServices;
        }

        private async void POView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            btnconfirmSchRe.Hide();
            if (userIden == null)
            {
                //throw new Exception("user claim is null");                
            }
            userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();
            if (!await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "po", "read" } }))
            {
                MessageBox.Show("No Access Permission");
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
            else
            {
                if (await CheckSchReleaseconfirmation())
                {
                    btnconfirmSchRe.Show();
                }
            }
            if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "po", "update" } }))
                btnedit.Show();
            else
                btnedit.Hide();
            if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "po", "write" } }))
            {
                btnadd.Show();
            }
            else
                btnadd.Hide();


            await LoadViewTable(userLoc);
            await GetSearchWords(userIden, "po");


        }
        private async Task LoadViewTable(string loc = null, searchObj obj = null)
        {
            searchObj sear = new searchObj();
            sear.searchWords.Add("bi_po_status_id", new List<string>() { "1", "3", "4" });
            lblnoresult.Hide();
            kryptonDataGridViewpo.DataSource = null;
            //poObj = await _pOAWorker.GetPoaWorker(loc, obj);
            POTableObj viewObj = new POTableObj();
            var kvpLoc = new Dictionary<string, string>()
            {
                {nameof(viewObj.bi_deli_loc_id),loc }
            };
            poObj = await _genericTableViewWorker.GetGenericWorker<POTableObj, PoItemList>(viewObj.GetSqlQuery(), nameof(viewObj.bi_po_header_id), kvpLoc, sear);

            if (poObj == null)
            {
                kryptonDataGridViewpo.Columns.Clear();
                lblnoresult.Show();
                //btnadd.Hide();
                btnedit.Hide();
                return;
            }
            var observableItems = new ObservableCollection<POTableObj>(poObj);
            BindingList<POTableObj> source = observableItems.ToBindingList();

            if (poObj != null)
                kryptonDataGridViewpo.DataSource = source;

            GenUtil.dataGridAttrName<POTableObj>(kryptonDataGridViewpo, new List<string>() { "not_shown" });
        }
        private void kryptonDataGridViewpoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == kryptonDataGridViewpo.CurrentRow.Index)
            {
                lblsubitemtitle.Show();
                selectId = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpo.CurrentRow.Cells["bi_po_header_id"].Value);

                kryptonDataGridViewitem.DataSource = null;
                //prevent po do not hv items
                //if (GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpoa.CurrentRow.Cells["ti_po_type_id"].Value) == 2)
                //{
                //    lblsubitemtitle.Hide();
                //    return;
                //}
                List<PoItemList> itemViewSelect = poObj.Where(x => x.bi_po_header_id == selectId).FirstOrDefault().itemLists;
                var observableItems = new ObservableCollection<PoItemList>(itemViewSelect);
                BindingList<PoItemList> source = observableItems.ToBindingList();
                kryptonDataGridViewitem.DataSource = source;
                GenUtil.dataGridAttrName<PoItemList>(kryptonDataGridViewitem, new List<string>() { "not_shown" });
            }
        }
        //edit PO and PO header
        private async void btnedit_Click(object sender, EventArgs e)
        {
            var currentIndex = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpo.CurrentRow.Cells["bi_po_header_id"].Value);
            var currentpoaType = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpo.CurrentRow.Cells["ti_po_type_id"].Value);
            //if (currentpoaType == 2)
            //{
            //    MessageBox.Show("Contract Agreement has no items to update");
            //    return;
            //}
            var readyToEdit = poObj.Where(x => x.bi_po_header_id == currentIndex).ToList();

            POEdit poaEdit = new POEdit(currentIndex, readyToEdit, _dbServices, _genericTableViewWorker);
            poaEdit.MdiParent = this.MdiParent;
            poaEdit.AutoScroll = true;
            poaEdit.Show();
            this.Close();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            POCreate poCre = new POCreate(_dbServices, _genericTableViewWorker, _createPoServices, _manualMappingProcess);
            poCre.MdiParent = this.MdiParent;
            poCre.AutoScroll = true;
            poCre.Show();
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnsearch_Click(object sender, EventArgs e)
        {
            //btnadd.Show();
            btnedit.Show();
            if (cbxsearch1.SelectedItem == cbxsearch2.SelectedItem && txtsearch1.Text != "" && txtsearch2.Text != "")
            {
                MessageBox.Show("Duplicate Search criteria");
                return;
            }
            lblnoresult.Hide();
            lblsubitemtitle.Hide();
            kryptonDataGridViewpo.DataSource = null;
            //string userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();

            if (txtsearch1.Text == string.Empty && txtsearch2.Text == string.Empty)
            {
                await LoadViewTable(userLoc);
                return;
            }
            var obj = new searchObj();

            foreach (KryptonPanel c in Controls.OfType<KryptonPanel>())
            {
                c.Controls.OfType<KryptonTextBox>().ToList().ForEach(x =>
                {
                    if (x.Text != string.Empty)
                    {
                        c.Controls.OfType<KryptonComboBox>().ToList().ForEach(p =>
                        {
                            var searchkey = searchWords.FirstOrDefault(x => x.Key == p.SelectedItem.ToString()).Value;
                            obj.searchWords.Add(searchkey, new List<string>() { x.Text });
                        });
                    }
                });
            }

            await LoadViewTable(userLoc, obj);
        }
        private async Task GetSearchWords(ClaimsIdentity identity, string part)
        {

            IEnumerable<tb_search_gen> searchString = await _searchFunc.SearchParaGenerator(identity, part);
            if (searchString == null)
            {
                return;
            }
            Dictionary<string, string> words = JsonConvert.DeserializeObject<Dictionary<string, string>>(searchString.ElementAt(0).js_search_para);

            searchWords = words;
            cbxsearch1.DataSource = words.Keys.ToList();
            cbxsearch2.DataSource = words.Keys.ToList();
        }

        private void btnconfirmppo_Click(object sender, EventArgs e)
        {
            SchReleaseConfirm schRelesaseForm = new SchReleaseConfirm(_genericTableViewWorker, _dbServices, _generalServices,_CreateDNServices);
            schRelesaseForm.MdiParent = this.MdiParent;
            schRelesaseForm.AutoScroll = true;
            schRelesaseForm.Show();
            this.Close();

            //kryptonDataGridViewpo.DataSource = null;
            //kryptonDataGridViewpo.Columns.Clear();
            //var observableItems = new ObservableCollection<POTableObj>(_confirmSchRelease);
            //BindingList<POTableObj> source = observableItems.ToBindingList();

            //if (_confirmSchRelease != null)
            //    kryptonDataGridViewpo.DataSource = source;

            //GenUtil.dataGridAttrName<POTableObj>(kryptonDataGridViewpo, new List<string>() { "not_shown" });

        }
        private async Task<bool> CheckSchReleaseconfirmation()
        {
            try
            {
                POTableObj viewObj = new POTableObj();

                searchObj searchObj = new searchObj()
                {
                    searchWords = new Dictionary<string, List<string>>
                {
                    { nameof(viewObj.ti_po_type_id), new List<string>(){"4"} },
                    {nameof(viewObj.bi_po_status_id), new List<string>(){"4"} },
                    {nameof(viewObj.bi_deli_loc_id),new List<string>(){ userLoc } },
                }
                };
                _confirmSchRelease = await _genericTableViewWorker.GetGenericWorker<POTableObj, PoItemList>(viewObj.GetSqlQuery(), nameof(viewObj.bi_po_header_id),
                     null, searchObj);
                return _confirmSchRelease != null ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }

        private async void btncsv_Click(object sender, EventArgs e)
        {
            if (selectId == 0)
            {
                MessageBox.Show("Please select a request to export");
                return;
            }
            var exportObj = poObj.Where(x => x.bi_po_header_id == selectId).FirstOrDefault();
            await CsvAsync(exportObj, $"Purchase_Order_id_{exportObj.bi_po_id}");
        }

        public async Task CsvAsync(POTableObj exportObj, string table)
        {
            if (await GenUtil.ExportCsv<POTableObj, PoItemList>(exportObj, exportObj.itemLists, table))
            {
                MessageBox.Show("CSV Generated");
            }
            else
            {
                MessageBox.Show("CSV Generated Fail");
            }
        }
    }
}
