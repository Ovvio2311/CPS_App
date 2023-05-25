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
using CPS_App.Services;
using Krypton.Toolkit;
using ScintillaNET;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class POAEdit : KryptonForm
    {
        public int index;
        public List<POATableObj> obj;
        private readonly DbServices _dbServices;
        public POAEdit(int index, List<POATableObj> obj, DbServices dbServices)
        {
            InitializeComponent();
            this.index = index;
            this.obj = obj;
            _dbServices = dbServices;
        }

        private void POAEdit_Load(object sender, EventArgs e)
        {
            if (obj.Count() == 0)
            {
                MessageBox.Show("error");
                return;
            }
            var editPoaLine = obj.ToList().ElementAt(index);
            kryptonDataGridViewit.DataSource = editPoaLine.itemLists;

            kryptonDataGridViewit.Columns.ToDynamicList().ForEach(col =>
            {
                DataGridViewColumn column = col;
                col.HeaderText = typeof(PoaItemList).GetProperties().ToList()
                .Where(x => col.HeaderText == x.Name)
                .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                if (column.HeaderText == "Item Id" || column.HeaderText == "i_uom_id")
                {
                    column.Visible = false;
                }

            });
        }


        private async void btnmod_Click(object sender, EventArgs e)
        {
            var readyToEdit = obj.ToList().ElementAt(index).itemLists.ElementAt(kryptonDataGridViewit.CurrentRow.Index);
            if (txtpro.Text == readyToEdit.dc_promise_qty.ToString() &&
                txtmin.Text == readyToEdit.dc_min_qty.ToString() && txtp.Text == readyToEdit.dc_price.ToString() &&
                txtam.Text == readyToEdit.dc_amount.ToString() && txtref.Text == readyToEdit.vc_reference.ToString())
            {
                MessageBox.Show("Value haven't change");
                return;
            }

            var updateObj = new updateObj()
            {
                table = "tb_po_line",
                updater = new Dictionary<string, string>
                    {
                        {nameof(readyToEdit.dc_promise_qty), txtpro.Text.ToString() },
                        {nameof(readyToEdit.dc_min_qty), txtmin.Text.ToString() },
                        {nameof(readyToEdit.dc_price), txtp.Text.ToString() },
                        {nameof(readyToEdit.dc_amount), txtam.Text.ToString() },
                    },
                selecter = new Dictionary<string, string>
                {
                    {nameof(readyToEdit.bi_poa_line_id),readyToEdit.bi_poa_line_id.ToString() },
                    {nameof(readyToEdit.bi_poa_header_id),readyToEdit.bi_poa_header_id.ToString() },
                }
            };
           
            var res = await _dbServices.UpdateAsync(updateObj);
            if (res.resCode != 1)
            {
                MessageBox.Show("update error");
            }
            else
            {
                MessageBox.Show("Update Success");
            }

        }

        private void kryptonDataGridViewit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == kryptonDataGridViewit.CurrentRow.Index)
            {
                var readyToEdit = obj.ToList().ElementAt(index).itemLists.ElementAt(e.RowIndex);

                txtline.Text = readyToEdit.bi_poa_line_id.ToString();
                txthead.Text = readyToEdit.bi_poa_header_id.ToString();
                txtit.Text = readyToEdit.vc_item_desc.ToString();
                txtsupid.Text = readyToEdit.bi_supp_item_id.ToString();
                txtpro.Text = readyToEdit.dc_promise_qty.ToString();
                txtuom.Text = readyToEdit.vc_uom_desc.ToString();
                txtmin.Text = readyToEdit.dc_min_qty.ToString();
                txtp.Text = readyToEdit.dc_price.ToString();
                txtam.Text = readyToEdit.dc_amount.ToString();
                txtref.Text = readyToEdit.vc_reference.ToString();
                txtqu.Text = readyToEdit.bi_quot_no.ToString();
            }
        }
    }
}
