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
                string sql = $"select * from {obj.table} where ";

                DynamicParameters para = new DynamicParameters();
                List<string> vari = new List<string>();
                obj.selecter.ToList().ForEach(x =>
                {
                    vari.Add($"{x.Key} = @{x.Key}");
                    para.Add($"@{x.Key}", x.Value.ToString());
                });
                if (vari.Count > 1)
                {
                    sql += string.Join(" and ", vari);
                    sql += " ;";
                }
                else
                {
                    sql += vari[0] + " ;";
                }

                //para.Add($"@{wName}", obj.selecter.Values.FirstOrDefault());
                var result = await _db.QueryAsync<T>(sql, para);

                if (result.Count() > 0)
                {
                    res.result = result;
                    res.resCode = 1;
                }
                else
                {
                    res.result = null;
                    res.resCode = 0;
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
                string insertValue = string.Join(",", obj.inserter.Select(x => $"'{x.Value}'").ToList());

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
                             $"({value}); " +
                             "SELECT LAST_INSERT_ID();";

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
                string selecter = string.Join(" and ", obj.selecter.Select(x => $"{x.Key}= \'{x.Value}\'").ToList());
                string sql = $"update {obj.table} set {updateValue} where {selecter}; ";

                var result = await _db.ExecuteAsync(sql, null);
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
        public async Task<DbResObj> GetReqMappingObj(string userloc = null, searchObj obj = null)
        {
            //var res = new DbResObj();

            string sql = $@"SELECT * FROM
                         (SELECT 
                             req.bi_req_id, req.i_staff_id, sta.vc_staff_name, sta.vc_staff_role, stat.vc_status_desc vc_req_status, 
                             sta.bi_location_id, loc.vc_location_desc, 
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
                             stat.vc_status_desc item_mapping_status, postat.bi_po_status_id, postat.vc_po_status_desc, det.dt_exp_deli_date, 
                             uom.vc_uom_desc, it.vc_item_desc, 
                             it.bi_category_id, cat.vc_category_desc
                         FROM
                             tb_request_detail det
	                     LEFT JOIN tb_item it ON det.bi_item_id = it.bi_item_id
                         INNER JOIN tb_item_category cat ON it.bi_category_id = cat.bi_category_id
                         left join lut_uom_type uom on det.i_uom_id = uom.i_uom_id
                         left join lut_mapping_status stat on det.i_map_stat_id = stat.i_map_stat_id
                         left join lut_po_status postat on det.bi_po_status_id = postat.bi_po_status_id
                         LEFT JOIN tb_item_vid_mapping mapp ON it.bi_item_id = mapp.bi_item_id) b) c 
                         ON a.bi_req_id = det_bi_req_id ";
            if (obj != null)
            {
                string seasrchList = string.Join(" and ", obj.searchWords.Select(x => $"{x.Key}= \'{x.Value}\'").ToList());
                sql += $"where {seasrchList} ";
            }
            if (userloc != null)
            {
                sql += $"order by bi_location_id = '{userloc}' desc; ";
            }
            else
            {
                sql += ";";
            }



            try
            {
                var result = await _db.QueryAsync<dynamic>(sql, null);
                if (result.Count() > 0)
                {

                    return new DbResObj
                    {
                        resCode = 1,
                        result = GenUtil.DbResulttoKVP(result)
                    };
                }
                else
                {
                    return new DbResObj { resCode = 0, result = null };
                }

            }
            catch (Exception e)
            {
                return new DbResObj { resCode = 0, result = null, err_msg = e.Message };
            }
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
                         select 1 as `itemInfo`, it.bi_item_id, it.vc_item_desc, it.bi_category_id, loc.vc_location_desc, cat.vc_category_desc, itu.bi_location_id, it.i_uom_id, itu.i_item_qty
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

        public async Task<DbResObj> GetStockLevel(string userloc = null, searchObj obj = null)
        {
            var res = new DbResObj();
            res.resCode = 0;
            try
            {
                string sql = @"SELECT * FROM
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
                if (obj != null)
                {
                    string seasrchList = string.Join(" and ", obj.searchWords.Select(x => $"{x.Key}= \'{x.Value}\'").ToList());
                    sql += $"where {seasrchList} ";
                }
                if (userloc != null)
                {
                    sql += $"order by bi_location_id = '{userloc}' desc; ";
                }
                else
                {
                    sql += ";";
                }
                var result = await _db.QueryAsync<StockLevelViewObj>(sql, null);

                if (result.Count() > 0)
                {
                    res.result = result;
                    res.resCode = 1;
                }
                else
                {
                    res.resCode = 0;
                    res.result = null;
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
        public async Task<DbResObj> GetVidMappingObj()
        {
            var res = new DbResObj();
            res.resCode = 0;
            try
            {
                string sql = @"set sql_mode = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

                             select *  , 
                             group_concat(concat('Item Id',': ',bi_item_id,', ','Location',': ',vc_location_desc) separator ';') as prefer_loc_group ,
                             group_concat(vc_item_desc separator ',') as items_group,
                             group_concat(concat(bi_item_id,',',bi_prefer_loc_id) separator ';') as item_loc_id_group
                             from (
                             select bi_item_vid, vid.bi_item_id, vc_item_desc, it.bi_category_id, vc_category_desc, 
                             vid.bi_prefer_loc_id, loc.vc_location_desc
                             from tb_item_vid_mapping vid
                             left join tb_item it on vid.bi_item_id = it.bi_item_id
                             left join tb_item_category cat on it.bi_category_id = cat.bi_category_id                             
                             left join tb_location loc on vid.bi_prefer_loc_id = loc.bi_location_id)a
                             group by bi_item_vid
                             order by bi_item_vid;";

                var result = await _db.QueryAsync<VidMappingObj>(sql, null);

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
        public async Task<DbResObj> GetPoaList()
        {
            //var res = new DbResObj();

            string sql = $@"select * from (
	                     select poa.bi_poa_id, poa.ti_poa_type_id, poatype.vc_poa_type_desc, poa.bi_poa_status_id, poast.vc_poa_status_desc, hd.bi_poa_header_id,
                         hd.bi_deli_loc_id, loc.vc_location_desc, hd.bi_supp_id, sup.vc_supp_desc, hd.vc_currency, hd.ti_tc_id, tc.vc_tc_desc, hd.ti_deli_sched_id, delisc.vc_deli_sched_desc, 
                         hd.dt_effect_date, hd.bi_contract_no,
	                     ln.bi_poa_line_id, ln.bi_item_id, it.vc_item_desc, ln.bi_supp_item_id, ln.dc_promise_qty, uom.vc_uom_desc, ln.i_uom_id, ln.dc_min_qty, ln.dc_price, ln.dc_amount, ln.vc_reference, ln.bi_quot_no,
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
                         inner join tb_location loc on hd.bi_deli_loc_id = loc.bi_location_id
                         left join lut_poa_status poast on poa.bi_poa_status_id = poast.bi_poa_status_id
                         ) a;";
            try
            {
                var result = await _db.QueryAsync<dynamic>(sql, null);
                if (result.Count() > 0)
                {

                    return new DbResObj
                    {
                        resCode = 1,
                        result = GenUtil.DbResulttoKVP(result)
                    };

                }
                else
                {
                    return new DbResObj
                    {
                        resCode = 0,
                        result = null
                    };
                }
            }
            catch (Exception ex)
            {
                return new DbResObj
                {
                    resCode = 0,
                    result = null,
                    err_msg = ex.Message
                };
            }

        }
        public async Task InsertMaintenance<T>(Dictionary<string, string> value)
        {
            if (value.ElementAt(0).Value == string.Empty)
            {
                MessageBox.Show("Name is Empty");
                return;
            }
            var select = new selectObj();
            select.table = typeof(T).Name;
            select.selecter.Add(value.ElementAt(0).Key, value.ElementAt(0).Value.ToLower().Trim());

            var result = await SelectWhereAsync<T>(select);
            if (result.result.Count > 0)
            {
                MessageBox.Show("Name has been used");
                return;
            }
            var insert = new insertObj();

            insert.table = typeof(T).Name;
            value.ToList().ForEach(row =>
            {
                insert.inserter.Add(row.Key, row.Value);
            });
            var res = await InsertAsync(insert);
            if (res.resCode != 1)
            {
                MessageBox.Show("insert error");
            }
            else
            {
                MessageBox.Show($"insert ID: {res.result}");
            }
        }
        public async Task<DbResObj> SelectRoleClaim(Dictionary<string, string> value = null)
        {
            var res = new DbResObj();
            res.resCode = 0;
            try
            {
                string sql = @"select i_claim_id, cl.vc_role_id, vc_claim_type, vc_claim_value, vc_role_name
                             from tb_role_claim cl
                             left join tb_roles ro on cl.vc_role_id = ro.vc_role_id ";

                DynamicParameters para = new DynamicParameters();
                if (value != null)
                {

                    List<string> vari = new List<string>();
                    value.ToList().ForEach(x =>
                    {
                        vari.Add($"{x.Key} = @{x.Key}");
                        para.Add($"@{x.Key}", x.Value.ToString());
                    });
                    if (vari.Count > 1)
                    {
                        sql += " where ";
                        sql += string.Join(" and ", vari);
                        sql += " ;";
                    }
                    else
                    {
                        sql += " where ";
                        sql += vari[0] + " ;";
                    }
                }
                else
                {
                    sql += " ;";
                }
                var result = await _db.QueryAsync<role_claim_table>(sql, value != null ? para : null);
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
        public async Task<bool> CheckDuplicateClaim<T>(Dictionary<string, string> value)
        {


            var select = new Dictionary<string, string>
                {
                    {value.ElementAt(0).Key, value.ElementAt(0).Value.ToLower().Trim() },
                    {value.ElementAt(1).Key, value.ElementAt(1).Value.ToLower().Trim() }
                };



            var result = await SelectRoleClaim(select);
            if (result.result.Count > 0)
            {
                MessageBox.Show("Type has been used");
                return false;
            }
            return true;
        }
    }
}
