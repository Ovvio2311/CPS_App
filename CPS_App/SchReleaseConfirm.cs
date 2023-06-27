using CPS_App.Services;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CPS_App
{
    public partial class SchReleaseConfirm : KryptonForm
    {
        public ClaimsIdentity userIden;
        private GenericTableViewWorker _genericTableViewWorker;
        private readonly DbServices _dbServices;
        private int selectId;
        private string userLoc;
        List<POTableObj> _confirmppo;
        public SchReleaseConfirm(GenericTableViewWorker genericTableViewWorker, DbServices dbServices)
        {
            InitializeComponent();
            _genericTableViewWorker = genericTableViewWorker;
            _confirmppo = new List<POTableObj>();
            _dbServices = dbServices;
        }

        private async void SchReleaseConfirm_Load(object sender, EventArgs e)
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
            POTableObj viewObj = new POTableObj();
            var kvpLoc = new Dictionary<string, string>()
            {
                {nameof(viewObj.bi_deli_loc_id),loc }
            };
            searchObj searchObj = new searchObj()
            {
                searchWords = new Dictionary<string, List<string>>
                {
                    { nameof(viewObj.ti_po_type_id), new List<string>(){"4"} },
                    {nameof(viewObj.bi_po_status_id), new List<string>(){"4"} },
                    {nameof(viewObj.bi_deli_loc_id),new List<string>(){ userLoc } },
                }
            };
            _confirmppo = await _genericTableViewWorker.GetGenericWorker<POTableObj, PoItemList>(viewObj.GetSqlQuery(), nameof(viewObj.bi_po_header_id),
                 null, searchObj);

            if (_confirmppo.Count == 0)
            {
                datagridview.Columns.Clear();
                lblnoresult.Show();
                btnconfirm.Hide();
                btnreject.Hide();
                return;
            }
            //dispatchObj = res.result;
            var observableItems = new ObservableCollection<POTableObj>(_confirmppo);
            BindingList<POTableObj> source = observableItems.ToBindingList();

            if (_confirmppo.Count > 0)
                datagridview.DataSource = source;

            GenUtil.dataGridAttrName<POTableObj>(datagridview, new List<string>() { "not_shown" });
        }
        private async void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectId == 0)
                {
                    MessageBox.Show("Please select item to Add");
                    return;
                }
                POTableObj readytoConfirm = _confirmppo.Where(x => x.bi_po_header_id == selectId).FirstOrDefault();
                await UpdatePlannedPurchase(readytoConfirm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task UpdatePlannedPurchase(POTableObj readytoConfirm)
        {
            try
            {
                foreach (var itemlist in readytoConfirm.itemLists)
                {
                    var ppoId = readytoConfirm.vc_ref_id.Split(':')[1].Trim();
                    var respo = await _dbServices.GetOriginalPoQty(ppoId);
                    if (respo.resCode != 1)
                    {
                        MessageBox.Show("update planned purchase order error");
                    }
                    List<List<KeyValuePair<string, object>>> kvp = respo.result;
                    var actQty = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "i_actual_qty").Value;
                    var actheader = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "bi_po_header_id").Value.ToString();
                    int relQty = GenUtil.ConvertObjtoType<int>(actQty) - itemlist.i_actual_qty;

                    updateObj updObj = new updateObj()
                    {
                        table = "tb_po_line",
                        updater = new Dictionary<string, string>
                            {
                                { nameof(itemlist.i_actual_qty), relQty.ToString()  }
                            },
                        selecter = new Dictionary<string, string>
                            {
                                { nameof(itemlist.bi_po_header_id), actheader },
                                { nameof(itemlist.bi_item_id), itemlist.bi_item_id.ToString() }
                            }
                    };
                    var resorin = await _dbServices.UpdateAsync(updObj);
                    if (resorin.resCode != 1 || resorin.result == null)
                    {
                        //_logger.LogDebug("insert error");
                        throw new Exception("Update Planned Purchase order error");
                    }
                  
                }
                updateObj updateReleaseStatus = new updateObj()
                {
                    table = "tb_po",
                    updater = new Dictionary<string, string>
                    {
                        { nameof(readytoConfirm.bi_po_status_id), "3" }
                    },
                    selecter = new Dictionary<string, string>
                    {
                        { nameof(readytoConfirm.bi_po_id), readytoConfirm.bi_po_id.ToString() },
                        { nameof(readytoConfirm.bi_po_status_id), "4" }
                    }
                };
                DbResObj upstatus = await _dbServices.UpdateAsync(updateReleaseStatus);
                if (upstatus.resCode != 1 || upstatus.result == null)
                {
                    //_logger.LogDebug("insert error");
                    throw new Exception("Update Planned Purchase order error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private async void btnreject_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectId == 0)
                {
                    MessageBox.Show("Please select item to Reject");
                    return;
                }
                POTableObj readytoReject = _confirmppo.Where(x => x.bi_po_header_id == selectId).FirstOrDefault();
                updateObj updateReleaseStatus = new updateObj()
                {
                    table = "tb_po",
                    updater = new Dictionary<string, string>
                    {
                        { nameof(readytoReject.bi_po_status_id), "5" }
                    },
                    selecter = new Dictionary<string, string>
                    {
                        { nameof(readytoReject.bi_po_id), readytoReject.bi_po_id.ToString() },
                        { nameof(readytoReject.bi_po_status_id), "4" }
                    }
                };
                DbResObj upstatus = await _dbServices.UpdateAsync(updateReleaseStatus);
                if (upstatus.resCode != 1 || upstatus.result == null)
                {
                    //_logger.LogDebug("insert error");
                    throw new Exception("Update Planned Purchase order error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
            
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

                selectId = GenUtil.ConvertObjtoType<int>(datagridview.CurrentRow.Cells["bi_po_header_id"].Value);
                datagridviewitem.DataSource = null;
                List<PoItemList> itemviewselect = _confirmppo.Where(x => x.bi_po_header_id == selectId).FirstOrDefault().itemLists;

                var observableItems = new ObservableCollection<PoItemList>(itemviewselect);
                BindingList<PoItemList> source = observableItems.ToBindingList();
                datagridviewitem.DataSource = source;
                GenUtil.dataGridAttrName<PoItemList>(datagridviewitem, new List<string>() { "not_shown" });


            }
        }
        
    }
}
