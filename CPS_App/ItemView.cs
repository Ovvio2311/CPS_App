using CPS_App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPS_App
{
    public partial class ItemView : Form
    {
        public ClaimsIdentity userIden;
        public AuthService _authService;
        private readonly DbServices _dbServices;
        public ItemView(DbServices dbServices, AuthService authService)
        {
            InitializeComponent();
            _dbServices = dbServices;
            _authService = authService;
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden != null)
            {
                var userRole = userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToString();


            }
        }
    }
}
