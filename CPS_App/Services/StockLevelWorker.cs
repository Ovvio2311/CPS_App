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
    public class StockLevelWorker
    {
        private readonly DbServices _services;
        private ILogger<StockLevelWorker> _logger;
        public StockLevelWorker(DbServices services, ILogger<StockLevelWorker> logger)
        {
            _services = services;
            _logger = logger;
        }

        public async Task<List<StockLevelViewObj>> GetStockLevelWorker(string userLoc = null, searchObj obj = null)
        {
            var stockviewobj = new List<StockLevelViewObj>();
            var res = new List<StockLevelViewObj>();
            var resObj = new DbResObj();
            //var resObjult = new List<StockLevelViewObj>();
            try
            {
                resObj = await _services.GetStockLevel(userLoc, obj);

                if (resObj.resCode == 1 && resObj.result != null)
                {
                    List<List<KeyValuePair<string, object>>> kvp = resObj.result;
                    var itemLst = new List<StockLevelSubItem>();
                    var mappingLst = new List<StockLevelViewObj>();

                    kvp.ForEach(row =>
                    {
                        var mappingObj = new StockLevelViewObj();
                        var item = new StockLevelSubItem();
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
                    var keylst = mappingLst.GroupBy(g => g.bi_item_id).Select(g => g.Key).ToList();
                    //var resObjresObj = mappingLst.GroupBy(g => g.bi_req_id).Select(g => g).ToList();
                    keylst.ForEach(key =>
                    {
                        var resRow = new StockLevelViewObj();
                        var templst = itemLst.Where(x => x.bi_item_id.Equals(key)).ToList();
                        resRow.GetType().GetProperties().ToList()
                        .ForEach(prop =>
                        {
                            var fstKey = mappingLst.Where(x => x.bi_item_id.Equals(key)).FirstOrDefault();
                            fstKey.GetType().GetProperties().ToList()
                            .ForEach(col =>
                            {
                                if (col.Name.Equals(prop.Name))
                                    prop.SetValue(resRow, col.GetValue(fstKey), null);
                                if (prop.Name.Equals("subitem"))
                                    prop.SetValue(resRow, templst, null);
                            });
                        });
                        res.Add(resRow);
                        
                    });
                    return res;
                }
            }
            catch (Exception ex)
            {
                _logger.LogDebug($"Get Stock level error, err_msg: {resObj.err_msg}");
                throw new Exception(ex.Message);

            }
            return null;
        }

    }

}
