using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class CreateDNServices
    {
        public DbServices _services;
        public CreateDNServices(DbServices services)
        {
            _services = services;
        }
        public async Task<resObj> CreateDnAsync(DeliveryNoteObj obj)
        {
            try
            {
                resObj res = new resObj();
                res.resCode = 0;
                res.err_msg = null;
                res.result = null;

                if (await InsertTableHeader(obj) && await InsertPoLineAsync(obj))
                {
                    res.resCode = 1;
                    res.result = true;
                    res.err_msg = null;

                }

                return res;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
