using CommonDBUtils;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPS_App.Models;
using static CPS_App.Models.CPSModel;
using Microsoft.Extensions.Configuration;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Security.Cryptography;
using System.CodeDom;
using System.Xml.Linq;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class DbServices
    {
        private readonly Db _db;
        private IConfiguration _configuration;
        public DbServices(Db db)
        {
            _db = db;
        }

        public async Task<resObj> SelectAllAsync<T>()
        {
            var res = new resObj();
            res.resCode = 0;
            string selectsql = $"select * from {typeof(T).Name};";
            var result = await _db.QueryAsync<T>(selectsql, null);
            if (result != null)
            {
                res.result = result;
                res.resCode = 1;
            }
            return res;
        }
        public async Task<resObj> SelectAllAsync(selectObj obj)
        {
            var res = new resObj();
            res.resCode = 0;
            string selectsql = $"select * from {obj.table};";
            var result = await _db.QueryAsync<dynamic>(selectsql, null);
            if (result != null)
            {
                res.result = result;
                res.resCode = 1;
            }
            return res;
        }
        public async Task<DbResObj> SelectWhereAsync<T>(selectObj obj)
        {
            var res = new DbResObj();
            res.resCode = 0;
            try
            {
                var wName = obj.selecter.Keys.FirstOrDefault();
                string sql = $"select * from {obj.table} where {wName} = @{wName};";
                DynamicParameters para = new DynamicParameters();
                para.Add($"@{wName}", obj.selecter.Values.FirstOrDefault());
                var result = await _db.QueryAsync<T>(sql, para);

                if (result != null)
                {
                    res.result = result;
                    res.resCode = 1;
                }
            }
            catch (Exception ex)
            {
                res.result = null;
                res.resCode = 0;
                res.err_msg = ex.Message;
            }

            return res;
        }
        public async Task<DbResObj> SelectWhereAsync(selectObj obj)
        {

            var res = new DbResObj();
            res.resCode = 0;
            try
            {
                var wName = obj.selecter.Keys.FirstOrDefault();
                string selectsql = $"select * from {obj.table} where {wName} = @{wName};";
                DynamicParameters para = new DynamicParameters();
                para.Add($"@{wName}", obj.selecter.Values.FirstOrDefault());
                var result = await _db.QueryAsync<dynamic>(selectsql, para);
                if (result != null)
                {
                    res.result = result;
                    res.resCode = 1;
                }

            }
            catch (Exception ex)
            {
                res.result = null;
                res.resCode = 0;
                res.err_msg = ex.Message;
            }
            return res;
        }
        public async Task<DbResObj> InsertAsync(insertObj obj)
        {
            var res = new DbResObj();
            res.resCode = 0;
            try
            {
                string inserter = string.Join(",", obj.inserter.Select(x => x.Key).ToList());
                string insertValue = string.Join(",", obj.inserter.Select(x => $"'{x.Value}").ToList());

                string insertSql = $"insert into {obj.table} ({inserter}) values ({insertValue}); " +
                                   "SELECT LAST_INSERT_ID();";

                var result = await _db.ExecuteScalarAsync(insertSql, null);
                if (result != null)
                {
                    res.result = result;
                    res.resCode = 1;
                }

            }
            catch (Exception ex)
            {
                res.result = null;
                res.resCode = 0;
                res.err_msg = ex.Message;
            }
            return res;
        }
        public async Task<DbResObj> InsertAsync<T>(T obj)
        {
            var res = new DbResObj();
            res.resCode = 0;
            try
            {

                var properties = typeof(T).GetProperties();

                string propName = string.Join(",", properties.Select(x => x.Name));

                string value = string.Join(",", properties.Select(x => "@" + x.Name));

                string sql = $"insert into {typeof(T).Name} " +
                             $"({propName}) values " +
                             $"({value});";

                var result = await _db.ExecuteAsync(sql, obj);
                if (result > 0)
                {
                    res.result = result;
                    res.resCode = 1;
                }
            }
            catch (Exception ex)
            {
                res.result = null;
                res.resCode = 0;
                res.err_msg = ex.Message;
            }

            return res;
        }

        public async Task<DbResObj> UpdateAsync(updateObj obj)
        {
            try
            {
                var res = new DbResObj();
                res.resCode = 0;
                string updateValue = string.Join(",", obj.updater.Select(x => $"{x.Key} = \'{x.Value}\'").ToList());
                string selecter = string.Join(",", obj.selecter.Select(x => $"{x.Key}= \'{x.Value}\'").ToList());
                string sql = $"update {obj.table} set {updateValue} where {selecter}; ";

                var result = await _db.ExecuteAsync(sql, obj);
                if (result > 0)
                {
                    res.result = result;
                    res.resCode = 1;
                }
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<DbResObj> GetReqMappingObj()
        {
            //var res = new DbResObj();

            string sql = $@"SELECT * FROM
                         (SELECT 
                             req.bi_req_id, req.i_staff_id, sta.vc_staff_role, sta.bi_location_id, loc.vc_location_desc, 
                             loc.vc_location_addr, vc_req_status, dt_exp_deli_date, req.dt_created_date, req.dt_updated_datetime
                         FROM
                             tb_request req
                         INNER JOIN tb_staff sta ON req.i_staff_id = sta.i_staff_id
                         INNER JOIN tb_location loc ON sta.bi_location_id = loc.bi_location_id
                         ) a
                             LEFT JOIN
                         (SELECT * FROM
                             (SELECT 
                             det.bi_req_id, det.bi_item_id bi_item_id, det.i_item_req_qty, det.i_remain_req_qty, det.i_uom_id, uom.vc_uom_desc, mapp.bi_item_vid, det.vc_req_status item_req_status, it.vc_item_desc, it.bi_category_id, cat.vc_category_desc
                         FROM
                             tb_request_detail det
                     	 LEFT JOIN tb_item it ON det.bi_item_id = it.bi_item_id
                         INNER JOIN tb_item_category cat ON it.bi_category_id = cat.bi_category_id
                         left join lut_uom_type uom on det.i_uom_id = uom.i_uom_id
                         LEFT JOIN tb_item_vid_mapping mapp ON it.bi_item_id = mapp.bi_item_id) b) c 
                         ON a.bi_req_id = c.bi_req_id
                         where vc_req_status != 'completed';
                    -- GROUP BY a.bi_req_id , c.bi_item_vid";

            var result = await _db.QueryAsync<dynamic>(sql, null);
            if (result.Count() > 0)
            {

                return new DbResObj
                {
                    resCode = 1,
                    result = GenUtil.DbResulttoKVP(result)
                };

            }
            return new DbResObj { resCode = 0, result = null };
        }
        public async Task<resObj> GetBPAResult<T>(string obj)
        {
            var res = new resObj();
            res.resCode = 0;

            string sql = @$"select * from (
	                     select p.bi_poa_id, p.ti_poa_type_id, pl.bi_item_id, p.vc_poa_status, ph.vc_order_revision, ph.bi_deli_loc_id, 
                         ph.ti_tc_id, ph.bi_supp_id, ph.vc_currency, ph.dt_effect_date, ph.bi_contract_no, 
                         pl.dc_promise_qty, pl.i_uom_id, pl.dc_min_qty, pl.dc_price, pl.dc_amount, pl.vc_reference,
                         pl.bi_quot_no, p.dt_created_date, p.dt_updated_datetime
                         from tb_poa p
                         left join tb_poa_header ph on p.bi_poa_id = ph.bi_poa_id
                         left join tb_poa_line pl on ph.bi_poa_header_id = pl.bi_poa_header_id
                         inner join lut_term_and_con tc on ph.ti_tc_id = tc.ti_tc_id
                         inner join lut_deli_schedule_type del on ph.ti_deli_sched_id = del.ti_deli_sched_id ) a
	                     left join (
                         select * from (
                         select 1 as `itemInfo`, it.bi_item_id, it.vc_item_desc, it.bi_category_id, loc.vc_location_desc, cat.vc_category_desc, itu.bi_location_id, itu.i_uom_id, itu.i_item_qty
                         from tb_item it
                         inner join tb_item_category cat on it.bi_category_id = cat.bi_category_id    
                         left join tb_item_unit itu on it.bi_item_id = itu.bi_item_id
                         inner join tb_location loc on itu.bi_location_id = loc.bi_location_id
                         ) a)c 
                         on a.bi_item_id = c.bi_item_id;";

            var result = await _db.QueryAsync<T>(sql, null);

            if (result != null)
            {
                res.result = result;
                res.resCode = 1;
            }
            return res;
        }
        public async Task<DbResObj> GetInStockQty()
        {
            var res = new DbResObj();
            res.resCode = 0;

            string sql = "";
            var result = await _db.QueryAsync<dynamic>(sql, null);

            if (result != null)
            {
                res.result = result;
                res.resCode = 1;
            }
            return res;
        }
        public async Task<DbResObj> GetLocationDesc<T>(T obj)
        {
            var res = new DbResObj();
            res.resCode = 0;

            if (typeof(T) == typeof(string) || typeof(T) == typeof(int))
            {

                string selectUnit = typeof(T) == typeof(int) ? "vc_location_desc" : "bi_location_id";
                string whereclause = typeof(T) == typeof(int) ? "bi_location_id" : "vc_location_desc";
                string sql = $"select {selectUnit} from tb_location where {whereclause} = @{whereclause}";
                DynamicParameters para = new DynamicParameters();
                para.Add($"@{whereclause}", obj.ToString());
                var result = await _db.QueryAsync<tb_location>(sql, para);
                if (result != null)
                {
                    res.result = result;
                    res.resCode = 1;
                }
                return res;
            }
            else
            {
                return res;
            }
        }
        //public async Task<DbResObj> GetItemId(selectObj obj)
        //{
        //    var res = new DbResObj();
        //    res.resCode = 0;
        //    try
        //    {
        //        var wName = obj.selecter.Keys.FirstOrDefault();
        //        string sql = $"select bi_item_id, bi_item_vid from tb_item_vid_mapping where {wName} = @{wName};";
        //        DynamicParameters para = new DynamicParameters();
        //        para.Add($"@{wName}", obj.selecter.Values.FirstOrDefault());
        //        var result = await _db.QueryAsync<tb_item_vid_mapping>(sql, para);

        //        if (result != null)
        //        {
        //            res.result = result;
        //            res.resCode = 1;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        res.result = null;
        //        res.resCode = 0;
        //        res.err_msg = ex.Message;
        //    }

        //    return res;

        //}
       

    }
}












//            SELECT
//    req.bi_req_id,
//    req.i_staff_id,
//    a.vc_staff_role,
//    a.bi_location_id,
//    a.vc_location_desc,
//    a.vc_location_addr,
//    vc_req_status,
//    dt_exp_deli_date,
//    req.dt_created_date,
//    req.dt_updated_datetime
//FROM
//    tb_request req
//        LEFT JOIN
//    (SELECT
//        i_staff_id,
//            vc_staff_role,
//            sta.bi_location_id,
//            loc.vc_location_desc,
//            loc.vc_location_addr
//    FROM
//        tb_staff sta
//    INNER JOIN tb_location loc ON sta.bi_location_id = loc.bi_location_id) a ON a.i_staff_id = req.i_staff_id;


//            SELECT
//                *, vid.bi_item_vid
//FROM
//    (SELECT
//        bi_item_id,
//            vc_item_desc,
//            it.bi_category_id,
//            cat.vc_category_desc
//    FROM
//        tb_item it
//    INNER JOIN tb_item_category cat ON it.bi_category_id = cat.bi_category_id) a
//            LEFT JOIN
//    tb_item_vid_mapping vid ON a.bi_item_id = vid.bi_item_id;
//        }
//    }

