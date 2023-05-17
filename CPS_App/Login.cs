using CommonDBUtils;
using CPS_App.Models;
using CPS_App.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPS_App
{

    public partial class Login : Form
    {
        private AccountServices _accountServices { get; set; }
        private AuthService _authService { get; set; }
        private readonly Db _db;
        private IConfiguration _configuration;
        public Dashboard _dashboard { get; set; }
        public RequestMapping _requestMapping { get; set; }
        public Login(AccountServices accountServices, Db db, IConfiguration configuration, AuthService authService, Dashboard dashboard, RequestMapping requestMapping)
        {
            InitializeComponent();
            _accountServices = accountServices;
            _db = db;
            _configuration = configuration;
            _authService = authService;
            _dashboard = dashboard;
            _requestMapping = requestMapping;
        }



        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                LoginRequest loginRequest = new LoginRequest()
                {
                    Usename = txtusername.Text,
                    Password = txtpass.Text
                };
                if(await _authService.Login(loginRequest.Usename, loginRequest.Password))
                {
                    MessageBox.Show("login Success");
                    //Form3 form3 = new Form3(_configuration,_db);
                    //form3.StartPosition = FormStartPosition.CenterParent;
                    //form3.ShowDialog();
                    this.Hide();
                    _dashboard.Show();
                    
                }
                else
                {
                    MessageBox.Show("login Failed");
                }
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
