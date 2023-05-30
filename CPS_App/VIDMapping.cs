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
            
            List<List<Label>> label = new List<List<Label>>();
            List<Label> templabel = new List<Label>();
            foreach (var def in defPage)
            {
                int colIndex = 0;
                templabel.Clear();
                foreach (PropertyInfo prop in def.GetType().GetProperties())
                {
                    var attName = prop.GetCustomAttribute<DisplayAttribute>();
                    if(attName ==null || attName.Name == "nil")
                    {
                        continue;
                    }
                    Label singleLab = new Label();
                    singleLab.Name = $"lblprop{rowIndex}{colIndex}";
                    singleLab.Size = new Size(100, 20);
                    singleLab.ForeColor = Color.Black;
                    singleLab.Location = new Point(colIndex * 100, rowIndex * 20);
                    var str = prop.GetValue(def, null);
                    singleLab.Text = GenUtil.ConvertObjtoType<string>(str);

                    this.Controls.Add(singleLab);
                    colIndex++;
                }

                rowIndex++;
            }
        }
    }
}
