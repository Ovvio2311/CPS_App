using CPS_App.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;
using Krypton.Toolkit;
using Newtonsoft.Json;
using System.Security.Claims;
using Krypton.Toolkit.Suite.Extended.DataGridView;

namespace CPS_App
{
    public partial class Maintenance : KryptonForm
    {
        private DbServices _dbServices;
        private RegisterServices _registerServices;

        public Maintenance(DbServices dbServices, RegisterServices registerServices)
        {
            InitializeComponent();
            _dbServices = dbServices;
            _registerServices = registerServices;
        }

        private async void Maintenance_Load(object sender, EventArgs e)
        {
            this.multiDetailView.TabPages.Remove(tabPagesup);
            var result = await _dbServices.SelectAllAsync<tb_roles>();
            kryptodatagridrole.DataSource = result.result;
            GenUtil.dataGridAttrName<tb_roles>(kryptodatagridrole);

            var userResult = await _dbServices.SelectAllAsync<tb_users>();
            kryptonDataGridViewUser.DataSource = userResult.result;
            GenUtil.dataGridAttrName<tb_users>(kryptonDataGridViewUser);

            var delische = await _dbServices.SelectAllAsync<lut_deli_schedule_type>();
            kryptonDataGridViewdelisc.DataSource = delische.result;
            GenUtil.dataGridAttrName<lut_deli_schedule_type>(kryptonDataGridViewdelisc);

            var poatype = await _dbServices.SelectAllAsync<lut_poa_type>();
            kryptonDataGridViewpoa.DataSource = poatype.result;
            GenUtil.dataGridAttrName<lut_poa_type>(kryptonDataGridViewpoa);

            var tc = await _dbServices.SelectAllAsync<lut_term_and_con>();
            kryptonDataGridViewtc.DataSource = tc.result;
            GenUtil.dataGridAttrName<lut_term_and_con>(kryptonDataGridViewtc);

            var uom = await _dbServices.SelectAllAsync<lut_uom_type>();
            kryptonDataGridViewuom.DataSource = uom.result;
            GenUtil.dataGridAttrName<lut_uom_type>(kryptonDataGridViewuom);

            var loc = await _dbServices.SelectAllAsync<tb_location>();
            kryptonDataGridViewloc.DataSource = loc.result;
            GenUtil.dataGridAttrName<tb_location>(kryptonDataGridViewloc);

            var po = await _dbServices.SelectAllAsync<tb_po_type>();
            kryptonDataGridViewpo.DataSource = po.result;
            GenUtil.dataGridAttrName<tb_po_type>(kryptonDataGridViewpo);

            var sup = await _dbServices.SelectAllAsync<tb_supplier>();
            kryptonDataGridViewsup.DataSource = sup.result;
            GenUtil.dataGridAttrName<tb_supplier>(kryptonDataGridViewsup);

            var rocl = await _dbServices.SelectRoleClaim();
            kryptonDataGridViewroleclaim.DataSource = rocl.result;
            GenUtil.dataGridAttrName<role_claim_table>(kryptodatagridrole);

            var roclType = await _dbServices.SelectAllAsync<tb_roles>();
            List<tb_roles> roleclaim = JsonConvert.DeserializeObject<List<tb_roles>>(JsonConvert.SerializeObject(roclType.result));
            roleclaim.ForEach(x => cbxroleinroleclaim.Items.Add($"{x.vc_role_name}"));
            //tabpage vid mapping refresh
            await VidMappingInitialLoad();

            multiDetailView.Show();

        }
        private async Task VidMappingInitialLoad()
        {
            var vidType = await _dbServices.GetVidMappingObj();
            List<VidMappingObj> vid = JsonConvert.DeserializeObject<List<VidMappingObj>>(JsonConvert.SerializeObject(vidType.result));
            vid.ForEach(x => cbxvidmapvid.Items.Add(x.bi_item_vid));

            var itemidType = await _dbServices.SelectAllAsync<tb_item>();
            List<tb_item> itid = JsonConvert.DeserializeObject<List<tb_item>>(JsonConvert.SerializeObject(itemidType.result));
            itid.ForEach(x => cbxvidmapitemid.Items.Add($"{x.bi_item_id}:{x.vc_item_desc}"));

            var locType = await _dbServices.SelectAllAsync<tb_location>();
            List<tb_location> loc = JsonConvert.DeserializeObject<List<tb_location>>(JsonConvert.SerializeObject(locType.result));
            loc.ForEach(x => cbxvidmaploc.Items.Add($"{x.bi_location_id}:{x.vc_location_desc}"));

        }

        //private async void btnAdd_Click(object sender, EventArgs e)
        //{
        //    if (txtrole.Text == string.Empty)
        //    {
        //        MessageBox.Show("Role is Empty");
        //        return;
        //    }
        //    var select = new selectObj();
        //    select.table = typeof(tb_roles).Name;
        //    select.selecter.Add("vc_role_name", txtrole.Text.ToLower().Trim());
        //    var result = await _dbServices.SelectWhereAsync<tb_roles>(select);
        //    if (result.result.Count > 0)
        //    {
        //        MessageBox.Show("Role has been used");
        //        return;
        //    }
        //    IdentityRole role = new IdentityRole();
        //    role.Name = txtrole.Text;
        //    IdentityResult res = await _registerServices.CreateAsync(role);
        //    if (res.Succeeded) { MessageBox.Show("role added"); }
        //}


