using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;

namespace CPS_App.Models
{
    public interface IRolesRepository
    {
        Task<tb_roles> GetRoleAsync(string RoleName);
        Task<List<tb_roles>> GetRolesAsync();
        Task<IdentityRole> CreateRoleAsync(tb_roles model);
        Task<bool> EditRoleAsync(tb_roles model);
        Task<bool> DeleteRoleAsync(string roleId);
        Task<List<CustomUserRole>> EditUsersInRoleAsync(string RoleId);
        Task<bool> EditUsersInRoleAsync(List<CustomUserRole> model, string RoleId);
    }

    public class RolesRepository : IRolesRepository
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public RolesRepository(RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        #region Roles
        // 取得單一角色
        public async Task<tb_roles> GetRoleAsync(string RoleName)
        {
            var role = await _roleManager.FindByNameAsync(RoleName);
            var users = await _userManager.GetUsersInRoleAsync(role.Name);
            var result = new tb_roles
            {
                vc_role_id = role.Id,
                vc_role_name = role.Name,
                vc_nor_name = role.Name.ToUpper(),
                lt_concurrency_stamp = role.ConcurrencyStamp,
            };
            return result;
        }

        // 取得角色 List
        public async Task<List<tb_roles>> GetRolesAsync()
        {
            var roles = _roleManager.Roles;
            var customRoles = new List<tb_roles>();
            foreach (var role in roles)
            {
                customRoles.Add(new tb_roles {
                    vc_role_id = role.Id,
                    vc_role_name = role.Name,
                    vc_nor_name = role.Name.ToUpper(),
                    lt_concurrency_stamp = role.ConcurrencyStamp,
                });
            }
            return await Task.Run(() => customRoles);
        }

        // 建立角色
        public async Task<IdentityRole> CreateRoleAsync(tb_roles model)
        {
            IdentityRole identityRole = new IdentityRole
            {   
                Id = model.vc_role_id,
                Name = model.vc_role_name,
                NormalizedName = model.vc_nor_name,
                ConcurrencyStamp = model.lt_concurrency_stamp
            };
            var result = await _roleManager.CreateAsync(identityRole);
            if (result.Succeeded)
            {
                return identityRole;

            }
            return null;            
        }

        // 編輯角色
        public async Task<bool> EditRoleAsync(tb_roles model)
        {
            var role = await _roleManager.FindByIdAsync(model.vc_role_id);

            if (role == null)
            {
                return false;
            }
            role.Name = model.vc_role_name;
            var result = await _roleManager.UpdateAsync(role);
            if (!result.Succeeded)
            {
                return false;
            }
            return true;
        }

        // 刪除角色
        public async Task<bool> DeleteRoleAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);

            if (role == null)
            {
                return false;
            }
            var result = await _roleManager.DeleteAsync(role);
            if (!result.Succeeded)
            {
                return false;
            }
            return true;
            
        }
        public async Task<List<CustomUserRole>> EditUsersInRoleAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            var model = new List<CustomUserRole>();

            foreach (var user in _userManager.Users)
            {
                var userRoleView = new CustomUserRole
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleView.IsSelected = true;
                }
                else
                {
                    userRoleView.IsSelected = false;
                }
                model.Add(userRoleView);
            }
            return model;
        }

        public async Task<bool> EditUsersInRoleAsync(List<CustomUserRole> model, string RoleName)
        {
            var role = await _roleManager.FindByNameAsync(RoleName);
            foreach (var m in model)
            {
                var user = await _userManager.FindByIdAsync(m.UserId);
                IdentityResult result;
                if (m.IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!m.IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }
                if (result.Succeeded)
                {
                    if (model.Count > 0)
                    {
                        continue;
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                 
                }
            }
            return true;
           
        }
        #endregion

      
    }
}
