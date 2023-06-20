using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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

        public ScheduleTask(DbServices dbServices, ILogger<ScheduleTask> logger, POAWorker pOAWorker, RequestMapping requestMapping, GenericTableViewWorker genericTableViewWorker)
        {
            _services = dbServices;
            _logger = logger;
            _pOAWorker = pOAWorker;
            _requestMapping = requestMapping;
            _genericTableViewWorker = genericTableViewWorker;
        }
        public async Task RequestMappingScheduler()
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
            List<RequestMappingReqObj> reqObj = await _genericTableViewWorker.GetGenericWorker<RequestMappingReqObj, ItemRequest>(viewObj.sql, nameof(viewObj.bi_req_id), null, reqse, addSearch);

            //List< RequestMappingReqObj> reqObj =  await _requestMapping.RequestMappingObjGetter(null, reqse);
            //get request obj
            var item_list_req = new List<ItemRequest>();
            var poaTable = new List<POATableObj>();

            foreach (RequestMappingReqObj row in reqObj)
            {
                if (row.i_map_stat_id == 1 && row.itemLists.Count > 0)
                {
                    foreach (ItemRequest item in row.itemLists)
                    {
                        if (item.i_hd_map_stat_id == 1 && item.i_remain_req_qty > 0)
                        {
                            item_list_req.Add(item);
                        }
                    }
                }
            }

            List<int> itemIdLst = item_list_req.Select(x => x.bi_item_id).ToList();
            string lst = string.Join(",", itemIdLst);
            //get poa obj
            searchObj seObj = new searchObj()
            {
                searchWords = new Dictionary<string, List<string>>
                {
                    {"bi_poa_status_id",new List<string>() { "1" } },
                }
            };
            List<POATableObj> poaObj = await _pOAWorker.GetPoaWorker(null, seObj);
            List<PoaItemList> poaitem = new List<PoaItemList>();
         
            //var poaObj = await _services.GetBPAResult<POATableObj>(lst);
            //var inStock = await _services.GetInStockQty();//warehouse part
            int cou = 0;
            int couu = 0;
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
                                if (i.dc_remain_qty > item.i_remain_req_qty && item.i_remain_req_qty > i.dc_min_qty)
                                {
                                    if (arrival > item.dt_exp_deli_date)
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
                                                { nameof(item.i_remain_req_qty), "0" },
                                                { nameof(item.i_hd_map_stat_id), "2" },
                                                { nameof(item.bi_po_status_id), "3" },
                                            }
                                        };
                                        update.Add(tempUpdate);
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
                                        tempPoItem.dc_actual_qty = item.i_remain_req_qty;
                                        tempPoItem.dc_actual_amount = tempPoItem.dc_actual_qty * tempPoItem.dc_price;
                                        tempPoCreate.itemLists.Add(tempPoItem);
                                        tempPoCreate.vc_ref_id = row.bi_poa_id.ToString();
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
                                        i.dc_remain_qty = i.dc_remain_qty - item.i_remain_req_qty;

                                        
                                        //update db
                                        //further process to po
                                    }
                                }
                                //request > poa
                                //else if (i.dc_remain_qty < item.i_remain_req_qty && item.i_remain_req_qty > i.dc_min_qty)
                                //{
                                //    couu++;
                                //}
                            });
                        }
                    });
                });
            });

        }
    }
}
