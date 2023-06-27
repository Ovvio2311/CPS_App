using Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot;
using Microsoft.AspNetCore.Server.HttpSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class ManualMappingProcess
    {
        private GenericTableViewWorker _genericTableViewWorker;
        private readonly DbServices _services;
        public ManualMappingProcess(GenericTableViewWorker genericTableViewWorker, DbServices dbServices)
        {
            _genericTableViewWorker = genericTableViewWorker;
            _services = dbServices;
        }
        public async Task<List<POTableObj>> CheckforOtherPurchaseOrder(List<RequestMappingReqObj> req)
        {
            try
            {
                List<POTableObj> newPoObj = new List<POTableObj>();
                POTableObj pot = new POTableObj();
                searchObj search = new searchObj()
                {
                    searchWords = new Dictionary<string, List<string>>
                {
                    {nameof(pot.ti_po_type_id),new List<string>(){ "1" } }
                }
                };
                List<POTableObj> poObj = await _genericTableViewWorker.GetGenericWorker<POTableObj, PoItemList>(pot.GetSqlQuery(), nameof(pot.bi_po_header_id), null, search);

                foreach (RequestMappingReqObj r in req)
                {
                    r.itemLists.ForEach((y) =>
                    {
                        poObj.ForEach(poObj =>
                        {
                            poObj.itemLists.ForEach(c =>
                            {
                                if(c.bi_item_id == y.bi_item_id)
                                {
                                    POTableObj temp = poObj;
                                    newPoObj.Add(temp);
                                }
                            });
                            
                        });
                        
                    });
                }
                return newPoObj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}