using CPS_App.Helpers;
using CPS_App.Services;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Text.RegularExpressions;
using static CPS_App.Models.CPSModel;
using Krypton.Toolkit;

namespace CPS_App
{
    
    public partial class Register : KryptonForm
    {        
        private RegisterServices _registerServices { get; set; }
        private Validator _validator;
        private DbServices _dbServices { get; set; }
        public Register(RegisterServices registerServices, DbServices dbServices)
        {
            
            InitializeComponent();
           

            
            _registerServices = registerServices;
            _validator = new Validator();
            _dbServices = dbServices;
            //this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
        }


        private async void Register_Load(object sender, EventArgs e)
        {
           
            disableValidation();

            var roleType = await _dbServices.SelectAllAsync<tb_roles>();
            List<tb_roles> rol = JsonConvert.DeserializeObject<List<tb_roles>>(JsonConvert.SerializeObject(roleType.result));
            rol.ForEach(x => GroupType.Items.Add(x.vc_role_name));
           
            var res = await _dbServices.SelectAllAsync<tb_location>();            
            List<tb_location> loc = JsonConvert.DeserializeObject<List<tb_location>>(JsonConvert.SerializeObject(res.result));
            loc.ForEach(x => locDesc.Items.Add(x.vc_location_desc));
            dynamic request = new
            {
                name = "admin",
                password = "123456Aa!",
                re_password = "123456Aa!",
                role = "Admin",
                email = "233@ddd.com",
                empid = "1234",
                location = "South Ellie",
                staffRole = "admin"

,
            };

            //submit_Click(sender, e);
           // await _registerServices.CreateUserAsync(request);
        }
        //private void requiredFieldCheck(object sender, EventArgs e)
        //{
        //    var role = GroupType.SelectedItem;
        //    var location = locDesc.SelectedItem;
        //    var availableTxtBox = grpBasic.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
        //    if (availableTxtBox != 6 || role == null || location == null)
        //    {

        //        //disableValidation();
        //        enableValidation();
        //    }
        //    else
        //    {
        //        enableValidation();
        //    }
        //}
        private async void submit_Click(object sender, EventArgs e)
        {

            //dynamic request = new
            //{
            //    name = txtName.Text,
            //    password = txtPassword.Text,
            //    re_password = txtRePw.Text,
            //    role = GroupType.SelectedItem,
            //    email = txtEmail.Text,
            //    empid = txtEmpID.Text,
            //    staffRole = txtStaffRole.Text,
            //    location = locDesc.SelectedItem,
            //    staffName = txtstaffname.Text
            //};
            dynamic request = new
            {
                name = "LoChunFai",
                password = "123456Aa!",
                re_password = "123456Aa!",
                role = "Restaurant",
                email = "LoChunFai@yummy.com",
                empid = "358",
                location = "Tai Po Road",
                staffRole = "Manager",
                staffName = "LoChunFai"

,
            };
            Validator validator = new Validator();
            validator.make(request,
            new
            {
                name /*key*/= "min:4" /*fieldRule*/,
                password = "password",
                re_password = "same:password",
                role = "role",
                email = "email",
                empid = "int",
                staffRole = "Required",
                location = "Required",
                staffName = "Required"

            });
            if (!validator.passes())
            {
                MessageBox.Show(GenUtil.ArrayToString(validator.errors()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (await _registerServices.CreateUserAsync(request))
                {
                    MessageBox.Show("Register success");

                }
                else
                {
                    MessageBox.Show("Register fail");
                }
            }
        }
        public void enableValidation()
        {
            submit.Enabled = true;
        }
        public void disableValidation()
        {
            submit.Enabled = false;
        }               

        private void clear_Click(object sender, EventArgs e)
        {

            txtName.Clear();
            txtPassword.Clear();
            txtRePw.Clear();
            GroupType.SelectionLength = 0;
            txtEmail.Clear();
            txtEmpID.Clear();
            locDesc.SelectionLength = 0;
            txtStaffRole.Clear();

        }

        private void requiredFieldCheck(object sender, CancelEventArgs e)
        {
            var role = GroupType.SelectedItem;
            var location = locDesc.SelectedItem;
            var availableTxtBox = grpBasic.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (availableTxtBox != 7 || role == null || location == null)
            {

                //disableValidation();
                enableValidation();
            }
            else
            {
                enableValidation();
            }
        }
    }
}
