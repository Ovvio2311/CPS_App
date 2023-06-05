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

namespace CPS_App
{
    public partial class ItemView : KryptonForm
    {
        public ClaimsIdentity userIden;
        public List<StockLevelViewObj> stock;
        private readonly DbServices _dbServices;
        private StockLevelWorker _stockWorker;
        public int selectId = 0;
        public ItemView(DbServices dbServices, StockLevelWorker stockWorker)
        {
            InitializeComponent();
            _dbServices = dbServices;
            stock = new List<StockLevelViewObj>();
            _stockWorker = stockWorker;
        }

        private async void ItemView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden == null)
            {
                //throw new Exception("user claim is null");

            }
           
            if (!await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "item", "update" } }))
            {
                btncreate.Hide();
                btnupdate.Hide();
            }
            else if (!await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "item", "read" } }))
            {                
                btnupdate.Hide();
            }
            lblnoresult.Hide();
            var userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();

            await LoadViewTable(userLoc);
            //stock = await _stockWorker.GetStockLevelWorker(userLoc);
            //if (stock != null)
            //{
            //    var observableItems = new ObservableCollection<StockLevelViewObj>(stock);
            //    BindingList<StockLevelViewObj> source = observableItems.ToBindingList();
            //    dataGridViewitem.DataSource = source;

            //    GenUtil.dataGridAttrName<StockLevelViewObj>(dataGridViewitem, new List<string>() { "not_shown" });

            //}

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectId == 0)
            {
                MessageBox.Show("Please select an item to update");
                return;
            }
            ItemEdit itemEdit = new ItemEdit(stock, _dbServices, selectId);
            itemEdit.MdiParent = this.MdiParent;
            itemEdit.Show();
        }

        private void dataGridViewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == dataGridViewitem.CurrentRow.Index)
            {
                selectId = GenUtil.ConvertObjtoType<int>(dataGridViewitem.CurrentRow.Cells["bi_item_id"].Value);
                //dataGridViewitem.DataSource = null;
                //List<StockLevelViewObj> itemViewSelect = stock.Where(x => x.bi_item_id == selectdId).ToList();


            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            ItemCreate itemCreate = new ItemCreate(_dbServices);
            itemCreate.MdiParent = this.MdiParent;
            itemCreate.Show();
        }
        private async Task LoadViewTable(string loc, searchObj obj = null)
        {
            lblnoresult.Hide();
            dataGridViewitem.DataSource = null;
            stock = await _stockWorker.GetStockLevelWorker(loc,obj);
            if (stock == null)
            {
                dataGridViewitem.Columns.Clear();
                lblnoresult.Show();
                return;
            }
            var observableItems = new ObservableCollection<StockLevelViewObj>(stock);
            BindingList<StockLevelViewObj> source = observableItems.ToBindingList();

            if (stock != null)
                dataGridViewitem.DataSource = source;

            GenUtil.dataGridAttrName<StockLevelViewObj>(dataGridViewitem, new List<string>() { "not_shown" });
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
