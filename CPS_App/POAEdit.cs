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
    public partial class POAEdit : KryptonForm
    {
        public int headId;
        public List<POATableObj> poaObj;
        public BindingList<PoaItemList> itemList;
        private readonly DbServices _dbServices;
        private POAWorker _pOAWorker;
        private GenericTableViewWorker _genericTableViewWorker;
        public POAEdit(int headId, List<POATableObj> obj, DbServices dbServices, POAWorker pOAWorker, GenericTableViewWorker genericTableViewWorker)
        {
            InitializeComponent();
            this.headId = headId;
            this.poaObj = obj;
            _dbServices = dbServices;
            _pOAWorker = pOAWorker;
            _genericTableViewWorker = genericTableViewWorker;
            itemList = new BindingList<PoaItemList>();


        }

        private async void POAEdit_Load(object sender, EventArgs e)
        {
            if (poaObj.Count() == 0)
            {
                MessageBox.Show("error");
                return;
            }

            var deliscType = await _dbServices.SelectAllAsync<lut_deli_schedule_type>();
            List<lut_deli_schedule_type> sc = JsonConvert.DeserializeObject<List<lut_deli_schedule_type>>(JsonConvert.SerializeObject(deliscType.result));
            sc.ForEach(x => cbxdelisc.Items.Add($"{x.ti_deli_sched_id}: {x.vc_deli_sched_desc}"));

            var stType = await _dbServices.SelectAllAsync<lut_poa_status>();
            List<lut_poa_status> st = JsonConvert.DeserializeObject<List<lut_poa_status>>(JsonConvert.SerializeObject(stType.result));
            st.ForEach(x => cbxst.Items.Add($"{x.bi_poa_status_id}: {x.vc_poa_status_desc}"));

            var editPoaLine = poaObj.ToList().Where(x => x.bi_poa_header_id == headId).FirstOrDefault();
            var observableItems = new ObservableCollection<PoaItemList>(editPoaLine.itemLists);
            BindingList<PoaItemList> source = observableItems.ToBindingList();


            await poaEditInitialLoad();


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
        private async Task poaEditInitialLoad()
        {
            POATableObj edititems = poaObj.ToList().Where(x => x.bi_poa_header_id == headId).FirstOrDefault();
            //txtreqid.Text = edititems.bi_req_id.ToString();
            //txtstaName.Text = GenUtil.ConvertObjtoType<string>(edititems.vc_staff_name);
            //txtloc.Text = edititems.vc_location_desc.ToString();
            //txtcrDate.Text = edititems.dt_created_date.ToString();

            var observableItems = new ObservableCollection<PoaItemList>(edititems.itemLists);
            itemList = observableItems.ToBindingList();
            kryptonDataGridViewit.Columns.Clear();
            kryptonDataGridViewit.DataSource = itemList;

            //change header name and hide column
            GenUtil.dataGridAttrName<PoaItemList>(kryptonDataGridViewit, new List<string>() { "not_shown" });
        }

        private async void btnmod_Click(object sender, EventArgs e)
        {
            int selectdId = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewit.CurrentRow.Cells["bi_poa_line_id"].Value);
            POATableObj poaView = poaObj.Where(x => x.bi_poa_header_id == headId).FirstOrDefault();
            PoaItemList readyToEdit = poaView.itemLists.Where(x => x.bi_poa_line_id == selectdId).FirstOrDefault();
            //var readyToEdit = itemList.Where(x => x.bi_poa_line_id == selectId).FirstOrDefault();

            string poast = cbxst.SelectedItem.ToString();
            if (poast != null) { poast = poast.Split(":").ElementAt(0); }
            var delisc = cbxdelisc.SelectedItem.ToString();
            if (delisc != null) { delisc = delisc.Split(":").ElementAt(0); }
            
            var avaltext = this.Controls.OfType<KryptonTextBox>().ToList().Where(x => x.Enabled && x.Tag != "vc_reference" &&
            GenUtil.ConvertObjtoType<int>(x.Text.Trim()) != null && GenUtil.ConvertObjtoType<int>(x.Text.Trim()) > 0).Count();
            var avalbox = this.Controls.OfType<KryptonComboBox>().ToList().Where(x => x.Enabled && x.SelectedIndex != -1).Count();
            if (avaltext != 3 && avalbox != 2)
            {
                MessageBox.Show("Please enter correct format");
                return;
            }

            if (txtmin.Text == readyToEdit.i_min_qty.ToString() && txtp.Text == readyToEdit.i_price.ToString() &&
                txtam.Text == readyToEdit.i_amount.ToString() && txtref.Text == readyToEdit.vc_reference.ToString() &&
                cbxst.SelectedItem.ToString().Contains(poaView.bi_poa_status_id.ToString()) &&
                cbxdelisc.SelectedItem.ToString().Contains(poaView.ti_deli_sched_id.ToString()))
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
                    var updatepoa = new updateObj()
                    {
                        table = "tb_poa",
                        updater = new Dictionary<string, string>
                {
                    {nameof(poaView.bi_poa_status_id), poast}
                },
                        selecter = new Dictionary<string, string>
                {
                    {nameof(poaView.bi_poa_id),poaView.bi_poa_id.ToString() }
                }
                    };

                    var respoa = await _dbServices.UpdateAsync(updatepoa);
                    if (respoa.resCode != 1)
                    {
                        MessageBox.Show("update tb_poa error");
                        return;
                    }

                    var updatepoaheader = new updateObj()
                    {
                        table = "tb_poa_header",
                        updater = new Dictionary<string, string>
                {
                    {nameof(poaView.ti_deli_sched_id),delisc}
                },
                        selecter = new Dictionary<string, string>
                {
                    {nameof(poaView.bi_poa_id),poaView.bi_poa_id.ToString() },
                }
                    };
                    var respoaheader = await _dbServices.UpdateAsync(updatepoaheader);
                    if (respoaheader.resCode != 1)
                    {
                        MessageBox.Show("update error");
                        return;
                    }

                    //MessageBox.Show("Update Success");

                    var updateObj = new updateObj()
                    {
                        table = "tb_poa_line",
                        updater = new Dictionary<string, string>
                    {
                        {nameof(readyToEdit.vc_reference), txtref.Text.ToString() },
                        {nameof(readyToEdit.i_min_qty), txtmin.Text.ToString() },
                        {nameof(readyToEdit.i_price), txtp.Text.ToString() },
                        {nameof(readyToEdit.i_amount), txtam.Text.ToString() },
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
                        MessageBox.Show("update poa line error");
                    }
                    else
                    {
                        MessageBox.Show("Update Success");
                        this.Controls.OfType<KryptonTextBox>().ToList().ForEach(x => x.Clear());
                        this.Controls.OfType<KryptonComboBox>().ToList().ForEach(x => x.SelectedItem = 0);
                        await RefreshPOAEditTable();
                    }
                }
            }
        }

        private async Task RefreshPOAEditTable()
        {
            POATableObj viewObj = new POATableObj();
            poaObj = await _genericTableViewWorker.GetGenericWorker<POATableObj, PoaItemList>(viewObj.sql, nameof(viewObj.bi_poa_header_id));

            //poaObj = await _pOAWorker.GetPoaWorker();
            await poaEditInitialLoad();
        }

        private async void kryptonDataGridViewit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == kryptonDataGridViewit.CurrentRow.Index)
            {
                int selectdId = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewit.CurrentRow.Cells["bi_poa_line_id"].Value);
                POATableObj poaView = poaObj.Where(x => x.bi_poa_header_id == headId).FirstOrDefault();
                PoaItemList readyToEdit = poaView.itemLists.Where(x => x.bi_poa_line_id == selectdId).FirstOrDefault();
                //var readyToEdit = itemList.Where(x => x.bi_poa_line_id == selectId).FirstOrDefault();
                await GenUtil.AutoLabelAddingfromTextBox<POATableObj>(this, poaView);
                await GenUtil.AutoLabelAddingfromTextBox<PoaItemList>(this, readyToEdit);
                //txtline.Text = readyToEdit.bi_poa_line_id.ToString();
                //txtit.Text = readyToEdit.vc_item_desc.ToString();
                //txtsupid.Text = readyToEdit.bi_supp_item_id.ToString();
                //txtpro.Text = readyToEdit.i_promise_qty.ToString();
                //txtuom.Text = readyToEdit.vc_uom_desc.ToString();
                //txtmin.Text = readyToEdit.i_min_qty.ToString();
                //txtp.Text = readyToEdit.i_price.ToString();
                //txtam.Text = readyToEdit.i_amount.ToString();
                //txtref.Text = readyToEdit.vc_reference.ToString();
                //txtqu.Text = readyToEdit.vc_quot_no.ToString();
                //txtpoa.Text = poaView.bi_poa_id.ToString();
                //txttype.Text = poaView.vc_poa_type_desc.ToString();
                //cbxst.SelectedItem = cbxst.Items.ToDynamicList<string>()
                //.Where(x => x.Contains(poaView.bi_poa_status_id.ToString())).FirstOrDefault();
                //cbxdelisc.SelectedItem = cbxdelisc.Items.ToDynamicList<string>()
                //.Where(x => x.Contains(poaView.ti_deli_sched_id.ToString())).FirstOrDefault();

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
