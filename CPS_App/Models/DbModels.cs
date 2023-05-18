using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS_App.Models
{
    public class DbModels
    {
        public class reqObj
        {
            public string table { get; set; }
            public Dictionary<string, string> selecter { get; set; }
            public reqObj()
            {
                selecter = new Dictionary<string, string>();
            }

        }
        public class updateObj : reqObj
        {
            public updateObj()
            {
                updater = new Dictionary<string, string>();

            }
            public Dictionary<string, string> updater { get; set; }

        }
        public class insertObj : reqObj
        {
            public insertObj()
            {
                inserter = new Dictionary<string, string>();

            }
            public Dictionary<string, string> inserter { get; set; }

        }
        public class selectObj : reqObj
        {
            public selectObj()
            {

            }

        }
        public class resObj
        {
            public dynamic result { get; set; }
            public int resCode { get; set; }
        }
        public class DbResObj
        {
            public dynamic result { get; set; }
            public int resCode { get; set; }
            public string err_msg { get; set; }
        }
    }
}
