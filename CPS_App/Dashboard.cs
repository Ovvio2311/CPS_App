using CPS_App.Services;
using Microsoft.AspNetCore.Server.IIS.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Security.Claims;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;

namespace CPS_App
{
    public partial class Dashboard : Form
    {

        public Register _register;
        private RequestMapping _requestMapp;
        public List<RequestMappingReqObj> defPage;
        public AuthService _authService;
        public ClaimsIdentity userIden;
        //private int _previousIndex;
        //private bool _sortDirection;
        //private int _previousitemIndex;
        //private bool _sortitemDirection;
        private readonly DbServices _dbServices;


        public Dashboard(Register register, AuthService authService, RequestMapping requestMapp, DbServices dbServices)
        {

            _authService = authService;
            _register = register;
            InitializeComponent();
            _requestMapp = requestMapp;
            defPage = new List<RequestMappingReqObj>();
            _dbServices = dbServices;
        }
        private async void Dashboard_Load(object sender, EventArgs e)
        {
            registerToolStripMenuItem.Visible = false;
            userIden = AuthService._userClaim;
            if (userIden != null)
            {
                loginToolStripMenuItem.Visible = false;
                if (userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToLower() == "admin")
                {
                    registerToolStripMenuItem.Visible = true;
                }
            }
            //defPage = await _requestMapp.RequestMappingObjGetter();
            //HomePage.DataSource = defPage;

            
        }

        //private void HomePage_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.ColumnIndex == _previousIndex)
        //        _sortDirection ^= true; // toggle direction

        //    HomePage.DataSource = SortData(
        //        (List<RequestMappingReqObj>)HomePage.DataSource, HomePage.Columns[e.ColumnIndex].Name, _sortDirection);

        //    _previousIndex = e.ColumnIndex;
        //}
        //public List<RequestMappingReqObj> SortData(List<RequestMappingReqObj> list, string column, bool ascending)
        //{
        //    return ascending ?
        //        list.OrderBy(_ => _.GetType().GetProperty(column).GetValue(_)).ToList() :
        //        list.OrderByDescending(_ => _.GetType().GetProperty(column).GetValue(_)).ToList();
        //}
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _register.MdiParent = this;
            _register.Show();
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

      

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestCreate reqForm = new RequestCreate(_dbServices);
            reqForm.MdiParent = this;
            reqForm.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestView reqview = new RequestView(_authService, _dbServices, _requestMapp);
            reqview.MdiParent = this;
            reqview.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //private void itemgridview_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.ColumnIndex == _previousitemIndex)
        //        _sortitemDirection ^= true; // toggle direction

        //    itemgridview.DataSource = SortData(
        //        (List<RequestMappingReqObj>)HomePage.DataSource, HomePage.Columns[e.ColumnIndex].Name, _sortitemDirection);

        //    _previousitemIndex = e.ColumnIndex;
        //}
    }
}
