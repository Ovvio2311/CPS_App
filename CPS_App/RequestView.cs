using CPS_App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;

namespace CPS_App
{
    public partial class RequestView : Form
    {
        public ClaimsIdentity userIden;
        private RequestMapping _requestMapp;
        public List<RequestMappingReqObj> defPage;
        public AuthService _authService;
        private readonly DbServices _dbServices;
        public RequestView(AuthService authService, DbServices dbServices, RequestMapping mapping)
        {
            InitializeComponent();
            _authService = authService;
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


            }
            defPage = await _requestMapp.RequestMappingObjGetter();
            if (defPage != null)
                datagridview.DataSource = defPage;
        }
        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == datagridview.CurrentRow.Index)
            {
                //itemgridview.DataSource = null;
                datagridviewitem.DataSource = defPage.ElementAt(datagridview.CurrentRow.Index).item;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            RequestEdit reqEdit = new RequestEdit(datagridview.CurrentRow.Index, defPage);
            //reqEdit.MdiParent = this;
            reqEdit.Show();
        }

        private void txtfield_KeyPress(object sender, KeyPressEventArgs e)
        {
            //search function
        }
    }
}
