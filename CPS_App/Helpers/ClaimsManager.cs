using CPS_App.Models;
using CPS_App.Services;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading;

namespace CPS_App.Helpers
{
    public class ClaimsManager
    {
        private readonly UserManager<AppUsers> _userManager;
        
        public ClaimsManager(UserManager<AppUsers> userManager)
        {
            _userManager = userManager;
            
        }

        public async Task<ClaimsIdentity> GetClaimsIdentity(string username)
        {

            AppUsers user = await _userManager.FindByNameAsync(username);
            if (user == null) { throw new Exception("User not find"); }
            var userRole = await _userManager.GetRolesAsync(user);
            if (userRole == null) { throw new Exception("User do not have role"); }
            var claims = new List<Claim>()
            {
                new Claim("user", user.NormalizedUserName.ToLower()),
                new Claim("role",userRole[0]),
                new Claim("email", user.Email),
                new Claim("fail_count", GenUtil.ConvertObjtoType<string>(user.AccessFailedCount))
            };
            return new ClaimsIdentity(claims);
        }
    }

}