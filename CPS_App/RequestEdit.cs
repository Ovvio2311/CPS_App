using CPS_App.Services;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
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
    public partial class RequestEdit : Form
    {
        public int index;
        public List<RequestMappingReqObj> defPage;
        private readonly DbServices _dbServices;
        public RequestEdit(int index, List<RequestMappingReqObj> defPage, DbServices dbServices)
        {
            InitializeComponent();
            this.index = index;
            this.defPage = defPage;
            _dbServices = dbServices;
        }

        private void RequestEdit_Load(object sender, EventArgs e)
        {
            if (defPage == null)
            {
                MessageBox.Show("error");
                return;
            }
            var edititems = defPage.ToList().ElementAt(index);
            txtreqid.Text = edititems.bi_req_id.ToString();
            txtstaid.Text = edititems.i_staff_id.ToString();
            txtloc.Text = edititems.vc_location_desc.ToString();
            txtcrDate.Text = edititems.dt_created_date.ToString();
            datagridviewitem.DataSource = edititems.item;
            //change header name and hide column
            datagridviewitem.Columns.ToDynamicList().ForEach(col =>
            {
                DataGridViewColumn column = col;
                col.HeaderText = typeof(ItemRequest).GetProperties().ToList()
                .Where(x => col.HeaderText == x.Name)
                .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                if (column.HeaderText == "Item Id" || column.HeaderText == "i_uom_id" ||
                column.HeaderText == "bi_category_id")
                {
                    column.Visible = false;
                }

            });

        }
        private void datagridviewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == datagridviewitem.CurrentRow.Index)
            {
                var readyToEdit = defPage.ToList().ElementAt(index).item.ElementAt(e.RowIndex);
                txtvid.Text = readyToEdit.bi_item_vid.ToString();
                txtrs.Text = readyToEdit.item_req_status.ToString();
                txtremain.Text = readyToEdit.i_remain_req_qty.ToString();
                txtqty.Text = readyToEdit.i_item_req_qty.ToString();
                dateTimePickerEDD.Value =  DateTime.Now ; // for testing only
                txtitname.Text = readyToEdit.vc_item_desc.ToString();
                txtcat.Text = readyToEdit.vc_category_desc.ToString();
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            //del item button
        }

        private async void btnchange_Click(object sender, EventArgs e)
        {
            var readyToEdit = defPage.ToList().ElementAt(index).item.ElementAt(datagridviewitem.CurrentRow.Index);
            if (txtremain.Text == readyToEdit.i_remain_req_qty.ToString() && dateTimePickerEDD.Value == readyToEdit.dt_exp_deli_date)
            {
                MessageBox.Show("Remain Qty and expected delivery date haven't change");
                return;
            }
            if(int.TryParse(txtremain.Text, out var a))
            {
                var updateObj = new updateObj();
                updateObj.table = "tb_request_detail";
                updateObj.updater.Add(nameof(readyToEdit.i_remain_req_qty), txtremain.Text.ToString());
                updateObj.updater.Add(nameof(readyToEdit.dt_exp_deli_date), dateTimePickerEDD.Value.ToString("yyyy-MM-ddTHH:mm:ss"));
                updateObj.selecter.Add(nameof(readyToEdit.bi_req_id),readyToEdit.bi_req_id.ToString());
                updateObj.selecter.Add(nameof(readyToEdit.bi_item_id), readyToEdit.bi_item_id.ToString());
                var res = await _dbServices.UpdateAsync(updateObj);
                if(res.resCode!=1)
                {
                    MessageBox.Show("update error");
                }
                else
                {
                    MessageBox.Show("Update Success");
                }
            }
        }
    }
}
