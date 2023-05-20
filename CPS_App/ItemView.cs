using CPS_App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;

namespace CPS_App
{
    public partial class ItemView : Form
    {
        public ClaimsIdentity userIden;
        public AuthService _authService;
        public List<StockLevelViewObj> _stock;
        private readonly DbServices _dbServices;
        private StockLevelWorker _stockWorker;
        public ItemView(DbServices dbServices, AuthService authService, StockLevelWorker stockWorker)
        {
            InitializeComponent();
            _dbServices = dbServices;
            _authService = authService;
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
                dataGridViewitem.DataSource = _stock;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ItemEdit itemEdit = new ItemEdit(_stock,_dbServices);
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
