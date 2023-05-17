

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCS_API.Data
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class MySQL
    {
        public string ConnectionString { get; set; }
    }

    public class MongoDB
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }

    public class TomsApi
    {
        public string BaseUrl { get; set; }
    }
    public class TokenService
    {
        public string BaseUrl { get; set; }
    }
    public class TxvApi
    {
        public string BaseUrl { get; set; }
    }

    public class OtherService
    {
        public TomsApi TomsApi { get; set; }
        public TxvApi TxvApi { get; set; }
        public TokenService TokenService { get; set; }
    }

    public class EndpointDefaults
    {
        public string ClientCertificateMode { get; set; }
    }

    public class Default
    {
        public string Path { get; set; }
        public string KeyPath { get; set; }
    }

    public class Certificates
    {
        public Default Default { get; set; }
    }

    public class Kestrel
    {
        public EndpointDefaults EndpointDefaults { get; set; }
        public Certificates Certificates { get; set; }
    }

    public class ClientCertConfig
    {
        public string Path { get; set; }
        public string KeyPath { get; set; }
    }

    public class AppConfig
    {
        public string AllowedHosts { get; set; }
        public MySQL MySQL { get; set; }
        public MongoDB MongoDB { get; set; }
        public OtherService OtherService { get; set; }
        public string AuthAPIHost { get; set; }
        public string NotificationHost { get; set; }
        public string DBServiceAPIHost { get; set; }
        public string AuthAPI_APP_ID { get; set; }
        public string APP_ID { get; set; }
        public Kestrel Kestrel { get; set; }
        public ClientCertConfig ClientCertConfig { get; set; }
        public bool CertAuthCacheEnabled { get; set; }
        public List<string> FullSet { get; set; }
        public List<string> DeltaSet { get; set; }
        public List<string> LookupSet { get; set; }
        public bool TestingMode { get; set; }
        public string Project { get; set; }
        public string SYSTEM_APP_ID { get; set; }       
        public DateTimeFormat DateTimeFormat { get; set; }
        public List<Process_List> Process_List { get; set; }
        public bool EnableEd25519AuthenticationPlugin { get; set; }
        public int interval_start { get; set; }
        public int interval_end { get; set; }
        public int interval_iccx01 { get; set; }
        
    }

    public class ValidVType
    {
        public List<string> DeltaSet { get; set; }
        public List<string> FullSet { get; set; }
        public List<string> Daliy { get; set; }
        public List<string> Enquiry { get; set; }
        public List<string> Enquiry_Download { get; set; }
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
