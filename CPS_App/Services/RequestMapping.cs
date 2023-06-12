using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class RequestMapping
    {
        private readonly DbServices _services;
        private ILogger<RequestMapping> _logger;
        public RequestMapping(DbServices services, ILogger<RequestMapping> logger)
        {
            _services = services;
            _logger = logger;
        }
        public async Task<List<RequestMappingReqObj>> RequestMappingObjGetter(string userloc=null, searchObj obj = null)
        {
            var reqMappingObj = new List<RequestMappingReqObj>();
            var res = new List<RequestMappingReqObj>();
            
            var resObj = await _services.GetReqMappingObj(userloc,obj);

            if (resObj.resCode == 1 && resObj.result != null)
            {
                List<List<KeyValuePair<string, object>>> kvp = resObj.result;
                var itemLst = new List<ItemRequest>();
                var mappingLst = new List<RequestMappingReqObj>();

                kvp.ForEach(row =>
                {
                    var mappingObj = new RequestMappingReqObj();
                    var item = new ItemRequest();
                    row.ForEach(col =>
                    {
                        mappingObj.GetType().GetProperties()
                        .Where(prop => col.Key.Equals(prop.Name) && col.Value != null).ToList()
                        .ForEach(p =>
                        {
                            p.SetValue(mappingObj, Convert.ChangeType(col.Value, p.PropertyType), null);
                        });

                        item.GetType().GetProperties()
                        .Where(it => col.Key.Equals(it.Name) && col.Value != null).ToList()
                        .ForEach(i => i.SetValue(item, Convert.ChangeType(col.Value, i.PropertyType), null));
                    });
                    mappingLst.Add(mappingObj);
                    itemLst.Add(item);
                });
                var keylst = mappingLst.GroupBy(g => g.bi_req_id).Select(g => g.Key).ToList();
                //var resres = mappingLst.GroupBy(g => g.bi_req_id).Select(g => g).ToList();
                keylst.ForEach(key =>
                {
                    var resRow = new RequestMappingReqObj();
                    var templst = itemLst.Where(x => x.bi_req_id.Equals(key)).ToList();
                    resRow.GetType().GetProperties().ToList()
                    .ForEach(prop =>
                    {
                        var fstKey = mappingLst.Where(x => x.bi_req_id.Equals(key)).FirstOrDefault();
                        fstKey.GetType().GetProperties().ToList()
                        .ForEach(col =>
                        {
                            if (col.Name.Equals(prop.Name))
                                prop.SetValue(resRow, col.GetValue(fstKey), null);
                            if (prop.Name.Equals("item"))
                                prop.SetValue(resRow, templst, null);
                        });
                    });
                    res.Add(resRow);
                    #region
                    //foreach (var prop in resRow.GetType().GetProperties())
                    //{
                    //  var o =  mappingLst.Where(x => x.bi_req_id.Equals(key)).FirstOrDefault();
                    //    foreach(var col in o.GetType().GetProperties())
                    //    {
                    //        if(col.Name == prop.Name)
                    //        {
                    //            prop.SetValue(resRow, col.GetValue(o), null);
                    //        }
                    //        if (prop.Name.Equals("ItemRequest"))
                    //        {
                    //            prop.SetValue(resRow, templst, null);
                    //        }
                    //    }

                    //}
                    //res.Add(resRow);
                    #endregion
                });

                if (true) //test
                {
                    await RequestMappingScheduler(res);
                }
                //Debug.WriteLine(JsonConvert.SerializeObject(res));
                return res;
                #region
                //foreach (var row in kvp)
                //{


                //    foreach (var col in row)
                //    {

                //        foreach (PropertyInfo prop in mappingObj.GetType().GetProperties())
                //        {
                //            if (col.Key == prop.Name && col.Value != null)
                //            {
                //                prop.SetValue(mappingObj,Convert.ChangeType(col.Value,prop.PropertyType), null);
                //            }


                //            foreach (PropertyInfo it in ItemRequest.GetType().GetProperties())
                //            {
                //                if (col.Key == it.Name && col.Value != null)
                //                {
                //                    it.SetValue(ItemRequest, Convert.ChangeType(col.Value, it.PropertyType), null);
                //                }
                //            }
                //        }
                //        mappingLst.Add(mappingObj);
                //        itemLst.Add(ItemRequest);
                //    }
                //}
                #endregion
            }
            else
            {
                _logger.LogDebug("Request Mapping has no value!");
                return null;
            }

        }
        public async Task RequestMappingScheduler(List<RequestMappingReqObj> reqObj)
        {
            var item_list = new List<ItemRequest>();
            var poaTable = new List<POATableObj>();

            foreach (var row in reqObj)
            {
                if (row.vc_req_status == "pending" && row.item.Count > 0)
                {
                    foreach (var item in row.item)
                    {
                        if (item.item_req_status == "pending" && item.i_remain_req_qty > 0)
                        {
                            item_list.Add(item);
                        }
                    }
                }
            }
            var itemIdLst = item_list.Select(x => x.bi_item_id).ToList();
            string lst = string.Join(",", itemIdLst);
            var poaObj = await _services.GetBPAResult<POATableObj>(lst);
            var inStock = await _services.GetInStockQty();
            if (poaObj.resCode == 1 && poaObj.result.Count > 0)
            {
                poaTable = poaObj.result;
            }
            foreach (var item in item_list)
            {
                var poalst = poaTable.Where(x => x.bi_item_id == item.bi_item_id).Select(p => p).ToList();
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
