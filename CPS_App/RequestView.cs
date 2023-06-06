using CPS_App.Services;
using System.ComponentModel;
using System.Data;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using static CPS_App.Models.CPSModel;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using static CPS_App.Models.DbModels;
using System.Windows.Forms;

namespace CPS_App
{
    public partial class RequestView : KryptonForm
    {
        public ClaimsIdentity userIden;
        private RequestMapping _requestMapp;
        public List<RequestMappingReqObj> defPage;
        private readonly DbServices _dbServices;
        private SearchFunc _searchFunc;
        private Dictionary<string, string> searchWords;
        public RequestView(DbServices dbServices, RequestMapping mapping, SearchFunc searchFunc)
        {
            InitializeComponent();
            defPage = new List<RequestMappingReqObj>();
            _dbServices = dbServices;
            _requestMapp = mapping;
            _searchFunc = searchFunc;
            searchWords = new Dictionary<string, string>();
        }

        private async void RequestView_Load(object sender, EventArgs e)
        {
            //await _searchFunc.insertJsonString();
            userIden = AuthService._userClaim;
            if (userIden == null)
            {
                //throw new Exception("user claim is null");
            }

            
            if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "request", "update" } }))
            {
                btnAdd.Hide();
                //btnEdit.Hide();
            }
            else if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "request", "read" } }))
            {
                btnAdd.Hide();
                btnEdit.Hide();
            }
            //var userRole = userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToString();
            string userLoc = null;
            userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();

            await GetSearchWords(userIden);

            lblitem.Hide();

            await LoadViewTable(userLoc);
            //await _searchFunc.insertJsonString();
            //defPage = await _requestMapp.RequestMappingObjGetter(userLoc);

            //var observableItems = new ObservableCollection<RequestMappingReqObj>(defPage);
            //BindingList<RequestMappingReqObj> source = observableItems.ToBindingList();

            //if (defPage != null)
            //    datagridview.DataSource = source;

            //GenUtil.dataGridAttrName<RequestMappingReqObj>(datagridview, new List<string>() { "not_shown" });

        }
        private async Task LoadViewTable(string loc, searchObj obj = null)
        {

            datagridview.DataSource = null;
            defPage = await _requestMapp.RequestMappingObjGetter(loc, obj);
            if (defPage == null)
            {
                datagridview.Columns.Clear();
                lblnoresult.Show();
                return;
            }
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

            RequestEdit reqEdit = new RequestEdit(selectdId, defPage, _dbServices,_requestMapp);
            reqEdit.MdiParent = this.MdiParent;
            reqEdit.AutoScroll= true;
            this.Close();
            reqEdit.Show();
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            RequestCreate requestCreate = new RequestCreate(_dbServices);
            requestCreate.MdiParent = this.MdiParent;
            requestCreate.AutoScroll= true;
            this.Close();
            requestCreate.Show();
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnsearch_Click(object sender, EventArgs e)
        {
            if (cbxsearch1.SelectedItem == cbxsearch2.SelectedItem && txtsearch1.Text != "" && txtsearch2.Text != "")
            {
                MessageBox.Show("Duplicate Search criteria");
                return;
            }
            lblnoresult.Hide();
            lblitem.Hide();
            datagridviewitem.DataSource = null;
            string userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();


            //var search1key = searchWords.FirstOrDefault(x => x.Key == cbxsearch1.SelectedItem.ToString()).Value;
            var search2key = searchWords.FirstOrDefault(x => x.Key == cbxsearch2.SelectedItem.ToString()).Value;
            if (txtsearch1.Text == string.Empty && txtsearch2.Text == string.Empty)
            {
                await LoadViewTable(userLoc);
                return;
            }
            var obj = new searchObj();

            foreach (KryptonPanel c in Controls.OfType<KryptonPanel>())
            {
                c.Controls.OfType<KryptonTextBox>().ToList().ForEach(x =>
                {
                    if (x.Text != string.Empty)
                    {
                        c.Controls.OfType<KryptonComboBox>().ToList().ForEach(p =>
                        {
                            var searchkey = searchWords.FirstOrDefault(x => x.Key == p.SelectedItem.ToString()).Value;
                            obj.searchWords.Add(searchkey, x.Text);
                        });
                    }
                });
            }

            await LoadViewTable(userLoc, obj);

        }
        private async Task GetSearchWords(ClaimsIdentity identity)
        {

            IEnumerable<tb_search_gen> searchString = await _searchFunc.SearchParaGenerator(identity);
            if (searchString == null)
            {
                return;
            }
            Dictionary<string, string> words = JsonConvert.DeserializeObject<Dictionary<string, string>>(searchString.ElementAt(0).js_search_para);
            //words.ForEach(x =>
            //{
            //    cbxsearch1.Items.Add(x);
            //    cbxsearch2.Items.Add(x);
            //});
            searchWords = words;
            cbxsearch1.DataSource = words.Keys.ToList();
            cbxsearch2.DataSource = words.Keys.ToList();
        }

    }
}
