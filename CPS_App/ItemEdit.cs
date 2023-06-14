﻿using CPS_App.Services;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class ItemEdit : KryptonForm
    {
        public int itemId;
        public List<StockLevelViewObj> stock;
        public BindingList<StockLevelSubItem> stockList;
        private DbServices _dbServices;
        private StockLevelWorker _worker;
        private GenericTableViewWorker _genericTableViewWorker;
        public ItemEdit(List<StockLevelViewObj> obj, DbServices dbServices, int itemId, StockLevelWorker worker, GenericTableViewWorker genericTableViewWorker)
        {
            InitializeComponent();
            stock = obj;
            _dbServices = dbServices;
            this.itemId = itemId;
            stockList = new BindingList<StockLevelSubItem>();
            _worker = worker;
            _genericTableViewWorker = genericTableViewWorker;
        }

        private async void ItemEdit_Load(object sender, EventArgs e)
        {
            if (stock == null)
            {
                MessageBox.Show("error");
                return;
            }
            await itemEditInitialLoad();
        
        }
        private async Task itemEditInitialLoad()
        {
            StockLevelViewObj edititems = stock.ToList().Where(x => x.bi_item_id == itemId).FirstOrDefault();
            //txtreqid.Text = edititems.bi_req_id.ToString();
            //txtstaName.Text = GenUtil.ConvertObjtoType<string>(edititems.vc_staff_name);
            //txtloc.Text = edititems.vc_location_desc.ToString();
            //txtcrDate.Text = edititems.dt_created_date.ToString();

            var observableItems = new ObservableCollection<StockLevelSubItem>(edititems.itemLists);
            stockList = observableItems.ToBindingList();
            dataGridViewitem.Columns.Clear();
            dataGridViewitem.DataSource = stockList;

            //change header name and hide column
            GenUtil.dataGridAttrName<StockLevelSubItem>(dataGridViewitem, new List<string>() { "not_shown" });
        }
        private async void dataGridViewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == dataGridViewitem.CurrentRow.Index)
            {
                if (e.RowIndex > dataGridViewitem.RowCount) { return; }
                //dataGridViewitem.DataSource = null;
                int selectid = GenUtil.ConvertObjtoType<int>(dataGridViewitem.CurrentRow.Cells["bi_location_id"].Value);

                var readyToEdit = stockList.ToList().Where(x => x.bi_location_id == selectid).FirstOrDefault();

                await GenUtil.AutoLabelAddingfromTextBox<StockLevelSubItem>(this, readyToEdit);
                StockLevelViewObj edititems = stock.ToList().Where(x => x.bi_item_id == itemId).FirstOrDefault();
                await GenUtil.AutoLabelAddingfromTextBox<StockLevelViewObj>(this, edititems);
                //txtvid.Text = readyToEdit.bi_item_vid.ToString();
                //txtid.Text = readyToEdit.bi_item_id.ToString();
                //txtcat.Text = readyToEdit.vc_category_desc.ToString();
                //txtloc.Text = readyToEdit.vc_location_desc.ToString();
                //txtuom.Text = readyToEdit.vc_uom_desc.ToString();
                //txtupdate.Text = readyToEdit.dt_updated_datetime.ToString();
                //txtname.Text = readyToEdit.vc_item_desc.ToString();
                //txtqty.Text = readyToEdit.i_item_qty.ToString();
            }
        }

        private async void btnmod_Click(object sender, EventArgs e)
        {
            //var reit = stock.ToList().ElementAt(dataGridViewitem.CurrentRow.Index);
            int selectdId = GenUtil.ConvertObjtoType<int>(dataGridViewitem.CurrentRow.Cells["bi_item_id"].Value);
            StockLevelSubItem readyToEdit = stockList.Where(x => x.bi_item_id == selectdId).FirstOrDefault();
            if (txtqty.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter qty");
                return;
            }

            string confirmStr = await GenUtil.ConfirmListAttach(this);
            if (confirmStr != string.Empty)
            {
                DialogResult response = MessageBox.Show(confirmStr, "Confirm", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes ? true : false)
                {
                    var updateObj = new updateObj();
                    updateObj.table = "tb_item_unit";
                    updateObj.updater.Add(nameof(readyToEdit.i_item_qty), txtqty.Text.ToString());
                    updateObj.selecter.Add(nameof(readyToEdit.bi_item_id), readyToEdit.bi_item_id.ToString());
                    updateObj.selecter.Add(nameof(readyToEdit.bi_location_id), readyToEdit.bi_location_id.ToString());
                    var res = await _dbServices.UpdateAsync(updateObj);
                    if (res.resCode != 1)
                    {
                        MessageBox.Show("error");
                        return;
                    }
                    MessageBox.Show("Item updated");
                    this.Controls.OfType<KryptonTextBox>().ToList().ForEach(x => x.Clear());
                    this.Controls.OfType<KryptonComboBox>().ToList().ForEach(x => x.SelectedItem = 0);
                    await RefreshItemEditTable();
                }
            }
            else
            {
                MessageBox.Show("confirmStr is null");
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async Task RefreshItemEditTable()
        {
            StockLevelViewObj viewObj = new StockLevelViewObj();
            stock = await _genericTableViewWorker.GetGenericWorker<StockLevelViewObj, StockLevelSubItem>(viewObj.sql, nameof(viewObj.bi_item_id));

            //stock = await _worker.GetStockLevelWorker();
            await itemEditInitialLoad();
        }

    }
}
