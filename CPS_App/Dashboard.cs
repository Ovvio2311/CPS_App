using CPS_App.Services;
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
        //private AccountServices _accountServices { get; set; }
        //private AuthService _authService { get; set; }
        //private readonly Db _db;
        //private IConfiguration _configuration;
        //public Dashboard(AccountServices accountServices, AuthService authService, Db db, IConfiguration configuration)
        //{
        //    InitializeComponent();
        //    _accountServices = accountServices;
        //    _authService = authService;
        //    _db = db;
        //    _configuration = configuration;
        //}

        public Register _register { get; set; }
        private RequestMapping _requestMapp;
        public List<RequestMappingReqObj> defPage;
        public AuthService _authService { get; set; }
        public ClaimsIdentity userIden;
        private int _previousIndex;
        private bool _sortDirection;
        private int _previousitemIndex;
        private bool _sortitemDirection;


        public Dashboard(Register register, AuthService authService, RequestMapping requestMapp)
        {

            _authService = authService;
            _register = register;
            InitializeComponent();
            _requestMapp = requestMapp;
            defPage = new List<RequestMappingReqObj>();
        }
        private async void Dashboard_Load(object sender, EventArgs e)
        {
            registerToolStripMenuItem.Visible = false;
            userIden = _authService._userClaim;
            if (userIden != null)
            {
                loginToolStripMenuItem.Visible = false;
                if (userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToLower() == "admin")
                {
                    registerToolStripMenuItem.Visible = true;
                }
            }
            defPage = await _requestMapp.RequestMappingObjGetter();
            HomePage.DataSource = defPage;

            
           
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

        private void HomePage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //foreach (DataGridViewRow row in HomePage.SelectedRows)
            //{
            //    MessageBox.Show(row.Cells[7].Value.ToString());
            //}
        }

        private void HomePage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == HomePage.CurrentRow.Index)
            {
                //itemgridview.DataSource = null;
                itemgridview.DataSource = defPage.ElementAt(HomePage.CurrentRow.Index).item;
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
