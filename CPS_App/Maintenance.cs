﻿using CPS_App.Services;
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
using System.Security.Cryptography;
using System.Windows.Media;

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
            cbxvidmapvid.Items.Clear();
            cbxvidmapitemid.Items.Clear();
            cbxvidmaploc.Items.Clear();
            var vidType = await _dbServices.GetVidMappingObj();
            List<VidMappingObj> vid = JsonConvert.DeserializeObject<List<VidMappingObj>>(JsonConvert.SerializeObject(vidType.result));
            vid.ForEach(x => cbxvidmapvid.Items.Add(x.bi_item_vid));
            cbxvidmapvid.Items.Add("Add new Vid");

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
            if (selectedVid != null)
            {
                if (cbxvidmapvid.SelectedItem.ToString().Equals("Add new Vid"))
                {
                    return;
                }
                var vidType = await _dbServices.GetVidMappingObj();

                //lstbox.Items.Add(vidType.result);
                List<VidMappingObj> obj = vidType.result;
                string lstObj = obj.FirstOrDefault(x => x.bi_item_vid == GenUtil.ConvertObjtoType<int>(selectedVid)).prefer_loc_group;
                string[] arr = lstObj.Split(";");
                foreach (var x in arr)
                {
                    lstbox.Items.Add(x);
                }
            }



        }
        private async void btnidinsert_Click(object sender, EventArgs e)
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
                        var id = x.SelectedItem.ToString().Split(":").ElementAt(0);
                        selObj.selecter.Add(prop.Name, id);
                    }
                });
            }
            selObj.table = nameof(tb_item_vid_mapping);
            if (selObj.selecter["bi_item_vid"] == "Add new Vid")
            {
                selObj.selecter.Remove("bi_item_vid");
            }

            DbResObj selduplicate = await _dbServices.SelectWhereAsync<tb_item_vid_mapping>(selObj);
            if (selduplicate.resCode == 0 && selduplicate.result == null && selduplicate.err_msg == null)
            {
                selectObj selObj2 = selObj.Clone();



                selObj2.selecter.Remove("bi_item_vid");
                selObj2.selecter.Remove("bi_prefer_loc_id");
                DbResObj res2 = await _dbServices.CheckVidmapDupItemId(selObj2);
                if (res2.resCode == 1 && res2.result.Count >= 1)
                {
                    tb_item_vid_mapping temp1 = res2.result[0];
                    if (res2.result.Count == 1 && temp1.bi_item_vid.ToString() != cbxvidmapvid.SelectedItem.ToString())
                    {
                        MessageBox.Show("Item id cannot assgined to another Vid");
                        return;
                    }
                    MessageBox.Show("Item id was assgined to another Vid");
                    return;
                }
                else if (res2.resCode == 0 || res2.err_msg != null)
                {
                    MessageBox.Show(res2.err_msg != null ? res2.err_msg : "CheckVidmapDupItemId error");
                    return;
                }
                insertObj insertvid = new insertObj()
                {
                    table = nameof(tb_item_vid_mapping),
                    inserter = selObj.selecter
                };
                if (insertvid.inserter.Count == 2)
                {
                    int lastitemIndex = cbxvidmapvid.Items.Count - 2;
                    int newVid = GenUtil.ConvertObjtoType<int>(cbxvidmapvid.Items[lastitemIndex]) + 1;
                    insertvid.inserter.Add("bi_item_vid", newVid.ToString());
                }
                DbResObj insertRes = await _dbServices.InsertAsync(insertvid);
                if (insertRes.resCode != 1)
                {
                    MessageBox.Show("insert in vid error");
                    return;
                }
                MessageBox.Show("insert vid success");

                await CleanVipMapselectedItem();
                await VidMappingInitialLoad();
                await VidMappListBoxRefresh();
            }
            else if (selduplicate.resCode == 1 && selduplicate.result.Count > 0 && selduplicate.err_msg == null)
            {
                MessageBox.Show("duplicate vid, drop and retry");
            }
            else if (selduplicate.err_msg != null)
            {
                MessageBox.Show(selduplicate.err_msg);
            }
        }

        private async void btniddrop_Click(object sender, EventArgs e)
        {
            if (lstbox.SelectedItem == null || cbxvidmapvid.SelectedItem == null)
            {
                MessageBox.Show("Please select Vid and the drop item");
                return;
            }
            DialogResult response = MessageBox.Show(lstbox.SelectedItem.ToString(), "Drop", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes ? true : false)
            {
                List<string> key = lstbox.Tag.ToString().Split(":").ToList();
                List<string> arr = lstbox.SelectedItem.ToString().Split(",").ToList();
                List<string> value = arr.Where(x => x.Contains("Item Id") || x.Contains("Location Id")).Select(p => p.ToString().Split(":").ElementAt(1)).ToList();
                deleteObj delObj = new deleteObj();
                for (int i = 0; i < key.Count(); i++)
                {
                    for (int k = 0; k < value.Count(); k++)
                    {
                        if (i == k)
                        {
                            delObj.deleter.Add(key[i], value[k]);
                        }
                    }
                }
                delObj.deleter.Add("bi_item_vid", cbxvidmapvid.SelectedItem.ToString());
                delObj.table = nameof(tb_item_vid_mapping);
                DbResObj res = await _dbServices.DeleteAsync(delObj);
                if (res.resCode != 1 || res.err_msg != null)
                {
                    MessageBox.Show("drop item id error");
                    return;
                }
                MessageBox.Show("item id was dropped");
                await VidMappListBoxRefresh();


            }
        }
        public async Task CleanVipMapselectedItem()
        {
            cbxvidmapvid.FormattingEnabled = true;
            cbxvidmapvid.SelectedIndex = -1;
            cbxvidmaploc.SelectedIndex = -1;
            cbxvidmapitemid.SelectedIndex = -1;
        }
    }
}
