using Krypton.Toolkit;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections;
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
            if (typeof(T) == typeof(long)) { return long.TryParse(obj.ToString(), out long number) ? Convert.ToInt64(obj) : obj; }
            if (typeof(T) == typeof(int)) { return int.TryParse(obj.ToString(), out int number) ? Convert.ToInt32(obj) : obj; }
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

        public static void dataGridAttrName<T>(KryptonDataGridView grid, List<string> invisibleList = null)
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
                if (invisibleList != null)
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
        //textbox to label
        public static async Task<bool> ConfirmListAttach(Form form)
        {
            var confirmObj = new Dictionary<string, string>();
            form.Controls.OfType<KryptonLabel>().ToList().ForEach(x =>
            {
                form.Controls.OfType<KryptonTextBox>().ToList().ForEach(p =>
                {
                    if (p.Enabled == true)
                    {
                        if (p.Tag != null && x.Tag != null &&
                        p.Tag.ToString() == x.Tag.ToString() && x.Text.Trim() != string.Empty)
                        {
                            confirmObj.Add(x.Text, p.Text);
                        }
                    }
                });
                form.Controls.OfType<KryptonComboBox>().ToList().ForEach(c =>
                {
                    if (c.Tag != null && x.Tag != null &&
                    c.Tag.ToString() == x.Tag.ToString())
                    {
                        confirmObj.Add(x.Text, c.SelectedItem.ToString());
                    }
                });
                form.Controls.OfType<DateTimePicker>().ToList().ForEach(d =>
                {
                    if (d.Tag != null && x.Tag != null &&
                    d.Tag.ToString() == x.Tag.ToString())
                    {
                        confirmObj.Add(x.Text, d.Value.ToString());
                    }
                });

            });
            string confirmStr = string.Join(Environment.NewLine, confirmObj.Select(x => $"{x.Key} = {x.Value}").ToList());

            DialogResult response = MessageBox.Show(confirmStr, "Confirm", MessageBoxButtons.YesNo);
            return response == DialogResult.Yes ? true : false;
        }
        //class obj to label
        public static async Task<bool> ConfirmListAttach<T>(Panel form, List<T> obj)
        {
            List<Dictionary<string, string>> confirmObj = new List<Dictionary<string, string>>();

            foreach (var item in obj)
            {
                Dictionary<string, string> temp = new Dictionary<string, string>();
                form.Controls.OfType<KryptonLabel>().ToList().ForEach(x =>
                {
                    if (item != null)
                    {
                        item.GetType().GetProperties().ToList().ForEach(p =>
                        {
                            if (x.Tag != null && p.Name == x.Tag.ToString())
                            {
                                if (p.GetValue(item).ToString() != null && p.GetValue(item) != "")
                                {
                                    temp.Add(x.Text, p.GetValue(item).ToString());
                                }
                            }
                        });
                    }
                });
                confirmObj.Add(temp);
            }

            string confirmStr = string.Empty;
            confirmObj.ForEach(x =>
            {
                x.ToList().ForEach(x =>
                {
                    confirmStr += string.Join(Environment.NewLine, $"{x.Key} = {x.Value}\n");
                });
            });

            DialogResult response = MessageBox.Show(confirmStr, "Confirm", MessageBoxButtons.YesNo);
            return response == DialogResult.Yes ? true : false;
        }

        //form class to textbox
        public static async Task AutoLabelAddingToTextBox<T>(Form form, T obj)
        {
            obj.GetType().GetProperties().ToList().ForEach(x =>
            {
                form.Controls.OfType<KryptonTextBox>().ToList().ForEach(p =>
                {
                    if (p.Tag != null && p.Tag.ToString() == x.Name)
                    {
                        if (x.GetValue(obj).ToString() != null && x.GetValue(obj) != "")
                        {
                            p.Text = GenUtil.ConvertObjtoType<string>(x.GetValue(obj, null));
                        }
                    }
                });
                form.Controls.OfType<KryptonComboBox>().ToList().ForEach(c =>
                {
                    if (c.Tag != null && c.Tag.ToString() == x.Name)
                    {
                        if (x.GetValue(obj).ToString() != null && x.GetValue(obj) != "")
                        {
                            var value = x.GetValue(obj);
                            c.SelectedItem = c.Items.ToDynamicList<string>().Where(x => x.Contains(value.ToString())).FirstOrDefault();
                        }
                    }
                });
            });
        }
        //no use
        public static async Task AutoAddObjItemFromTextBox<T>(Form form, T obj)
        {
            form.Controls.OfType<KryptonTextBox>().ToList().ForEach(x =>
            {
                obj.GetType().GetProperties().ToList().ForEach(p =>
                {
                    if (x.Tag != null && p.Name == x.Tag.ToString())
                    {
                        p.SetValue(obj, Convert.ChangeType(x.Text, p.PropertyType, null));
                    }

                });
            });
        }
    }
}
