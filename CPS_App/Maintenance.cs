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
            var result = await _dbServices.SelectAllAsync<tb_roles>();
            kryptodatagrid.DataSource = result.result;

            var userResult = await _dbServices.SelectAllAsync<tb_users>();
            kryptonDataGridViewUser.DataSource = userResult.result;

            multiDetailView.Show();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
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


        private void btnAddnewuser_Click(object sender, EventArgs e)
        {
            Register regNew = new Register(_registerServices, _dbServices);
            regNew.MdiParent = this;
            regNew.Show();
        }
    }
}
