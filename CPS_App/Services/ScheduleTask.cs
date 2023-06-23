using Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class ScheduleTask
    {
        private readonly DbServices _services;
        private ILogger<ScheduleTask> _logger;
        private POAWorker _pOAWorker;
        private RequestMapping _requestMapping;
        private GenericTableViewWorker _genericTableViewWorker;
        private List<updateObj> _updateObjects;
        private CreatePoServices _createPoServices;
        private SearchFunc _searchFunc;

        public ScheduleTask(DbServices dbServices, ILogger<ScheduleTask> logger, POAWorker pOAWorker, 
            RequestMapping requestMapping, GenericTableViewWorker genericTableViewWorker, 
            CreatePoServices createPoServices, SearchFunc searchFunc)
        {
            _services = dbServices;
            _logger = logger;
            _pOAWorker = pOAWorker;
            _requestMapping = requestMapping;
            _genericTableViewWorker = genericTableViewWorker;
            _updateObjects = new List<updateObj>();
            _createPoServices = createPoServices;
            _searchFunc = searchFunc;
        }
        public async Task RequestMappingScheduler()
        {
            JsonResponse jsonObj = new JsonResponse()
            {
                jsonRes = new Dictionary<string, string>
                {
                    { "Po Id", "bi_po_id" },
                    { "Po Type", "vc_po_type_desc" },
                    { "Po Status", "vc_po_status_desc" },
                    //{ "Supplier", "vc_supp_desc" },
                    //{ "Contract No", "vc_contract_no" },
                    {"Delivery Location","vc_location_desc" },
                    { "Expected Delievery Date", "dt_expect_delidate" },
                    //{ "Staff Name","vc_staff_name" }
                    {"Supplier Item Id", "bi_supp_item_id" },
                    //{"Quot No", "vc_quot_no" }
                },
            };
               await _searchFunc.insertJsonString("a06fae55-8c3d-46d8-8778-a19b149c7fe7", "po", jsonObj);
            try
            {
                //Mapping process P1
                List<POTableObj> newPo1 = await MappingScheduler_P1();
                newPo1.ForEach(async x => await _createPoServices.CreatePoASync(x));
                
                if (_updateObjects.Any())
                {
                    _updateObjects.ForEach(async updateObj =>
                    {
                        DbResObj res = await _services.UpdateAsync(updateObj);
                        if (res.resCode != 1 || res.err_msg != null)
                        {
                            _logger.LogDebug($"Mapping process P1 update Db Error: {res.err_msg}");
                        }
                    });
                    _updateObjects.Clear();
                }
                //Mapping process p2
                List<POTableObj> newPo2 = await MappingScheduler_P1();
                if (_updateObjects.Any())
                {
                    _updateObjects.ForEach(async updateObj =>
                    {
                        DbResObj res = await _services.UpdateAsync(updateObj);
                        if (res.resCode != 1 || res.err_msg != null)
                        {
                            _logger.LogDebug($"Mapping process P1 update Db Error: {res.err_msg}");
                        }
                    });
                    _updateObjects.Clear();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            //var poaObj = await _services.GetBPAResult<POATableObj>(lst);
            //var inStock = await _services.GetInStockQty();//warehouse part



        }
        public async Task<List<RequestMappingReqObj>> RequestMapObjectGetter()
        {
            searchObj reqse = new searchObj()
            {
                searchWords = new Dictionary<string, List<string>>
                {
                    {"i_map_stat_id", new List<string>(){"1","3"} },
                    {"i_hd_map_stat_id" ,new List<string>(){"1"} },
                }
            };
            string addSearch = " i_remain_req_qty > 0";
            RequestMappingReqObj viewObj = new RequestMappingReqObj();
            try
            {
                return await _genericTableViewWorker.GetGenericWorker<RequestMappingReqObj, ItemRequest>(viewObj.GetSqlQuery(), nameof(viewObj.bi_req_id), null, reqse, addSearch);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<POATableObj>> PoaMapObjectGetter()
        {
            searchObj seObj = new searchObj()
            {
                searchWords = new Dictionary<string, List<string>>
                {
                    {"bi_poa_status_id",new List<string>() { "1" } },
                }
            };
            try
            {
                POATableObj viewObj = new POATableObj();
                return await _genericTableViewWorker.GetGenericWorker<POATableObj, PoaItemList>(viewObj.GetSqlQuery(), nameof(viewObj.bi_poa_header_id), null, seObj);
                //return await _pOAWorker.GetPoaWorker(null, seObj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task<List<POTableObj>> iteratePoaProcess(List<RequestMappingReqObj> reqObj, List<POATableObj> poaObj)
        {
            List<POTableObj> PoCreateList = new List<POTableObj>();
            List<updateObj> update = new List<updateObj>();

            reqObj.ForEach(reqObj =>
            {
                reqObj.itemLists.ForEach(item =>
                {
                    poaObj.ForEach(row =>
                    {
                        if (row.itemLists.Count > 0)
                        {
                            row.itemLists.Where(x => x.bi_item_id == item.bi_item_id).ToList().ForEach(i =>
                            {
                                var day = i.vc_deli_sched_desc.Split(' ');
                                DateTime arrival = DateTime.Now.AddDays(GenUtil.ConvertObjtoType<int>(day.ElementAt(0)));
                                //poa > request
                                if (i.i_remain_qty > item.i_remain_req_qty && item.i_remain_req_qty > i.i_min_qty &&
                                arrival > item.dt_exp_deli_date)
                                {
                                    try
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
                                                { nameof(item.i_remain_req_qty), i.i_remain_qty >= item.i_remain_req_qty ? "0": GenUtil.ConvertObjtoType<int>(item.i_remain_req_qty - i.i_remain_qty).ToString() },
                                                { nameof(item.i_hd_map_stat_id), "2" },
                                                { nameof(item.bi_po_status_id), "3" },
                                            }
                                        };
                                        _updateObjects.Add(tempUpdate);

                                        POTableObj tempPoCreate = new POTableObj();
                                        row.GetType().GetProperties().ToList().ForEach(p =>
                                        {
                                            tempPoCreate.GetType().GetProperties().ToList().ForEach(t =>
                                            {
                                                if (t.Name == p.Name && t.Name != "itemLists")
                                                {
                                                    t.SetValue(tempPoCreate, Convert.ChangeType(p.GetValue(row), p.PropertyType, null));
                                                }
                                            });
                                        });
                                        reqObj.GetType().GetProperties().ToList().ForEach(p =>
                                        {
                                            tempPoCreate.GetType().GetProperties().ToList().ForEach(t =>
                                            {
                                                if (t.Name == p.Name && t.Name != "itemLists")
                                                {
                                                    t.SetValue(tempPoCreate, Convert.ChangeType(p.GetValue(reqObj), p.PropertyType, null));
                                                }
                                            });

                                        });
                                        PoItemList tempPoItem = new PoItemList();
                                        i.GetType().GetProperties().ToList().ForEach(it =>
                                        {
                                            tempPoItem.GetType().GetProperties().ToList().ForEach(y =>
                                            {
                                                if (y.Name == it.Name)
                                                {
                                                    y.SetValue(tempPoItem, Convert.ChangeType(it.GetValue(i), it.PropertyType, null));
                                                }
                                            });
                                        });
                                        tempPoItem.i_actual_qty = i.i_remain_qty >= item.i_remain_req_qty ? item.i_remain_req_qty: i.i_remain_qty;
                                        tempPoItem.i_actual_amount = tempPoItem.i_actual_qty * tempPoItem.i_price;
                                        tempPoCreate.itemLists.Add(tempPoItem);
                                        tempPoCreate.vc_ref_id = $"Poa Id: {row.bi_poa_id}" ;
                                        tempPoCreate.ti_po_type_id = 2;
                                        tempPoCreate.bi_deli_loc_id = reqObj.bi_location_id;
                                        tempPoCreate.bi_po_status_id = 1;
                                        tempPoCreate.dt_expect_delidate = (DateTime.Now.AddDays(GenUtil.ConvertObjtoType<int>(tempPoCreate.vc_deli_sched_desc.ToString().Split(' ').ElementAt(0)))).ToString("yyyy-MM-dd");
                                        if (PoCreateList.Any(x => x.vc_ref_id == tempPoCreate.vc_ref_id && x.bi_deli_loc_id == tempPoCreate.bi_deli_loc_id))
                                        {
                                            PoCreateList.Where(x => x.vc_ref_id == tempPoCreate.vc_ref_id && x.bi_deli_loc_id == tempPoCreate.bi_deli_loc_id).FirstOrDefault()!.itemLists.Add(tempPoItem);
                                        }
                                        else
                                        {
                                            PoCreateList.Add(tempPoCreate);
                                        }

                                        //adjust available items
                                        i.i_remain_qty = i.i_remain_qty >= item.i_remain_req_qty ? i.i_remain_qty - item.i_remain_req_qty : 0;
                                        updateObj tempPoaUpdate = new updateObj()
                                        {
                                            table = "tb_poa_line",
                                            updater = new Dictionary<string, string>
                                            {
                                                {nameof(i.i_remain_qty), i.i_remain_qty.ToString()},
                                            },
                                            selecter = new Dictionary<string, string>
                                                {
                                                    {nameof(i.bi_poa_header_id), i.bi_poa_header_id.ToString()},
                                                    {nameof(i.bi_poa_line_id), i.bi_poa_line_id.ToString()},
                                                    {nameof(i.bi_item_id), i.bi_item_id.ToString()},
                                                }
                                        };
                                        _updateObjects.Add(tempPoaUpdate);
                                        //update db
                                        //further process to po

                                    }
                                    catch (Exception ex)
                                    {
                                        throw new Exception(ex.Message);
                                    }

                                }
                                //request > poa
                                //else if (i.i_remain_qty < item.i_remain_req_qty && item.i_remain_req_qty > i.i_min_qty)
                                //{
                                //    couu++;
                                //}
                            });
                        }
                    });
                });
            });
            return PoCreateList;
        }
        public async Task<List<POTableObj>> MappingScheduler_P1()
        {
            try
            {
                //get request obj
                List<RequestMappingReqObj> reqObj = await RequestMapObjectGetter();

                //get poa obj            
                List<POATableObj> poaObj = await PoaMapObjectGetter();
                //iterate enough poa 
                return await iteratePoaProcess(reqObj, poaObj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public async Task MappingScheduler_P2()
        {
            //get request obj
            List<RequestMappingReqObj> reqObj = await RequestMapObjectGetter();

            //get poa obj            
            List<POATableObj> poaObj = await PoaMapObjectGetter();
        }
    }
}
