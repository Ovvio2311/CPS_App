using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    {"i_map_stat_id", new List<string>(){"1","3"} }
                }
            };
            RequestMappingReqObj viewObj = new RequestMappingReqObj();
            List<RequestMappingReqObj> reqObj = await _genericTableViewWorker.GetGenericWorker<RequestMappingReqObj, ItemRequest>(viewObj.sql, nameof(viewObj.bi_req_id), null, reqse);

            //List< RequestMappingReqObj> reqObj =  await _requestMapping.RequestMappingObjGetter(null, reqse);
            var item_list = new List<ItemRequest>();
            var poaTable = new List<POATableObj>();

            foreach (RequestMappingReqObj row in reqObj)
            {
                if (row.i_map_stat_id == 1 && row.itemLists.Count > 0)
                {
                    foreach (ItemRequest item in row.itemLists)
                    {
                        if (item.i_hd_map_stat_id == 1 && item.i_remain_req_qty > 0)
                        {
                            item_list.Add(item);
                        }
                    }
                }
            }
            List<int> itemIdLst = item_list.Select(x => x.bi_item_id).ToList();
            string lst = string.Join(",", itemIdLst);
            searchObj seObj = new searchObj()
            {
                searchWords = new Dictionary<string, List<string>>
                {
                    {"bi_poa_status_id",new List < string >() { "1" } },
                }
            };
            List<POATableObj> poaObj = await _pOAWorker.GetPoaWorker(null, seObj);
            List<PoaItemList> poaitem = new List<PoaItemList>();
            foreach (POATableObj row in poaObj)
            {
                if (row.itemLists.Count > 0)
                {
                    foreach (PoaItemList col in row.itemLists)
                    {
                        poaitem.Add(col);
                    }
                }
            }
            //var poaObj = await _services.GetBPAResult<POATableObj>(lst);
            //var inStock = await _services.GetInStockQty();//warehouse part

            foreach (var item in item_list)
            {
                poaObj.ForEach(row =>
                {
                    if (row.itemLists.Count > 0)
                    {
                        row.itemLists.Where(x => x.bi_item_id == item.bi_item_id).ToList().ForEach(i =>
                        {

                            var day = row.vc_deli_sched_desc.Split(' ');
                            DateTime arrival = DateTime.Now.AddDays(GenUtil.ConvertObjtoType<int>(day.ElementAt(0)));
                            //poa > request
                            if (i.dc_remain_qty > item.i_remain_req_qty && item.i_remain_req_qty > i.dc_min_qty )
                            {
                                if (arrival > item.dt_exp_deli_date)
                                {
                                    //update db
                                    //further process to po
                                }
                            }
                            //request > poa
                            else if (i.dc_remain_qty < item.i_remain_req_qty && item.i_remain_req_qty > i.dc_min_qty)
                            {

                            }
                        });
                    }
                });

                
            }
        }
    }
}
