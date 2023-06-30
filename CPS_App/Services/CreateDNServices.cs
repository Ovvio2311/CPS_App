using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class CreateDNServices
    {
        public DbServices _services;
        private DbGeneralServices _dbGeneralServices;
        public CreateDNServices(DbServices services, DbGeneralServices dbGeneralServices)
        {
            _services = services;
            _dbGeneralServices = dbGeneralServices; 
        }
        public async Task<resObj> CreateDnAsync(List<DeliveryNoteObj> obj)
        {
            try
            {
                resObj res = new resObj();
                res.resCode = 0;
                res.err_msg = null;
                res.result = null;

                if (await InsertDeliveryNote(obj))
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
        public async Task<bool> InsertDeliveryNote(List<DeliveryNoteObj> obj)
        {

            foreach (DeliveryNoteObj readytoAdd in obj)
            {
                try
                {
                    insertObj insertObj = new insertObj()
                    {
                        table = "tb_delivery_note",
                        inserter = new Dictionary<string, string>
                    {
                        {nameof(readytoAdd.bi_po_id),readytoAdd.bi_po_id.ToString() },
                        {nameof(readytoAdd.i_dn_type_id),readytoAdd.i_dn_type_id.ToString() },
                        { nameof(readytoAdd.i_dn_status_id), readytoAdd.i_dn_status_id.ToString() },
                        { nameof(readytoAdd.bi_req_id), readytoAdd.bi_req_id.ToString() },
                        { nameof(readytoAdd.bi_item_id), readytoAdd.bi_item_id.ToString() },
                        { nameof(readytoAdd.bi_item_vid), readytoAdd.bi_item_vid.ToString() },
                        { nameof(readytoAdd.i_item_qty), readytoAdd.i_item_qty.ToString() },
                        { nameof(readytoAdd.bi_location_id), readytoAdd.bi_location_id.ToString() },
                        { nameof(readytoAdd.dt_exp_deli_date), readytoAdd.dt_exp_deli_date },
                        {nameof(readytoAdd.bi_supp_id),readytoAdd.bi_supp_id.ToString() },
                    }
                    };
                    DbResObj res = await _services.InsertAsync(insertObj);
                    if (res.resCode != 1)
                    {
                        MessageBox.Show("Insert Delievery Note error");
                        return false;
                    }
                    if (res.err_msg != null)
                    {
                        MessageBox.Show(res.err_msg);
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

            }
            MessageBox.Show($"Delevery Note Created");
            return true;
        }
        
    }
}
