using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        public async Task<IEnumerable<tb_search_gen>> SearchParaGenerator(ClaimsIdentity identity,string part)
        {
            var res = new DbResObj();
            if (identity.Claims.Count() == 0)
            {
                return null;
            }
            try
            {
                var roleId = identity.Claims.FirstOrDefault(x => x.Type == "role_id").Value;
                var obj = new selectObj()
                {
                    table = nameof(tb_search_gen),
                    selecter = new Dictionary<string, string>
                    {
                        {"vc_role_id",roleId },
                        {"vc_search_part", part}
                    }
                };
                res = await _services.SelectWhereAsync<tb_search_gen>(obj);
                if (res.resCode != 1)
                {
                    return null;
                }
                return res.result;
            }
            catch (Exception ex)
            {
                throw new Exception(res.err_msg);
            }
        }
        public async Task insertJsonString(string vc_role_id, string part, JsonResponse jsonObj)
        {
            try
            {
                //JsonResponse jsonObj = new JsonResponse()
                //{
                //    jsonRes = new Dictionary<string, string>
                //{
                //        { "Request Id", "bi_req_id" },
                //        { "Location","bi_location_id" },
                //        { "Item Name", "vc_item_desc" },
                //        { "Category Type", "vc_category_desc" },
                //        { "Expected Delievery Date","dt_exp_deli_date" },
                //        { "Staff Name","vc_staff_name" }
                //},
               // };
                tb_search_gen obj = new tb_search_gen()
                {
                    vc_role_id = vc_role_id,
                    js_search_para = JsonConvert.SerializeObject(jsonObj.jsonRes),
                    dt_created_date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                    vc_search_part = part,
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
