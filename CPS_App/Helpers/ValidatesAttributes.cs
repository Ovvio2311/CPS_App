using CommonDBUtils;
using CPS_App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;

namespace CPS_App.Helpers
{
    public class ValidatesAttributes
    {
        public dynamic request;
        public readonly DbServices _dbservice;
        public readonly Db _db;
        public Dictionary<string, object[]> rules;


        protected bool validateInt(string attribute, dynamic value, dynamic parameters, Validator validator)
        {
            if (value == null) { return false; }
            if (!validateMin(attribute, value, "3", validator)) { return false; }
            return int.TryParse(value, out int valueInt) ? true : false;
        }
        protected bool validatePassword(string attribute, dynamic value, dynamic parameters, Validator validator)
        {
            if (value is not string)
            {
                return false;
            }
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9 :])(?=.{8,})";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(value);
        }
        protected bool validateSame(string attribute, dynamic value, dynamic parameters, Validator validator)
        {
            var compareValue = request.GetType().GetProperty(parameters).GetValue(request, null);

            return value == compareValue;

        }
        protected bool validateEmail(string attribute, dynamic value, dynamic parameters, Validator validator)
        {
            return new EmailAddressAttribute().IsValid(value);
        }
        protected bool validateRequired(string attribute, dynamic value, dynamic parameters, Validator validator)
        {
            if (value == null)
            {
                return false;
            }
            else if (value is string && value.Trim() == string.Empty)
            {
                return false;
            }

            return true;
        }
        protected bool validateGender(string attribute, dynamic value, dynamic parameters, Validator validator)
        {
            if (!(value is string))
            {
                return false;
            }
            return value == "M" || value == "F";
        }
        protected bool validateMin(string attribute, dynamic value, dynamic parameters, Validator validator)
        {
            if (value == null)
            {
                return false;
            }
            return getSize(attribute, value) >= int.Parse(parameters);
        }

        protected bool validateMax(string attribute, dynamic value, dynamic parameters, Validator validator)
        {
            if (value == null)
            {
                return false;
            }
            return getSize(attribute, value) <= int.Parse(parameters);
        }
        protected bool validateRole(string attribute, dynamic value, dynamic parameters, Validator validator)
        {
            if (value == null)
            {
                return false;
            }
            return value == "User" || value == "Admin" || value == "Restaurant" || value == "Category" || value == "Purchase" ||
             value == "Warehouse";
        }
        private dynamic getSize(string attribute, dynamic value)
        {
            if (value is int || value is double || value is decimal)
            {
                return value;
            }

            return value.Length;
        }

    }
}
