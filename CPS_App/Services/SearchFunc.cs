using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class SearchFunc
    {
        private readonly DbServices _services;
        public SearchFunc(DbServices dbServices)
        {
            _services = dbServices;
        }
        public async Task SearchParaGenerator(Dictionary<string, string> role)
        {
            if (role.Count == 0)
            {
                return;
            }
            try
            {

                var roleValue = role.Values.FirstOrDefault();
                var obj = new selectObj()
                {
                    table = nameof(tb_search_gen),
                    selecter = new Dictionary<string, string>
                    {
                        {"vc_role_id",roleValue }
                    }
                };
                 var res = await _services.SelectWhereAsync<tb_search_gen>(obj);
                if( res.resCode != 1)
                {
                    return;
                } 
            }
            catch (Exception ex) { }
        }

    }
}
