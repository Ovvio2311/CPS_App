using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
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
            public role_claim_table role_Claim { get; set; }

        }
        public class CPSModelBase
        {

        }
        public class role_claim_table
        {
            [Display(Name = "ID")]
            public int i_claim_id { get; set; }
            [Display(Name = "Role_id")]
            public string vc_role_id { get; set; }
            [Display(Name = "Role Name")]
            public string vc_role_name { get; set; }
            [Display(Name = "Role Type")]
            public string vc_claim_type { get; set; }
            [Display(Name = "Role value")]
            public string vc_claim_value { get; set; }
        }
        public class lut_poa_status
        {
            [Display(Name = "ID")]
            public int bi_poa_status_id { get; set; }
            [Display(Name = "Name")]
            public string vc_poa_status_desc { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public string dt_updated_datetime { get; set; }
        }
        public class lut_po_status
        {
            [Display(Name = "ID")]
            public int bi_po_status_id { get; set; }
            [Display(Name = "Name")]
            public string vc_po_status_desc { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public string dt_updated_datetime { get; set; }
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
            public string vc_staff_name { get; set; }
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
        public class lut_currency : CPSModelBase
        {
            [Display(Name = "ID")]
            public int i_cur_id { get; set; }
            [Display(Name = "currency")]
            public string vc_cur_desc { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }
        public class tb_item_vid_mapping : CPSModelBase
        {
            public int bi_item_id { get; set; }
            public int bi_item_vid { get; set; }
            public string bi_prefer_loc_id { get; set; }
            public string dt_created_date { get; set; }
            public string dt_updated_datetime { get; set; }
        }
        public class tb_item_unit : CPSModelBase
        {
            public int bi_item_id { get; set; }
            public int bi_location_id { get; set; }
            public int i_uom_id { get; set; }
            public int bi_supp_id { get; set; }
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
            [Display(Name = "is_ref")]
            public bool b_is_ref_type { get; set; }
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
        public class lut_term_and_con : CPSModelBase
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

        public class lut_deli_schedule_type : CPSModelBase
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
            [Display(Name = "is_ref")]
            public bool b_is_ref_type { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public string dt_updated_datetime { get; set; }
        }
        public class tb_search_gen : CPSModelBase
        {
            [Display(Name = "ID")]
            public int i_search_id { get; set; }
            [Display(Name = "Role Id")]
            public string vc_role_id { get; set; }
            [Display(Name = "Json")]
            public string js_search_para { get; set; }
            [Display(Name = "Search Part")]
            public string vc_search_part { get; set; }
            [Display(Name = "Create Date")]
            public string dt_created_date { get; set; }
            [Display(Name = "Update Date")]
            public string dt_updated_datetime { get; set; }
        }
        public class JsonResponse : CPSModelBase
        {
            public Dictionary<string, string> jsonRes { get; set; }
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
            [Display(Name = "Item Name")]
            public string vc_item_desc { get; set; }
            [Display(Name = "Request Quantity")]
            public int i_item_req_qty { get; set; }
            [Display(Name = "Remain Quanity")]
            public int i_remain_req_qty { get; set; }
            [Display(Name = "i_uom_id")]
            public int i_uom_id { get; set; }
            [Display(Name = "not_shown")]
            public int bi_supp_id { get; set; }
            [Display(Name = "Mapping Id")]
            public int i_map_stat_id { get; set; }
            [Display(Name = "Po Status Id")]
            public int bi_po_status_id { get; set; }
            [Display(Name = "Remark")]
            public string vc_remark { get; set; }
            [Display(Name = "Expected Delievery Date")]
            public string dt_exp_deli_date { get; set; }
        }

        //req view
        public class RequestMappingReqObj
        {
            public RequestMappingReqObj() 
            {
                itemLists = new List<ItemRequest>();
            }
            
            [Display(Name = "Request Id")]
            public int bi_req_id { get; set; }
            [Display(Name = "Staff Id")]
            public int i_staff_id { get; set; }
            [Display(Name = "Staff Name")]
            public string vc_staff_name { get; set; }
            [Display(Name = "Staff Role")]
            public string vc_staff_role { get; set; }
            [Display(Name = "not_shown")]
            public int i_map_stat_id { get; set; }
            [Display(Name = "Mapping Status")]
            public string vc_req_status { get; set; }
            [Display(Name = "not_shown")]
            public int bi_location_id { get; set; }
            [Display(Name = "Location")]
            public string vc_location_desc { get; set; }
            [Display(Name = "not_shown")]
            public string vc_location_addr { get; set; }
            [Display(Name = "not_shown")]
            public List<ItemRequest> itemLists { get; set; }
            [Display(Name = "not_shown")]
            public string dt_created_date { get; set; }
            [Display(Name = "not_shown")]
            public string dt_updated_datetime { get; set; }
            public string GetSqlQuery()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($@"SELECT * FROM
                         (SELECT 
                             req.bi_req_id, req.i_staff_id, sta.vc_staff_name, sta.vc_staff_role, req.i_map_stat_id, 
                             stat.vc_status_desc vc_req_status, sta.bi_location_id, loc.vc_location_desc, 
                             loc.vc_location_addr, req.dt_created_date, req.dt_updated_datetime
                         FROM
                             tb_request req
                         INNER JOIN tb_staff sta ON req.i_staff_id = sta.i_staff_id
                         INNER JOIN tb_location loc ON sta.bi_location_id = loc.bi_location_id
                         left join lut_mapping_status stat on req.i_map_stat_id = stat.i_map_stat_id
                         ) a
                             LEFT JOIN
                         (SELECT * FROM
                             (SELECT 
                             det.bi_req_id det_bi_req_id, mapp.bi_item_vid, det.bi_item_id, det.i_item_req_qty, det.i_remain_req_qty, det.i_uom_id, 
                             det.i_hd_map_stat_id, stat.vc_status_desc item_mapping_status, postat.bi_po_status_id, 
                             postat.vc_po_status_desc, det.dt_exp_deli_date, uom.vc_uom_desc, it.vc_item_desc, 
                             it.bi_category_id, cat.vc_category_desc
                         FROM
                             tb_request_detail det
	                     LEFT JOIN tb_item it ON det.bi_item_id = it.bi_item_id
                         INNER JOIN tb_item_category cat ON it.bi_category_id = cat.bi_category_id
                         left join lut_uom_type uom on det.i_uom_id = uom.i_uom_id
                         left join lut_mapping_status stat on det.i_hd_map_stat_id = stat.i_map_stat_id
                         left join lut_po_status postat on det.bi_po_status_id = postat.bi_po_status_id
                         LEFT JOIN tb_item_vid_mapping mapp ON it.bi_item_id = mapp.bi_item_id) b) c 
                         ON a.bi_req_id = det_bi_req_id ");

                return sb.ToString();
            }
        }

        public class ItemRequest
        {
            [Display(Name = "not_shown")]
            public int bi_req_id { get; set; }
            [Display(Name = "Item Vid")]
            public int bi_item_vid { get; set; }
            [Display(Name = "not_shown")]
            public int bi_item_id { get; set; }
            [Display(Name = "not_shown")]
            public int i_item_req_qty { get; set; }
            [Display(Name = "Remain Quanity")]
            public int i_remain_req_qty { get; set; } //need update sql
            [Display(Name = "not_shown")]
            public int i_uom_id { get; set; } //need update sql
            [Display(Name = "Item Name")]
            public string vc_item_desc { get; set; }
            [Display(Name = "not_shown")]
            public int bi_category_id { get; set; }
            [Display(Name = "Category")]
            public string vc_category_desc { get; set; }
            [Display(Name = "not_shown")]
            public int i_hd_map_stat_id { get; set; }
            [Display(Name = "Mapping Status")]
            public string item_mapping_status { get; set; }
            [Display(Name = "not_shown")]
            public int bi_po_status_id { get; set; }
            [Display(Name = "PO Status")]
            public string vc_po_status_desc { get; set; }
            [Display(Name = "Expected Delievery Date")]
            public DateTime dt_exp_deli_date { get; set; }
        }

        //item view
        public class StockLevelViewObj
        {
            public StockLevelViewObj() {
                itemLists = new List<StockLevelSubItem>();
                sql = @"SELECT * FROM
                         (SELECT 
                             it.bi_item_id,
                                 vid.bi_item_vid,
                                 vc_item_desc,
                                 it.bi_category_id,
                                 cat.vc_category_desc,
                                 it.i_uom_id,
                                 uom.vc_uom_desc,
                                 uni.bi_location_id,
                                 loc.vc_location_desc,
                                 i_item_qty,
                                 it.dt_created_date,
                                 it.dt_updated_datetime
                         FROM
                             tb_item it
                         INNER JOIN tb_item_category cat ON it.bi_category_id = cat.bi_category_id
                         INNER JOIN tb_item_vid_mapping vid ON it.bi_item_id = vid.bi_item_id
                         LEFT JOIN tb_item_unit uni ON it.bi_item_id = uni.bi_item_id
                         LEFT JOIN tb_location loc ON uni.bi_location_id = loc.bi_location_id
                         LEFT JOIN lut_uom_type uom ON it.i_uom_id = uom.i_uom_id
                         )a ";
            }
            [Display(Name = "not_shown")]
            public string sql { get; set; }
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Item Vid")]
            public int bi_item_vid { get; set; }
            [Display(Name = "Item Name")]
            public string vc_item_desc { get; set; }
            [Display(Name = "not_shown")]
            public int bi_category_id { get; set; }
            [Display(Name = "Category")]
            public string vc_category_desc { get; set; }
            [Display(Name = "not_shown")]
            public int i_uom_id { get; set; }
            [Display(Name = "Unit of Measurement")]
            public string vc_uom_desc { get; set; }
            [Display(Name = "not_shown")]
            public List<StockLevelSubItem> itemLists { get; set; }

        }
        public class StockLevelSubItem
        {
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Item Name")]
            public string vc_item_desc { get; set; }
            [Display(Name = "not_shown")]
            public int bi_location_id { get; set; }
            [Display(Name = "Location")]
            public string vc_location_desc { get; set; }
            [Display(Name = "Quantity")]
            public int i_item_qty { get; set; }
            [Display(Name = "not_shown")]
            public string items_group { get; set; }
            [Display(Name = "not_shown")]
            public DateTime dt_created_date { get; set; }
            [Display(Name = "not_shown")]
            public DateTime dt_updated_datetime { get; set; }
        }
        public class CreateStockObj
        {
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Item Vid")]
            public int bi_item_vid { get; set; }
            [Display(Name = "Item Name")]
            public string vc_item_desc { get; set; }
            [Display(Name = "not_shown")]
            public int bi_category_id { get; set; }
            [Display(Name = "Category")]
            public string vc_category_desc { get; set; }
            [Display(Name = "not_shown")]
            public int bi_location_id { get; set; }
            [Display(Name = "Location")]
            public string vc_location_desc { get; set; }
            [Display(Name = "not_shown")]
            public int i_uom_id { get; set; }
            [Display(Name = "Unit of Measurement")]
            public string vc_uom_desc { get; set; }
            [Display(Name = "Supplier Id")]
            public int bi_supp_id { get; set; }
            [Display(Name = "Supplier")]
            public string vc_supp_desc { get; set; }
            [Display(Name = "Quantity")]
            public int i_item_qty { get; set; }
        }
        public class POATableObj
        {
            public POATableObj()
            {
                itemLists = new List<PoaItemList>();             
            }
            [Display(Name = "not_shown")]
            public string sql { get; set; }
            [Display(Name = "Poa Id")]
            public int bi_poa_id { get; set; }
            [Display(Name = "not_shown")]
            public int bi_poa_header_id { get; set; }
            [Display(Name = "not_shown")]
            public int ti_poa_type_id { get; set; }
            [Display(Name = "Type")]
            public string vc_poa_type_desc { get; set; }
            [Display(Name = "not_shown")]
            public long bi_poa_status_id { get; set; }
            [Display(Name = "Status")]
            public string vc_poa_status_desc { get; set; }
            //[Display(Name = "not_shown")]
            //public int bi_deli_loc_id { get; set; }//no need
            //[Display(Name = "Delivery Location")]
            //public string vc_location_desc { get; set; }//no need
            [Display(Name = "not_shown")]
            public int bi_supp_id { get; set; }
            [Display(Name = "Supplier")]
            public string vc_supp_desc { get; set; }
            [Display(Name = "not_shown")]
            public int i_cur_id { get; set; }
            [Display(Name = "currency")]
            public string vc_cur_desc { get; set; }
            [Display(Name = "not_shown")]
            public int ti_tc_id { get; set; }
            [Display(Name = "Terms and Conditions")]
            public string vc_tc_desc { get; set; }
            [Display(Name = "not_shown")]
            public int ti_deli_sched_id { get; set; }
            [Display(Name = "Delivery Schedule")]
            public string vc_deli_sched_desc { get; set; }
            [Display(Name = "Effective Date")]
            public string dt_effect_date { get; set; }
            [Display(Name = "Contract No")]
            public string vc_contract_no { get; set; }
            [Display(Name = "not_shown")]
            public string dt_created_date { get; set; }
            [Display(Name = "not_shown")]
            public string dt_updated_datetime { get; set; }
            [Display(Name = "not_shown")]
            public List<PoaItemList> itemLists { get; set; }
            public string GetSqlQuery()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select * from (
	                     select poa.bi_poa_id, poa.ti_poa_type_id, poatype.vc_poa_type_desc, poa.bi_poa_status_id, poast.vc_poa_status_desc, hd.bi_poa_header_id,
                         hd.bi_supp_id, sup.vc_supp_desc, hd.i_cur_id, cur.vc_cur_desc , hd.ti_tc_id, tc.vc_tc_desc, 
                         hd.ti_deli_sched_id, delisc.vc_deli_sched_desc, DATE_FORMAT(hd.dt_effect_date, '%Y-%m-%d %H:%i:%s') dt_effect_date, hd.vc_contract_no, ln.bi_poa_line_id, ln.bi_item_id, it.vc_item_desc, 
                         ln.bi_supp_item_id, ln.i_promise_qty, ln.i_remain_qty, uom.vc_uom_desc, ln.i_uom_id, ln.i_min_qty, ln.i_price, ln.i_amount, ln.vc_reference, ln.vc_quot_no,
                         poa.dt_created_date, poa.dt_updated_datetime
                         from tb_poa poa
                         inner join tb_poa_header hd on poa.bi_poa_id = hd.bi_poa_id
                         left join tb_poa_line ln on hd.bi_poa_header_id = ln.bi_poa_header_id
                         inner join tb_supplier sup on hd.bi_supp_id = sup.bi_supp_id
                         inner join lut_term_and_con tc on hd.ti_tc_id = tc.ti_tc_id
                         inner join lut_deli_schedule_type delisc on hd.ti_deli_sched_id = delisc.ti_deli_sched_id
                         left join tb_item it on ln.bi_item_id = it.bi_item_id
                         left join lut_uom_type uom on ln.i_uom_id = uom.i_uom_id
                         left join lut_poa_type poatype on poa.ti_poa_type_id = poatype.ti_poa_type_id                         
                         left join lut_poa_status poast on poa.bi_poa_status_id = poast.bi_poa_status_id
                         left join lut_currency cur on hd.i_cur_id = cur.i_cur_id
                         ) a ");
                return sb.ToString();
            }
        }
        public class PoaItemList
        {
            [Display(Name = "Poa line Id")]
            public int bi_poa_line_id { get; set; }
            [Display(Name = "not_shown")]
            public int bi_poa_header_id { get; set; }
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Item")]
            public string vc_item_desc { get; set; }
            [Display(Name = "Supplier Item Id")]
            public string bi_supp_item_id { get; set; }
            [Display(Name = "Promise Qty")]
            public int i_promise_qty { get; set; }//add remain qty
            [Display(Name = "Remain Qty")]
            public int i_remain_qty { get; set; }
            [Display(Name = "not_shown")]
            public int i_uom_id { get; set; }
            [Display(Name = "Unit of Measurement")]
            public string vc_uom_desc { get; set; }
            [Display(Name = "Min Qty")]
            public int i_min_qty { get; set; }
            [Display(Name = "Price")]
            public int i_price { get; set; }
            [Display(Name = "Amount")]
            public int i_amount { get; set; }
            [Display(Name = "not_shown")]
            public string vc_deli_sched_desc { get; set; }
            [Display(Name = "Reference")]
            public string vc_reference { get; set; }
            [Display(Name = "not_shown")]
            public string vc_quot_no { get; set; }

        }
        //Vip Mapping Table
        public class VidMappingObj
        {
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Item Vid")]
            public int bi_item_vid { get; set; }
            [Display(Name = "Item Name")]
            public string vc_item_desc { get; set; }
            [Display(Name = "not_shown")]
            public int bi_category_id { get; set; }
            [Display(Name = "Category")]
            public string vc_category_desc { get; set; }
            [Display(Name = "not_shown")]
            public int bi_prefer_loc_id { get; set; }
            [Display(Name = "Location")]
            public string vc_location_desc { get; set; }
            [Display(Name = "not_shown")]
            public string items_group { get; set; }
            [Display(Name = "not_shown")]
            public string prefer_loc_group { get; set; }
            [Display(Name = "not_shown")]
            public string item_loc_id_group { get; set; }
        }

        //public class PoCreateObj
        //{
        //    public PoCreateObj()
        //    {
        //        itemLists = new List<PoCreateItem>();
        //    }
        //    [Display(Name = "Po Id")]
        //    public int bi_po_id { get; set; }
        //    [Display(Name = "Poa Id")]
        //    public int bi_poa_id { get; set; }
        //    [Display(Name = "not_shown")]
        //    public int bi_po_header_id { get; set; }
        //    [Display(Name = "not_shown")]
        //    public int ti_po_type_id { get; set; }
        //    [Display(Name = "Type")]
        //    public string vc_po_type_desc { get; set; }
        //    [Display(Name = "not_shown")]
        //    public long bi_po_status_id { get; set; }
        //    [Display(Name = "Status")]
        //    public string vc_po_status_desc { get; set; }
        //    [Display(Name = "not_shown")]
        //    public int bi_deli_loc_id { get; set; }//no need
        //    [Display(Name = "Delivery Location")]
        //    public string vc_location_desc { get; set; }//no need
        //    [Display(Name = "not_shown")]
        //    public int bi_supp_id { get; set; }
        //    [Display(Name = "Supplier")]
        //    public string vc_supp_desc { get; set; }
        //    [Display(Name = "not_shown")]
        //    public int i_cur_id { get; set; }
        //    [Display(Name = "currency")]
        //    public string vc_cur_desc { get; set; }
        //    [Display(Name = "not_shown")]
        //    public int ti_tc_id { get; set; }
        //    [Display(Name = "Terms and Conditions")]
        //    public string vc_tc_desc { get; set; }
        //    //[Display(Name = "not_shown")]
        //    //public int ti_deli_sched_id { get; set; }
        //    //[Display(Name = "Delivery Schedule")]
        //    //public string vc_deli_sched_desc { get; set; }
        //    [Display(Name = "Effective Date")]
        //    public string dt_effect_date { get; set; }
        //    //[Display(Name = "Contract No")]
        //    //public string vc_contract_no { get; set; }
        //    [Display(Name = "not_shown")]
        //    public string dt_created_date { get; set; }
        //    [Display(Name = "not_shown")]
        //    public string dt_updated_datetime { get; set; }
        //    [Display(Name = "not_shown")]
        //    public List<PoCreateItem> itemLists { get; set; }
        //}
        //public class PoCreateItem
        //{
        //    [Display(Name = "Po line Id")]
        //    public int bi_po_line_id { get; set; }
        //    [Display(Name = "not_shown")]
        //    public int bi_po_header_id { get; set; }
        //    [Display(Name = "Item Id")]
        //    public int bi_item_id { get; set; }
        //    [Display(Name = "Item")]
        //    public string vc_item_desc { get; set; }
        //    [Display(Name = "Supplier Item Id")]
        //    public string bi_supp_item_id { get; set; }
        //    [Display(Name = "Remain Qty")]
        //    public int i_actual_qty { get; set; }
        //    [Display(Name = "not_shown")]
        //    public int i_uom_id { get; set; }
        //    [Display(Name = "Unit of Measurement")]
        //    public string vc_uom_desc { get; set; }
        //    [Display(Name = "Price")]
        //    public int i_price { get; set; }
        //    [Display(Name = "Amount")]
        //    public int dc_act_amount { get; set; }
        //    [Display(Name = "Reference")]
        //    public string vc_reference { get; set; }
        //    [Display(Name = "not_shown")]
        //    public string vc_quot_no { get; set; }

        //}
        public class POTableObj
        {
            public POTableObj()
            {
                itemLists = new List<PoItemList>();               
            }
                        
            [Display(Name = "Po Id")]
            public int bi_po_id { get; set; }
            [Display(Name = "Ref Id")]
            public string vc_ref_id { get; set; }
            [Display(Name = "not_shown")]
            public int bi_po_header_id { get; set; }
            [Display(Name = "not_shown")]
            public int ti_po_type_id { get; set; }
            [Display(Name = "Type")]
            public string vc_po_type_desc { get; set; }
            [Display(Name = "not_shown")]
            public long bi_po_status_id { get; set; }
            [Display(Name = "Status")]
            public string vc_po_status_desc { get; set; }
            [Display(Name = "not_shown")]
            public int bi_deli_loc_id { get; set; }//no need
            [Display(Name = "Delivery Location")]
            public string vc_location_desc { get; set; }//no need
            [Display(Name = "not_shown")]
            public int bi_supp_id { get; set; }
            [Display(Name = "Supplier")]
            public string vc_supp_desc { get; set; }
            [Display(Name = "not_shown")]
            public int i_cur_id { get; set; }
            [Display(Name = "currency")]
            public string vc_cur_desc { get; set; }
            [Display(Name = "not_shown")]
            public int ti_tc_id { get; set; }
            [Display(Name = "Terms and Conditions")]
            public string vc_tc_desc { get; set; }
            [Display(Name = "not_shown")]
            public int ti_deli_sched_id { get; set; }
            [Display(Name = "Delivery Schedule")]
            public string vc_deli_sched_desc { get; set; }
            [Display(Name = "Delivery Date")]
            public string dt_expect_delidate { get; set; }
            [Display(Name = "Contract No")]
            public string vc_contract_no { get; set; }
            [Display(Name = "Effective Date")]
            public string dt_effect_date { get; set; }
            [Display(Name = "not_shown")]
            public string dt_created_date { get; set; }
            [Display(Name = "not_shown")]
            public string dt_updated_datetime { get; set; }
            [Display(Name = "not_shown")]
            public string vc_quot_no { get; set; }
            [Display(Name = "not_shown")]
            public List<PoItemList> itemLists { get; set; }
            public string GetSqlQuery()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($@"select * from (
	                     select po.bi_po_id, po.bi_poa_id, po.vc_ref_id, po.ti_po_type_id, potype.vc_po_type_desc, po.bi_po_status_id, post.vc_po_status_desc, hd.bi_po_header_id,
                         hd.bi_supp_id, sup.vc_supp_desc, hd.i_cur_id, cur.vc_cur_desc , hd.ti_tc_id, tc.vc_tc_desc, hd.bi_deli_loc_id, loc.vc_location_desc,
                         hd.ti_deli_sched_id, delisc.vc_deli_sched_desc, hd.dt_expect_delidate, hd.dt_effect_date, ln.bi_po_line_id, ln.bi_item_id, it.vc_item_desc, 
                         ln.bi_supp_item_id, ln.i_actual_qty, uom.vc_uom_desc, ln.i_uom_id, ln.i_price, ln.i_actual_amount, ln.vc_reference, ln.vc_quot_no,
                         po.dt_created_date, po.dt_updated_datetime
                         from tb_po po
                         inner join tb_po_header hd on po.bi_po_id = hd.bi_po_id
                         left join tb_po_line ln on hd.bi_po_header_id = ln.bi_po_header_id
                         inner join tb_supplier sup on hd.bi_supp_id = sup.bi_supp_id
                         inner join lut_term_and_con tc on hd.ti_tc_id = tc.ti_tc_id
                         inner join lut_deli_schedule_type delisc on hd.ti_deli_sched_id = delisc.ti_deli_sched_id
                         left join tb_item it on ln.bi_item_id = it.bi_item_id
                         left join lut_uom_type uom on ln.i_uom_id = uom.i_uom_id
                         left join tb_po_type potype on po.ti_po_type_id = potype.ti_po_type_id                         
                         left join lut_po_status post on po.bi_po_status_id = post.bi_po_status_id
                         left join lut_currency cur on hd.i_cur_id = cur.i_cur_id
                         left join tb_location loc on hd.bi_deli_loc_id = loc.bi_location_id
                         ) a ");
                return sb.ToString();
            }
        }
        public class PoItemList
        {
            [Display(Name = "po line Id")]
            public int bi_po_line_id { get; set; }
            [Display(Name = "not_shown")]
            public int bi_po_header_id { get; set; }
            [Display(Name = "Item Id")]
            public int bi_item_id { get; set; }
            [Display(Name = "Item")]
            public string vc_item_desc { get; set; }
            [Display(Name = "Supplier Item Id")]
            public string bi_supp_item_id { get; set; }
            [Display(Name = "Quantity")]
            public int i_actual_qty { get; set; }
            [Display(Name = "not_shown")]
            public int i_uom_id { get; set; }
            [Display(Name = "Unit of Measurement")]
            public string vc_uom_desc { get; set; }
            [Display(Name = "Min Qty")]
            public int i_min_qty { get; set; }
            [Display(Name = "Price")]
            public int i_price { get; set; }
            [Display(Name = "Amount")]
            public int i_actual_amount { get; set; }
            [Display(Name = "Contract No")]
            public string vc_contract_no { get; set; }
            [Display(Name = "Reference")]
            public string vc_reference { get; set; }
            [Display(Name = "not_shown")]
            public string vc_quot_no { get; set; }

        }
        public class PoCreateRefList
        {
            public List<POTableObj> poList { get; set; }
            public List<POATableObj> poaList { get; set; }
            public PoCreateRefList()
            {
                poList = new List<POTableObj>();
                poaList= new List<POATableObj>();
            }
        }
    }
}
