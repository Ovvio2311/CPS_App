using CPS_App.Models;
using CPS_App.Services;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Threading;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Helpers
{
    public class ClaimsManager
    {
        private readonly UserManager<AppUsers> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly DbServices _dbServices;
        public ClaimsManager(UserManager<AppUsers> userManager, DbServices dbServices, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _dbServices = dbServices;
            _roleManager = roleManager;
        }

        public async Task<ClaimsIdentity> GetClaimsIdentity(string username)
        {

            AppUsers user = await _userManager.FindByNameAsync(username);
            if (user == null) { throw new Exception("User not find"); }
            var req = new selectObj();
            req.table = "tb_staff";
            req.selecter = new Dictionary<string, string>
            {
                {"vc_user_id",user.Id }
            };
            var userInfo = await _dbServices.SelectWhereAsync<tb_staff>(req);
            if (userInfo.resCode != 1 || userInfo.result == null)
            {
                //_logger.LogDebug("uom Id not find");
                MessageBox.Show("Id not find");
            }
            tb_staff info = userInfo.result[0];
            var userRole = await _userManager.GetRolesAsync(user);
            if (userRole == null) { throw new Exception("User do not have role"); }
            
            IdentityRole role = await _roleManager.FindByNameAsync(userRole[0]);
            var userclaims = await _roleManager.GetClaimsAsync(role);
            userclaims.Add(new Claim("role", userRole[0]));
            userclaims.Add(new Claim("location_id", info.bi_location_id.ToString()));
            userclaims.Add(new Claim("staff_id", info.i_staff_id.ToString()));
            userclaims.Add(new Claim("staff_role", info.vc_staff_role.ToString()));
            userclaims.Add(new Claim("staff_name", info.vc_staff_name.ToString()));
            //var claims = new List<Claim>()
            //{
            //    new Claim("user", user.NormalizedUserName.ToLower()),
            //    new Claim("role",userRole[0]),
            //    new Claim("email", user.Email),
            //    new Claim("fail_count", GenUtil.ConvertObjtoType<string>(user.AccessFailedCount)),
            //    new Claim("location_id", info.bi_location_id.ToString()),
            //    new Claim("staff_id",info.i_staff_id.ToString()),
            //    new Claim("staff_role",info.vc_staff_role.ToString()),
            //    new Claim("id", user.Id),
            //    new Claim("staff_name", info.vc_staff_name.ToString()),
            //};
            return new ClaimsIdentity(userclaims);
        }
    }

}