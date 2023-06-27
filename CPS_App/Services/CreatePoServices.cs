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
        public CreatePoServices(DbServices services)
        {
            _services = services;
        }
        public async Task<resObj> CreatePoASync(POTableObj obj)
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
                        {nameof(obj.vc_ref_id), obj.vc_ref_id != string.Empty?obj.vc_ref_id:"null" }
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
                        {nameof(row.vc_contract_no),row.vc_contract_no }
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
                    if (obj.bi_po_status_id == 4 && obj.ti_po_type_id == 4)
                    {
                        var poId = obj.vc_ref_id.Split(':').ElementAt(1).Trim();
                        var respo = await _services.GetOriginalPoQty(poId);
                        if (respo.resCode != 1)
                        {
                            MessageBox.Show("update planned purchase order error");
                        }
                        List<List<KeyValuePair<string, object>>> kvp = respo.result;
                        var actQty = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "i_actual_qty").Value;
                        var actheader = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "bi_po_header_id").Value.ToString();
                        int relQty = GenUtil.ConvertObjtoType<int>(actQty) - row.i_actual_qty;
                        updateObj updObj = new updateObj()
                        {
                            table = "tb_po_line",
                            updater = new Dictionary<string, string>
                            {
                                { nameof(row.i_actual_qty), relQty.ToString()  }
                            },
                            selecter = new Dictionary<string, string>
                            {
                                { nameof(row.bi_po_header_id), actheader },
                                { nameof(row.bi_item_id), row.bi_item_id.ToString() }
                            }

                        };
                        var resorin = await _services.UpdateAsync(updObj);
                        if (resorin.resCode != 1 || resorin.result == null)
                        {
                            //_logger.LogDebug("insert error");
                            throw new Exception("Update Planned Purchase order error");
                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
             
            }
            return true;
        }
    }
}
