using CommonDBUtils;
using CPS_App.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPS_App
{
    public partial class Form3 : Form
    {
        private readonly IConfiguration _configuration;
        private readonly Db _db;
        public Form3(IConfiguration configuration, Db db)
        {
            _configuration = configuration;
            _db = db;
            InitializeComponent();
            PopulateDataGridView();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void SetupDataGridView()
        {
            //this.Controls.Add(songsDataGridView);

            //songsDataGridView.ColumnCount = 2;
            /*
            songsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            songsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            songsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(songsDataGridView.Font, FontStyle.Bold);

            songsDataGridView.Name = "songsDataGridView";
            songsDataGridView.Location = new Point(8, 8);
            songsDataGridView.Size = new Size(500, 250);
            songsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            songsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            songsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            songsDataGridView.GridColor = Color.Black;
            songsDataGridView.RowHeadersVisible = false;

            songsDataGridView.Columns[0].Name = "Id";
            songsDataGridView.Columns[1].Name = "Password";
            */
            //songsDataGridView.Columns[4].DefaultCellStyle.Font =
            //  new Font(songsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);
            /*
            songsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            songsDataGridView.MultiSelect = false;
            songsDataGridView.Dock = DockStyle.Fill;

            songsDataGridView.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                songsDataGridView_CellFormatting);
        */
        }

     
        private void PopulateDataGridView()
        {
            string sql = "select * from cps_db.tb_users;";
            var result = _db.Query<dynamic>(sql, null);
            //if have result
            List<List<KeyValuePair<string, object>>> output = new();

            foreach (var row in result)
            {
                var singlePair = new KeyValuePair<string, object>();
                var listRow = new List<KeyValuePair<string, object>>();
                var rows = row;
                //Console.WriteLine(rows);
                foreach (var col in rows)
                {
                    var cols = (KeyValuePair<string, object>)col;
                    singlePair = cols;
                    //Console.WriteLine(cols);
                    listRow.Add(singlePair);
                    //Console.WriteLine(listRow);
                }
                
                output.Add(listRow);
                Console.WriteLine("");
            }

            DataTable dt = new DataTable();
            var rowIndex = 0;

            foreach (var header in output[0])
            {
                dt.Columns.Add(header.Key);
            }
            foreach (List<KeyValuePair<string, object>> rows in output)
            {

                //dataGridView1.Rows.Add();
                //dataGridView1.Rows[rowIndex].Selected = true;
                DataRow r = dt.NewRow();
                foreach (KeyValuePair<string, object> col in rows)
                {
                    r[col.Key] = col.Value;                    
                }
                dt.Rows.Add(r);
            }
            dataGridView1.DataSource = dt;
            /*
            string[] row0 = { "11/22/1968", "29" };
            dataGridView1.Rows.Add(row0);
            
            string[] row0 = { "11/22/1968", "29", "Revolution 9",
            "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
            "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
            "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
            "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
            "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
            "Scatterbrain. (As Dead As Leaves.)",
            "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };
            
            songsDataGridView.Rows.Add(row0);
            songsDataGridView.Rows.Add(row1);
            songsDataGridView.Rows.Add(row2);
            songsDataGridView.Rows.Add(row3);
            songsDataGridView.Rows.Add(row4);
            songsDataGridView.Rows.Add(row5);
            songsDataGridView.Rows.Add(row6);
            
            songsDataGridView.Columns[0].DisplayIndex = 3;
            songsDataGridView.Columns[1].DisplayIndex = 4;
            songsDataGridView.Columns[2].DisplayIndex = 0;
            songsDataGridView.Columns[3].DisplayIndex = 1;
            songsDataGridView.Columns[4].DisplayIndex = 2;
            */
        }
    }
}
