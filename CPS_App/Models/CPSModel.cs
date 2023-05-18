using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.ComponentModel.DataAnnotations;

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
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
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
        public class tb_item : CPSModel
        {
            public int bi_item_id { get; set; }
            public string vc_item_desc { get; set; }
            public int bi_category_id { get; set; }
            public int i_uom_id { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }
       public class tb_item_vid_mapping : CPSModel
        {
            public int bi_item_id { get; set; }
            public int bi_item_vid { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }
        public class tb_item_unit : CPSModel
        {
            public int bi_item_id { get; set; }
            public int bi_location_id { get; set; }            
            public int i_item_qty { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }

        //public class CustomRole
        //{
        //    public CustomRole()
        //    {
        //        Users = new();
        //    }
        //    public string RoleId { get; set; }

        //    [Required(ErrorMessage = "角色名稱為必填")]
        //    public string RoleName { get; set; }
        //    public List<string> Users { get; set; }
        //}


        //public class CustomUserRole
        //{
        //    public string UserId { get; set; }
        //    public string UserName { get; set; }
        //    public bool IsSelected { get; set; }
        //}
        public class RequestCreationReq
        {
            [Display(Name = "Staff Id")]
            public int i_staff_id { get; set; }
            [Display(Name = "bi_location_id")]
            public int bi_location_id { get; set; }
            
            public List<RequestionCreationItem> items { get; set; }
            public RequestCreationReq()
            {
                items = new List<RequestionCreationItem>();
            }
        }
        public class RequestionCreationItem
        {
            [Display(Name = "Request Id")]
            public int bi_req_id { get; set; }
            [Display(Name = "Item Vid")]
            public int bi_item_vid { get; set; }
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Request Quantity")]
            public int i_item_req_qty { get; set; }
            [Display(Name = "Remain Quanity")]
            public int i_remain_req_qty { get; set; } //need update sql
            [Display(Name = "i_uom_id")]
            public int i_uom_id { get; set; } //need update sql
            [Display(Name = "Request Status")]
            public string vc_req_status { get; set; }
            [Display(Name = "Remark")]
            public string vc_remark { get; set; }
            [Display(Name = "Expected Delievery Date")]
            public DateTime dt_exp_deli_date { get; set; }
        }
        public class RequestMappingReqObj
        {
            [Display(Name = "Request Id")]
            public int bi_req_id { get; set; }
            [Display(Name = "Staff Id")]
            public int i_staff_id { get; set; }
            [Display(Name = "Staff Role")]
            public string vc_staff_role { get; set; }
            [Display(Name = "bi_location_id")]
            public int bi_location_id { get; set; }
            [Display(Name = "Your Location")]
            public string vc_location_desc { get; set; }
            [Display(Name = "Address")]
            public string vc_location_addr { get; set; }
            [Display(Name = "Request Status")]
            public string vc_req_status { get; set; }
            //public string i_item_req_qty { get; set; }            
            public List<ItemRequest> item { get; set; }
            [Display(Name = "Created Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Updated Date")]
            public string dt_updated_datetime { get; set; }
            
        }
        
        public class ItemRequest
        {
            [Display(Name = "Request Id")]
            public int bi_req_id { get; set; }
            [Display(Name = "Item Vid")]
            public int bi_item_vid { get; set; }
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Request Quantity")]
            public int i_item_req_qty { get; set; }
            [Display(Name = "Remain Quanity")]
            public int i_remain_req_qty { get; set; } //need update sql
            [Display(Name = "i_uom_id")]
            public int i_uom_id { get; set; } //need update sql
            [Display(Name = "Item Name")]
            public string vc_item_desc { get; set; }
            [Display(Name = "bi_category_id")]
            public int bi_category_id { get; set; }
            [Display(Name = "Category")]
            public string vc_category_desc { get; set; }
            [Display(Name = "Request Status")]
            public string item_req_status { get; set; }
            [Display(Name = "Expected Delievery Date")]
            public DateTime dt_exp_deli_date { get; set; }
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
        
        
    }
}