        private async void btnAddnewuser_Click(object sender, EventArgs e)
        {
            Register regNew = new Register(_registerServices, _dbServices);
            regNew.MdiParent = this.MdiParent;
            regNew.Show();
        }

        private async void btndelisc_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> value = new Dictionary<string, string>()
            {
                {"vc_deli_sched_desc", txtdelisc.Text }
            };
            await _dbServices.InsertMaintenance<lut_deli_schedule_type>(value);
        }

        private async void btnpoa_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> value = new Dictionary<string, string>()
            {
                {"vc_poa_type_desc", txtpoa.Text }
            };
            await _dbServices.InsertMaintenance<lut_poa_type>(value);
        }

        private async void btntc_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> value = new Dictionary<string, string>()
            {
                {"vc_tc_desc", txttc.Text }
            };
            await _dbServices.InsertMaintenance<lut_term_and_con>(value);

        }

        private async void btnuom_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> value = new Dictionary<string, string>()
            {
                {"vc_uom_desc", txtuom.Text }
            };
            await _dbServices.InsertMaintenance<lut_uom_type>(value);
        }

        private async void btnloc_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> value = new Dictionary<string, string>()
            {
                {"vc_location_desc", txtloc.Text },
                { "vc_location_addr", txtaddr.Text },
            };
            await _dbServices.InsertMaintenance<tb_location>(value);
        }

        private async void btnpo_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> value = new Dictionary<string, string>()
            {
                {"vc_po_type_desc", txtpo.Text }
            };
            await _dbServices.InsertMaintenance<tb_po_type>(value);
        }

        private void btnsup_Click(object sender, EventArgs e)
        {

        }

        private void tabroleclaim_Click(object sender, EventArgs e)
        {

        }

        private async void btnaddclaim_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> value = new Dictionary<string, string>()
            {
                {"vc_role_name",cbxroleinroleclaim.SelectedItem.ToString()},
                {"vc_claim_type", txtclaimt.Text },
                {"vc_claim_value",txtclaimv.Text},
            };
            if (await _dbServices.CheckDuplicateClaim<role_claim_table>(value))
            {
                Claim claim = new Claim(txtclaimt.Text.ToLower(), txtclaimv.Text.ToLower());

                var res = await _registerServices.InsertclaimAsync(cbxroleinroleclaim.SelectedItem.ToString(), claim);
                MessageBox.Show(res ? "Claim Added" : "Error");
            }
        }

        private async void btnroleadd_Click(object sender, EventArgs e)
        {
            if (txtrole.Text == string.Empty)
            {
                MessageBox.Show("Role is Empty");
                return;
            }
            var select = new selectObj();
            select.table = typeof(tb_roles).Name;
            select.selecter.Add("vc_role_name", txtrole.Text.ToLower().Trim());
            var result = await _dbServices.SelectWhereAsync<tb_roles>(select);
            if (result.result.Count > 0)
            {
                MessageBox.Show("Role has been used");
                return;
            }
            IdentityRole role = new IdentityRole();
            role.Name = txtrole.Text;
            IdentityResult res = await _registerServices.CreateAsync(role);
            if (res.Succeeded) { MessageBox.Show("role added"); }
        }



        private async void cbxvidmap_SelectedIndexChanged(object sender, EventArgs e)
        {
            await VidMappListBoxRefresh();
        }
        private async Task VidMappListBoxRefresh()
        {
            lstbox.Items.Clear();
            var selectedVid = cbxvidmapvid.SelectedItem;
            var vidType = await _dbServices.GetVidMappingObj();
            //lstbox.Items.Add(vidType.result);
            List<VidMappingObj> obj = vidType.result;
            var lstObj = obj.FirstOrDefault(x => x.bi_item_vid == GenUtil.ConvertObjtoType<int>(selectedVid)).prefer_loc_group;
            string[] arr = lstObj.Split(";");
            foreach (var x in arr)
            {
                lstbox.Items.Add(x);
            }
        }
        private void btnidinsert_Click(object sender, EventArgs e)
        {
            if (cbxvidmapitemid.SelectedItem == null || cbxvidmaploc.SelectedItem == null || cbxvidmapvid.SelectedItem == null)
            {
                MessageBox.Show("Please select Item Id and Location");
                return;
            }
            var selObj = new selectObj();
            foreach (var prop in typeof(tb_item_vid_mapping).GetProperties())
            {
                tabpagevid.Controls.OfType<KryptonComboBox>().ToList().ForEach(x =>
                {
                    if (x.Tag.ToString() == prop.Name)
                    {
                        selObj.selecter.Add(prop.Name, x.SelectedItem.ToString().Substring(0,1));
                    }
                });
            }            
        }

        private void btniddrop_Click(object sender, EventArgs e)
        {
            if (lstbox.SelectedItem == null || cbxvidmapvid.SelectedItem == null)
            {
                MessageBox.Show("Please select Vid and the drop item");
            }
        }
    }
}
