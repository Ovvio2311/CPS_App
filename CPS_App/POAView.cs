using CPS_App.Services;
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
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;

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
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }
    }
}
