﻿using CPS_App.Services;
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
        private int poId;
        private string userLoc;
        private List<POTableObj> _confirmppo;
        private DbGeneralServices _generalServices;
        private CreateDNServices _createDNServices;
        public SchReleaseConfirm(GenericTableViewWorker genericTableViewWorker, DbServices dbServices, DbGeneralServices dbGeneralServices, CreateDNServices createDNServices)
        {
            InitializeComponent();
            _genericTableViewWorker = genericTableViewWorker;
            _confirmppo = new List<POTableObj>();
            _dbServices = dbServices;
            _generalServices = dbGeneralServices;
            _createDNServices = createDNServices;
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
                    {"bi_ln_po_status_id", new List<string>(){"4"} },
                    {nameof(viewObj.bi_deli_loc_id),new List<string>(){ userLoc } },
                }
            };
            _confirmppo = await _genericTableViewWorker.GetGenericWorker<POTableObj, PoItemList>(viewObj.GetSqlQuery(), nameof(viewObj.bi_po_header_id),
                 null, searchObj);

            if (_confirmppo == null)
            {
                datagridview.Columns.Clear();
                datagridviewitem.Columns.Clear();
                lblitem.Hide();
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
                if (poId == 0)
                {
                    MessageBox.Show("Please select item to Confirm");
                    return;
                }
                int itemid = GenUtil.ConvertObjtoType<int>(datagridviewitem.CurrentRow.Cells["bi_item_id"].Value);
                POTableObj readytoConfirm = _confirmppo.Where(x => x.bi_po_header_id == selectId).FirstOrDefault();
                PoItemList itemtoConfirm = readytoConfirm.itemLists.Where(x => x.bi_po_line_id == poId).FirstOrDefault();
                await UpdatePlannedPurchase(readytoConfirm, poId);
                await UpdatePoLine(readytoConfirm, poId, "3");
                List<POTableObj> outstandingPo = await _generalServices.OutstandingPoObj();
                var tar = outstandingPo.Where(x => x.bi_po_header_id == selectId).FirstOrDefault();
                await UpdatePo(tar, 3);
                List<RequestMappingReqObj> outreq = await _generalServices.OutstandingReqObj();
                RequestMappingReqObj tarReq = outreq.Where(x => x.bi_req_id == readytoConfirm.bi_req_id).FirstOrDefault();
                ItemRequest tarItem = tarReq.itemLists.Where(x => x.bi_item_id == itemid).FirstOrDefault();
                await UpdateReqDetail(tarReq, tarItem);
                List<DeliveryNoteObj> listDn = await CreateDnObject(readytoConfirm, itemtoConfirm);
                if(listDn != null)
                {
                   if(await _createDNServices.InsertDeliveryNote(listDn))
                    {
                        MessageBox.Show("Process Completed");
                    }
                }
                               
                await LoadViewTable(userLoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task UpdatePlannedPurchase(POTableObj readytoConfirm, int itemId)
        {
            try
            {
                PoItemList itemtoConfirm = readytoConfirm.itemLists.Where(x => x.bi_po_line_id == itemId).FirstOrDefault();

                var ppoId = readytoConfirm.vc_ref_id.Split(':')[1].Trim();
                var respo = await _dbServices.GetOriginalPoQty(ppoId);
                if (respo.resCode != 1)
                {
                    MessageBox.Show("update planned purchase order error");
                }
                List<List<KeyValuePair<string, object>>> kvp = respo.result;
                var actQty = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "i_actual_qty").Value;
                var actheader = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "bi_po_header_id").Value.ToString();
                int relQty = GenUtil.ConvertObjtoType<int>(actQty) - itemtoConfirm.i_actual_qty;

                updateObj updObj = new updateObj()
                {
                    table = "tb_po_line",
                    updater = new Dictionary<string, string>
                            {
                                { nameof(itemtoConfirm.i_actual_qty), relQty.ToString()  },

                            },
                    selecter = new Dictionary<string, string>
                            {
                                { nameof(itemtoConfirm.bi_po_header_id), actheader },
                                { nameof(itemtoConfirm.bi_item_id), itemtoConfirm.bi_item_id.ToString() }
                            }
                };
                var resorin = await _dbServices.UpdateAsync(updObj);
                if (resorin.resCode != 1 || resorin.result == null)
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
        public async Task UpdatePoLine(POTableObj readytoConfirm, int itemId, string bi_po_status_id)
        {
            try
            {
                PoItemList itemtoConfirm = readytoConfirm.itemLists.Where(x => x.bi_po_line_id == itemId).FirstOrDefault();
                updateObj updateReleaseStatus = new updateObj()
                {
                    table = "tb_po_line",
                    updater = new Dictionary<string, string>
                    {
                        { "bi_po_status_id", bi_po_status_id }
                    },
                    selecter = new Dictionary<string, string>
                    {
                        { nameof(itemtoConfirm.bi_item_id), itemtoConfirm.bi_item_id.ToString() },
                        { "bi_po_status_id", "4" },
                        {nameof(itemtoConfirm.bi_po_line_id),itemtoConfirm.bi_po_line_id.ToString() }
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
        public async Task UpdatePo(POTableObj tar, int bi_po_status_id)
        {
            int count = tar.itemLists.Where(x => x.bi_ln_po_status_id != bi_po_status_id).Count();

            if (count == 0)
            {
                updateObj updateObj = new updateObj()
                {
                    table = "tb_po",
                    updater = new Dictionary<string, string>
                        {
                            { "bi_po_status_id", bi_po_status_id.ToString()}
                        },
                    selecter = new Dictionary<string, string>
                        {
                            {nameof(tar.bi_po_id), tar.bi_po_id.ToString()}
                        }
                };
                var updatePo = await _dbServices.UpdateAsync(updateObj);
                if (updatePo.resCode != 1 || updatePo.result == null)
                {
                    //_logger.LogDebug("insert error");
                    throw new Exception("Update Po order error");
                }
            }
        }
        public async Task UpdateReqDetail(RequestMappingReqObj reqObj, ItemRequest item)
        {
            updateObj tempUpdate = new updateObj()
            {
                table = "tb_request_detail",
                selecter = new Dictionary<string, string>
                                            {
                                                { nameof(reqObj.bi_req_id), reqObj.bi_req_id.ToString() },
                                                { nameof(item.bi_item_id), item.bi_item_id.ToString() },
                                            },
                updater = new Dictionary<string, string>
                                            {
                                                { nameof(item.i_remain_req_qty), "0"},
                                                { nameof(item.i_hd_map_stat_id), "2" },
                                                { nameof(item.bi_po_status_id), "3" },
                                            }
            };
            var updatereq = await _dbServices.UpdateAsync(tempUpdate);
            if (updatereq.resCode != 1 || updatereq.result == null)
            {
                //_logger.LogDebug("insert error");
                throw new Exception("Update req detail order error");
            }
        }
        private async void btnreject_Click(object sender, EventArgs e)
        {
            try
            {
                if (poId == 0)
                {
                    MessageBox.Show("Please select item to Reject");
                    return;
                }
                POTableObj readytoReject = _confirmppo.Where(x => x.bi_po_header_id == selectId).FirstOrDefault();
                PoItemList itemtoReject = readytoReject.itemLists.Where(x => x.bi_po_line_id == poId).FirstOrDefault();
                await UpdatePoLine(readytoReject, poId, "5");
                List<POTableObj> outstandingPo = await _generalServices.OutstandingPoObj();
                var tar = outstandingPo.Where(x => x.bi_po_header_id == selectId).FirstOrDefault();
                await UpdatePo(tar, 5);

                await LoadViewTable(userLoc);
                //updateObj updateReleaseStatus = new updateObj()
                //{
                //    table = "tb_po",
                //    updater = new Dictionary<string, string>
                //    {
                //        { nameof(readytoReject.bi_po_status_id), "5" }
                //    },
                //    selecter = new Dictionary<string, string>
                //    {
                //        { nameof(readytoReject.bi_po_id), readytoReject.bi_po_id.ToString() },
                //        { nameof(readytoReject.bi_po_status_id), "4" }
                //    }
                //};
                //DbResObj upstatus = await _dbServices.UpdateAsync(updateReleaseStatus);
                //if (upstatus.resCode != 1 || upstatus.result == null)
                //{
                //    //_logger.LogDebug("insert error");
                //    throw new Exception("Update Planned Purchase order error");
                //}
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

        private void datagridviewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }  // header clicked

            if (e.RowIndex == datagridviewitem.CurrentRow.Index)
            {

                poId = GenUtil.ConvertObjtoType<int>(datagridviewitem.CurrentRow.Cells["bi_po_line_id"].Value);
            }
        }
        public async Task<List<DeliveryNoteObj>> CreateDnObject(POTableObj obj, PoItemList itemtoConfirm)
        {
            try
            {
                List<DeliveryNoteObj> listDn = new List<DeliveryNoteObj>();

                DeliveryNoteObj dnObj = new DeliveryNoteObj();
                tb_item_vid_mapping vid = await _generalServices.GetVidAsync(itemtoConfirm.bi_item_id.ToString());
                dnObj.bi_po_id = obj.bi_po_id;
                dnObj.bi_req_id = obj.bi_req_id;
                dnObj.i_dn_status_id = 3;
                dnObj.i_dn_type_id = 2;
                dnObj.bi_item_id = itemtoConfirm.bi_item_id;
                dnObj.bi_item_vid = GenUtil.ConvertObjtoType<int>(vid.bi_item_vid);
                dnObj.i_item_qty = itemtoConfirm.i_actual_qty;
                dnObj.bi_location_id = obj.bi_deli_loc_id;
                dnObj.dt_exp_deli_date = obj.dt_expect_delidate;
                dnObj.bi_supp_id = obj.bi_supp_id;
                listDn.Add(dnObj);

                return listDn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
