using Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        private DbGeneralServices _dbGeneralServices;
        private CreateDNServices _createDNServices;

        public ScheduleTask(DbServices dbServices, ILogger<ScheduleTask> logger, POAWorker pOAWorker,
            RequestMapping requestMapping, GenericTableViewWorker genericTableViewWorker,
            CreatePoServices createPoServices, SearchFunc searchFunc, DbGeneralServices dbGeneralServices, CreateDNServices createDNServices)
        {
            _services = dbServices;
            _logger = logger;
            _pOAWorker = pOAWorker;
            _requestMapping = requestMapping;
            _genericTableViewWorker = genericTableViewWorker;
            _updateObjects = new List<updateObj>();
            _createPoServices = createPoServices;
            _searchFunc = searchFunc;
            _dbGeneralServices = dbGeneralServices;
            _createDNServices = createDNServices;
        }
        public async Task RequestMappingScheduler()
        {
            //JsonResponse jsonObj = new JsonResponse()
            //{
            //    jsonRes = new Dictionary<string, string>
            //    {
            //        { "Po Id", "bi_po_id" },
            //        { "Po Type", "vc_po_type_desc" },
            //        { "Po Status", "vc_po_status_desc" },
            //        //{ "Supplier", "vc_supp_desc" },
            //        //{ "Contract No", "vc_contract_no" },
            //        {"Delivery Location","vc_location_desc" },
            //        { "Expected Delievery Date", "dt_expect_delidate" },
            //        //{ "Staff Name","vc_staff_name" }
            //        {"Supplier Item Id", "bi_supp_item_id" },
            //        //{"Quot No", "vc_quot_no" }
            //    },
            //};
            //   await _searchFunc.insertJsonString("a06fae55-8c3d-46d8-8778-a19b149c7fe7", "po", jsonObj);
            try
            {
                //Mapping Process Warehouse
                //List<DispatchInstruction> dis = await MappingProcessWarehouse();
                //await CreateDispatchAsync(dis);
                //await UpdateRecordAsync();

                //Mapping process P1
                List<POTableObj> newPo1 = await MappingScheduler_P1();
                if(newPo1 != null)
                {
                    newPo1.ForEach(async x => {
                        await _createPoServices.CreatePoAsync(x);
                    });
                    await _dbGeneralServices.UpdateRecordAsync(_updateObjects);
                    _updateObjects.Clear();

                    //create delivery note
                    List<DeliveryNoteObj> listDn = await CreateDnObject(newPo1);
                    if (listDn != null)
                    {
                        resObj res = await _createDNServices.CreateDnAsync(listDn);
                        if (res.resCode != 1)
                        {
                            _logger.LogDebug("Create Dn Async with error");
                        }
                    }
                }
                
              

               
                

                ////Mapping process p2
                //List<POTableObj> newPo2 = await MappingScheduler_P1();
                //await UpdateRecordAsync();

                //Mapping Process Warehouse p3
                List<DispatchInstruction> dis = await MappingProcessWarehouse();
                if(dis != null)
                {
                    await CreateDispatchAsync(dis);
                    await _dbGeneralServices.UpdateRecordAsync(_updateObjects);
                    _updateObjects.Clear();
                }

                //Record remaining req to fail
                await UpdateMappRecordtoFail();
                await _dbGeneralServices.UpdateRecordAsync(_updateObjects);
                _updateObjects.Clear();

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
        public async Task<List<StockLevelViewObj>> StockMapObjectGetter()
        {
            searchObj seObj = new searchObj()
            {
                searchWords = new Dictionary<string, List<string>>
                {
                    {"bi_location_id",new List<string>() { "71" } },
                }
            };
            try
            {
                StockLevelViewObj viewObj = new StockLevelViewObj();
                return await _genericTableViewWorker.GetGenericWorker<StockLevelViewObj, StockLevelSubItem>(viewObj.sql, nameof(viewObj.bi_item_id), null, seObj);
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
                            row.itemLists.Where(x => x.bi_item_id == item.bi_item_id).ToList().ForEach(async i =>
                            {
                                var day = i.vc_deli_sched_desc.Split(' ');
                                DateTime arrival = DateTime.Now.AddDays(GenUtil.ConvertObjtoType<int>(day.ElementAt(0)));
                                //poa > request
                                if (i.i_remain_qty > item.i_remain_req_qty && item.i_remain_req_qty > i.i_min_qty &&
                                arrival < GenUtil.ConvertObjtoType<DateTime>(item.dt_exp_deli_date) && GenUtil.ConvertObjtoType<DateTime>(row.dt_effect_date) > DateTime.Now)
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
                                        tempPoItem.i_actual_qty = i.i_remain_qty >= item.i_remain_req_qty ? item.i_remain_req_qty : i.i_remain_qty;
                                        tempPoItem.i_actual_amount = tempPoItem.i_actual_qty * tempPoItem.i_price;
                                        tempPoItem.bi_ln_po_status_id = 1;
                                        tempPoCreate.itemLists.Add(tempPoItem);
                                        tempPoCreate.vc_ref_id = $"Poa Id: {row.bi_poa_id}";
                                        tempPoCreate.bi_req_id = reqObj.bi_req_id;
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
        public async Task<List<DispatchInstruction>> iterateWarehouseProcess(List<RequestMappingReqObj> reqObj, List<StockLevelViewObj> stockObj)
        {
            List<DispatchInstruction> createDispatch = new List<DispatchInstruction>();
            List<updateObj> updateObj = new List<updateObj>();
            reqObj.ForEach(reqObj =>
            {
                reqObj.itemLists.ForEach(reqitem =>
                {
                    stockObj.ForEach(stockItem =>
                    {
                        if (stockItem.itemLists.Count > 0)
                        {
                            stockItem.itemLists.Where(x => x.bi_item_id == reqitem.bi_item_id).ToList().ForEach(item =>
                            {
                                if (item.i_item_qty > 0)
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
                                                { nameof(reqitem.i_remain_req_qty), item.i_item_qty >= reqitem.i_remain_req_qty ? "0": GenUtil.ConvertObjtoType<int>(reqitem.i_remain_req_qty - item.i_item_qty).ToString() },
                                                { nameof(reqitem.i_hd_map_stat_id), "2" },
                                                { nameof(reqitem.bi_po_status_id), "3" },
                                            }
                                    };
                                    _updateObjects.Add(tempUpdate);
                                }

                                DispatchInstruction tempDis = new DispatchInstruction();
                                reqObj.GetType().GetProperties().ToList().ForEach(p =>
                                {
                                    tempDis.GetType().GetProperties().ToList().ForEach(t =>
                                    {
                                        if (t.Name == p.Name && t.Name != "itemLists")//&& t.GetValue(tempDis) == null)
                                        {
                                            t.SetValue(tempDis, Convert.ChangeType(p.GetValue(reqObj), p.PropertyType, null));
                                        }
                                    });
                                });
                                stockItem.GetType().GetProperties().ToList().ForEach(p =>
                                {
                                    tempDis.GetType().GetProperties().ToList().ForEach(t =>
                                    {
                                        if (t.Name == p.Name && t.Name != "itemLists")//&& t.GetValue(tempDis) == null)
                                        {
                                            t.SetValue(tempDis, Convert.ChangeType(p.GetValue(stockItem), p.PropertyType, null));
                                        }
                                    });

                                });
                                reqitem.GetType().GetProperties().ToList().ForEach(it =>
                                {
                                    tempDis.GetType().GetProperties().ToList().ForEach(y =>
                                    {
                                        if (y.Name == it.Name)//&& y.GetValue(tempDis) == null)
                                        {
                                            y.SetValue(tempDis, Convert.ChangeType(it.GetValue(reqitem), it.PropertyType, null));
                                        }
                                    });
                                });
                                //item.GetType().GetProperties().ToList().ForEach(it =>
                                //{
                                //    tempDis.GetType().GetProperties().ToList().ForEach(y =>
                                //    {
                                //        if (y.Name == it.Name)//&& y.GetValue(tempDis) == null)
                                //        {
                                //            y.SetValue(tempDis, Convert.ChangeType(it.GetValue(item), it.PropertyType, null));
                                //        }
                                //    });
                                //});
                                tempDis.bi_supp_id = item.bi_supp_id;
                                tempDis.i_di_status_id = 1;
                                tempDis.i_item_qty = item.i_item_qty >= reqitem.i_remain_req_qty ? reqitem.i_remain_req_qty : item.i_item_qty;
                                createDispatch.Add(tempDis);

                            });
                        }
                    });
                });
            });
            return createDispatch;
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
                if(reqObj != null)
                {
                    return await iteratePoaProcess(reqObj, poaObj);
                }
                else
                {
                    return null;
                }
                
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
        public async Task<List<DispatchInstruction>> MappingProcessWarehouse()
        {
            //get request obj
            List<RequestMappingReqObj> reqObj = await RequestMapObjectGetter();

            //get stock in warehouse
            List<StockLevelViewObj> stockObj = await StockMapObjectGetter();
            if(reqObj != null)
            {
                return await iterateWarehouseProcess(reqObj, stockObj);
            }
            else
            {
                return null;
            }
            
        }
        public async Task CreateDispatchAsync(List<DispatchInstruction> disObj)
        {
            if (disObj.Count > 0)
            {
                foreach (DispatchInstruction instruction in disObj)
                {
                    insertObj inObj = new insertObj()
                    {
                        table = "tb_dispatch_instruction",
                        inserter = new Dictionary<string, string>
                {
                    //{nameof(disObj.bi_di_id),disObj.bi_di_id.ToString() },
                    {nameof(instruction.bi_req_id),instruction.bi_req_id.ToString() },
                    {nameof(instruction.bi_item_id),instruction.bi_item_id.ToString() },
                    {nameof(instruction.bi_item_vid),instruction.bi_item_vid.ToString() },
                    {nameof(instruction.i_di_status_id),instruction.i_di_status_id.ToString() },
                    {nameof(instruction.i_item_qty),instruction.i_item_qty.ToString() },
                    {nameof(instruction.bi_category_id),instruction.bi_category_id.ToString() },
                    {nameof(instruction.dt_exp_deli_date),instruction.dt_exp_deli_date},
                    {nameof(instruction.bi_location_id),instruction.bi_location_id.ToString() },
                    {nameof(instruction.bi_supp_id),instruction.bi_supp_id.ToString() }
                }
                    };
                    DbResObj res = await _services.InsertAsync(inObj);
                    if (res.resCode != 1)
                    {
                        MessageBox.Show("insert Dispatch error");
                        return;
                    }
                    if (res.err_msg != null)
                    {
                        MessageBox.Show(res.err_msg);
                        return;
                    }
                }
                MessageBox.Show("Insert Dispatch success");
            }
            else
            {
                MessageBox.Show("No Dispatch order");
            }

        }
       
        public async Task UpdateMappRecordtoFail()
        {
            try
            {
                List<RequestMappingReqObj> reqRemain = await RequestMapObjectGetter();
                if(reqRemain != null)
                {
                    await CreateUpdateObject(reqRemain);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task CreateUpdateObject(List<RequestMappingReqObj> reqRemain)
        {
            try
            {
                foreach (RequestMappingReqObj row in reqRemain)
                {
                    updateObj updateObj = new updateObj()
                    {
                        table = "tb_request",
                        updater = new Dictionary<string, string>
                            {
                                {nameof(row.i_map_stat_id),"3" }
                            },
                        selecter = new Dictionary<string, string>
                            {
                                {nameof(row.bi_req_id),row.bi_req_id.ToString()},
                                {nameof(row.i_map_stat_id), "1"}
                            }
                    };
                    _updateObjects.Add(updateObj);

                    row.itemLists.ForEach(it =>
                    {
                        updateObj updateObj = new updateObj()
                        {
                            table = "tb_request_detail",
                            updater = new Dictionary<string, string>
                            {
                                {nameof(it.i_hd_map_stat_id),"3" }
                            },
                            selecter = new Dictionary<string, string>
                            {
                                {nameof(it.bi_req_id),it.bi_req_id.ToString()},
                                {nameof(it.bi_item_id), it.bi_item_id.ToString()},
                                {nameof(it.i_hd_map_stat_id),"1"},
                            }
                        };
                        _updateObjects.Add(updateObj);
                    });

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<DeliveryNoteObj>> CreateDnObject(List<POTableObj> obj)
        {
            try
            {
                List<DeliveryNoteObj> listDn = new List<DeliveryNoteObj>();

                foreach (POTableObj it in obj)
                {
                    foreach (PoItemList item in it.itemLists)
                    {
                        DeliveryNoteObj dnObj = new DeliveryNoteObj();
                        tb_item_vid_mapping vid = await _dbGeneralServices.GetVidAsync(item.bi_item_id.ToString());
                        dnObj.bi_po_id = it.bi_po_id;
                        dnObj.bi_req_id = it.bi_req_id;
                        dnObj.i_dn_status_id = 3;
                        dnObj.i_dn_type_id = 2;
                        dnObj.bi_item_id = item.bi_item_id;
                        dnObj.bi_item_vid = GenUtil.ConvertObjtoType<int>(vid.bi_item_vid);
                        dnObj.i_item_qty = item.i_actual_qty;
                        dnObj.bi_location_id = it.bi_deli_loc_id;
                        dnObj.dt_exp_deli_date = it.dt_expect_delidate;
                        dnObj.bi_supp_id= it.bi_supp_id;
                        listDn.Add(dnObj);
                    }

                }
                return listDn;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
