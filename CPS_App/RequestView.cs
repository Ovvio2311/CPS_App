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
using Newtonsoft.Json;

namespace CPS_App
{
    public partial class RequestView : KryptonForm
    {
        public ClaimsIdentity userIden;
        private RequestMapping _requestMapp;
        public List<RequestMappingReqObj> defPage;
        private readonly DbServices _dbServices;
        private SearchFunc _searchFunc;
        public RequestView(DbServices dbServices, RequestMapping mapping, SearchFunc searchFunc)
        {
            InitializeComponent();
            defPage = new List<RequestMappingReqObj>();
            _dbServices = dbServices;
            _requestMapp = mapping;
            _searchFunc = searchFunc;
        }

        private async void RequestView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden == null)
            {
                //throw new Exception("user claim is null");
            }
            if (!await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "request", "write" } }))
            {
                btnAdd.Hide();
            }
            if (!await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "request", "update" } }))
            {
                btnEdit.Hide();
            }
            //var userRole = userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToString();
            string userLoc = null;
            userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();


            lblitem.Hide();
            defPage = await _requestMapp.RequestMappingObjGetter(userLoc);

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

        private async void btnsearch_Click(object sender, EventArgs e)
        {
            if (userIden.Claims.Any())
            {
                var obj = new Dictionary<string, string>();
                userIden.Claims.Where(x => x.Type == "role_id").ToList().ForEach(x =>
                {
                    obj = new Dictionary<string, string>
                   {
                        {x.Type,x.Value }
                   };
                });
                //var searchWords =  await _searchFunc.SearchParaGenerator(obj);
                var searchWords = JsonConvert.DeserializeObject<List<string>>(await _searchFunc.SearchParaGenerator(obj));
            }
        }
        private async Task GetSearchWords()
        {
            await _searchFunc.SearchParaGenerator(userIden);
        }
    }
}
