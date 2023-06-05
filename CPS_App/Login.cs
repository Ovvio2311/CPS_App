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
        
        private AuthService _authService { get; set; }
        
        private IConfiguration _configuration;
        public Dashboard _dashboard { get; set; }
        
        public Login(IConfiguration configuration, AuthService authService, Dashboard dashboard)
        {
            InitializeComponent();
            
            
            _configuration = configuration;
            _authService = authService;
            _dashboard = dashboard;
            
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
                if(await _authService.Login("LoChunFai"/*loginRequest.Usename*/, "123456Aa!"/*loginRequest.Password)*/))
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


        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Text = string.Empty;
            txtpass.Text = string.Empty;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}
