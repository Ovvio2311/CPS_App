using Newtonsoft.Json;
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
        public async Task<string> SearchParaGenerator(Dictionary<string, string> role)
        {
            var res = new DbResObj();
            if (role.Count == 0)
            {
                return null;
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
                 res = await _services.SelectWhereAsync<tb_search_gen>(obj);
                if (res.resCode != 1)
                {
                    return null;
                }
                return res.result.js_search_para;
            }
            catch (Exception ex) 
            {
                throw new Exception(res.err_msg);
            }
        }
        public async Task insertJsonString()
        {
            try
            {
                JsonResponse jsonObj = new JsonResponse()
                {
                    jsonRes = new List<string>()
                {
                    "Request Id", "Location", "Item Name", "Category Type","Expected Delievery Date","Staff Name"
                },
                };
                tb_search_gen obj = new tb_search_gen()
                {
                    vc_role_id = "5ac89490-fdb3-4cfa-9adb-a3959e63524a",
                    js_search_para = JsonConvert.SerializeObject(jsonObj.jsonRes),
                    dt_created_date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
                };
                var res = await _services.InsertAsync<tb_search_gen>(obj);
                if (res.resCode != 1 || res.err_msg != null)
                {
                    MessageBox.Show($"insert error\n{res.err_msg}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
