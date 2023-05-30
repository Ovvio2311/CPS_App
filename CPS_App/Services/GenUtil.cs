using Krypton.Toolkit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App.Services
{
    public class GenUtil
    {
        
        public static dynamic ConvertObjtoType<T>(object obj)
        {
            if (typeof(T) == typeof(DateTime)) { return DateTime.Parse(obj.ToString()); }
            if (typeof(T) == typeof(string)) { return Convert.ToString(obj); }
            if (typeof(T) == typeof(int)) { return int.TryParse(obj.ToString(),out int number)? Convert.ToInt32(obj):obj; }
            if (typeof(T) == typeof(double)) { return double.TryParse(obj.ToString(), out double number) ? Convert.ToDouble(obj) : obj; }
            if (typeof(T) == typeof(decimal)) { return decimal.TryParse(obj.ToString(), out decimal number) ? Convert.ToDecimal(obj) : obj; }
            return null;
        }
        public static bool isNull(string obj)
        {
            return string.IsNullOrWhiteSpace(obj.Trim()) ? true : false;
        }
        public static bool isNull(List<string> obj)
        {
            foreach (var item in obj)
            {
                if (string.IsNullOrWhiteSpace(item.Trim()))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ArrayToString(dynamic obj)
        {

            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            return string.Join("\n", obj);
        }
        public static List<List<KeyValuePair<string, object>>> DbResulttoKVP(IEnumerable<dynamic> obj)
        {
            List<List<KeyValuePair<string, object>>> output = new();

            foreach (var row in obj)
            {
                var singlePair = new KeyValuePair<string, object>();
                var listRow = new List<KeyValuePair<string, object>>();
                var rows = row;

                foreach (var col in rows)
                {
                    var cols = (KeyValuePair<string, object>)col;
                    singlePair = cols;

                    listRow.Add(singlePair);

                }
                output.Add(listRow);
                Console.WriteLine("");
            }
            return output;
        }
        public static List<T> DbResultToClass<T>(IEnumerable<dynamic> obj)
        {
            return JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(obj));
        }
        public static async Task TableSelector<T>(T table, string res, string req)
        {
            string sql = $"select {res} from {typeof(T).Name} " +
                         $" where {req} = {req}";
        }

        public static void dataGridAttrName<T>(KryptonDataGridView grid, List<string> invisibleList=null)
        {            
            grid.Columns.ToDynamicList().ForEach(col =>
            {
                DataGridViewColumn column = col;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.HeaderText = typeof(T).GetProperties().ToList()
                .Where(x => col.HeaderText == x.Name)
                .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                .Where(x => x != null).Select(x => x.Name.ToString()).FirstOrDefault();
                if(invisibleList != null)
                {
                    foreach (var header in invisibleList)
                    {
                        if (column.HeaderText == header)
                        {
                            column.Visible = false;
                        }
                    }
                }                
            });
        }
        
    }
}
