using CPS_App.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            if (userIden == null)
            {
                //throw new Exception("user claim is null");                
            }
            if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "poa", "update" } }))
            {
                btnadd.Hide();
                btnedit.Hide();
            }
            else if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "poa", "read" } }))
            {
                btnadd.Hide();
            }
            obj = await _pOAWorker.GetPoaWorker();
            if (obj != null)
            {
                var observableItems = new ObservableCollection<POATableObj>(obj);
                BindingList<POATableObj> source = observableItems.ToBindingList();


                kryptonDataGridViewpoa.DataSource = source;

                GenUtil.dataGridAttrName<POATableObj>(kryptonDataGridViewpoa, new List<string>() { "not_shown" });
                //kryptonDataGridViewpoa.Columns.ToDynamicList().ForEach(col =>
                //{
                //    DataGridViewColumn column = col;
                //    col.HeaderText = typeof(POATableObj).GetProperties().ToList()
                //    .Where(x => col.HeaderText == x.Name)
                //    .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                //    .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                //    if (column.HeaderText == "bi_deli_loc_id" || column.HeaderText == "bi_supp_id"
                //    || column.HeaderText == "ti_tc_id" || column.HeaderText == "ti_deli_sched_id"
                //    || column.HeaderText == "itemLists")
                //    {
                //        column.Visible = false;
                //    }

                //});
            }

            //var deliscType = await _dbServices.SelectAllAsync<lut_deli_schedule_type>();
            //List<lut_deli_schedule_type> sc = JsonConvert.DeserializeObject<List<lut_deli_schedule_type>>(JsonConvert.SerializeObject(deliscType.result));
            //sc.ForEach(x => cbxdelisc.Items.Add($"{x.ti_deli_sched_id}: {x.vc_deli_sched_desc}"));

        }

        private void kryptonDataGridViewpoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == kryptonDataGridViewpoa.CurrentRow.Index)
            {

                int selectdId = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpoa.CurrentRow.Cells["bi_poa_header_id"].Value);
                kryptonDataGridViewitem.DataSource = null;
                List<PoaItemList> itemViewSelect = obj.Where(x => x.bi_poa_header_id == selectdId).FirstOrDefault().itemLists;
                var observableItems = new ObservableCollection<PoaItemList>(itemViewSelect);
                BindingList<PoaItemList> source = observableItems.ToBindingList();
                kryptonDataGridViewitem.DataSource = source;
                GenUtil.dataGridAttrName<PoaItemList>(kryptonDataGridViewitem, new List<string>() { "not_shown" });
                //kryptonDataGridViewitem.Columns.ToDynamicList().ForEach(col =>
                //{
                //    DataGridViewColumn column = col;
                //    col.HeaderText = typeof(ItemRequest).GetProperties().ToList()
                //    .Where(x => col.HeaderText == x.Name)
                //    .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                //    .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                //    if (column.HeaderText == "i_uom_id")
                //    {
                //        column.Visible = false;
                //    }

                //});

            }
        }
        //edit POA and POA header
        private async void btnedit_Click(object sender, EventArgs e)
        {
            var currentIndex = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpoa.CurrentRow.Cells["bi_poa_header_id"].Value);
            var readyToEdit = obj.Where(x => x.bi_poa_header_id == currentIndex).ToList();
          
            POAEdit poaEdit = new POAEdit(currentIndex, readyToEdit, _dbServices);
            poaEdit.MdiParent = this.MdiParent;
            poaEdit.AutoScroll = true;
            poaEdit.Show();

            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            POACreate poaCre = new POACreate(_dbServices);
            poaCre.MdiParent = this.MdiParent;
            poaCre.AutoScroll = true;
            poaCre.Show();
        }
    }
}
