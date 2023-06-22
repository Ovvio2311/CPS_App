using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic.Core;
using CPS_App.Services;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class POEdit : KryptonForm
    {
        public int headId;
        public List<POTableObj> poObj;
        public BindingList<PoItemList> itemList;
        private readonly DbServices _dbServices;
        GenericTableViewWorker _genericTableViewWorker;
        //private POWorker _pOAWorker;
        public POEdit(int headId, List<POTableObj> obj, DbServices dbServices, GenericTableViewWorker genericTableViewWorker)
        {
            InitializeComponent();
            this.headId = headId;
            this.poObj = obj;
            _dbServices = dbServices;
            //_pOAWorker = pOAWorker;
            itemList = new BindingList<PoItemList>();
            _genericTableViewWorker = genericTableViewWorker;
        }

        private async void POEdit_Load(object sender, EventArgs e)
        {
            if (poObj.Count() == 0)
            {
                MessageBox.Show("error");
                return;
            }

            var deliscType = await _dbServices.SelectAllAsync<lut_deli_schedule_type>();
            List<lut_deli_schedule_type> sc = JsonConvert.DeserializeObject<List<lut_deli_schedule_type>>(JsonConvert.SerializeObject(deliscType.result));
            sc.ForEach(x => cbxdelisc.Items.Add($"{x.ti_deli_sched_id}: {x.vc_deli_sched_desc}"));

            var stType = await _dbServices.SelectAllAsync<lut_po_status>();
            List<lut_po_status> st = JsonConvert.DeserializeObject<List<lut_po_status>>(JsonConvert.SerializeObject(stType.result));
            st.ForEach(x => cbxst.Items.Add($"{x.bi_po_status_id}: {x.vc_po_status_desc}"));

            var editPoLine = poObj.ToList().Where(x => x.bi_po_header_id == headId).FirstOrDefault();
            var observableItems = new ObservableCollection<PoItemList>(editPoLine.itemLists);
            BindingList<PoItemList> source = observableItems.ToBindingList();


            await poEditInitialLoad();


            //kryptonDataGridViewit.Columns.ToDynamicList().ForEach(col =>
            //{
            //    DataGridViewColumn column = col;
            //    col.HeaderText = typeof(PoaItemList).GetProperties().ToList()
            //    .Where(x => col.HeaderText == x.Name)
            //    .Select(x => x.GetCustomAttribute<DisplayAttribute>())
            //    .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
            //    if (column.HeaderText == "Item Id" || column.HeaderText == "i_uom_id")
            //    {
            //        column.Visible = false;
            //    }

            //});
        }
        private async Task poEditInitialLoad()
        {
            POTableObj edititems = poObj.ToList().Where(x => x.bi_po_header_id == headId).FirstOrDefault();
            //txtreqid.Text = edititems.bi_req_id.ToString();
            //txtstaName.Text = GenUtil.ConvertObjtoType<string>(edititems.vc_staff_name);
            //txtloc.Text = edititems.vc_location_desc.ToString();
            //txtcrDate.Text = edititems.dt_created_date.ToString();

            var observableItems = new ObservableCollection<PoItemList>(edititems.itemLists);
            itemList = observableItems.ToBindingList();
            kryptonDataGridViewit.Columns.Clear();
            kryptonDataGridViewit.DataSource = itemList;

            //change header name and hide column
            GenUtil.dataGridAttrName<PoItemList>(kryptonDataGridViewit, new List<string>() { "not_shown" });
        }

        private async void btnmod_Click(object sender, EventArgs e)
        {
            int selectdId = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewit.CurrentRow.Cells["bi_po_line_id"].Value);
            POTableObj poView = poObj.Where(x => x.bi_po_header_id == headId).FirstOrDefault();
            PoItemList readyToEdit = poView.itemLists.Where(x => x.bi_po_line_id == selectdId).FirstOrDefault();
            //var readyToEdit = itemList.Where(x => x.bi_po_line_id == selectdId).FirstOrDefault();

            string post = cbxst.SelectedItem.ToString();
            if (post != null) { post = post.Split(":").ElementAt(0); }
            var delisc = cbxdelisc.SelectedItem.ToString();
            if (delisc != null) { delisc = delisc.Split(":").ElementAt(0); }

            if (txtp.Text == readyToEdit.dc_price.ToString() &&
                txtam.Text == readyToEdit.dc_actual_amount.ToString() && txtref.Text == readyToEdit.vc_reference.ToString() &&
                cbxst.SelectedItem.ToString().Contains(poView.bi_po_status_id.ToString()) &&
                cbxdelisc.SelectedItem.ToString().Contains(poView.ti_deli_sched_id.ToString()))
            {
                MessageBox.Show("Value haven't change");
                return;
            }
            string confirmStr = await GenUtil.ConfirmListAttach(this);
            if (confirmStr != string.Empty)
            {
                DialogResult response = MessageBox.Show(confirmStr, "Confirm", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes ? true : false)
                {
                    var updatepo = new updateObj()
                    {
                        table = "tb_po",
                        updater = new Dictionary<string, string>
                {
                    {nameof(poView.bi_po_status_id), post}
                },
                        selecter = new Dictionary<string, string>
                {
                    {nameof(poView.bi_po_id),poView.bi_po_id.ToString() }
                }
                    };

                    var respo = await _dbServices.UpdateAsync(updatepo);
                    if (respo.resCode != 1)
                    {
                        MessageBox.Show("update tb_po error");
                        return;
                    }

                    var updatepoheader = new updateObj()
                    {
                        table = "tb_po_header",
                        updater = new Dictionary<string, string>
                {
                    {nameof(poView.ti_deli_sched_id),delisc}
                },
                        selecter = new Dictionary<string, string>
                {
                    {nameof(poView.bi_po_id),poView.bi_po_id.ToString() },
                }
                    };
                    var respoheader = await _dbServices.UpdateAsync(updatepoheader);
                    if (respoheader.resCode != 1)
                    {
                        MessageBox.Show("update error");
                        return;
                    }

                    //MessageBox.Show("Update Success");

                    var updateObj = new updateObj()
                    {
                        table = "tb_po_line",
                        updater = new Dictionary<string, string>
                    {
                        {nameof(readyToEdit.vc_reference), txtref.Text.ToString() },                        
                        {nameof(readyToEdit.dc_price), txtp.Text.ToString() },
                        {nameof(readyToEdit.dc_actual_amount), txtam.Text.ToString() },
                    },
                        selecter = new Dictionary<string, string>
                {
                    {nameof(readyToEdit.bi_po_line_id),readyToEdit.bi_po_line_id.ToString() },
                    {nameof(readyToEdit.bi_po_header_id),readyToEdit.bi_po_header_id.ToString() },
                }
                    };

                    var res = await _dbServices.UpdateAsync(updateObj);
                    if (res.resCode != 1)
                    {
                        MessageBox.Show("update po line error");
                    }
                    else
                    {
                        MessageBox.Show("Update Success");
                        this.Controls.OfType<KryptonTextBox>().ToList().ForEach(x => x.Clear());
                        this.Controls.OfType<KryptonComboBox>().ToList().ForEach(x => x.SelectedItem = 0);
                        await RefreshPOEditTable();
                    }
                }
            }
        }

        private async Task RefreshPOEditTable()
        {
            POTableObj viewObj = new POTableObj();
            
            poObj = await _genericTableViewWorker.GetGenericWorker<POTableObj, PoItemList>(viewObj.GetSqlQuery(), nameof(viewObj.bi_po_header_id));

            //poObj = await _pOAWorker.GetPoaWorker();
            await poEditInitialLoad();
        }

        private async void kryptonDataGridViewit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == kryptonDataGridViewit.CurrentRow.Index)
            {
                int selectdId = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewit.CurrentRow.Cells["bi_po_line_id"].Value);
                POTableObj poView = poObj.Where(x => x.bi_po_header_id == headId).FirstOrDefault();
                PoItemList readyToEdit = poView.itemLists.Where(x => x.bi_po_line_id == selectdId).FirstOrDefault();
                //var readyToEdit = itemList.Where(x => x.bi_po_line_id == selectdId).FirstOrDefault();
                await GenUtil.AutoLabelAddingfromTextBox<POTableObj>(this, poView);
                await GenUtil.AutoLabelAddingfromTextBox<PoItemList>(this, readyToEdit);
                //txtline.Text = readyToEdit.bi_po_line_id.ToString();
                //txtit.Text = readyToEdit.vc_item_desc.ToString();
                //txtsupid.Text = readyToEdit.bi_supp_item_id.ToString();
                //txtpro.Text = readyToEdit.dc_promise_qty.ToString();
                //txtuom.Text = readyToEdit.vc_uom_desc.ToString();
                //txtmin.Text = readyToEdit.dc_min_qty.ToString();
                //txtp.Text = readyToEdit.dc_price.ToString();
                //txtam.Text = readyToEdit.dc_amount.ToString();
                //txtref.Text = readyToEdit.vc_reference.ToString();
                //txtqu.Text = readyToEdit.bi_quot_no.ToString();
                //txtpo.Text = poView.bi_po_id.ToString();
                //txttype.Text = poView.vc_po_type_desc.ToString();
                //cbxst.SelectedItem = cbxst.Items.ToDynamicList<string>()
                //.Where(x => x.Contains(poView.bi_po_status_id.ToString())).FirstOrDefault();
                //cbxdelisc.SelectedItem = cbxdelisc.Items.ToDynamicList<string>()
                //.Where(x => x.Contains(poView.ti_deli_sched_id.ToString())).FirstOrDefault();

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
