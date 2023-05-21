using CPS_App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;

namespace CPS_App
{
    public partial class Maintenance : MetroFramework.Forms.MetroForm
    {
        private DbServices _dbServices;
        public Maintenance(DbServices dbServices)
        {
            InitializeComponent();
            _dbServices = dbServices;
        }

        private async void Maintenance_Load(object sender, EventArgs e)
        {
            var result = await _dbServices.SelectAllAsync<tb_roles>();
            dataGridViewRole.DataSource= result.result;
            metroGridRole.DataSource= result.result;
        }

        private void dataGridViewRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
