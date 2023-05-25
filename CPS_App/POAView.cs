using CPS_App.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class POAView : Krypton.Toolkit.KryptonForm
    {
        public ClaimsIdentity userIden;
        private readonly DbServices _dbServices;
        public List<POATableObj> obj;

        private POAWorker _pOAWorker;
        public POAView(DbServices dbServices, POAWorker pOAWorker)
        {
            InitializeComponent();

            _dbServices = dbServices;
            obj = new List<POATableObj>();
            _pOAWorker = pOAWorker;
        }

        private async void POAView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden != null)
            {
                var userRole = userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToString();
            }
            obj = await _pOAWorker.GetPoaWorker();
            if (obj != null)
            {
                kryptonDataGridViewpoa.DataSource = obj;
                kryptonDataGridViewpoa.Columns.ToDynamicList().ForEach(col =>
                {
                    DataGridViewColumn column = col;
                    col.HeaderText = typeof(POATableObj).GetProperties().ToList()
                    .Where(x => col.HeaderText == x.Name)
                    .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                    .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                    if (column.HeaderText == "bi_deli_loc_id" || column.HeaderText == "bi_supp_id"
                    || column.HeaderText == "ti_tc_id" || column.HeaderText == "ti_deli_sched_id"
                    || column.HeaderText == "itemLists")
                    {
                        column.Visible = false;
                    }

                });
            }

            var deliscType = await _dbServices.SelectAllAsync<lut_deli_schedule_type>();
            List<lut_deli_schedule_type> sc = JsonConvert.DeserializeObject<List<lut_deli_schedule_type>>(JsonConvert.SerializeObject(deliscType.result));
            sc.ForEach(x => cbxdelisc.Items.Add($"{x.ti_deli_sched_id}: {x.vc_deli_sched_desc}"));

        }

        private void kryptonDataGridViewpoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == kryptonDataGridViewpoa.CurrentRow.Index)
            {
                //itemgridview.DataSource = null;
                kryptonDataGridViewitem.DataSource = obj.ElementAt(kryptonDataGridViewpoa.CurrentRow.Index).itemLists;
                kryptonDataGridViewitem.Columns.ToDynamicList().ForEach(col =>
                {
                    DataGridViewColumn column = col;
                    col.HeaderText = typeof(ItemRequest).GetProperties().ToList()
                    .Where(x => col.HeaderText == x.Name)
                    .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                    .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                    if (column.HeaderText == "i_uom_id")
                    {
                        column.Visible = false;
                    }

                });
            }
            var selectedObj = obj.ElementAt(kryptonDataGridViewpoa.CurrentRow.Index);
            txttype.Text = selectedObj.ti_poa_type_id.ToString();
            txtpoa.Text = selectedObj.bi_poa_id.ToString();
            txtst.Text = selectedObj.vc_poa_status.ToString();
            txtloc.Text = selectedObj.vc_location_desc.ToString();
            txtsup.Text = selectedObj.vc_supp_desc.ToString();
            txtcur.Text = selectedObj.vc_currency.ToString();
            txtconNo.Text = selectedObj.bi_contract_no.ToString();
            txttc.Text = selectedObj.vc_tc_desc.ToString();
            cbxdelisc.SelectedItem = cbxdelisc.Items.ToDynamicList().Select(x => x.Name.Contains(selectedObj.vc_deli_sched_desc.ToString())).FirstOrDefault();
            //txtdelisc.Text = selectedObj.vc_deli_sched_desc.ToString();
            kryptonDateTimePickerec.Value = selectedObj.dt_effect_date;
        }
        //edit POA and POA header
        private async void btnedit_Click(object sender, EventArgs e)
        {
            var currentIndex = kryptonDataGridViewpoa.CurrentRow.Index;
            var readyToEdit = obj.ToList().ElementAt(currentIndex);
            if (txtst.Text == readyToEdit.vc_poa_status.ToString() && cbxdelisc.SelectedItem.ToString().Contains(readyToEdit.vc_deli_sched_desc))
            {
                MessageBox.Show("Status and delivery schedule haven't change");
                return;
            }

            var updatepoa = new updateObj()
            {
                table = "tb_poa",
                updater = new Dictionary<string, string>
                {
                    {nameof(readyToEdit.vc_poa_status), txtst.Text }
                },
                selecter = new Dictionary<string, string>
                {
                    {nameof(readyToEdit.bi_poa_id),readyToEdit.bi_poa_id.ToString() }
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
                    {nameof(readyToEdit.ti_deli_sched_id),cbxdelisc.SelectedItem.ToString().Split(":").ElementAt(0)}
                },
                selecter = new Dictionary<string, string>
                {
                    {nameof(readyToEdit.bi_poa_id),readyToEdit.bi_poa_id.ToString() },

                }
            };
            var respoaheader = await _dbServices.UpdateAsync(updatepoaheader);
            if (respoaheader.resCode != 1)
            {
                MessageBox.Show("update error");
                return;
            }
            
            MessageBox.Show("Update Success");
        }
      
    }
}
