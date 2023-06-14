﻿using CPS_App.Services;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class POView : Krypton.Toolkit.KryptonForm
    {
        public ClaimsIdentity userIden;
        private readonly DbServices _dbServices;
        public List<POATableObj> poaObj;
        private POAWorker _pOAWorker;
        private Dictionary<string, string> searchWords;
        private SearchFunc _searchFunc;
        public POView(DbServices dbServices, POAWorker pOAWorker, SearchFunc searchFunc)
        {
            InitializeComponent();
            _dbServices = dbServices;
            poaObj = new List<POATableObj>();
            _pOAWorker = pOAWorker;
            searchWords = new Dictionary<string, string>();
            _searchFunc = searchFunc;
        }

        private async void POAView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden == null)
            {
                //throw new Exception("user claim is null");                
            }
            if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "poa", "update" } }))
            {
                btnadd.Hide();
                btnedit.Hide();
            }
            else if (await AuthService.UserAuthCheck(userIden, new Dictionary<string, string>() { { "poa", "read" } }))
            {
                btnadd.Hide();
            }
            var userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();
            await LoadViewTable(userLoc);
            //kryptonDataGridViewpoa.Columns.ToDynamicList().ForEach(col =>
            //{
            //    DataGridViewColumn column = col;
            //    col.HeaderText = typeof(POATableObj).GetProperties().ToList()
            //    .Where(x => col.HeaderText == x.Name)
            //    .Select(x => x.GetCustomAttribute<DisplayAttribute>())
            //    .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
            //    if (column.HeaderText == "bi_deli_loc_id" || column.HeaderText == "bi_supp_id"
            //    || column.HeaderText == "ti_tc_id" || column.HeaderText == "ti_deli_sched_id"
            //    || column.HeaderText == "itemLists")
            //    {
            //        column.Visible = false;
            //    }

            //});


            //var deliscType = await _dbServices.SelectAllAsync<lut_deli_schedule_type>();
            //List<lut_deli_schedule_type> sc = JsonConvert.DeserializeObject<List<lut_deli_schedule_type>>(JsonConvert.SerializeObject(deliscType.result));
            //sc.ForEach(x => cbxdelisc.Items.Add($"{x.ti_deli_sched_id}: {x.vc_deli_sched_desc}"));

        }
        private async Task LoadViewTable(string loc = null, searchObj obj = null)
        {
            lblnoresult.Hide();
            kryptonDataGridViewpoa.DataSource = null;
            poaObj = await _pOAWorker.GetPoaWorker(loc, obj);
            if (poaObj == null)
            {
                kryptonDataGridViewpoa.Columns.Clear();
                lblnoresult.Show();
                btnadd.Hide();
                btnedit.Hide();
                return;
            }
            var observableItems = new ObservableCollection<POATableObj>(poaObj);
            BindingList<POATableObj> source = observableItems.ToBindingList();

            if (poaObj != null)
                kryptonDataGridViewpoa.DataSource = source;

            GenUtil.dataGridAttrName<POATableObj>(kryptonDataGridViewpoa, new List<string>() { "not_shown" });
        }
        private void kryptonDataGridViewpoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex < 0 || e.RowIndex < 0) return; // header clicked

            if (e.RowIndex == kryptonDataGridViewpoa.CurrentRow.Index)
            {
                lblsubitemtitle.Show();
                int selectdId = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpoa.CurrentRow.Cells["bi_poa_header_id"].Value);

                kryptonDataGridViewitem.DataSource = null;
                if (GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpoa.CurrentRow.Cells["ti_poa_type_id"].Value) == 2)
                {
                    lblsubitemtitle.Hide();
                    return;
                }
                List<PoaItemList> itemViewSelect = poaObj.Where(x => x.bi_poa_header_id == selectdId).FirstOrDefault().itemLists;
                var observableItems = new ObservableCollection<PoaItemList>(itemViewSelect);
                BindingList<PoaItemList> source = observableItems.ToBindingList();
                kryptonDataGridViewitem.DataSource = source;
                GenUtil.dataGridAttrName<PoaItemList>(kryptonDataGridViewitem, new List<string>() { "not_shown" });
                //kryptonDataGridViewitem.Columns.ToDynamicList().ForEach(col =>
                //{
                //    DataGridViewColumn column = col;
                //    col.HeaderText = typeof(ItemRequest).GetProperties().ToList()
                //    .Where(x => col.HeaderText == x.Name)
                //    .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                //    .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                //    if (column.HeaderText == "i_uom_id")
                //    {
                //        column.Visible = false;
                //    }

                //});

            }
        }
        //edit POA and POA header
        private async void btnedit_Click(object sender, EventArgs e)
        {
            var currentIndex = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpoa.CurrentRow.Cells["bi_poa_header_id"].Value);
            var currentpoaType = GenUtil.ConvertObjtoType<int>(kryptonDataGridViewpoa.CurrentRow.Cells["ti_poa_type_id"].Value);
            if (currentpoaType == 2)
            {
                MessageBox.Show("Contract Agreement has no items to update");
                return;
            }
            var readyToEdit = poaObj.Where(x => x.bi_poa_header_id == currentIndex).ToList();

            POAEdit poaEdit = new POAEdit(currentIndex, readyToEdit, _dbServices, _pOAWorker);
            poaEdit.MdiParent = this.MdiParent;
            poaEdit.AutoScroll = true;
            poaEdit.Show();
            this.Close();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            POACreate poaCre = new POACreate(_dbServices);
            poaCre.MdiParent = this.MdiParent;
            poaCre.AutoScroll = true;
            poaCre.Show();
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnsearch_Click(object sender, EventArgs e)
        {
            btnadd.Show();
            btnedit.Show();
            if (cbxsearch1.SelectedItem == cbxsearch2.SelectedItem && txtsearch1.Text != "" && txtsearch2.Text != "")
            {
                MessageBox.Show("Duplicate Search criteria");
                return;
            }
            lblnoresult.Hide();
            lblsubitemtitle.Hide();
            kryptonDataGridViewpoa.DataSource = null;
            string userLoc = userIden.Claims.FirstOrDefault(x => x.Type == "location_id").Value.ToString();

            if (txtsearch1.Text == string.Empty && txtsearch2.Text == string.Empty)
            {
                await LoadViewTable(userLoc);
                return;
            }
            var obj = new searchObj();

            foreach (KryptonPanel c in Controls.OfType<KryptonPanel>())
            {
                c.Controls.OfType<KryptonTextBox>().ToList().ForEach(x =>
                {
                    if (x.Text != string.Empty)
                    {
                        c.Controls.OfType<KryptonComboBox>().ToList().ForEach(p =>
                        {
                            var searchkey = searchWords.FirstOrDefault(x => x.Key == p.SelectedItem.ToString()).Value;
                            obj.searchWords.Add(searchkey, new List<string>() { x.Text });
                        });
                    }
                });
            }

            await LoadViewTable(userLoc, obj);
        }
        private async Task GetSearchWords(ClaimsIdentity identity)
        {

            IEnumerable<tb_search_gen> searchString = await _searchFunc.SearchParaGenerator(identity);
            if (searchString == null)
            {
                return;
            }
            Dictionary<string, string> words = JsonConvert.DeserializeObject<Dictionary<string, string>>(searchString.ElementAt(0).js_search_para);

            searchWords = words;
            cbxsearch1.DataSource = words.Keys.ToList();
            cbxsearch2.DataSource = words.Keys.ToList();
        }
    }
}