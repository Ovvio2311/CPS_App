using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class DbGeneralServices
    {
        private DbServices _dbServices;
        private GenericTableViewWorker _worker;
        public DbGeneralServices(DbServices dbServices, GenericTableViewWorker worker)
        {
            _dbServices = dbServices;
            _worker = worker;
        }

        public async Task<tb_item_vid_mapping> GetVidAsync(string bi_item_id)
        {
            try
            {
                var idFinder = new selectObj();
                idFinder.table = "tb_item_vid_mapping";
                idFinder.selecter = new Dictionary<string, string>
                    {
                        {"bi_item_id", bi_item_id }
                    };
                DbResObj vid = await _dbServices.SelectWhereAsync<tb_item_vid_mapping>(idFinder);
                if (vid.resCode != 1 || vid.result == null)
                {
                    //_logger.LogDebug("item Id not find");
                    MessageBox.Show("item Id not find");
                }
                tb_item_vid_mapping itemvid = vid.result[0];

                return itemvid;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task<tb_item> GetUomAsync(string bi_item_id)
        {
            try
            {
                //find uom id
                var uomFinder = new selectObj();
                uomFinder.table = "tb_item";
                uomFinder.selecter = new Dictionary<string, string>
                {
                        {"bi_item_id", bi_item_id.ToString()}
                    };
                DbResObj uomid = await _dbServices.SelectWhereAsync<tb_item>(uomFinder);
                if (uomid.resCode != 1 || uomid.result == null)
                {
                    //_logger.LogDebug("uom Id not find");
                    MessageBox.Show("uom Id not find");
                }
                tb_item uomId = uomid.result[0];

                return uomId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task UpdateRecordAsync(List<updateObj> _updateObjs)
        {
            try
            {
                if (_updateObjs.Any())
                {
                    foreach (var obj in _updateObjs)
                    {
                        DbResObj res = await _dbServices.UpdateAsync(obj);
                        if (res.resCode != 1 || res.err_msg != null)
                        {
                            MessageBox.Show($"Process update Db Error: {res.err_msg}");
                        }
                    }
                    _updateObjs.Clear();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task<string> GetpoHeaderIdAsync(string bi_po_id)
        {
            try
            {
                //find po header id
                var poheader = new selectObj();
                poheader.table = "tb_po_header";
                poheader.selecter = new Dictionary<string, string>
                {
                        {"bi_po_id", bi_po_id}
                    };
                DbResObj poH = await _dbServices.SelectWhereAsync(poheader);
                if (poH.resCode == 1 && poH.result != null)
                {
                    List<List<KeyValuePair<string, object>>> kvp = GenUtil.DbResulttoKVP(poH.result);
                    string poh = kvp.ElementAt(0).FirstOrDefault(x => x.Key == "bi_po_header_id").Value.ToString();
                    if (poh != null)
                    {
                        return poh;
                    }
                    else
                    {
                        return null;
                    }
                }
                else if (poH.err_msg != null)
                {
                    MessageBox.Show($"{poH.err_msg}");
                    return null;
                }
                else
                {
                    //_logger.LogDebug("uom Id not find");
                    MessageBox.Show("po header Id not find");
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task<List<RequestMappingReqObj>> OutstandingReqObj()
        {
            try
            {
                searchObj reqse = new searchObj()
                {
                    searchWords = new Dictionary<string, List<string>>
                {
                    {"i_map_stat_id", new List<string>(){"1","3"} },
                }
                };
                //string addSearch = " i_remain_req_qty > 0";


                RequestMappingReqObj viewObj = new RequestMappingReqObj();
                var res = await _worker.GetGenericWorker<RequestMappingReqObj, ItemRequest>(viewObj.GetSqlQuery(), nameof(viewObj.bi_req_id), null, reqse);
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<POTableObj>> OutstandingPoObj()
        {
            try
            {
                searchObj reqse = new searchObj()
                {
                    searchWords = new Dictionary<string, List<string>>
                {
                    {"bi_po_status_id", new List<string>(){"1","3","4"} },
                }
                };
                //string addSearch = " i_remain_req_qty > 0";


                POTableObj viewObj = new POTableObj();
                var res = await _worker.GetGenericWorker<POTableObj, PoItemList>(viewObj.GetSqlQuery(), nameof(viewObj.bi_po_header_id), null, reqse);
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
