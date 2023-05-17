using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CPS_App.Models
{
    public class AppUsers : IdentityUser
    {
        [Required(ErrorMessage = "User Name is Required")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Only letters")]
        [MaxLength(100), MinLength(4, ErrorMessage = " 4 Characters")]
        public string UserName { get; set; }

        
        //[Required(ErrorMessage = "Password is Required")]
        //[RegularExpression(@"^(?=[a-zA-Z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9 :])(?=.{8,})", ErrorMessage = "Only letters")]
        //[StringLength(100, ErrorMessage = "Minimum 8 Characters, Minimum 1 Capital Letter and Minimum 1 Special Character", MinimumLength = 8)]
        //public string Password { get; set; }

   

      


     

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Capture a Valid Email")]
        public override string Email { get => base.Email; set => base.Email = value; }

        //[Required(ErrorMessage = "Phone is required")]
        //[RegularExpression(@"^[0-9]+$", ErrorMessage = "Only numbers")]
        //[MaxLength(10, ErrorMessage = "Only 10 digits")]
        //public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        
        //public string Logout { get; set; }

        



    }
}
