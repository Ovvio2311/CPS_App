using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.DbModels;

namespace CPS_App.Models
{
    public class DbModels
    {
        public interface ICloneable<T> : ICloneable
        where T : ICloneable<T>
        {
            T Clone();
        }
        public abstract class reqObj: ICloneable
        {
            public string table { get; set; }
            public Dictionary<string, string> selecter { get; set; }
            public reqObj()
            {
                selecter = new Dictionary<string, string>();
            }

            public abstract object Clone();
            //{

            //    reqObj obj = (reqObj)this.MemberwiseClone();
            //    obj.table = this.table;
            //    obj.selecter = new Dictionary<string, string>();
            //    foreach(var kvp in this.selecter)
            //    {
            //        KeyValuePair<string, string> temp = new KeyValuePair<string, string>();
            //        temp = kvp;
            //        obj.selecter.Add(temp.Key, temp.Value);
            //    }
            //    return (reqObj)obj;
            //}

            
        }
        public class updateObj : reqObj
        {
            public updateObj()
            {
                updater = new Dictionary<string, string>();

            }
            public Dictionary<string, string> updater { get; set; }
            public override object Clone()
            {
                updateObj obj = (updateObj)this.MemberwiseClone();
                obj.table = this.table;
                obj.selecter = new Dictionary<string, string>();
                foreach (var kvp in this.selecter)
                {
                    KeyValuePair<string, string> temp = new KeyValuePair<string, string>();
                    temp = kvp;
                    obj.selecter.Add(temp.Key, temp.Value);
                }
                return obj;
            }

        }
        public class insertObj : reqObj
        {
            public insertObj()
            {
                inserter = new Dictionary<string, string>();

            }
            public Dictionary<string, string> inserter { get; set; }
            public override object Clone()
            {
                insertObj obj = (insertObj)this.MemberwiseClone();
                obj.table = this.table;
                obj.selecter = new Dictionary<string, string>();
                foreach (var kvp in this.selecter)
                {
                    KeyValuePair<string, string> temp = new KeyValuePair<string, string>();
                    temp = kvp;
                    obj.selecter.Add(temp.Key, temp.Value);
                }
                return obj;
            }

        }
        public class selectObj : reqObj
        {
            public selectObj()
            {

            }
            public override selectObj Clone()
            {
                selectObj obj = (selectObj)this.MemberwiseClone();
                    obj.table = this.table;
                    obj.selecter = new Dictionary<string, string>();
                    foreach (var kvp in this.selecter)
                    {
                        KeyValuePair<string, string> temp = new KeyValuePair<string, string>();
                        temp = kvp;
                        obj.selecter.Add(temp.Key, temp.Value);
                    }
                    return obj;                
            }

        }
        public class deleteObj : reqObj
        {
            public deleteObj()
            {
                deleter = new Dictionary<string, string>();
            }
            public Dictionary<string, string> deleter { get; set; }
            public override object Clone()
            {
                deleteObj obj = (deleteObj)this.MemberwiseClone();
                obj.table = this.table;
                obj.selecter = new Dictionary<string, string>();
                foreach (var kvp in this.selecter)
                {
                    KeyValuePair<string, string> temp = new KeyValuePair<string, string>();
                    temp = kvp;
                    obj.selecter.Add(temp.Key, temp.Value);
                }
                return obj;
            }
        }
        public class searchObj
        {
            public searchObj()
            {
                searchWords = new Dictionary<string, List<string>>();
            }
            public Dictionary<string, List<string>> searchWords { get; set; }
        }
        public class resObj
        {
            public dynamic result { get; set; }
            public int resCode { get; set; }
            public string err_msg { get; set; }
        }
        public class DbResObj
        {
            public dynamic result { get; set; }
            public int resCode { get; set; }
            public string err_msg { get; set; }
        }
    }
}
