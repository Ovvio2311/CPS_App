using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPS_App.Data
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class MySQL
    {
        public string ConnectionString { get; set; }
    }



    public class AppConfig
    {
        public string AllowedHosts { get; set; }
        public MySQL MySQL { get; set; }

        public DateTimeFormat DateTimeFormat { get; set; }
        public List<Process_List> Process_List { get; set; }

        public int interval_start { get; set; }
        public int interval_end { get; set; }
        public int interval_iccx01 { get; set; }

    }




    public class Process_List
    {
        public List<string> ProcessType { get; set; }
        public int Job_Interval_Min { get; set; }
    }

    public class DateTimeFormat
    {
        public string GOV_DateTime { get; set; }
        public string GOV_Date { get; set; }
        public string TSP_Datetime { get; set; }
        public string TSP_Date { get; set; }
        public string DB_DateTime { get; set; }
        public string DB_DateTime_out { get; set; }
        public string DB_Date { get; set; }
        public string DB_Date_out { get; set; }
        public string DB_Time { get; set; }
    }
}
