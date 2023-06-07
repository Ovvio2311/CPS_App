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
        private RequestMapping _requestMapp;
        public RequestEdit(int reqID, List<RequestMappingReqObj> defPage,
            DbServices dbServices, RequestMapping requestMapp)
        {
            InitializeComponent();
            this.reqID = reqID;
            this.defPage = defPage;
            _dbServices = dbServices;
            itemsReq = new BindingList<ItemRequest>();
            _requestMapp = requestMapp;
        }

        private async void RequestEdit_Load(object sender, EventArgs e)
        {
            if (defPage.Count() == 0)
            {
                MessageBox.Show("error");
                return;
            }
            //initial load
            await ReqEditInitialLoad();
            //RequestMappingReqObj edititems = defPage.ToList().Where(x => x.bi_req_id == reqID).FirstOrDefault();
            //txtreqid.Text = edititems.bi_req_id.ToString();
            //txtstaName.Text = GenUtil.ConvertObjtoType<string>(edititems.vc_staff_name);
            //txtloc.Text = edititems.vc_location_desc.ToString();
            //txtcrDate.Text = edititems.dt_created_date.ToString();

            //var observableItems = new ObservableCollection<ItemRequest>(edititems.item);
            //itemsReq = observableItems.ToBindingList();
            //datagridviewitem.DataSource = itemsReq;

            //change header name and hide column
            //GenUtil.dataGridAttrName<ItemRequest>(datagridviewitem, new List<string>() { "not_shown" });
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
        private async Task ReqEditInitialLoad()
        {
            RequestMappingReqObj edititems = defPage.ToList().Where(x => x.bi_req_id == reqID).FirstOrDefault();
            txtreqid.Text = edititems.bi_req_id.ToString();
            txtstaName.Text = GenUtil.ConvertObjtoType<string>(edititems.vc_staff_name);
            txtloc.Text = edititems.vc_location_desc.ToString();
            txtcrDate.Text = edititems.dt_created_date.ToString();

            var observableItems = new ObservableCollection<ItemRequest>(edititems.item);
            itemsReq = observableItems.ToBindingList();
            datagridviewitem.Columns.Clear();
            datagridviewitem.DataSource = itemsReq;

            //change header name and hide column
            GenUtil.dataGridAttrName<ItemRequest>(datagridviewitem, new List<string>() { "not_shown" });
        }
        private async void datagridviewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == datagridviewitem.CurrentRow.Index)
            {
                int selectdId = GenUtil.ConvertObjtoType<int>(datagridviewitem.CurrentRow.Cells["bi_item_id"].Value);
                ItemRequest readyToEdit = itemsReq.Where(x => x.bi_item_id == selectdId).FirstOrDefault();
                await GenUtil.AutoLabelAdding<ItemRequest>(this, readyToEdit);
                //txtvid.Text = readyToEdit.bi_item_vid.ToString();
                //txtrs.Text = GenUtil.ConvertObjtoType<string>(readyToEdit.vc_po_status_desc);
                //txtremain.Text = readyToEdit.i_remain_req_qty.ToString();
                //txtqty.Text = readyToEdit.i_item_req_qty.ToString();
                dateTimePickerEDD.Value = readyToEdit.dt_exp_deli_date; // for testing only
                //txtitname.Text = GenUtil.ConvertObjtoType<string>(readyToEdit.vc_item_desc);
                //txtcat.Text = readyToEdit.vc_category_desc.ToString();
                //txtreqst.Text = GenUtil.ConvertObjtoType<string>(readyToEdit.item_mapping_status);
            }
        }
    
        private void btndel_Click(object sender, EventArgs e)
        {
            //del item button
        }

        private async void btnchange_Click(object sender, EventArgs e)
        {
            int selectdId = GenUtil.ConvertObjtoType<int>(datagridviewitem.CurrentRow.Cells["bi_item_id"].Value);
            ItemRequest readyToEdit = itemsReq.Where(x => x.bi_item_id == selectdId).FirstOrDefault();
            if (txtremain.Text == readyToEdit.i_remain_req_qty.ToString() && dateTimePickerEDD.Value == readyToEdit.dt_exp_deli_date)
            {
                MessageBox.Show("Value haven't change");
                return;
            }
            if (!int.TryParse(txtremain.Text, out var a))
            {
                MessageBox.Show("Remain Quantity input type is not correct");
                return;
            }
            if (GenUtil.ConvertObjtoType<int>(txtremain.Text) > readyToEdit.i_item_req_qty)
            {
                MessageBox.Show("Remain Quantity cannot larger than Request Quantity");
                return;
            }
            if (await GenUtil.ConfirmListAttach(this))
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
                    this.Controls.OfType<KryptonTextBox>().ToList().ForEach(x => x.Clear());
                    await RefreshItemEditTable();
                }
            }

        }
        //private async Task<bool> ConfirmListAttach()
        //{
        //    var confirmObj = new Dictionary<string, string>();
        //    this.Controls.OfType<KryptonTextBox>().ToList().ForEach(x =>
        //    {
        //        if (x.ReadOnly == false)
        //        {
        //            this.Controls.OfType<KryptonLabel>().ToList().ForEach(p =>
        //            {
        //                if (p.Tag != null && p.Tag.ToString() == x.Tag.ToString())
        //                {
        //                    confirmObj.Add(p.Text, x.Text);
        //                }
        //            });
        //        }
        //    });
        //    string confirmStr = string.Join(Environment.NewLine, confirmObj.Select(x => $"{x.Key} = {x.Value}").ToList());

        //    DialogResult response = MessageBox.Show(confirmStr, "Confirm", MessageBoxButtons.YesNo);
        //    return response == DialogResult.Yes ? true : false;
        //}
        private async Task RefreshItemEditTable()
        {
            defPage = await _requestMapp.RequestMappingObjGetter();
            await ReqEditInitialLoad();
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
