using CPS_App.Services;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class DNView : KryptonForm
    {
        public ClaimsIdentity userIden;
        private GenericTableViewWorker _genericTableViewWorker;
        public List<DeliveryNoteObj> dnObj;
        private readonly DbServices _dbServices;
        private int selectId;
        private string userLoc;
        private List<updateObj> _updateObjs;
        public DNView(DbServices dbServices)
        {
            InitializeComponent();
            _dbServices = dbServices;
            _updateObjs = new List<updateObj>();
        }

        
        private async void DNView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;

            if (userIden == null)
            {
                //throw new Exception("user claim is null");
            }
            userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();
            await LoadViewTable(userLoc);
        }
        private async Task LoadViewTable(string loc, searchObj obj = null)
        {

            lblnoresult.Hide();
            datagridview.DataSource = null;
            //defPage = await _requestMapp.RequestMappingObjGetter(loc, obj);
            DeliveryNoteObj viewObj = new DeliveryNoteObj();
            
            searchObj searchObj = new searchObj()
            {
                searchWords = new Dictionary<string, List<string>>
                {
                    { nameof(viewObj.bi_location_id), new List<string>(){ userLoc } }
                }
            };
            DbResObj res = await _dbServices.GetDiliveryNote(loc, searchObj);
            if (res.resCode != 1)
            {
                datagridview.Columns.Clear();
                lblnoresult.Show();
                btndn.Hide();
                btnreceive.Hide();
                return;
            }
            dnObj = res.result;
            var observableItems = new ObservableCollection<DeliveryNoteObj>(dnObj);
            BindingList<DeliveryNoteObj> source = observableItems.ToBindingList();

            if (dnObj != null)
                datagridview.DataSource = source;

            GenUtil.dataGridAttrName<DeliveryNoteObj>(datagridview, new List<string>() { "not_shown" });
        }
        private void btnreceive_Click(object sender, EventArgs e)
        {
            if (selectId == 0)
            {
                MessageBox.Show("Please select item to complete");
                return;
            }
            DeliveryNoteObj readytoConfirm = dnObj.Where(x => x.bi_dn_id == selectId).FirstOrDefault();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }  // header clicked

            if (e.RowIndex == datagridview.CurrentRow.Index)
            {

                selectId = GenUtil.ConvertObjtoType<int>(datagridview.CurrentRow.Cells["bi_dn_id"].Value);


            }
        }
        public async Task UpdateRecordAsync()
        {
            if (_updateObjs.Any())
            {
                foreach (var obj in _updateObjs)
                {
                    DbResObj res = await _dbServices.UpdateAsync(obj);
                    if (res.resCode != 1 || res.err_msg != null)
                    {
                        MessageBox.Show($"Process update Db Error: {res.err_msg}");
                    }
                }
                _updateObjs.Clear();
            }
        }
        public async Task CreateUpdateObj(DeliveryNoteObj readytoConfirm)
        {

        }
    }
}
