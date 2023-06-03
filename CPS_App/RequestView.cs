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
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace CPS_App
{
    public partial class RequestView : KryptonForm
    {
        public ClaimsIdentity userIden;
        private RequestMapping _requestMapp;
        public List<RequestMappingReqObj> defPage;
        private readonly DbServices _dbServices;
        public RequestView(DbServices dbServices, RequestMapping mapping)
        {
            InitializeComponent();
            defPage = new List<RequestMappingReqObj>();
            _dbServices = dbServices;
            _requestMapp = mapping;
        }

        private async void RequestView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden != null)
            {
                var userRole = userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToString();
                var userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();
            }

            lblitem.Hide();
            defPage = await _requestMapp.RequestMappingObjGetter();

            var observableItems = new ObservableCollection<RequestMappingReqObj>(defPage);
            BindingList<RequestMappingReqObj> source = observableItems.ToBindingList();

            if (defPage != null)
                datagridview.DataSource = source;

            GenUtil.dataGridAttrName<RequestMappingReqObj>(datagridview, new List<string>() { "not_shown" });

        }
        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }  // header clicked

            if (e.RowIndex == datagridview.CurrentRow.Index)
            {
                lblitem.Show();
                int selectdId = GenUtil.ConvertObjtoType<int>(datagridview.CurrentRow.Cells["bi_req_id"].Value);
                datagridviewitem.DataSource = null;
                List<ItemRequest> itemViewSelect = defPage.Where(x => x.bi_req_id == selectdId).FirstOrDefault().item;

                var observableItems = new ObservableCollection<ItemRequest>(itemViewSelect);
                BindingList<ItemRequest> source = observableItems.ToBindingList();
                datagridviewitem.DataSource = source;
                GenUtil.dataGridAttrName<ItemRequest>(datagridviewitem, new List<string>() { "not_shown" });

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectdId = GenUtil.ConvertObjtoType<int>(datagridview.CurrentRow.Cells["bi_req_id"].Value);

            RequestEdit reqEdit = new RequestEdit(selectdId, defPage, _dbServices);
            reqEdit.MdiParent = this.MdiParent;
            reqEdit.Show();
        }

        private void txtfield_KeyPress(object sender, KeyPressEventArgs e)
        {
            //search function
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            RequestCreate requestCreate = new RequestCreate(_dbServices);
            requestCreate.MdiParent = this.MdiParent;
            requestCreate.Show();
        }



        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
