using CPS_App.Migrations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS_App.Helpers
{
    class DBcreateSql
    {
    }
}


//use cps_db;
//CREATE TABLE `tb_users` (
//  `vc_user_id` varchar(255) NOT NULL,
//  `lt_discriminator` longtext NOT NULL,
//  `vc_email` varchar(256) DEFAULT NULL,
//  `vc_user_name` varchar(100) NOT NULL,
//  `vc_normalized_user_name` varchar(256) DEFAULT NULL,
//  `vc_normalized_email` varchar(256) DEFAULT NULL,
//  `ti_email_confirmed` tinyint(1) NOT NULL,
//  `lt_password_hash` longtext DEFAULT NULL,
//  `lt_security_stamp` longtext DEFAULT NULL,
//  `lt_concurrency_stamp` longtext DEFAULT NULL,
//  `dt_lockout_end` datetime(6) DEFAULT NULL,
//  `ti_lockout_enabled` tinyint(1) NOT NULL,
//  `i_access_failed_count` int(11) NOT NULL,
//  PRIMARY KEY (`vc_user_id`),
//  UNIQUE KEY `UserNameIndex` (`vc_normalized_user_name`),
//  KEY `EmailIndex` (`vc_normalized_email`)
//) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;

//CREATE TABLE `tb_roles` (
//  `vc_role_id` varchar(255) NOT NULL,
//  `vc_role_name` varchar(256) DEFAULT NULL,
//  `vc_nor_name` varchar(256) DEFAULT NULL,
//  `lt_concurrency_stamp` longtext DEFAULT NULL,
//  PRIMARY KEY (`vc_role_id`),
//  UNIQUE KEY `RoleNameIndex` (`vc_nor_name`)
//) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;

//CREATE TABLE `tb_user_roles` (
//  `vc_user_id` varchar(255) NOT NULL,
//  `vc_role_id` varchar(255) NOT NULL,
//  PRIMARY KEY (`vc_user_id`,`vc_role_id`),
//  KEY `IX_tb_user_roles_vc_role_id` (`vc_role_id`),
//  CONSTRAINT `FK_tb_user_roles_tb_roles_vc_role_id` FOREIGN KEY(`vc_role_id`) REFERENCES `tb_roles` (`vc_role_id`) ON DELETE CASCADE,
//  CONSTRAINT `FK_tb_user_roles_tb_users_vc_user_id` FOREIGN KEY (`vc_user_id`) REFERENCES `tb_users` (`vc_user_id`) ON DELETE CASCADE
//) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;

//create TABLE `tb_location` (    
//  `bi_location_id` bigint(20) NOT NULL AUTO_INCREMENT,
//  `vc_location_desc` varchar(45) DEFAULT NULL,
//  `vc_location_addr` varchar(150) DEFAULT NULL,
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_location_id)
  
//) ENGINE = InnoDB AUTO_INCREMENT = 1 DEFAULT CHARSET = utf8mb4;

//create TABLE `tb_staff` (
//  `i_staff_id` int(11) not NULL,
//  `vc_staff_role` varchar(50) DEFAULT NULL,
//  `vc_user_id` varchar(255) DEFAULT NULL,
//  `bi_location_id` bigint(20) DEFAULT NULL,
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(i_staff_id),
//  constraint fn_key_user_id foreign key(vc_user_id) references tb_users(vc_user_id),
//  constraint fn_key_loc_id foreign key(bi_location_id) references tb_location(bi_location_id)
//) ENGINE = InnoDB AUTO_INCREMENT = 1 DEFAULT CHARSET = utf8mb4;

//create TABLE `tb_request` (
//  `bi_req_id` bigint(20) NOT NULL AUTO_INCREMENT,
//  `i_staff_id` int(11) DEFAULT NULL,
//  `vc_req_status` varchar(15) DEFAULT NULL,
//  `dt_exp_deli_date` datetime DEFAULT NULL,
//  `vc_mark` varchar(20) DEFAULT NULL,
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_req_id),
//  constraint fn_key_staff_id foreign key(i_staff_id) references tb_staff(i_staff_id)
//) ENGINE = InnoDB AUTO_INCREMENT = 1 DEFAULT CHARSET = utf8mb4;

//create TABLE `tb_item_category` (
//  `bi_category_id` bigint(20) not NULL AUTO_INCREMENT,  
//  `vc_category_desc` varchar(45) not NULL,    
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_category_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;



