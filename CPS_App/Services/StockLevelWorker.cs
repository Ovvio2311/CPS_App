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
        private ILogger<RequestMapping> _logger;
        public StockLevelWorker(DbServices services, ILogger<RequestMapping> logger)
        {
            _services = services;
            _logger = logger;
        }

        public async Task<List<StockLevelViewObj>> GetStockLevelWorker()
        {
            var res = new DbResObj();
            res.resCode = 0;
            //var result = new List<StockLevelViewObj>();
            try
            {
                res = await _services.GetStockLevel();

                if (res.resCode == 1 && res.result != null)
                {
                    return res.result;
                }                
            }
            catch (Exception ex)
            {
                _logger.LogDebug($"Get Stock level error, err_msg: {res.err_msg}");
                throw new Exception(ex.Message); 
                
            }
            return res.result = null;
        }

    }

}
