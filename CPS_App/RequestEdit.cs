using CPS_App.Services;
using Krypton.Toolkit;
using System.ComponentModel;
using System.Data;
using System.Linq.Dynamic.Core;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace CPS_App
{
    public partial class RequestEdit : KryptonForm
    {
        public int reqID;
        public List<RequestMappingReqObj> defPage;
        public BindingList<ItemRequest> itemsReq;
        private readonly DbServices _dbServices;
        public RequestEdit(int reqID, List<RequestMappingReqObj> defPage, DbServices dbServices)
        {
            InitializeComponent();
            this.reqID = reqID;
            this.defPage = defPage;
            _dbServices = dbServices;
            itemsReq = new BindingList<ItemRequest>();
        }

        private void RequestEdit_Load(object sender, EventArgs e)
        {
            if (defPage.Count() == 0)
            {
                MessageBox.Show("error");
                return;
            }
            RequestMappingReqObj edititems = defPage.ToList().Where(x => x.bi_req_id == reqID).FirstOrDefault();
            txtreqid.Text = edititems.bi_req_id.ToString();
            txtstaName.Text = GenUtil.ConvertObjtoType<string>(edititems.vc_staff_name);
            txtloc.Text = edititems.vc_location_desc.ToString();
            txtcrDate.Text = edititems.dt_created_date.ToString();

            var observableItems = new ObservableCollection<ItemRequest>(edititems.item);
            itemsReq = observableItems.ToBindingList();
            datagridviewitem.DataSource = itemsReq;

            //change header name and hide column
            GenUtil.dataGridAttrName<ItemRequest>(datagridviewitem, new List<string>() { "Item Id", "i_uom_id", "bi_category_id" });
            //datagridviewitem.Columns.ToDynamicList().ForEach(col =>
            //{
            //    DataGridViewColumn column = col;
            //    col.HeaderText = typeof(ItemRequest).GetProperties().ToList()
            //    .Where(x => col.HeaderText == x.Name)
            //    .Select(x => x.GetCustomAttribute<DisplayAttribute>())
            //    .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
            //    if (column.HeaderText == "Item Id" || column.HeaderText == "i_uom_id" ||
            //    column.HeaderText == "bi_category_id")
            //    {
            //        column.Visible = false;
            //    }

            //});

        }
        private void datagridviewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == datagridviewitem.CurrentRow.Index)
            {
                int selectdId = GenUtil.ConvertObjtoType<int>(datagridviewitem.CurrentRow.Cells["bi_item_id"].Value);
                var readyToEdit = itemsReq.Where(x => x.bi_item_id == selectdId).FirstOrDefault();
                txtvid.Text = readyToEdit.bi_item_vid.ToString();
                txtrs.Text = GenUtil.ConvertObjtoType<string>(readyToEdit.item_mapping_status);
                txtremain.Text = readyToEdit.i_remain_req_qty.ToString();
                txtqty.Text = readyToEdit.i_item_req_qty.ToString();
                dateTimePickerEDD.Value = DateTime.Now; // for testing only
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
            int selectdId = GenUtil.ConvertObjtoType<int>(datagridviewitem.CurrentRow.Cells["bi_item_id"].Value);
            var readyToEdit = itemsReq.Where(x => x.bi_item_id == selectdId).FirstOrDefault();
            if (txtremain.Text == readyToEdit.i_remain_req_qty.ToString() && dateTimePickerEDD.Value == readyToEdit.dt_exp_deli_date)
            {
                MessageBox.Show("Remain Qty and expected delivery date haven't change");
                return;
            }
            if (int.TryParse(txtremain.Text, out var a))
            {
                var updateObj = new updateObj();
                updateObj.table = "tb_request_detail";
                updateObj.updater.Add(nameof(readyToEdit.i_remain_req_qty), txtremain.Text.ToString());
                updateObj.updater.Add(nameof(readyToEdit.dt_exp_deli_date), dateTimePickerEDD.Value.ToString("yyyy-MM-ddTHH:mm:ss"));
                updateObj.selecter.Add(nameof(readyToEdit.bi_req_id), readyToEdit.bi_req_id.ToString());
                updateObj.selecter.Add(nameof(readyToEdit.bi_item_id), readyToEdit.bi_item_id.ToString());
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
        }
    }
}