//create TABLE `lut_term_&_Con` (
//  `ti_t&c_id` tinyint(4) NOT NULL AUTO_INCREMENT,  
//  `vc_t&c_desc` varchar(100) DEFAULT NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(`ti_t&c_id`)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `lut_poa_type` (
//  `ti_poa_type_id` tinyint(4) NOT NULL AUTO_INCREMENT,  
//  `vc_poa_type_desc` varchar(20) not NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(ti_poa_type_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `lut_deli_schedule_type` (
//  `ti_deli_sched_id` tinyint(4) NOT NULL AUTO_INCREMENT,  
//  `vc_deli_sched_desc` varchar(45) not NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(ti_deli_sched_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_supplier` (    
//  `bi_supp_id` bigint(20) NOT NULL AUTO_INCREMENT,  
//  `vc_supp_desc` varchar(45) not NULL,
//  `vc_supp_addr` varchar(100) default NULL,
//  `vc_supp_contact` varchar(30) DEFAULT NULL,
//  `vc_supp_contact_no` varchar(20) default NULL,
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_supp_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `lut_uom_type` (
//  `i_uom_id` int(11) NOT NULL AUTO_INCREMENT,  
//  `vc_uom_desc` varchar(45) not NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(i_uom_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;


//create TABLE `tb_poa` (  
//  `bi_poa_id` bigint(20) not NULL AUTO_INCREMENT,
//  `ti_poa_type_id` tinyint(4) not NULL,  
//  `vc_poa_status` varchar(20) DEFAULT NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_poa_id),
//  constraint fn_poatypekey1 foreign key(ti_poa_type_id) references lut_poa_type(ti_poa_type_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_poa_header` (
//  `bi_poa_header_id` bigint(20) NOT NULL AUTO_INCREMENT,
//  `bi_poa_id` bigint(20) not NULL,
//  `vc_order_revision` int(11) DEFAULT NULL,  
//  `bi_supp_id` bigint(20) DEFAULT NULL,
//  `bi_deli_loc_id` bigint(20) DEFAULT NULL,  
//  `vc_currency` varchar(10) DEFAULT NULL,  
//  `ti_t&c_id` tinyint(4) DEFAULT NULL,
//  `ti_deli_sched_id` tinyint(4) DEFAULT NULL,
//  `dt_effect_date` datetime default NULL,  
//  `bi_contract_no` bigint(20) DEFAULT NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_poa_header_id),
//  constraint fn_poakey11 foreign key(bi_poa_id) references tb_poa(bi_poa_id),
//  constraint fn_suppkey22 foreign key(bi_supp_id) references tb_supplier(bi_supp_id),
//  constraint fn_tckey33 foreign key(`ti_t&c_id`) references `lut_term_&_Con`(`ti_t&c_id`),
//  constraint fn_schkey44 foreign key(ti_deli_sched_id) references lut_deli_schedule_type(ti_deli_sched_id),
//  constraint fn_deli_loc_id foreign key(bi_deli_loc_id) references tb_location(bi_location_id)
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_item` (
//  `bi_item_id` bigint(20) NOT NULL AUTO_INCREMENT,  
//  `vc_item_desc` varchar(45) not NULL,  
//  `bi_category_id` bigint(20) DEFAULT NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_item_id),
//  constraint fn_catkey1 foreign key(bi_category_id) references tb_item_category(bi_category_id)

//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_poa_line` (
//  `bi_poa_header_id` bigint(20) NOT NULL,  
//  `bi_poa_line_id` bigint(20) not NULL AUTO_INCREMENT,  
//  `bi_item_id` bigint(20) DEFAULT NULL,  
//  `dc_promise_qty` decimal(5,2) DEFAULT NULL,
//  `i_uom_id` int(11) DEFAULT NULL,
//  `dc_min_qty` decimal(5,2) default NULL,  
//  `dc_price` decimal(10,2) DEFAULT NULL,  
//  `dc_amount` decimal(5,2) DEFAULT NULL,
//  `vc_reference` varchar(45) DEFAULT NULL,
//  `bi_quot_no` bigint(20) default NULL,    
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_poa_line_id),
//  constraint fn_headkey1 foreign key(bi_poa_header_id) references tb_poa_header(bi_poa_header_id),
//  constraint fn_itemkey2 foreign key(bi_item_id) references tb_item(bi_item_id),
//  constraint fn_uomkey3 foreign key(i_uom_id) references lut_uom_type(i_uom_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;


//create TABLE `tb_item_unit` (
//  `bi_item_id` bigint(20) NOT NULL,  
//  `bi_location_id` bigint(20) NOT NULL,    
//  `i_uom_id` int(11) DEFAULT NULL,
//  `i_item_qty` int(11) DEFAULT NULL,
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  constraint f_lockey1 foreign key(bi_location_id) references tb_location(bi_location_id),
//  constraint f_itemkey2 foreign key(bi_item_id) references tb_item(bi_item_id),
//  constraint f_uomkey3 foreign key(i_uom_id) references lut_uom_type(i_uom_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_request_detail` (    
//  `bi_req_id` bigint(20) NOT NULL,  
//  `bi_item_id` bigint(20) not NULL,
//  `i_item_req_qty` int(11) DEFAULT NULL,
//  `i_remain_req_qty` int(11) DEFAULT NULL,
//  `i_uom_id` int(11) DEFAULT NULL,
//  `vc_req_status` int(11) DEFAULT NULL,
//  `vc_remark` varchar(45) DEFAULT NULL,
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  constraint fn_item_key1 foreign key(bi_item_id) references tb_item(bi_item_id),
//  constraint fn_re1_key2 foreign key(bi_req_id) references tb_request(bi_req_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_po_type` (
//  `ti_po_type_id` tinyint(4) NOT NULL,  
//  `vc_po_type_desc` varchar(45) not NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(ti_po_type_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_po` (    
//  `bi_po_id` bigint(20) NOT NULL AUTO_INCREMENT,
//  `bi_poa_id` bigint(20) default NULL,
//  `ti_po_type_id` tinyint(4) not null,
//  `vc_po_status` varchar(45) default NULL,
//  `dt_expect_delidate` datetime default NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_po_id),
//  constraint fn_potype_key2 foreign key(ti_po_type_id) references tb_po_type(ti_po_type_id),
//  constraint fn_poa_key2 foreign key(bi_poa_id) references tb_poa(bi_poa_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_po_header` (
//  `bi_po_header_id` bigint(20) NOT NULL AUTO_INCREMENT,
//  `bi_po_id` bigint(20) not NULL,
//  `vc_order_revision` int(11) DEFAULT NULL,    
//  `bi_deli_loc_id` bigint(20) DEFAULT NULL,  
//  `bi_supp_id` bigint(20) DEFAULT NULL,
//  `vc_currency` varchar(10) DEFAULT NULL,  
//  `ti_t&c_id` tinyint(4) DEFAULT NULL,
//  `dt_expect_delidate` datetime DEFAULT NULL,
//  `dt_effect_date` datetime default NULL,      
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_po_header_id),
//  constraint fn_po_id foreign key(bi_po_id) references tb_po(bi_po_id),
//  constraint fn_supp_id foreign key(bi_supp_id) references tb_supplier(bi_supp_id),
//  constraint fn_tc_id foreign key(`ti_t&c_id`) references `lut_term_&_Con`(`ti_t&c_id`),
//  constraint fn_loc_id foreign key(bi_deli_loc_id) references tb_location(bi_location_id)
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_po_line` (
//  `bi_po_header_id` bigint(20) NOT NULL,  
//  `bi_po_line_id` bigint(20) not NULL AUTO_INCREMENT,  
//  `bi_supp_item_id` bigint(20) DEFAULT NULL,  
//  `bi_item_id` bigint(20) DEFAULT NULL,    
//  `i_uom_id` int(11) DEFAULT NULL,
//  `dc_price` decimal(10,2) DEFAULT NULL,  
//  `dc_actual_amount` decimal(5,2) DEFAULT NULL,
//  `vc_reference` varchar(45) DEFAULT NULL,
//  `bi_quot_no` bigint(20) default NULL,
//  `bi_contract_no` bigint(20) DEFAULT NULL,    
//  `dc_actual_qty` decimal(5,2) DEFAULT NULL,
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_po_line_id),
//  constraint fn_poheader foreign key(bi_po_header_id) references tb_po_header(bi_po_header_id),
//  constraint fn_poline_item_id foreign key(bi_item_id) references tb_item(bi_item_id),
//  constraint fn_poline_uom foreign key(i_uom_id) references lut_uom_type(i_uom_id)
  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_delivery_note` (
//  `bi_dn_id` bigint(20) NOT NULL AUTO_INCREMENT,  
//  `bi_po_id` bigint(20) not NULL, 
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
//  PRIMARY key(bi_dn_id),
//  constraint fn_dn_poid foreign key(bi_po_id) references tb_po(bi_po_id)

  
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

//create TABLE `tb_item_vid_mapping` (
//  `bi_item_id` bigint(20) NOT NULL,  
//  `bi_item_vid` bigint(20) not NULL,  
//  `dt_created_date` datetime NOT NULL DEFAULT current_timestamp(),
//  `dt_updated_datetime` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp()  ,
//  constraint vid_map foreign key(bi_item_id) references tb_item(bi_item_id)
//) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
