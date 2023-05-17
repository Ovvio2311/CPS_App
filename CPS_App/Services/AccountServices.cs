using CPS_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS_App.Services
{
    public class AccountServices
    {
        public async Task<bool> GetAccessAsync(LoginRequest loginRequest)
        {
            return true;
        }
    }
}
