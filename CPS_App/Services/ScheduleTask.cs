﻿using Microsoft.Extensions.Logging;
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

        public ScheduleTask(DbServices dbServices, ILogger<ScheduleTask> logger, POAWorker pOAWorker, RequestMapping requestMapping)
        {
            _services = dbServices;
            _logger = logger;
            _pOAWorker = pOAWorker;
            _requestMapping = requestMapping;
        }
        public async Task RequestMappingScheduler(List<RequestMappingReqObj> reqObj)
        {
            searchObj reqse = new searchObj()
            {
                searchWords = new Dictionary<string, string>
                {
                    {"vc_req_status", "1"}
                }
            };
            var item_list = new List<ItemRequest>();
            var poaTable = new List<POATableObj>();

            foreach (RequestMappingReqObj row in reqObj)
            {
                if (row.i_map_stat_id == 1 && row.item.Count > 0)
                {
                    foreach (ItemRequest item in row.item)
                    {
                        if (item.i_map_stat_id == 1 && item.i_remain_req_qty > 0)
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
                searchWords = new Dictionary<string, string>
                {
                    {"bi_poa_status_id","1" },
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
            var inStock = await _services.GetInStockQty();//warehouse part

            foreach (var item in item_list)
            {
                poaObj.ForEach(row =>
                {
                    if (row.itemLists.Count > 0)
                    {
                        row.itemLists.Where(x => x.bi_item_id == item.bi_item_id).ToList().ForEach(i =>
                        {
                            //poa > request
                            if (i.dc_remain_qty > item.i_remain_req_qty && item.i_remain_req_qty > i.dc_min_qty)
                            {
                                var day = row.vc_deli_sched_desc.Split(' ');
                                DateTime arrival = DateTime.Now.AddDays(GenUtil.ConvertObjtoType<int>(day.ElementAt(0)));
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

                if (poalst.Count > 0)
                {
                    poalst.ForEach(row =>
                    {
                        if (row.dc_promise_qty > item.i_remain_req_qty && item.i_remain_req_qty > row.dc_min_qty)
                        {
                            //update db
                            //further process to po
                            return;
                        }
                        else if (row.dc_promise_qty < item.i_remain_req_qty && item.i_remain_req_qty > row.dc_min_qty)
                        {
                            //update db 
                            //further process to po 
                            //continue check remaining item qty
                        }
                    });
                }
            }
        }
    }
}
