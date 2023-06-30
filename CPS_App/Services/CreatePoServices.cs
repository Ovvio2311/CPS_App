using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{

    public class CreatePoServices
    {
        public DbServices _services;
        private DbGeneralServices _generalServices;
        private CreateDNServices _createDNServices;
        public CreatePoServices(DbServices services, DbGeneralServices generalServices, CreateDNServices createDNServices)
        {
            _services = services;
            _generalServices = generalServices;
            _createDNServices = createDNServices;
        }
        public async Task<resObj> CreatePoAsync(POTableObj obj)
        {
            try
            {
                resObj res = new resObj();
                res.resCode = 0;
                res.err_msg = null;
                res.result = null;

                if (await InsertTableHeader(obj) && await InsertPoLineAsync(obj))
                {
                    res.resCode = 1;
                    res.result = true;
                    res.err_msg = null;

                }
                if (obj.ti_po_type_id == 1 || obj.ti_po_type_id == 4)
                {

                }
                await UpdateReqDetail(obj);
                List<POTableObj> list = new List<POTableObj>();
                list.Add(obj);
                List<DeliveryNoteObj> dnO = await CreateDnObject(list);
                if (await _createDNServices.InsertDeliveryNote(dnO))
                {
                    res.resCode = 1;
                    res.result = true;
                }
                return res;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        private async Task<bool> InsertTableHeader(POTableObj obj)
        {
            try
            {
                //insert tb_po
                var tb_po = new insertObj()
                {
                    table = "tb_po",
                    inserter = new Dictionary<string, string>
                    {
                        {nameof(obj.ti_po_type_id),obj.ti_po_type_id.ToString() },
                        {nameof(obj.bi_po_status_id), obj.bi_po_status_id.ToString() },
                        {nameof(obj.vc_ref_id), obj.vc_ref_id != string.Empty?obj.vc_ref_id:"null" },
                        {nameof(obj.bi_req_id),obj.bi_req_id.ToString() }
                    },
                };
                var respoa = await _services.InsertAsync(tb_po);
                if (respoa.resCode != 1 || respoa.result == null)
                {
                    throw new Exception("insert po error");
                    //MessageBox.Show("insert po error");
                    //return;
                }



                obj.bi_po_id = GenUtil.ConvertObjtoType<int>(respoa.result);
                obj.dt_expect_delidate = (DateTime.Now.AddDays(GenUtil.ConvertObjtoType<int>(obj.vc_deli_sched_desc.Trim().Split(' ').ElementAt(0)))).ToString("yyyy-MM-ddTHH:mm:ss");
                //insert tb_poa_header
                var tb_po_header = new insertObj()
                {
                    table = "tb_po_header",
                    inserter = new Dictionary<string, string>
                {
                        { nameof(obj.bi_po_id), obj.bi_po_id.ToString() },
                        { "vc_order_revision", "0" },
                        { nameof(obj.bi_supp_id), obj.bi_supp_id.ToString() },
                        { nameof(obj.bi_deli_loc_id), obj.bi_deli_loc_id.ToString() },
                        { nameof(obj.i_cur_id), obj.i_cur_id.ToString()},
                        { nameof(obj.ti_tc_id), obj.ti_tc_id.ToString() },
                        { nameof(obj.ti_deli_sched_id), obj.ti_deli_sched_id.ToString() },
                        { nameof(obj.dt_effect_date), obj.dt_effect_date },
                        {nameof(obj.dt_expect_delidate),obj.dt_expect_delidate}
            },
                    //{ nameof(obj.vc_contract_no), obj.vc_contract_no },

                };
                var resheader = await _services.InsertAsync(tb_po_header);
                if (resheader.resCode != 1 || resheader.result == null)
                {
                    throw new Exception("insert po header error");

                }
                obj.bi_po_header_id = GenUtil.ConvertObjtoType<int>(resheader.result);
                MessageBox.Show($"insert completed, po id: {obj.bi_po_id}, po header id: {obj.bi_po_header_id}");
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private async Task<bool> InsertPoLineAsync(POTableObj obj)
        {
            foreach (PoItemList row in obj.itemLists)
            {
                try
                {
                    var po_line = new insertObj()
                    {
                        table = "tb_po_line",
                        inserter = new Dictionary<string, string>
                        {
                        {nameof(row.bi_po_header_id), obj.bi_po_header_id.ToString() },
                        {nameof(row.bi_item_id), row.bi_item_id.ToString() },
                        {nameof(row.bi_supp_item_id),row.bi_supp_item_id.ToString() },
                        {nameof(row.i_actual_qty), row.i_actual_qty.ToString() },
                        {nameof(row.i_uom_id),row.i_uom_id.ToString() },
                        {nameof(row.i_price), row.i_price.ToString() },
                        {nameof(row.i_actual_amount), row.i_actual_amount.ToString() },
                        {nameof(row.vc_reference), row.vc_reference.ToString() },
                        {nameof(row.vc_quot_no),row.vc_quot_no.ToString() },
                        {nameof(row.vc_contract_no),row.vc_contract_no },
                        {"bi_po_status_id", row.bi_ln_po_status_id.ToString() }
                        }
                    };
                    var resitem = await _services.InsertAsync(po_line);
                    if (resitem.resCode != 1 || resitem.result == null)
                    {
                        //_logger.LogDebug("insert error");
                        throw new Exception("insert po line error");
                    }
                    MessageBox.Show($"po line id: {resitem.result}");

                    // update planned purchase order quantity
                    //if (obj.bi_po_status_id == 4 && obj.ti_po_type_id == 4)
                    //{
                    //    var poId = obj.vc_ref_id.Split(':').ElementAt(1).Trim();
                    //    var respo = await _services.GetOriginalPoQty(poId);
                    //    if (respo.resCode != 1)
                    //    {
                    //        MessageBox.Show("update planned purchase order error");
                    //    }
                    //    List<List<KeyValuePair<string, object>>> kvp = respo.result;
                    //    var actQty = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "i_actual_qty").Value;
                    //    var actheader = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "bi_po_header_id").Value.ToString();
                    //    int relQty = GenUtil.ConvertObjtoType<int>(actQty) - row.i_actual_qty;
                    //    updateObj updObj = new updateObj()
                    //    {
                    //        table = "tb_po_line",
                    //        updater = new Dictionary<string, string>
                    //        {
                    //            { nameof(row.i_actual_qty), relQty.ToString()  }
                    //        },
                    //        selecter = new Dictionary<string, string>
                    //        {
                    //            { nameof(row.bi_po_header_id), actheader },
                    //            { nameof(row.bi_item_id), row.bi_item_id.ToString() }
                    //        }

                    //    };
                    //    var resorin = await _services.UpdateAsync(updObj);
                    //    if (resorin.resCode != 1 || resorin.result == null)
                    //    {
                    //        //_logger.LogDebug("insert error");
                    //        throw new Exception("Update Planned Purchase order error");
                    //    }

                    //}
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            return true;
        }
        public async Task UpdateReqDetail(POTableObj readytoConfirm)
        {
            try
            {
                foreach (var i in readytoConfirm.itemLists)
                {
                    //find qty
                    selectObj selObj = new selectObj()
                    {
                        table = "tb_request_detail",
                        selecter = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.bi_req_id) ,readytoConfirm.bi_req_id.ToString()},
                    {nameof(i.bi_item_id), i.bi_item_id.ToString() },
                }

                    };
                    DbResObj selres = await _services.SelectWhereAsync(selObj);
                    if (selres.resCode != 1)
                    {

                        MessageBox.Show("update request detail order error");
                        return;
                    }
                    List<List<KeyValuePair<string, object>>> kvp = GenUtil.DbResulttoKVP(selres.result);
                    var qty = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "i_remain_req_qty").Value;
                    int realqty = GenUtil.ConvertObjtoType<int>(qty) - i.i_actual_qty;


                    updateObj updateReq = new updateObj()
                    {
                        table = "tb_request_detail",
                        updater = new Dictionary<string, string>
                {
                    {"i_remain_req_qty" ,realqty<=0? "0":realqty.ToString()},
                    {"bi_po_status_id", "3" },
                    {"i_hd_map_stat_id", "2" }
                },
                        selecter = new Dictionary<string, string>
                {
                    {nameof(readytoConfirm.bi_req_id),readytoConfirm.bi_req_id.ToString() },
                    {nameof(i.bi_item_id),i.bi_item_id.ToString() },
                }
                    };
                    var resorin = await _services.UpdateAsync(updateReq);
                    if (resorin.resCode != 1 || resorin.result == null)
                    {
                        //_logger.LogDebug("insert error");
                        throw new Exception("Update Planned Purchase order error");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task<List<DeliveryNoteObj>> CreateDnObject(List<POTableObj> obj)
        {
            try
            {
                List<DeliveryNoteObj> listDn = new List<DeliveryNoteObj>();

                foreach (POTableObj it in obj)
                {
                    foreach (PoItemList item in it.itemLists)
                    {
                        DeliveryNoteObj dnObj = new DeliveryNoteObj();
                        tb_item_vid_mapping vid = await _generalServices.GetVidAsync(item.bi_item_id.ToString());
                        dnObj.bi_po_id = it.bi_po_id;
                        dnObj.bi_req_id = it.bi_req_id;
                        dnObj.i_dn_status_id = 3;
                        dnObj.i_dn_type_id = 2;
                        dnObj.bi_item_id = item.bi_item_id;
                        dnObj.bi_item_vid = GenUtil.ConvertObjtoType<int>(vid.bi_item_vid);
                        dnObj.i_item_qty = item.i_actual_qty;
                        dnObj.bi_location_id = it.bi_deli_loc_id;
                        dnObj.dt_exp_deli_date = it.dt_expect_delidate;
                        dnObj.bi_supp_id = it.bi_supp_id;
                        listDn.Add(dnObj);
                    }

                }
                return listDn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
