﻿using System.Collections.ObjectModel;
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

        private async void POAEdit_Load(object sender, EventArgs e)
        {
            if (obj.Count() == 0)
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

            var editPoaLine = obj.ToList().Where(x => x.bi_poa_header_id == index).FirstOrDefault();
            var observableItems = new ObservableCollection<PoaItemList>(editPoaLine.itemLists);
            BindingList<PoaItemList> source = observableItems.ToBindingList();


            kryptonDataGridViewit.DataSource = source;

            GenUtil.dataGridAttrName<PoaItemList>(kryptonDataGridViewit, new List<string>() { "not_shown" });
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


        private async void btnmod_Click(object sender, EventArgs e)
        {
            int selectdId = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewit.CurrentRow.Cells["bi_poa_line_id"].Value);
            var poaItem = obj.Where(x => x.bi_poa_header_id == index).FirstOrDefault();
            var readyToEdit = obj.FirstOrDefault(x => x.bi_poa_header_id == index).itemLists
                .Where(x => x.bi_poa_line_id == selectdId).FirstOrDefault();

            var poast = cbxst.SelectedItem.ToString();
            if (poast != null) { poast = poast.Split(":").ElementAt(0); }
            var delisc = cbxdelisc.SelectedItem.ToString();
            if (delisc != null) { delisc = delisc.Split(":").ElementAt(0); }

            if (txtpro.Text == readyToEdit.dc_promise_qty.ToString() &&
                txtmin.Text == readyToEdit.dc_min_qty.ToString() && txtp.Text == readyToEdit.dc_price.ToString() &&
                txtam.Text == readyToEdit.dc_amount.ToString() && txtref.Text == readyToEdit.vc_reference.ToString() &&
                cbxst.SelectedItem.ToString().Contains(poaItem.bi_poa_status_id.ToString()) && 
                cbxdelisc.SelectedItem.ToString().Contains(poaItem.ti_deli_sched_id.ToString()))
            {
                MessageBox.Show("Value haven't change");
                return;
            }
            
            var updatepoa = new updateObj()
            {
                table = "tb_poa",
                updater = new Dictionary<string, string>
                {
                    {nameof(poaItem.bi_poa_status_id), poast}
                },
                selecter = new Dictionary<string, string>
                {
                    {nameof(poaItem.bi_poa_id),poaItem.bi_poa_id.ToString() }
                }
            };

            var respoa = await _dbServices.UpdateAsync(updatepoa);
            if (respoa.resCode != 1)
            {
                MessageBox.Show("update error");
                return;
            }

            var updatepoaheader = new updateObj()
            {
                table = "tb_poa_header",
                updater = new Dictionary<string, string>
                {
                    {nameof(poaItem.ti_deli_sched_id),delisc}
                },
                selecter = new Dictionary<string, string>
                {
                    {nameof(poaItem.bi_poa_id),poaItem.bi_poa_id.ToString() },

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
                int selectdId = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewit.CurrentRow.Cells["bi_poa_line_id"].Value);
                var poaItem = obj.Where(x => x.bi_poa_header_id == index).FirstOrDefault();
                var readyToEdit = obj.FirstOrDefault(x => x.bi_poa_header_id == index).itemLists
                    .Where(x => x.bi_poa_line_id == selectdId).FirstOrDefault();

                txtline.Text = readyToEdit.bi_poa_line_id.ToString();
                txtit.Text = readyToEdit.vc_item_desc.ToString();
                txtsupid.Text = readyToEdit.bi_supp_item_id.ToString();
                txtpro.Text = readyToEdit.dc_promise_qty.ToString();
                txtuom.Text = readyToEdit.vc_uom_desc.ToString();
                txtmin.Text = readyToEdit.dc_min_qty.ToString();
                txtp.Text = readyToEdit.dc_price.ToString();
                txtam.Text = readyToEdit.dc_amount.ToString();
                txtref.Text = readyToEdit.vc_reference.ToString();
                txtqu.Text = readyToEdit.bi_quot_no.ToString();
                txtpoa.Text = poaItem.bi_poa_id.ToString();
                txttype.Text = poaItem.vc_poa_type_desc.ToString();                
                cbxst.SelectedItem = cbxst.Items.ToDynamicList<string>()
                .Where(x => x.Contains(poaItem.bi_poa_status_id.ToString())).FirstOrDefault();
                cbxdelisc.SelectedItem = cbxdelisc.Items.ToDynamicList<string>()
                .Where(x => x.Contains(poaItem.ti_deli_sched_id.ToString())).FirstOrDefault();

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
