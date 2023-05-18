using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace CPS_App
{
    public partial class RequestEdit : Form
    {
        public int index;
        public List<RequestMappingReqObj> defPage;
        public RequestEdit(int index, List<RequestMappingReqObj> defPage)
        {
            InitializeComponent();
            this.index = index;
            this.defPage = defPage;
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
                txtEDD.Text = readyToEdit.dt_exp_deli_date.ToString();
                txtitname.Text = readyToEdit.vc_item_desc.ToString();
                txtcat.Text = readyToEdit.vc_category_desc.ToString();
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            //del item button
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            //modify item button
        }
    }
}
