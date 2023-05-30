using CPS_App.Services;
using System;
using System.Collections.Generic;
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
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using Krypton.Toolkit;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace CPS_App
{
    public partial class ItemView : KryptonForm
    {
        public ClaimsIdentity userIden;
        public List<StockLevelViewObj> _stock;
        private readonly DbServices _dbServices;
        private StockLevelWorker _stockWorker;
        public ItemView(DbServices dbServices, StockLevelWorker stockWorker)
        {
            InitializeComponent();
            _dbServices = dbServices;
            _stock = new List<StockLevelViewObj>();
            _stockWorker = stockWorker;
        }

        private async void ItemView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden != null)
            {
                var userRole = userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToString();
            }
            _stock = await _stockWorker.GetStockLevelWorker();
            if (_stock != null)
            {
                var observableItems = new ObservableCollection<StockLevelViewObj>(_stock);
                BindingList<StockLevelViewObj> source = observableItems.ToBindingList();
                dataGridViewitem.DataSource = source;

                GenUtil.dataGridAttrName<StockLevelViewObj>(dataGridViewitem, new List<string>() { "bi_location_id", "items_group",
                "i_uom_id","bi_category_id"});
                //dataGridViewitem.Columns.ToDynamicList().ForEach(col =>
                //{
                //    DataGridViewColumn column = col;
                //    col.HeaderText = typeof(StockLevelViewObj).GetProperties().ToList()
                //    .Where(x => col.HeaderText == x.Name)
                //    .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                //    .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                //    if (column.HeaderText == "bi_location_id" || column.HeaderText == "items_group"
                //    || column.HeaderText == "i_uom_id" || column.HeaderText == "bi_category_id")
                //    {
                //        column.Visible = false;
                //    }

                //});
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ItemEdit itemEdit = new ItemEdit(_stock, _dbServices);
            //itemEdit.TopMost = true;
            itemEdit.ShowDialog();
        }

        private void dataGridViewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == dataGridViewitem.CurrentRow.Index)
            {


            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            ItemCreate itemCreate = new ItemCreate(_dbServices);
            itemCreate.Show();
        }
    }
}
