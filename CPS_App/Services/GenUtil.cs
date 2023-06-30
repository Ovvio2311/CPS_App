using Krypton.Toolkit;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using ScintillaNET;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Runtime.InteropServices;
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
                try
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
                                    if (p.GetValue(item, null) != null && p.GetValue(item, null) != "")
                                    {
                                        temp.Add(x.Text, p.GetValue(item).ToString());
                                    }
                                }
                            });
                        }
                    });
                    confirmObj.Add(temp);
                }
                catch (Exception ex)
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
                        if (x.GetValue(obj) != null && x.GetValue(obj) != "")
                        {
                            p.Text = GenUtil.ConvertObjtoType<string>(x.GetValue(obj, null));
                        }
                    }
                });
                form.Controls.OfType<KryptonComboBox>().ToList().ForEach(c =>
                {
                    if (c.Tag != null && c.Tag.ToString() == x.Name)
                    {
                        if (x.GetValue(obj) != null && x.GetValue(obj) != "")
                        {
                            var value = x.GetValue(obj);
                            c.SelectedItem = c.Items.ToDynamicList<string>().Where(x => x.Contains(value.ToString())).FirstOrDefault();
                        }
                    }
                });
            });


        }
        //for Po Create
        public static async Task AutoLabelAddingTextBox<T>(Panel pan, List<T> List, string ignore = null)
        {
            string check = "ignore";
            if (ignore != null)
            {
                check = ignore;
            }

            try
            {
                List.ForEach(obj =>
                {
                    obj!.GetType().GetProperties().ToList().ForEach(x =>
                    {

                        if (x.Name != check)
                        {
                            pan.Controls.OfType<KryptonTextBox>().ToList().ForEach(p =>
                            {
                                if (p.Tag != null && p.Tag.ToString() == x.Name)
                                {
                                    if (x.GetValue(obj) != null && x.GetValue(obj) != "")
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
                                    if (x.GetValue(obj) != null && x.GetValue(obj) != "")
                                    {
                                        t.Value = GenUtil.ConvertObjtoType<DateTime>(x.GetValue(obj));
                                        t.Enabled = false;
                                    }
                                }
                            });
                        }

                    });
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public static async Task ResumeBlankPage<T>(Panel pan, List<T> List = null)
        {

            try
            {
                typeof(T).GetProperties().ToList().ForEach(x =>
                {

                    pan.Controls.OfType<KryptonTextBox>().ToList().ForEach(p =>
                    {
                        if (p.Tag != null && p.Tag.ToString() == x.Name)
                        {

                            p.Clear();
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
        //only pocreate and poacreate add textbox, combobox data to class obj
        public static async Task AddingInputToObject<T>(Panel panel, T obj)
        {
            try
            {
                panel.Controls.OfType<KryptonTextBox>().ToList().ForEach(x =>
                {
                    obj.GetType().GetProperties().ToList().ForEach(p =>
                    {
                        if (x.Tag != null && p.Name == x.Tag.ToString() &&
                        x.Text.Trim() != string.Empty)
                        {
                            p.SetValue(obj, Convert.ChangeType(x.Text, p.PropertyType, null));
                        }

                    });
                });
                panel.Controls.OfType<KryptonComboBox>().ToList().ForEach(x =>
                {
                    obj.GetType().GetProperties().ToList().ForEach(p =>
                    {
                        if (x.Tag != null && x.Tag.ToString().Contains(":") && x.SelectedItem != null)
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
                        else if (x.Tag != null && p.Name == x.Tag.ToString() && x.SelectedItem != null)
                        {
                            //var value = x.SelectedItem.ToString().Split(":").ElementAt(0);
                            //for vc_ref_id only
                            p.SetValue(obj, Convert.ChangeType(x.SelectedItem.ToString(), p.PropertyType, null));
                        }

                    });
                });
                panel.Controls.OfType<KryptonDateTimePicker>().ToList().ForEach(d =>
                {
                    obj.GetType().GetProperties().ToList().ForEach(p =>
                    {
                        if (d.Tag != null && p.Name == d.Tag.ToString() &&
                        d.Text.Trim() != string.Empty)
                        {
                            p.SetValue(obj, Convert.ChangeType(d.Value.ToString("yyyy-MM-dd HH:mm:ss"), p.PropertyType, null));
                        }

                    });
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public enum KnownFolder
        {
            Contacts,
            Downloads,
            Favorites,
            Links,
            SavedGames,
            SavedSearches
        }

        public static class KnownFolders
        {
            private static readonly Dictionary<KnownFolder, Guid> _guids = new()
            {
                [KnownFolder.Contacts] = new("56784854-C6CB-462B-8169-88E350ACB882"),
                [KnownFolder.Downloads] = new("374DE290-123F-4565-9164-39C4925E467B"),
                [KnownFolder.Favorites] = new("1777F761-68AD-4D8A-87BD-30B759FA33DD"),
                [KnownFolder.Links] = new("BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968"),
                [KnownFolder.SavedGames] = new("4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4"),
                [KnownFolder.SavedSearches] = new("7D1D3A04-DEBB-4115-95CF-2F29DA2920DA")
            };

            public static string GetPath(KnownFolder knownFolder)
            {
                return SHGetKnownFolderPath(_guids[knownFolder], 0);
            }

            [DllImport("shell32",
                CharSet = CharSet.Unicode, ExactSpelling = true, PreserveSig = false)]
            private static extern string SHGetKnownFolderPath(
                [MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags,
                nint hToken = 0);
        }
        public async Task<bool> ExportCsv(List<List<KeyValuePair<string, object>>> result, string fileFolder, string fileName)
        {
            Directory.CreateDirectory(fileFolder);
            var filepath = $"{fileFolder}\\{fileName}";
            StringBuilder csv = new StringBuilder();
            var rowIndex = 0;
            try
            {
                foreach (List<KeyValuePair<string, object>> row in result)
                {
                    foreach (KeyValuePair<string, object> col in row)
                    {
                        if (rowIndex == 0)
                        {

                            csv.Append(string.Format("\"{0}\",", col.Key.ToString()));
                        }
                        else
                        {
                            var value = col.Value != null ? $"\"{col.Value.ToString()}\"" : "null";
                            csv.Append(string.Format("{0},", value));
                        }
                    }
                    csv.AppendLine("");
                    rowIndex++;
                }

                File.WriteAllText(filepath, csv.ToString());
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Fail to export {filepath} \n Error msg is {e.Message}");
                //return false;
                //throw new Exception(e.Message);
            }

        }
        public static async Task ConvertObjtoReportFormat<T>(List<T> obj) where T : new()
        {
            var newList = new List<T>();

            foreach (T r in obj)
            {
                T temp = new T();
                var attname = temp.GetType().GetProperties().ToList()
                    .Where(x => x.Name == nameof(r))
                 .Select(x => x.GetCustomAttribute<DisplayAttribute>())
                 .Where(x => x.Name != "not_shown")
                 .Select(x => x.Name.ToString()).FirstOrDefault();
            }
        }
        public static async Task<bool> ExportCsv<T>(List<T> result, string table) where T : new()
        {
            var folder = KnownFolders.GetPath(KnownFolder.Downloads);
            var filepath = $@"{folder}{table}_{DateTime.Now.ToString("yyyy-MM-dd")}.csv";
            StringBuilder csv = new StringBuilder();

            try
            {
                T pName = new T();
                int index = 0;
                foreach (var x in pName.GetType().GetProperties())
                {
                    var displayAttribute = (DisplayAttribute)x.GetCustomAttributes().First(a => a is DisplayAttribute);
                    var props = displayAttribute.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public).ToList();
                    props.Single(p => p.Name != "not_shown").SetValue(displayAttribute, index);
                    csv.Append($"\"{x.Name}\",");
                }
                csv.AppendLine("");
                foreach (var x in result)
                {

                }

                File.WriteAllText(filepath, csv.ToString());
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Fail to export {filepath} \n Error msg is {e.Message}");
                return false;
                //throw new Exception(e.Message);
            }

        }
    }
}
