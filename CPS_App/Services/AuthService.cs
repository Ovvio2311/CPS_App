using CPS_App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CPS_App.Helpers;
using System.Security.Claims;

namespace CPS_App.Services
{
    public class AuthService
    {
        private readonly UserManager<AppUsers> _userManager;
        private readonly SignInManager<AppUsers> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        private readonly ClaimsManager _claimsManager;
        public  static ClaimsIdentity _userClaim;


        public AuthService(
            SignInManager<AppUsers> signInManager,
            UserManager<AppUsers> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db,
            ClaimsManager claimsManager
            
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _db = db;
            _claimsManager = claimsManager;
            _userClaim = null;
        }

        #region Getters

        public async Task<AppUsers> GetUserByEmailAsync(string email)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(email);
                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<AppUsers> GetUserById(string id)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(id);
                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion


        #region Login, register, unpdate 
        //public ClaimsIdentity GetUserClaims()
        //{
        //    return this._userClaim;
        //}

        public async Task<SignInResult> Login(string email, string password, bool rememberMe = false)
        {
            try
            {
                return await _signInManager.PasswordSignInAsync(email, password, rememberMe, false);
            }
            catch (Exception ex)
            {
                return SignInResult.Failed;
            }
        }

       
        public async Task<bool> Login(string userName, string password)
        {
            try
            {
                
                var user = await _userManager.FindByNameAsync(userName);
                
                var result = await _signInManager.CheckPasswordSignInAsync(user, password, true);
                //var check = await _userManager.CheckPasswordAsync(user, password);
                if (result.Succeeded)
                {
                    _userClaim = await _claimsManager.GetClaimsIdentity(userName);
                    return true;
                }
                if (result.IsLockedOut)
                {
                    MessageBox.Show("Account Lockout!");
                    string date = (await _userManager.GetLockoutEndDateAsync(user)).Value.LocalDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    MessageBox.Show($"Unlock Time: {date}");

                    //MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task SignIn(AppUsers model, bool isPersistent = false)
        {
            try
            {
                await _signInManager.SignInAsync(model, isPersistent: false);
            }
            catch (Exception ex)
            {

            }
        }


        #endregion

        #region Roles

        public async Task<bool> IsInRole(string email, string role)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(email);
                return await _userManager.IsInRoleAsync(user, role);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IdentityResult> AddToRoleAsync(string email, string role)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(email);
                return await _userManager.AddToRoleAsync(user, role);
            }
            catch (Exception ex)
            {
                IdentityError errors = new IdentityError();
                errors.Code = ex.StackTrace;
                errors.Description = ex.Message;
                return IdentityResult.Failed(errors);
            }

        }

        public async Task<IdentityResult> RemoveFromRoleAsync(string email, string role)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(email);
                return await _userManager.RemoveFromRoleAsync(user, role);
            }
            catch (Exception ex)
            {
                IdentityError errors = new IdentityError();
                errors.Code = ex.StackTrace;
                errors.Description = ex.Message;
                return IdentityResult.Failed(errors);
            }

        }

        public async Task<List<IdentityRole>> RoleList()
        {
            try
            {
                return await _roleManager.Roles.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }

        }


        #endregion




        public async Task<bool> IsUserActive(string email)
        {
            try
            {
                var res = await _db.AppUsers.FirstOrDefaultAsync(x => x.Email == email);
                if (true)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> PasswordValidator(string passwword)
        {
            var passwordValidator = new PasswordValidator<AppUsers>();
            return await passwordValidator.ValidateAsync(_userManager, null, passwword);
        }

        public string PasswordHasher(AppUsers user, string passwod)
        {
            try
            {
                return _userManager.PasswordHasher.HashPassword(user, passwod);
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        public async Task<string> PasswordHashAsync(AppUsers model)
        {
            try
            {
                var passwordValidator = new PasswordValidator<AppUsers>();
                var passwordResult = await passwordValidator.ValidateAsync(_userManager, null, model.PasswordHash);

                if (passwordResult.Succeeded)
                {
                    //hash new password
                    var newPasswordHash = _userManager.PasswordHasher.HashPassword(model, model.PasswordHash);
                    return newPasswordHash;
                }

                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }
        
    }
}
