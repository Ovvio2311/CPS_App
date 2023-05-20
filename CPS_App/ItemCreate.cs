using CPS_App.Helpers;
using CPS_App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CPS_App.Models.CPSModel;
using static CPS_App.Models.DbModels;

namespace CPS_App
{
    public partial class ItemCreate : Form
    {
        private DbServices _dbServices;
        private Validator _validator;
        public ClaimsIdentity userIden;
        public StockLevelViewObj req;
        public ItemCreate(DbServices dbServices)
        {
            InitializeComponent();
            _dbServices = dbServices;
            req = new StockLevelViewObj();
            _validator = new Validator();

        }

        private void pnit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemCreate_Load(object sender, EventArgs e)
        {
            userIden = AuthService._userClaim;
            if (userIden != null)
            {

                if (!(userIden.Claims.FirstOrDefault(x => x.Type == "role").Value.ToLower() == "admin"))//warehouse admin
                {
                    MessageBox.Show("You are not the warehouse admin");
                    return;
                }
            }
        }

        private void requiredFieldCheck(object sender, EventArgs e)
        {



            var avaliableCat = pncat.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            var availableItem = pnit.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if (avaliableCat != 1 || avaliableItemBox != )
            {


            }
            else
            {

            }
        }

        private async void btncatsb_Click(object sender, EventArgs e)
        {
            if (txtcatname.Text == String.Empty)
            {
                MessageBox.Show("Please enter Category name");
            }
            else
            {
                var obj = new selectObj();
                obj.table = "tb_item_category";
                obj.selecter.Add("vc_category_desc", txtcatname.Text);
                var res = await _dbServices.SelectWhereAsync(obj);
                if (res.resCode != 1)
                {
                    //_logger.LogDebug("item Id not find");
                    MessageBox.Show("error");
                    return;
                }
                else if (res.resCode == 1 && res.result.Count > 0)
                {
                    MessageBox.Show("Category Name has been used");
                    return;
                }
                else
                {
                    //insert into tb_caterogy
                    var tb_cat = new insertObj();
                    tb_cat.table = "tb_item_category";
                    tb_cat.inserter = new Dictionary<string, string>
                    {
                        { nameof(req.vc_category_desc), txtcatname.Text },
                    };
                    var tb_cat_res = await _dbServices.InsertAsync(tb_cat);
                    if (tb_cat_res.resCode != 1 || tb_cat_res.result.Count <= 0)
                    {
                        //_logger.LogDebug("insert error");
                        MessageBox.Show("insert error");
                    }else
                    {
                        MessageBox.Show($"New Category created, ID: {tb_cat_res.result}");
                    }
                }
            }
        }

        private void btnitsb_Click(object sender, EventArgs e)
        {
            var availableItem = pnit.Controls.OfType<TextBox>().Where(n => !GenUtil.isNull(n.Text)).Count();
            if(availableItem != 5)
            {
                MessageBox.Show("Please completed the item form");
            }
        }
    }
}
