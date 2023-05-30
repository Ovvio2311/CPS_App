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
        private StockLevelWorker _stockWorker;
        private RegisterServices _registerServices;
        private POAWorker _pOAWorker;

        public Dashboard(Register register, AuthService authService, RequestMapping requestMapp, DbServices dbServices, StockLevelWorker stockWorker, RegisterServices registerServices, POAWorker pOAWorker)
        {
            _authService = authService;
            _register = register;
            InitializeComponent();
            _requestMapp = requestMapp;
            defPage = new List<RequestMappingReqObj>();
            _dbServices = dbServices;
            _stockWorker = stockWorker;
            _registerServices = registerServices;
            _pOAWorker = pOAWorker;
        }
        private async void Dashboard_Load(object sender, EventArgs e)
        {

            userIden = AuthService._userClaim;
            if (userIden != null)
            {

                if (userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToLower() == "admin")
                {

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


        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestCreate reqForm = new RequestCreate(_dbServices);
            reqForm.MdiParent = this;
            reqForm.Show();
        }


        private void btnpoa_Click(object sender, EventArgs e)
        {
            POAView poaView = new POAView(_dbServices, _pOAWorker);
            poaView.MdiParent = this;
            poaView.Show();
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            RequestView reqView = new RequestView(_dbServices, _requestMapp);
            reqView.MdiParent = this;
            reqView.Show();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ItemView itemView = new ItemView(_dbServices, _stockWorker);
            itemView.MdiParent = this;
            itemView.Show();
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            Maintenance main = new Maintenance(_dbServices, _registerServices);
            main.MdiParent = this;
            main.Show();
        }

        private void createReq_Click(object sender, EventArgs e)
        {
            RequestCreate requestCreate = new RequestCreate(_dbServices);
            requestCreate.MdiParent = this;
            requestCreate.Show();
        }

        private void createItem_Click(object sender, EventArgs e)
        {
            ItemCreate itemCreate = new ItemCreate(_dbServices);
            itemCreate.MdiParent = this;
            itemCreate.Show();
        }

        private void createpoa_Click(object sender, EventArgs e)
        {
            POACreate pOACreate = new POACreate(_dbServices);
            pOACreate.MdiParent = this;
            pOACreate.Show();
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
