using CommonDBUtils;
using CPS_App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CPS_App.Helpers
{
    public class Validator : ValidatesAttributes
    {
        private List<string> message = new List<string>();
        public Validator() { }


        private async void validateAttribute(string key, dynamic rule)
        {
            try
            {

                string[] ruleList = parse(rule);
                string method = string.Format("validate{0}", ruleList[0]);
                var value /*input value*/= request.GetType().GetProperty(key).GetValue(request, null);
                MethodInfo? theMethod = typeof(ValidatesAttributes).GetMethod(method, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);

                var valid = (bool)theMethod.Invoke(this, new object[] { key, value, ruleList[1], this });
                if (!valid && value != null && value != string.Empty)
                {
                    addFailure(ruleList[0], key, value, ruleList[1]);
                }



            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Validator make(dynamic request, dynamic rule)
        {
            this.request = request;
            rules = explodeRules(rule);
            return this;
        }

        public bool fails()
        {
            return !passes();
        }
        public bool passes()
        {
            foreach (var rule in rules)
            {
                //bool ignorable = isIgnorable(rule.Value);
                string attribute = rule.Key;
                foreach (string fieldRule in rule.Value)
                {
                    validateAttribute(rule.Key, fieldRule);
                }
            }
            return !message.Any();
        }
        private bool isIgnorable(object[] rule)
        {
            foreach (string fieldRule in rule)
            {
                if (fieldRule == "required")
                {
                    return false;
                }
            }
            return true;
        }
        private Dictionary<string, object[]> explodeRules(dynamic rules)
        {
            var rule = new Dictionary<string, object[]>();
            foreach (PropertyInfo propertyInfo in rules.GetType().GetProperties())
            {
                string key = propertyInfo.Name;
                string value = propertyInfo.GetValue(rules, null);
                rule.Add(key, value.Split('|'));
            }
            return rule;
        }
        private dynamic parse(string value)
        {
            string parameters = "";
            if (value.IndexOf(":") >= 0)
            {
                var splitRule = value.Split(':');
                value = splitRule[0];
                parameters = splitRule[1];
            }
            value = value.Replace('-', ' ').Replace('_', ' ');
            string rule = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value.ToLower()).Replace(" ", String.Empty);
            return new string[] {
                rule.Trim(),
                parameters
            };
        }
        private void addFailure(string rule, string key, string value, string parameter)
        {
            ErrMessage msg = new ErrMessage();
            string? reason = msg.message.Where(n => n.Key == key).Select(n => (string)n.Value).FirstOrDefault();
            message.Add($"Validation_{key}:\n{reason}\n");
            //var matches = Regex.Matches(reason, @"{(.*?)}");
            //var uniqueMatchCount = matches.OfType<Match>().Select(m => m.Value).Distinct().Count();
            //if (uniqueMatchCount == 0)
            //{
            //    message.Add(reason);
            //}
            //else if (parameter.Trim() != string.Empty)
            //{
            //    message.Add(string.Format(reason, key, parameter));
            //}
            //else
            //{
            //    message.Add(string.Format(reason, key));
            //}
        }
        public List<string> errors()
        {
            return message;
        }
        public class ErrMessage
        {
            public List<KeyValuePair<string, object>> message;
            public ErrMessage()
            {
                message = new List<KeyValuePair<string, object>>()
                {
                    new KeyValuePair<string, object>("name", "User name at least 4 characters!"),
                    new KeyValuePair<string, object>("password", "Password at least 1 Capital letter, 1 Small letter, 1 number, 1 symbol and at least 8 characters!"),
                    new KeyValuePair<string, object>("re_password", "Passwords not match!"),
                    new KeyValuePair<string, object>("email","Email invalid!")
                };

            }
        }
    }
}
