using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS_App.Models
{
    class RegisterModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password), Display(Name = "Password"), StringLength(20, MinimumLength = 3)]
        public string Password { get; set; }

        [Display(ShortName = "Re_Password", Name = "Re-enter Password")]
        public string Re_Password { get; set; }

        [DataType(DataType.EmailAddress), Display(Name = "Email")]
        public string Email { get; set; }
        public enum GroupType
        {
            User = 1,
            Admin = 2,
        }
    }
}
