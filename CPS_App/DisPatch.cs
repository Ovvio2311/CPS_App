using CPS_App.Services;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class DisPatch : KryptonForm
    {
        public ClaimsIdentity userIden;
        private GenericTableViewWorker _genericTableViewWorker;
        public List<DispatchInstruction> dispatchObj;
        private readonly DbServices _dbServices;
        private int selectdId;
        private string userLoc;
        public DisPatch(GenericTableViewWorker genericTableViewWorker, DbServices dbServices)
        {
            InitializeComponent();
            _genericTableViewWorker = genericTableViewWorker;
            dispatchObj = new List<DispatchInstruction>();
            _dbServices = dbServices;
        }

        private async void DisPatch_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;

            if (userIden == null)
            {
                //throw new Exception("user claim is null");
            }
            userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();
            await LoadViewTable(userLoc);

        }
        private async Task LoadViewTable(string loc, searchObj obj = null)
        {

            lblnoresult.Hide();
            datagridview.DataSource = null;
            //defPage = await _requestMapp.RequestMappingObjGetter(loc, obj);
            DispatchInstruction viewObj = new DispatchInstruction();
            var kvpLoc = new Dictionary<string, string>()
            {
                {nameof(viewObj.bi_location_id),loc }
            };
            searchObj searchObj = new searchObj()
            {
                searchWords = new Dictionary<string, List<string>>
                {
                    { nameof(viewObj.i_di_status_id), new List<string>(){"1"} }
                }
            };
            DbResObj res = await _dbServices.GetDisPatchObj(loc, searchObj);
            if (res.resCode != 1)
            {
                datagridview.Columns.Clear();
                lblnoresult.Show();
                btndn.Hide();
                btnall.Hide();
                return;
            }
            dispatchObj = res.result;
            var observableItems = new ObservableCollection<DispatchInstruction>(dispatchObj);
            BindingList<DispatchInstruction> source = observableItems.ToBindingList();

            if (dispatchObj != null)
                datagridview.DataSource = source;

            GenUtil.dataGridAttrName<DispatchInstruction>(datagridview, new List<string>() { "not_shown" });
        }
        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }  // header clicked

            if (e.RowIndex == datagridview.CurrentRow.Index)
            {

                selectdId = GenUtil.ConvertObjtoType<int>(datagridview.CurrentRow.Cells["bi_di_id"].Value);

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnall_Click(object sender, EventArgs e)
        {
            try
            {
                if (await InsertDeliveryNote(dispatchObj))
                {
                    await UpdateDispatch(dispatchObj);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btndn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectdId == 0)
                {
                    MessageBox.Show("Please select item to Add");
                    return;
                }
                DispatchInstruction readytoAdd = dispatchObj.Where(x => x.bi_di_id == selectdId).FirstOrDefault();
                List<DispatchInstruction> disList = new List<DispatchInstruction>
                {
                    readytoAdd!
                };
                if (await InsertDeliveryNote(disList))
                {
                    await UpdateDispatch(disList);
                    await LoadViewTable(userLoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public async Task<bool> InsertDeliveryNote(List<DispatchInstruction> obj)
        {

            foreach (DispatchInstruction readytoAdd in obj)
            {
                try
                {
                    insertObj insertObj = new insertObj()
                    {
                        table = "tb_delivery_note",
                        inserter = new Dictionary<string, string>
                    {
                        //{nameof(readytoAdd.bi_di_id),readytoAdd.bi_di_id.ToString() },
                        { "i_dn_status_id", "3" },
                        {"i_dn_type_id","1" },
                        {nameof(readytoAdd.bi_supp_id),readytoAdd.bi_supp_id.ToString() },
                        { nameof(readytoAdd.bi_req_id), readytoAdd.bi_req_id.ToString() },
                        { nameof(readytoAdd.bi_item_id), readytoAdd.bi_item_id.ToString() },
                        { nameof(readytoAdd.bi_item_vid), readytoAdd.bi_item_vid.ToString() },
                        { nameof(readytoAdd.i_item_qty), readytoAdd.i_item_qty.ToString() },
                        { nameof(readytoAdd.bi_location_id), readytoAdd.bi_location_id.ToString() },
                        { nameof(readytoAdd.dt_exp_deli_date), readytoAdd.dt_exp_deli_date },
                    }
                    };
                    DbResObj res = await _dbServices.InsertAsync(insertObj);
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
        public async Task UpdateDispatch(List<DispatchInstruction> obj)
        {
            foreach (DispatchInstruction ins in obj)
            {
                updateObj updateObj = new updateObj()
                {
                    table = "tb_dispatch_instruction",
                    updater = new Dictionary<string, string>
                    {
                        {nameof(ins.i_di_status_id),"2" }
                    },
                    selecter = new Dictionary<string, string>
                    {
                        {nameof(ins.bi_di_id),ins.bi_di_id.ToString() }
                    }
                };
                DbResObj res = await _dbServices.UpdateAsync(updateObj);
                if (res.resCode != 1 || res.err_msg != null)
                {
                    MessageBox.Show("update Dispatch Instruction error");
                    return;
                }
            }

        }

        private async void btncsv_Click(object sender, EventArgs e)
        {
            if(dispatchObj.Count() > 0)
            {
                if (await GenUtil.ExportCsv<DispatchInstruction>(dispatchObj, "Dispatch_Instruction"))
                {
                    MessageBox.Show("CSV Generated");
                }
            }
            else
            {
                MessageBox.Show("Empty");
            }
            
        }
    }
}
