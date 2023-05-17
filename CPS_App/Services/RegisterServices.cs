using CPS_App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static CPS_App.Models.CPSModel;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class RegisterServices
    {
        
        private readonly UserManager<AppUsers> _userManager;
        private readonly SignInManager<AppUsers> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        private readonly IUserStore<AppUsers> _userStore;
        private readonly IUserEmailStore<AppUsers> _emailStore;
        private readonly DbServices _dbServices;
        
        public ILogger<RegisterServices> _logger { get; set; }

        public RegisterServices
        (
            SignInManager<AppUsers> signInManager,
            UserManager<AppUsers> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db,
            IUserStore<AppUsers> userStore,
            DbServices dbServices,
            ILogger<RegisterServices> logger

        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _db = db;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _dbServices = dbServices;
            _logger = logger;
        }
        public async Task<bool> CreateUserAsync(dynamic request)
        {

            //var user00 = await _userManager.FindByNameAsync("User777");
            //var tt = await _userManager.GetRolesAsync(user00);
            //var iuser = await _userManager.FindByNameAsync("app_admin");
            //var roleuser = await _roleManager.FindByNameAsync("User");
            //var groupRole = await _userManager.GetUsersInRoleAsync("Admin");
            //var rr = await _userManager.AddToRoleAsync(iuser, "Admin");
            //var singin = _signInManager.CreateUserPrincipalAsync(iuser);

            var user = CreateUser();
            //var re = await _userManager.
            await _userStore.SetUserNameAsync(user, request.name, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, request.email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, request.password);
            await setStaffAsnyc(request.location, request.name, request.empid, request.staffRole, CancellationToken.None);
            await SetUserRoleAsync(request.name, request.role, CancellationToken.None);                      
            
            return result.Succeeded ? true : false;

        }
        private AppUsers CreateUser()
        {
            try
            {
                return Activator.CreateInstance<AppUsers>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
        private IUserEmailStore<AppUsers> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<AppUsers>)_userStore;
        }
        private async Task<bool> setStaffAsnyc(string location, string name, string empID, string staffRole, CancellationToken token)
        {
            //find user id
            var user = await _userManager.FindByNameAsync(name);
            if (user == null) { return false; }
            var userID = user.Id;
            
            
            //find Location Id
            selectObj findLoc = new selectObj();
            findLoc.selecter.Add("vc_location_desc", location);
            findLoc.table = "tb_location";
            var findLocid = await _dbServices.SelectWhereAsync(findLoc);
            if (findLocid.resCode != 1 || findLocid.result.Count == 0)
            {
                _logger.LogDebug("Location not find");
                return false;
            }
            List<List<KeyValuePair<string, object>>> pairvalue_loc = GenUtil.DbResulttoKVP(findLocid.result);
            if (pairvalue_loc.Count == 0) { return false; }
            var LocId = pairvalue_loc.Select(x => x).FirstOrDefault().Where(y => y.Key == "bi_location_id").FirstOrDefault().Value.ToString();


            if (!await validateEmp(empID))
            {
                _logger.LogDebug("EmployeeID duplicate");
                return false;
            }
            //create insert tb_staff object
            var insertObj = new tb_staff()
            {
                i_staff_id = GenUtil.ConvertObjtoType<int>(empID),
                vc_staff_role = staffRole,
                vc_user_id = userID,
                bi_location_id = GenUtil.ConvertObjtoType<int>(LocId)
            };

            var result = await _dbServices.InsertAsync<tb_staff>(insertObj);
            if (result.resCode != 1) { return false; }

            return true;
        }
        private async Task<bool> SetUserRoleAsync(string name, string role, CancellationToken token)
        {
            //find user id
            var user = await _userManager.FindByNameAsync(name);
            if (user == null) { return false; }
            var userID = user.Id;


        
            //find role id
            var roleType = await _roleManager.FindByNameAsync(role);
            if (roleType == null) { return false; }
            var roleID = roleType.Id;
         
            //create insert tb_user_roles object
            var insertObj = new tb_user_roles()
            {
                vc_user_id = userID,
                vc_role_id = roleID
            };

            var result = await _dbServices.InsertAsync<tb_user_roles>(insertObj);
            if (result.resCode != 1) { return false; }

            return true;
        }
        public async Task<bool> validateEmp(dynamic value)
        {
            var obj = new selectObj();
            obj.selecter.Add("i_staff_id", value);
            obj.table = "tb_staff";
            var result = await _dbServices.SelectWhereAsync(obj);
            if (result.resCode != 1 || result.result.Count > 0) { return false; }
            return true;
        }
    }
}
