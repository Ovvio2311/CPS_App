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
    public class POAWorker
    {
        private readonly DbServices _services;
        private ILogger<POAWorker> _logger;

        public POAWorker(DbServices dbServices, ILogger<POAWorker> logger)
        {
            _logger = logger;
            _services = dbServices;
        }
        public async Task<List<POATableObj>> GetPoaWorker()
        {
            var reqPoaList = new List<POATableObj>();
            var res = new List<POATableObj>();
            var resObj = await _services.GetPoaList();
            if (resObj.resCode == 1 && resObj.result != null)
            {
                List<List<KeyValuePair<string, object>>> kvp = resObj.result;
                var itemLst = new List<PoaItemList>();
                var workerLst = new List<POATableObj>();
                kvp.ForEach(row =>
                {
                    var mappingObj = new POATableObj();
                    var item = new PoaItemList();
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
                    workerLst.Add(mappingObj);
                    itemLst.Add(item);
                });
                var keylst = workerLst.GroupBy(g => g.bi_poa_header_id).Select(g => g.Key).ToList();
                keylst.ForEach(key =>
                {
                    var resRow = new POATableObj();
                    var templst = itemLst.Where(x => x.bi_poa_header_id.Equals(key)).ToList();
                    resRow.GetType().GetProperties().ToList()
                    .ForEach(prop =>
                    {
                        var fstKey = workerLst.Where(x => x.bi_poa_header_id.Equals(key)).FirstOrDefault();
                        fstKey.GetType().GetProperties().ToList()
                        .ForEach(col =>
                        {
                            if (col.Name.Equals(prop.Name))
                                prop.SetValue(resRow, col.GetValue(fstKey), null);
                            if (prop.Name.Equals("itemLists"))
                                prop.SetValue(resRow, templst, null);
                        });
                    });
                    res.Add(resRow);
                    
                });
                return res;
            }
            else
            {
                _logger.LogDebug("POA table has no value!");
                return null;
            }
        }
    }
}
