using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPS_App.Services;
using Krypton.Toolkit;
using static CPS_App.Models.CPSModel;

namespace CPS_App
{
    public partial class VIDMapping : KryptonForm
    {
        private RequestMapping _requestMapp;
        public List<RequestMappingReqObj> defPage;
        public VIDMapping(RequestMapping requestMapping)
        {
            InitializeComponent();
            defPage = new List<RequestMappingReqObj>();
            _requestMapp = requestMapping;
        }

        private async void VIDMapping_Load(object sender, EventArgs e)
        {
            defPage = await _requestMapp.RequestMappingObjGetter();

            int rowIndex = 0;


            foreach (var def in defPage)
            {
                int colIndex = 0;

                if (rowIndex == 0)
                {
                    foreach (PropertyInfo prop in def.GetType().GetProperties())
                    {
                        var attName = prop.GetCustomAttribute<DisplayAttribute>();
                        if (attName == null || attName.Name == "nil")
                        {
                            continue;
                        }
                        Label singleLab = new Label();
                        singleLab.Name = $"lblheader{rowIndex}{colIndex}";
                        singleLab.Size = new Size(100, 20);
                        singleLab.ForeColor = Color.Black;
                        singleLab.Location = new Point(colIndex * 100, rowIndex * 20);
                        singleLab.Text = attName.Name;

                        this.Controls.Add(singleLab);
                        colIndex++;
                    }

                }
                colIndex = 0;

                foreach (PropertyInfo prop in def.GetType().GetProperties())
                {

                    var attName = prop.GetCustomAttribute<DisplayAttribute>();
                    if (attName == null || attName.Name == "nil")
                    {
                        continue;
                    }
                    Label singleLab = new Label();
                    singleLab.Name = $"lblprop{rowIndex}{colIndex}";
                    singleLab.Size = new Size(100, 20);
                    singleLab.ForeColor = Color.Black;
                    singleLab.Location = new Point(colIndex * 100, (rowIndex + 1) * 20);
                    var str = prop.GetValue(def, null);
                    singleLab.Text = GenUtil.ConvertObjtoType<string>(str);

                    this.Controls.Add(singleLab);
                    colIndex++;
                }

                rowIndex++;

                var lst = this.Controls.OfType<Label>().ToList();
                foreach (Label lbl in lst)
                {
                    lbl.Click += Lbl_Click;
                }
            }
        }

        private void Lbl_Click(object? sender, EventArgs e)
        {
            Label lbl = sender as Label;
            MessageBox.Show(lbl.Name);
        }
    }
}
