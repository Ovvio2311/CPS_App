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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class ItemEdit : Form
    {
        //public int index;
        public List<StockLevelViewObj> _stock;
        private DbServices _dbServices;
        public ItemEdit(List<StockLevelViewObj> obj, DbServices dbServices)
        {
            InitializeComponent();
            _stock = obj;
            _dbServices = dbServices;
            //this.index = index;
        }

        private void ItemEdit_Load(object sender, EventArgs e)
        {
            if (_stock == null)
            {
                MessageBox.Show("error");
                return;
            }
            dataGridViewitem.DataSource = _stock;
            dataGridViewitem.Columns.ToDynamicList().ForEach(col =>
            {
                DataGridViewColumn column = col;
                col.HeaderText = typeof(StockLevelViewObj).GetProperties().ToList()
                .Where(x => col.HeaderText == x.Name)
                .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                if (column.HeaderText == "bi_location_id" || column.HeaderText == "items_group"
                || column.HeaderText == "i_uom_id" || column.HeaderText == "bi_category_id")
                {
                    column.Visible = false;
                }

            });
        }

        private void dataGridViewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == dataGridViewitem.CurrentRow.Index)
            {
                var readyToEdit = _stock.ToList().ElementAt(e.RowIndex);
                txtvid.Text = readyToEdit.bi_item_vid.ToString();
                txtid.Text = readyToEdit.bi_item_id.ToString();
                txtcat.Text = readyToEdit.vc_category_desc.ToString();
                txtloc.Text = readyToEdit.vc_location_desc.ToString();
                txtuom.Text = readyToEdit.vc_uom_desc.ToString();
                txtupdate.Text = readyToEdit.dt_updated_datetime.ToString();
                txtname.Text = readyToEdit.vc_item_desc.ToString();
                txtqty.Text = readyToEdit.i_item_qty.ToString();
            }
        }

        private async void btnmod_Click(object sender, EventArgs e)
        {
            var reit = _stock.ToList().ElementAt(dataGridViewitem.CurrentRow.Index);

            if (txtqty.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter qty");
                return;
            }
            var updateObj = new updateObj();
            updateObj.table = "tb_item_unit";
            updateObj.updater.Add(nameof(reit.i_item_qty), txtqty.ToString());
            updateObj.selecter.Add(nameof(reit.bi_item_id), reit.bi_item_id.ToString());
            updateObj.selecter.Add(nameof(reit.bi_location_id), reit.bi_location_id.ToString());
            var res = await _dbServices.UpdateAsync(updateObj);
            if (res.resCode != 1)
            {
                MessageBox.Show("error");
                return;
            }
            MessageBox.Show("Item updated");
        }
    }
}
