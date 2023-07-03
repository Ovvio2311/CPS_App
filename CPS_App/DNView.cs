﻿using CPS_App.Data;
using CPS_App.Services;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        //private readonly IConfiguration _configuration;
        //private readonly AppConfig _config;
        public ClaimsIdentity userIden;
        private GenericTableViewWorker _genericTableViewWorker;
        public List<DeliveryNoteObj> dnObj;
        private readonly DbServices _dbServices;
        private int selectId;
        private string userLoc;
        private List<updateObj> _updateObjs;
        private DbGeneralServices _generalServices;
        public DNView(DbServices dbServices, GenericTableViewWorker genericTableViewWorker, DbGeneralServices generalServices/*, IConfiguration configuration*/)
        {
            InitializeComponent();
            _dbServices = dbServices;
            _updateObjs = new List<updateObj>();
            _genericTableViewWorker = genericTableViewWorker;
            _generalServices = generalServices;
            //_configuration = configuration;
            //_config = configuration.Get<AppConfig>();
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
                    { nameof(viewObj.bi_location_id), new List<string>(){ userLoc } },
                    { nameof(viewObj.i_dn_type_id), new List<string>(){ "1","2" } },
                    { nameof(viewObj.i_dn_status_id), new List<string>(){ "3" } }
                }
            };
            DbResObj res = await _dbServices.GetDiliveryNote(loc, searchObj);
            if (res.resCode != 1)
            {
                datagridview.Columns.Clear();
                lblnoresult.Show();
                
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
        private async void btnreceive_Click(object sender, EventArgs e)
        {
            if (selectId == 0)
            {
                MessageBox.Show("Please select item to complete");
                return;
            }
            DeliveryNoteObj readytoConfirm = dnObj.Where(x => x.bi_dn_id == selectId).FirstOrDefault();
            await CreateUpdateObj(readytoConfirm);

            await _generalServices.UpdateRecordAsync(_updateObjs);
            _updateObjs.Clear();

            //update tb_request if any
            int count = 0;
            List<RequestMappingReqObj> reqObj = await _generalServices.OutstandingReqObj();
            if(reqObj != null)
            {
                foreach (RequestMappingReqObj row in reqObj)
                {
                    count = row.itemLists.Where(x => x.i_remain_req_qty != 0 || x.bi_po_status_id != 2 || x.i_hd_map_stat_id != 2).Count();

                    if (count == 0)
                    {
                        updateObj updateObj = new updateObj()
                        {
                            table = "tb_request",
                            updater = new Dictionary<string, string>
                        {
                            { "i_map_stat_id", "2"}
                        },
                            selecter = new Dictionary<string, string>
                        {
                            {nameof(row.bi_req_id), row.bi_req_id.ToString()}
                        }
                        };
                        _updateObjs.Add(updateObj);
                    }

                }
            }
            
            await _generalServices.UpdateRecordAsync(_updateObjs);
            _updateObjs.Clear();

            //update tb_po if any
            int poCount = 0;
            List<POTableObj> poObj = await _generalServices.OutstandingPoObj();
            if(poObj != null )
            {
                foreach (POTableObj row in poObj)
                {

                    count = row.itemLists.Where(x => x.bi_ln_po_status_id != 2).Count();

                    if (count == 0)
                    {
                        updateObj updateObj = new updateObj()
                        {
                            table = "tb_po",
                            updater = new Dictionary<string, string>
                        {
                            { "bi_po_status_id", "2"}
                        },
                            selecter = new Dictionary<string, string>
                        {
                            {nameof(row.bi_po_id), row.bi_po_id.ToString()}
                        }
                        };
                        _updateObjs.Add(updateObj);
                    }

                }
            }
            
            await _generalServices.UpdateRecordAsync(_updateObjs);
            _updateObjs.Clear();
            MessageBox.Show("Update Completed");
            await LoadViewTable(userLoc);
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

        public async Task CreateUpdateObj(DeliveryNoteObj readytoConfirm)
        {
            //update tb_delivery_note
            await UpdateDeliNote(readytoConfirm);

            //update tb_request_detail
            await UpdateReqDetail(readytoConfirm);

            //update dest stock unit
            await UpdateDestStockUnit(readytoConfirm);
            if (readytoConfirm.i_dn_type_id == 1)//warehouse
            {
                await UpdateSourceStockUnit(readytoConfirm);
            }
            else if (readytoConfirm.i_dn_type_id == 2) //po order
            {
                await UpdatePoCompleteStatus(readytoConfirm);
            }

        }
        //public async Task<List<RequestMappingReqObj>> OutstandingReqObj()
        //{
        //    try
        //    {
        //        searchObj reqse = new searchObj()
        //        {
        //            searchWords = new Dictionary<string, List<string>>
        //        {
        //            {"i_map_stat_id", new List<string>(){"1","3"} },
        //        }
        //        };
        //        //string addSearch = " i_remain_req_qty > 0";


        //        RequestMappingReqObj viewObj = new RequestMappingReqObj();
        //        var res = await _genericTableViewWorker.GetGenericWorker<RequestMappingReqObj, ItemRequest>(viewObj.GetSqlQuery(), nameof(viewObj.bi_req_id), null, reqse);
        //        return res;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public async Task UpdateDeliNote(DeliveryNoteObj readytoConfirm)
        {
            try
            {
                updateObj updateObj = new updateObj()
                {
                    table = "tb_delivery_note",
                    updater = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.i_dn_status_id),"2" },
                },
                    selecter = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.bi_dn_id),readytoConfirm.bi_dn_id.ToString()},
                    {nameof(readytoConfirm.bi_item_id),readytoConfirm.bi_item_id.ToString()}
                }
                };
                _updateObjs.Add(updateObj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task UpdateReqDetail(DeliveryNoteObj readytoConfirm)
        {
            try
            {
                //find qty
                selectObj selObj = new selectObj()
                {
                    table = "tb_request_detail",
                    selecter = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.bi_req_id) ,readytoConfirm.bi_req_id.ToString()},
                    {nameof(readytoConfirm.bi_item_id), readytoConfirm.bi_item_id.ToString() },
                }

                };
                DbResObj selres = await _dbServices.SelectWhereAsync(selObj);
                if (selres.resCode != 1)
                {

                    MessageBox.Show("update request detail order error");
                    return;
                }
                List<List<KeyValuePair<string, object>>> kvp = GenUtil.DbResulttoKVP(selres.result);
                var qty = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "i_remain_req_qty").Value;
                int realqty = GenUtil.ConvertObjtoType<int>(qty) - readytoConfirm.i_item_qty;


                updateObj updateReq = new updateObj()
                {
                    table = "tb_request_detail",
                    updater = new Dictionary<string, string>
                {
                    {"i_remain_req_qty" ,realqty<=0? "0":realqty.ToString()},
                    {"bi_po_status_id", "2" },
                    {"i_hd_map_stat_id", "2" }
                },
                    selecter = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.bi_req_id),readytoConfirm.bi_req_id.ToString() },
                    {nameof(readytoConfirm.bi_item_id),readytoConfirm.bi_item_id.ToString() },
                }
                };
                _updateObjs.Add(updateReq);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task UpdateDestStockUnit(DeliveryNoteObj readytoConfirm)
        {
            try
            {
                if (readytoConfirm.i_dn_type_id == 1)//warehouse
                {

                }
                //find delivery location qty
                selectObj selObj = new selectObj()
                {
                    table = nameof(tb_item_unit),
                    selecter = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.bi_location_id) ,readytoConfirm.bi_location_id.ToString()},
                    {nameof(readytoConfirm.bi_item_id), readytoConfirm.bi_item_id.ToString() },
                }

                };
                DbResObj selres = await _dbServices.SelectWhereAsync(selObj);
                if (selres.resCode == 1 && selres.result.Count == 0)
                {
                    tb_item uom = await _generalServices.GetUomAsync(readytoConfirm.bi_item_id.ToString());
                    insertObj insertItemUnit = new insertObj();
                    insertItemUnit.table = nameof(tb_item_unit);
                    insertItemUnit.inserter.Add(nameof(readytoConfirm.bi_item_id), readytoConfirm.bi_item_id.ToString());
                    insertItemUnit.inserter.Add(nameof(readytoConfirm.bi_location_id), readytoConfirm.bi_location_id.ToString());
                    insertItemUnit.inserter.Add(nameof(readytoConfirm.i_item_qty), readytoConfirm.i_item_qty.ToString());
                    insertItemUnit.inserter.Add("i_uom_id", uom != null ? uom.i_uom_id.ToString() : null);
                    //MessageBox.Show("update item unit order error");
                }
                else if (selres.resCode == 1 && selres.result.Count > 0)
                {
                    List<List<KeyValuePair<string, object>>> kvp = GenUtil.DbResulttoKVP(selres.result);
                    var qty = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "i_item_qty").Value;
                    int realqty = GenUtil.ConvertObjtoType<int>(qty) + readytoConfirm.i_item_qty;


                    updateObj updateStock = new updateObj()
                    {
                        table = "tb_item_unit",
                        selecter = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.bi_item_id), readytoConfirm.bi_item_id.ToString()  },
                    {nameof(readytoConfirm.bi_location_id), readytoConfirm.bi_location_id.ToString() }
                },
                        updater = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.i_item_qty),realqty.ToString() }
                }
                    };
                    _updateObjs.Add(updateStock);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task UpdateSourceStockUnit(DeliveryNoteObj readytoConfirm)
        {
            try
            {

                //find delivery location qty
                selectObj selObj = new selectObj()
                {
                    table = nameof(tb_item_unit),
                    selecter = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.bi_location_id) ,"71"},
                    {nameof(readytoConfirm.bi_item_id), readytoConfirm.bi_item_id.ToString() },
                }

                };
                DbResObj selres = await _dbServices.SelectWhereAsync(selObj);
                if (selres.resCode != 1)
                {

                    MessageBox.Show("update item unit order error");
                }
                List<List<KeyValuePair<string, object>>> kvp = GenUtil.DbResulttoKVP(selres.result);
                var qty = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "i_item_qty").Value;
                int realqty = GenUtil.ConvertObjtoType<int>(qty) - readytoConfirm.i_item_qty;


                updateObj updateStock = new updateObj()
                {
                    table = "tb_item_unit",
                    selecter = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.bi_item_id), readytoConfirm.bi_item_id.ToString()  },
                    {nameof(readytoConfirm.bi_location_id), "71" }
                },
                    updater = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.i_item_qty),realqty.ToString() }
                }
                };
                _updateObjs.Add(updateStock);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task UpdatePoCompleteStatus(DeliveryNoteObj readytoConfirm)
        {
            string poHead = await _generalServices.GetpoHeaderIdAsync(readytoConfirm.bi_po_id.ToString());
            if (poHead == null)
            {
                MessageBox.Show("Cannot find po Header Id");
                return;
            }
            updateObj updateObj = new updateObj()
            {
                table = "tb_po_line",
                updater = new Dictionary<string, string>
                {
                    {"bi_po_status_id", "2"},
                },
                selecter = new Dictionary<string, string>
                {
                    {"bi_po_header_id", poHead },
                    {nameof(readytoConfirm.bi_item_id),readytoConfirm.bi_item_id.ToString() }
                }
            };
            _updateObjs.Add(updateObj);
        }

        private async void btncsv_Click(object sender, EventArgs e)
        {
            await CsvAsync(dnObj);
        }
        public async Task CsvAsync(List<DeliveryNoteObj> obj)
        {
            if(await GenUtil.ExportCsv<DeliveryNoteObj>(obj, $"Delivery_Note"))
            {
                MessageBox.Show("CSV Generated");
            }
        }
    }
}
