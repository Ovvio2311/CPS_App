using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Printing.IndexedProperties;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class GenericTableViewWorker
    {
        private readonly DbServices _services;
        private ILogger<GenericTableViewWorker> _logger;

        public GenericTableViewWorker(DbServices dbServices, ILogger<GenericTableViewWorker> logger)
        {
            _logger = logger;
            _services = dbServices;
        }
        public async Task<List<T>> GetGenericWorker<T, i>(string sql,string keyName, Dictionary<string,string> loc = null, searchObj obj = null)
            where T : new()
            where i : new()
        {
            var reqPoaList = new List<T>();
            var res = new List<T>();
            var resObj = await _services.GetGenericViewTable(sql,loc, obj);
            if (resObj.resCode == 1 && resObj.result != null)
            {
                List<List<KeyValuePair<string, object>>> kvp = resObj.result;
                var itemLst = new List<i>();
                var workerLst = new List<T>();
                kvp.ForEach(row =>
                {
                    T mappingObj = new T();
                    var item = new i();
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
                var keylst = workerLst.GroupBy(g => g.GetType().GetProperty(keyName)!.GetValue(g)).Select(g => g.Key).ToList();
                //use function to get group by
                //var keyls = workerLst.GroupBy(GroupByExpression<T>(keyName).Compile()).Select(g => g.Key).ToList();
                keylst.ForEach(key =>
                {
                var resRow = new T();

              
                    var templst = itemLst.Where(x => x.GetType().GetProperty(keyName).GetValue(x).Equals(key)).ToList();
                    //var templst = itemLst.Where(x => x.bi_poa_header_id.Equals(key)).ToList();
                    resRow.GetType().GetProperties().ToList()
                    .ForEach(prop =>
                    {
                        var fstKey = workerLst.Where(x => x.GetType().GetProperty(keyName).GetValue(x).Equals(key)).FirstOrDefault();
                        //var fstKey = workerLst.Where(x => x.bi_poa_header_id.Equals(key)).FirstOrDefault();
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

        //public object GetProperty(this object source, string name)
        //{
        //    if (source == null) return null;
        //    var pi = source.GetType().GetProperty(name);
        //    if (pi == null) return null;
        //    return pi.GetValue(source);
        //}
        public Expression<Func<T, object>> GroupByExpression<T>(string propertyName)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var body = Expression.Property(parameter, propertyName);
            return Expression.Lambda<Func<T, object>>(Expression.Convert(body, typeof(object)), parameter);
        }
    }
}

