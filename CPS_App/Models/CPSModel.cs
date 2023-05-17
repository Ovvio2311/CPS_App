using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CPS_App.Models
{
    public class CPSModel
    {
        public class CPSModelBase
        {

        }
        public class tb_location : CPSModelBase
        {
            public int bi_location_id { get; set; }
            public string vc_location_desc { get; set; }
            public string vc_location_addr { get; set; }
        }
        public class tb_staff : CPSModelBase
        {
            public int i_staff_id { get; set; }
            public string vc_staff_role { get; set; }
            public string vc_user_id { get; set; }
            public int bi_location_id { get; set; }
        }
        public class tb_user_roles : CPSModelBase
        {
            public string vc_user_id { get; set; }
            public string vc_role_id { get; set; }
        }
        public class tb_roles : CPSModelBase
        {
            public string vc_role_id { get; set; }
            public string vc_role_name { get; set; }
            public string vc_nor_name { get; set; }
            public string lt_concurrency_stamp { get; set; }
        }
        public class reqObj
        {
            public string table { get; set; }
        }
        public class updateObj : reqObj
        {
            public updateObj()
            {
                updater = new Dictionary<string, string>();
                selecter = new Dictionary<string, string>();
            }
            public Dictionary<string, string> updater { get; set; }
            public Dictionary<string, string> selecter { get; set; }
        }
        public class insertObj : reqObj
        {
            public insertObj()
            {
                inserter = new List<Dictionary<string, string>>();
                selecter = new Dictionary<string, string>();
            }
            public List<Dictionary<string, string>> inserter { get; set; }
            public Dictionary<string, string> selecter { get; set; }
        }
        public class selectObj : reqObj
        {
            public selectObj()
            {
                selecter = new Dictionary<string, string>();
            }
            public Dictionary<string, string> selecter { get; set; }
        }
        public class resObj
        {
            public dynamic result { get; set; }
            public int resCode { get; set; }
        }
        public class CustomRole
        {
            public CustomRole()
            {
                Users = new();
            }
            public string RoleId { get; set; }

            [Required(ErrorMessage = "角色名稱為必填")]
            public string RoleName { get; set; }
            public List<string> Users { get; set; }
        }


        public class CustomUserRole
        {
            public string UserId { get; set; }
            public string UserName { get; set; }
            public bool IsSelected { get; set; }
        }
        public class RequestCreationReq
        {
            public int i_staff_id { get; set; }
            public int bi_location_id { get; set; }
            public DateTime dt_exp_deli_date { get; set; }
            public List<ItemRequest> items { get; set; }
            public RequestCreationReq()
            {
                items = new List<ItemRequest>();
            }
        }        

        public class RequestMappingReqObj
        {
            public int bi_req_id { get; set; }
            public int i_staff_id { get; set; }
            public string vc_staff_role { get; set; }
            public int bi_location_id { get; set; }
            public string vc_location_desc { get; set; }
            public string vc_location_addr { get; set; }
            public string vc_req_status { get; set; }
            public string i_item_req_qty { get; set; }
            public DateTime dt_exp_deli_date { get; set; }
            public List<ItemRequest> item { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }
        public class POATable
        {
            public int bi_poa_id { get; set; }
            public int ti_poa_type_id { get; set; }
            public int bi_item_id { get; set; }
            public string vc_tc_desc { get; set; }
            public string vc_poa_status { get; set; }
            public string vc_order_revision { get; set; }
            public int bi_deli_loc_id { get; set; }
            public string vc_deli_sched_desc { get; set; }
            public int ti_tc_id { get; set; }
            public int bi_supp_id { get; set; }
            public string vc_currency { get; set; }
            public string bi_contract_no { get; set; }
            public DateTime dt_effect_date { get; set; }
            public DateTime dt_updated_datetime { get; set; }
            public int dc_promise_qty { get; set; }
            public int dc_min_qty { get; set; }
            public int i_uom_id { get; set; }
            public double dc_price { get; set; }
            public double dc_amount { get; set; }
            public string vc_reference { get; set; }
            public string bi_quot_no { get; set; }
            public DateTime dt_created_date { get; set; }

        }
        public class ItemRequest
        {
            public int bi_req_id { get; set; }
            public int bi_item_vid { get; set; }
            public int bi_item_id { get; set; }
            public int i_item_req_qty { get; set; }
            public int i_remain_req_qty { get; set; } //need update sql
            public int i_uom_id { get; set; } //need update sql
            public string vc_item_desc { get; set; }
            public int bi_category_id { get; set; }
            public string vc_category_desc { get; set; }
            public string item_req_status { get; set; }
        }
        public class tb_item : CPSModel
        {
            public int bi_item_id { get; set; }
            public string vc_item_desc { get; set; }
            public int bi_category_id { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }

        public class DbResObj
        {
            public dynamic result { get; set; }
            public int response_code { get; set; }
        }
    }
}
