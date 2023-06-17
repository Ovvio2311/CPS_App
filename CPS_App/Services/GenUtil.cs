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
using System.Windows.Forms;
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
            if (typeof(T) == typeof(long)) { return long.TryParse(obj.ToString(), out long number) ? Convert.ToInt64(obj) : null; }
            if (typeof(T) == typeof(int)) { return int.TryParse(obj.ToString(), out int number) ? Convert.ToInt32(obj) : null; }
            if (typeof(T) == typeof(double)) { return double.TryParse(obj.ToString(), out double number) ? Convert.ToDouble(obj) : null; }
            if (typeof(T) == typeof(decimal)) { return decimal.TryParse(obj.ToString(), out decimal number) ? Convert.ToDecimal(obj) : null; }
            return null;
        }
        public static bool isNull(string obj)
        {

            return string.IsNullOrWhiteSpace(obj.Trim()) || obj == string.Empty ? true : false;
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
        //coordinate label and textbox, combobox, datetimepicker to confirm list
        public static async Task<string> ConfirmListAttach(Form form)
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
            return string.Join(Environment.NewLine, confirmObj.Select(x => $"{x.Key} = {x.Value}").ToList());
        }
        //coordinate class obj and label data to confirm list
        public static async Task<string> ConfirmListAttach<T>(Panel form, List<T> obj)
        {
            List<Dictionary<string, string>> confirmObj = new List<Dictionary<string, string>>();

            foreach (var item in obj)
            {
                try {
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
                }catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                
            }

            string confirmStr = string.Empty;
            confirmObj.ForEach(x =>
            {
                x.ToList().ForEach(x =>
                {
                    confirmStr += string.Join(Environment.NewLine, $"{x.Key} = {x.Value}\n");
                });
            });
            return confirmStr;
        }

        //Adding data from class obj to textbox and combobox
        public static async Task AutoLabelAddingfromTextBox<T>(Form form, T obj)
        {

            obj!.GetType().GetProperties().ToList().ForEach(x =>
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
        //for Po Create
        public static async Task AutoLabelAddingTextBox<T>(Panel pan, List<T> List)
        {

            try
            {
                List.ForEach(obj =>
                {
                    obj!.GetType().GetProperties().ToList().ForEach(x =>
                    {

                        pan.Controls.OfType<KryptonTextBox>().ToList().ForEach(p =>
                        {
                            if (p.Tag != null && p.Tag.ToString() == x.Name)
                            {
                                if (x.GetValue(obj).ToString() != null && x.GetValue(obj) != "")
                                {
                                    p.Text = GenUtil.ConvertObjtoType<string>(x.GetValue(obj, null));
                                    p.Enabled = false;
                                }
                            }
                        });
                        pan.Controls.OfType<KryptonComboBox>().ToList().ForEach(c =>
                        {

                            if (c.Tag != null && c.Tag.ToString().Contains(":"))
                            {
                                var id = c.Tag.ToString().Split(":").ElementAt(0);
                                var name = c.Tag.ToString().Split(":").ElementAt(1);
                                if (id == x.Name)
                                {
                                    c.SelectedItem = c.Items.ToDynamicList<string>().Where(c => c.ToString().Contains(x.GetValue(obj).ToString())).FirstOrDefault();
                                    c.Enabled = false;
                                    //var idValue = c.SelectedItem.ToString().Split(":").ElementAt(0);
                                    //x.SetValue(obj, Convert.ChangeType(idValue, x.PropertyType, null));
                                }
                                else if (name == x.Name)
                                {

                                }
                            }
                            else if (c.Tag != null && x.Name == c.Tag.ToString() && c.Enabled)
                            {
                                c.SelectedItem = c.Items.ToDynamicList<string>().Where(c => c.ToString().Contains(x.GetValue(obj).ToString())).FirstOrDefault();
                                c.Enabled = false;
                            }
                        });
                        pan.Controls.OfType<KryptonDateTimePicker>().ToList().ForEach(t =>
                        {
                            if (t.Tag != null && t.Tag.ToString() == x.Name)
                            {
                                if (x.GetValue(obj).ToString() != null && x.GetValue(obj) != "")
                                {
                                    t.Value = GenUtil.ConvertObjtoType<DateTime>(x.GetValue(obj));
                                    t.Enabled = false;
                                }
                            }
                        });
                    });
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public static async Task ResumeBlankPage<T>(Panel pan, List<T> List=null)
        {

            try
            {
                typeof(T).GetProperties().ToList().ForEach(x =>
                {

                    pan.Controls.OfType<KryptonTextBox>().ToList().ForEach(p =>
                    {
                        if (p.Tag != null && p.Tag.ToString() == x.Name)
                        {

                            p.Text = string.Empty;
                            p.Enabled = true;

                        }
                    });
                    pan.Controls.OfType<KryptonComboBox>().ToList().ForEach(c =>
                    {

                        if (c.Tag != null && c.Tag.ToString().Contains(":"))
                        {
                            var id = c.Tag.ToString().Split(":").ElementAt(0);
                            var name = c.Tag.ToString().Split(":").ElementAt(1);
                            if (id == x.Name)
                            {
                                c.SelectedIndex = -1;
                                c.Enabled = true;
                                //var idValue = c.SelectedItem.ToString().Split(":").ElementAt(0);
                                //x.SetValue(obj, Convert.ChangeType(idValue, x.PropertyType, null));
                            }
                            else if (name == x.Name)
                            {

                            }
                        }
                        else if (c.Tag != null && x.Name == c.Tag.ToString() && c.Enabled)
                        {
                            c.SelectedIndex = -1;
                            c.Enabled = true;
                        }
                    });
                    pan.Controls.OfType<KryptonDateTimePicker>().ToList().ForEach(t =>
                    {
                        if (t.Tag != null && t.Tag.ToString() == x.Name)
                        {

                            t.Value = DateTime.Now;
                            t.Enabled = true;

                        }
                    });
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        //add textbox, combobox data to class obj
        public static async Task AddingInputToObject<T>(Panel panel, T obj)
        {
            panel.Controls.OfType<KryptonTextBox>().ToList().ForEach(x =>
            {
                obj.GetType().GetProperties().ToList().ForEach(p =>
                {
                    if (x.Tag != null && p.Name == x.Tag.ToString() &&
                    x.Text.Trim() != string.Empty )
                    {
                        p.SetValue(obj, Convert.ChangeType(x.Text, p.PropertyType, null));
                    }

                });
            });
            panel.Controls.OfType<KryptonComboBox>().ToList().ForEach(x =>
            {
                obj.GetType().GetProperties().ToList().ForEach(p =>
                {
                    if (x.Tag != null && x.Tag.ToString().Contains(":"))
                    {
                        var id = x.Tag.ToString().Split(":").ElementAt(0);
                        var name = x.Tag.ToString().Split(":").ElementAt(1);
                        if (id == p.Name)
                        {
                            var idValue = x.SelectedItem.ToString().Split(":").ElementAt(0);
                            p.SetValue(obj, Convert.ChangeType(idValue, p.PropertyType, null));
                        }
                        else if (name == p.Name)
                        {
                            var nameValue = x.SelectedItem.ToString().Split(":").ElementAt(1);
                            p.SetValue(obj, Convert.ChangeType(nameValue, p.PropertyType, null));
                        }
                    }
                    else if (x.Tag != null && p.Name == x.Tag.ToString() )
                    {
                        var value = x.SelectedItem.ToString().Split(":").ElementAt(0);
                        p.SetValue(obj, Convert.ChangeType(value, p.PropertyType, null));
                    }

                });
            });
            panel.Controls.OfType<KryptonDateTimePicker>().ToList().ForEach(d =>
            {
                obj.GetType().GetProperties().ToList().ForEach(p =>
                {
                    if (d.Tag != null && p.Name == d.Tag.ToString() &&
                    d.Text.Trim() != string.Empty )
                    {
                        p.SetValue(obj, Convert.ChangeType(d.Value.ToString("yyyy-MM-dd HH:mm:ss"), p.PropertyType, null));
                    }

                });
            });
        }
    }
}
