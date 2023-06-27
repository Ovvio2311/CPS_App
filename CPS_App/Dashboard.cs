using CPS_App.Services;
using Microsoft.AspNetCore.Server.IIS.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Security.Claims;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using Krypton.Toolkit;
using Microsoft.Extensions.Configuration;

namespace CPS_App
{
    public partial class Dashboard : KryptonForm
    {

        public Register _register;
        private RequestMapping _requestMapp;
        public List<RequestMappingReqObj> defPage;
        public AuthService _authService;
        public ClaimsIdentity userIden;
        private readonly DbServices _dbServices;
        private StockLevelWorker _stockWorker;
        private RegisterServices _registerServices;
        private POAWorker _pOAWorker;
        private SearchFunc _searchFunc;
        private IConfiguration _configuration;
        private ScheduleTask _scheduleTask;
        private GenericTableViewWorker _genericTableViewWorker;
        private CreatePoServices _createPoServices;
        private ManualMappingProcess _manualMappingProcess;

        public Dashboard(Register register, AuthService authService,
            RequestMapping requestMapp, DbServices dbServices,
            StockLevelWorker stockWorker, RegisterServices registerServices,
            POAWorker pOAWorker, SearchFunc searchFunc, IConfiguration configuration,
            ScheduleTask scheduleTask, GenericTableViewWorker genericTableViewWorker, CreatePoServices createPoServices, ManualMappingProcess manualMappingProcess)
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
            _searchFunc = searchFunc;
            _configuration = configuration;
            _scheduleTask = scheduleTask;
            _genericTableViewWorker = genericTableViewWorker;
            _createPoServices = createPoServices;
            _manualMappingProcess = manualMappingProcess;
        }
        private async void Dashboard_Load(object sender, EventArgs e)
        {
            RefreshDashborad();
            //userIden = AuthService._userClaim;
            //if (userIden != null)
            //{
            //    var roleName = userIden.Claims.FirstOrDefault(x => x.Type == "role").Value;
            //    var staName = userIden.Claims.FirstOrDefault(x => x.Type == "staff_name").Value;
            //    striplblwelcome.Text = $"Welcome {staName},{roleName}";
            //    if (userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToLower() == "admin")
            //    {

            //    }
            //}
            //defPage = await _requestMapp.RequestMappingObjGetter();
            //HomePage.DataSource = defPage;
        }
        public void RefreshDashborad()
        {
            userIden = AuthService._userClaim;
            if (userIden != null)
            {
                striplblwelcome.Text = string.Empty;
                var roleName = userIden.Claims.FirstOrDefault(x => x.Type == "role").Value;
                var staName = userIden.Claims.FirstOrDefault(x => x.Type == "staff_name").Value;
                striplblwelcome.Text = $"Welcome {staName},{roleName}";
                if (userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToLower() == "admin")
                {

                }
            }
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






        private void stripreq_Click(object sender, EventArgs e)
        {
            RequestView reqView = new RequestView(_dbServices, _requestMapp, _searchFunc, _genericTableViewWorker, _createPoServices, _manualMappingProcess);
            reqView.MdiParent = this;
            reqView.AutoScroll = true;
            reqView.Show();
        }

        private void stripitem_Click(object sender, EventArgs e)
        {
            ItemView itemView = new ItemView(_dbServices, _stockWorker, _searchFunc, _genericTableViewWorker);
            itemView.MdiParent = this;
            itemView.AutoScroll = true;
            itemView.Show();
        }

        private void strippoa_Click(object sender, EventArgs e)
        {
            POAView poaView = new POAView(_dbServices, _pOAWorker, _searchFunc, _genericTableViewWorker);
            poaView.MdiParent = this;
            poaView.AutoScroll = true;
            poaView.Show();
        }

        private void strippo_Click(object sender, EventArgs e)
        {
            POView poView = new POView(_dbServices, _pOAWorker, _searchFunc, _genericTableViewWorker, _createPoServices, _manualMappingProcess);
            poView.MdiParent = this;
            poView.AutoScroll = true;
            poView.Show();
        }

        private void stripset_Click(object sender, EventArgs e)
        {
            Maintenance main = new Maintenance(_dbServices, _registerServices);
            main.MdiParent = this;
            main.AutoScroll = true;
            main.Show();
        }

        private async void striplogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure want to Logout?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                userIden = null;
                this.Hide();
                Login login = new Login(_configuration, _authService, this, _scheduleTask);
                login.Show();
            }
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
