using CPS_App.Services;
using System.ComponentModel;
using System.Data;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using static CPS_App.Models.CPSModel;
using Krypton.Toolkit;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using static CPS_App.Models.DbModels;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Windows.Controls;

namespace CPS_App
{
    public partial class ItemView : KryptonForm
    {
        public ClaimsIdentity userIden;
        public List<StockLevelViewObj> stock;
        private readonly DbServices _dbServices;
        private StockLevelWorker _stockWorker;
        public int selectId = 0;
        private SearchFunc _searchFunc;
        private Dictionary<string, string> searchWords;
        private GenericTableViewWorker _genericTableViewWorker;
        public ItemView(DbServices dbServices, StockLevelWorker stockWorker, SearchFunc searchFunc, GenericTableViewWorker genericTableViewWorker)
        {
            InitializeComponent();
            _dbServices = dbServices;
            stock = new List<StockLevelViewObj>();
            _stockWorker = stockWorker;
            searchWords = new Dictionary<string, string>();
            _searchFunc = searchFunc;
            _genericTableViewWorker = genericTableViewWorker;
        }

        private async void ItemView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden == null)
            {
                //throw new Exception("user claim is null");

            }
            if (!await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "item", "read" } }))
            {
                MessageBox.Show("No Access Permission");
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
            if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "item", "update" } }))
                btnupdate.Show();
            else
                btnupdate.Hide();
            if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "item", "write" } }))
                btncreate.Show();
            else
                btncreate.Hide();

            lblnoresult.Hide();
            var userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();

            await LoadViewTable(userLoc);
            await GetSearchWords(userIden,"item");
            //stock = await _stockWorker.GetStockLevelWorker(userLoc);
            //if (stock != null)
            //{
            //    var observableItems = new ObservableCollection<StockLevelViewObj>(stock);
            //    BindingList<StockLevelViewObj> source = observableItems.ToBindingList();
            //    dataGridViewitem.DataSource = source;

            //    GenUtil.dataGridAttrName<StockLevelViewObj>(dataGridViewitem, new List<string>() { "not_shown" });

            //}

        }
        private async Task LoadViewTable(string loc, searchObj obj = null)
        {
            StockLevelViewObj viewObj = new StockLevelViewObj();
            var kvpLoc = new Dictionary<string, string>()
            {
                {"bi_location_id",loc }
            };
            lblnoresult.Hide();
            dataGridViewitem.DataSource = null;
            //stock = await _stockWorker.GetStockLevelWorker(loc, obj);
            stock = await _genericTableViewWorker.GetGenericWorker<StockLevelViewObj, StockLevelSubItem>(viewObj.sql, nameof(viewObj.bi_item_id), kvpLoc, obj);
            if (stock == null)
            {
                dataGridViewitem.Columns.Clear();
                lblnoresult.Show();
                btncreate.Hide();
                btnupdate.Hide();
                return;
            }
            var observableItems = new ObservableCollection<StockLevelViewObj>(stock);
            BindingList<StockLevelViewObj> source = observableItems.ToBindingList();

            if (stock != null)
                dataGridViewitem.DataSource = source;

            GenUtil.dataGridAttrName<StockLevelViewObj>(dataGridViewitem, new List<string>() { "not_shown" });
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectId == 0)
            {
                MessageBox.Show("Please select an item to update");
                return;
            }
            ItemEdit itemEdit = new ItemEdit(stock, _dbServices, selectId, _stockWorker,_genericTableViewWorker);
            itemEdit.MdiParent = this.MdiParent;
            itemEdit.AutoScroll = true;
            itemEdit.Show();
            this.Close();
        }

        private void dataGridViewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == dataGridViewitem.CurrentRow.Index)
            {
                lblsubitemtitle.Show();
                selectId = GenUtil.ConvertObjtoType<int>(dataGridViewitem.CurrentRow.Cells["bi_item_id"].Value);

                kryptonDataGridViewsubitem.DataSource = null;
                List<StockLevelSubItem> itemViewSelect = stock.Where(x => x.bi_item_id == selectId).FirstOrDefault().itemLists;

                var observableItems = new ObservableCollection<StockLevelSubItem>(itemViewSelect);
                BindingList<StockLevelSubItem> source = observableItems.ToBindingList();
                kryptonDataGridViewsubitem.DataSource = source;
                GenUtil.dataGridAttrName<StockLevelSubItem>(kryptonDataGridViewsubitem, new List<string>() { "not_shown" });

            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            ItemCreate itemCreate = new ItemCreate(_dbServices);
            itemCreate.MdiParent = this.MdiParent;
            itemCreate.AutoScroll = true;
            itemCreate.Show();
            this.Close();
        }


        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnsearch_Click(object sender, EventArgs e)
        {
            btncreate.Show();
            btnupdate.Show();
            if (cbxsearch1.SelectedItem == cbxsearch2.SelectedItem && txtsearch1.Text != "" && txtsearch2.Text != "")
            {
                MessageBox.Show("Duplicate Search criteria");
                return;
            }
            lblnoresult.Hide();
            lblsubitemtitle.Hide();
            dataGridViewitem.DataSource = null;
            string userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();

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
    }
}
