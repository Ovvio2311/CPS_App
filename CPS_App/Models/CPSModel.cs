﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace CPS_App.Models
{
    public class CPSModel
    {
        public class MaintenanceInstance
        {
            public tb_location location { get; set; }
            public tb_users users { get; set; }
            public lut_uom_type uom { get; set; }
            public lut_poa_type poa { get; set; }
            public tb_po_type po { get; set; }
            public lut_deli_schedule_type deli { get; set; }
            public lut_term_and_con tc { get; set; }
            public tb_supplier supplier { get; set; }
            public tb_roles role { get; set; }

        }
        public class CPSModelBase
        {

        }
        public class tb_location : CPSModelBase
        {
            [Display(Name = "ID")]
            public int bi_location_id { get; set; }
            [Display(Name = "Location")]
            public string vc_location_desc { get; set; }
            [Display(Name = "Address")]
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
            [Display(Name = "ID")]
            public string vc_role_id { get; set; }
            [Display(Name = "Name")]
            public string vc_role_name { get; set; }
            [Display(Name = "Nor Name")]
            public string vc_nor_name { get; set; }
            [Display(Name = "Create Date")]
            public string lt_concurrency_stamp { get; set; }
        }
        public class tb_users : CPSModelBase
        {
            [Display(Name = "ID")]
            public string vc_user_id { get; set; }
            [Display(Name = "Email")]
            public string vc_email { get; set; }
            [Display(Name = "UserName")]
            public string vc_user_name { get; set; }
            [Display(Name = "Access Fail Count")]
            public int i_access_failed_count { get; set; }
        }
        public class tb_item : CPSModelBase
        {
            public int bi_item_id { get; set; }
            public string vc_item_desc { get; set; }
            public int bi_category_id { get; set; }
            public int i_uom_id { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }

       public class tb_item_vid_mapping : CPSModelBase
        {
            public int bi_item_id { get; set; }
            public int bi_item_vid { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }
        public class tb_item_unit : CPSModelBase
        {
            public int bi_item_id { get; set; }
            public int bi_location_id { get; set; }
            public int i_item_qty { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }

        public class tb_item_category : CPSModelBase
        {
            public int bi_category_id { get; set; }
            public string vc_category_desc { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }
        public class lut_uom_type : CPSModelBase
        {
            [Display(Name = "ID")]
            public int i_uom_id { get; set; }
            [Display(Name = "Name")]
            public string vc_uom_desc { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public string dt_updated_datetime { get; set; }
        }
        public class lut_poa_type : CPSModelBase
        {
            [Display(Name = "ID")]
            public int ti_poa_type_id { get; set; }
            [Display(Name = "Name")]
            public string vc_poa_type_desc { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public string dt_updated_datetime { get; set; }
        }
        public class tb_supplier : CPSModelBase
        {
            [Display(Name = "ID")]
            public int bi_supp_id { get; set; }
            [Display(Name = "Name")]
            public string vc_supp_desc { get; set; }
            [Display(Name = "Address")]
            public string vc_supp_addr { get; set; }
            [Display(Name = "Contract")]
            public string vc_supp_contact { get; set; }
            [Display(Name = "Contract No.")]
            public string vc_supp_contact_no { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public string dt_updated_datetime { get; set; }
        }
        public class lut_term_and_con: CPSModelBase
        {
            [Display(Name = "ID")]
            public int ti_tc_id { get; set; }
            [Display(Name = "Name")]
            public string vc_tc_desc { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public string dt_updated_datetime { get; set; }
        }

        public class lut_deli_schedule_type: CPSModelBase
        {
            [Display(Name = "ID")]
            public int ti_deli_sched_id { get; set; }
            [Display(Name = "Name")]
            public string vc_deli_sched_desc { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public string dt_updated_datetime { get; set; }
        }
        public class tb_po_type : CPSModelBase
        {
            [Display(Name = "ID")]
            public int ti_po_type_id { get; set; }
            [Display(Name = "Name")]
            public string vc_po_type_desc { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
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

        //create req
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

        //req view
        public class RequestMappingReqObj
        {
            [Display(Name = "Request Id")]
            public int bi_req_id { get; set; }
            [Display(Name = "Staff Id")]
            public int i_staff_id { get; set; }
            [Display(Name = "Staff Role")]
            public string vc_staff_role { get; set; }
            [Display(Name = "nil")]
            public int bi_location_id { get; set; }
            [Display(Name = "Your Location")]
            public string vc_location_desc { get; set; }
            [Display(Name = "nil")]
            public string vc_location_addr { get; set; }
            [Display(Name = "Request Status")]
            public string vc_req_status { get; set; }
            //public string i_item_req_qty { get; set; }            
            public List<ItemRequest> item { get; set; }
            [Display(Name = "nil")]
            public string dt_created_date { get; set; }
            [Display(Name = "nil")]
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

        //item view
        public class StockLevelViewObj
        {
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Item Vid")]
            public int bi_item_vid { get; set; }
            [Display(Name = "Item Name")]
            public string vc_item_desc { get; set; }
            [Display(Name = "bi_category_id")]
            public int bi_category_id { get; set; }
            [Display(Name = "Category")]
            public string vc_category_desc { get; set; }
            [Display(Name = "i_uom_id")]
            public int i_uom_id { get; set; }
            [Display(Name = "Unit of Measurement")]
            public string vc_uom_desc { get; set; }
            [Display(Name = "bi_location_id")]
            public int bi_location_id { get; set; }
            [Display(Name = "Location")]
            public string vc_location_desc { get; set; }
            [Display(Name = "Quantity")]
            public int i_item_qty { get; set; }
            [Display(Name = "items_group")]
            public string items_group { get; set; }
            [Display(Name = "Created Date")]
            public DateTime dt_created_date { get; set; }
            [Display(Name = "Updated Date")]
            public DateTime dt_updated_datetime { get; set; }
        }

        public class POATableObj
        {
            public POATableObj()
            {
                itemLists = new List<PoaItemList>();
            }
            [Display(Name = "Poa Id")]
            public int bi_poa_id { get; set; }
            [Display(Name = "Poa Header Id")]
            public int bi_poa_header_id { get; set; }
            [Display(Name = "Type")]
            public int ti_poa_type_id { get; set; }
            [Display(Name = "Status")]
            public string vc_poa_status { get; set; }
            [Display(Name = "bi_deli_loc_id")]
            public int bi_deli_loc_id { get; set; }
            [Display(Name = "Delivery Location")]
            public string vc_location_desc { get; set; }
            [Display(Name = "bi_supp_id")]
            public int bi_supp_id { get; set; }
            [Display(Name = "Supplier")]
            public string vc_supp_desc { get; set; }
            [Display(Name = "currency")]
            public string vc_currency { get; set; }
            [Display(Name = "ti_tc_id")]
            public int ti_tc_id { get; set; }
            [Display(Name = "Terms and Conditions")]
            public string vc_tc_desc { get; set; }
            [Display(Name = "ti_deli_sched_id")]
            public int ti_deli_sched_id { get; set; }
            [Display(Name = "Delivery Schedule")]
            public string vc_deli_sched_desc { get; set; }
            [Display(Name = "Effective Date")]
            public DateTime dt_effect_date { get; set; }
            [Display(Name = "Contract No")]
            public string bi_contract_no { get; set; }
            [Display(Name = "Create Date")]
            public DateTime dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public DateTime dt_updated_datetime { get; set; }
            [Display(Name = "itemLists")]
            public List<PoaItemList> itemLists { get; set; }
        }
        public class PoaItemList
        {
            [Display(Name = "Poa line Id")]
            public int bi_poa_line_id { get; set; }
            [Display(Name = "Poa Header Id")]
            public int bi_poa_header_id { get; set; }
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Item")]
            public string vc_item_desc { get; set; }
            [Display(Name = "Supplier Item Id")]
            public int bi_supp_item_id { get; set; }
            [Display(Name = "Promise Qty")]
            public decimal dc_promise_qty { get; set; }
            [Display(Name = "i_uom_id")]
            public int i_uom_id { get; set; }
            [Display(Name = "Unit of Measurement")]
            public string vc_uom_desc { get; set; }
            [Display(Name = "Min Qty")]
            public decimal dc_min_qty { get; set; }
            [Display(Name = "Price")]
            public decimal dc_price { get; set; }
            [Display(Name = "Amount")]
            public decimal dc_amount { get; set; }
            [Display(Name = "Reference")]
            public string vc_reference { get; set; }
            [Display(Name = "Quotation No.")]
            public string bi_quot_no { get; set; }

        }

    }
}
