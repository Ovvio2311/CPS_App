using Krypton.Toolkit;
using System.Windows.Forms;

namespace CPS_App
{
    partial class RequestView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestView));
            createdbBindingSource = new BindingSource(components);
            datagridview = new KryptonDataGridView();
            datagridviewitem = new KryptonDataGridView();
            btnEdit = new KryptonButton();
            kryptonPalettebtn = new KryptonPalette(components);
            lblsearch = new KryptonLabel();
            kryptonPalettelbl = new KryptonPalette(components);
            cbxsearch1 = new KryptonComboBox();
            btnAdd = new KryptonButton();
            lblreqtable = new KryptonLabel();
            kryptonPaletteheader = new KryptonPalette(components);
            lblitem = new KryptonLabel();
            btncancel = new KryptonButton();
            btnsearch = new KryptonButton();
            cbxsearch2 = new KryptonComboBox();
            txtsearch1 = new KryptonTextBox();
            txtsearch2 = new KryptonTextBox();
            lblnoresult = new KryptonLabel();
            pnsearch2 = new KryptonPanel();
            kryptonPalettepanel = new KryptonPalette(components);
            pnsearch1 = new KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)createdbBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxsearch1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxsearch2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch2).BeginInit();
            pnsearch2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnsearch1).BeginInit();
            pnsearch1.SuspendLayout();
            SuspendLayout();
            // 
            // createdbBindingSource
            // 
            createdbBindingSource.DataSource = typeof(Migrations.createdb);
            // 
            // datagridview
            // 
            datagridview.AllowUserToAddRows = false;
            datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview.Location = new Point(12, 132);
            datagridview.Name = "datagridview";
            datagridview.ReadOnly = true;
            datagridview.RowTemplate.Height = 25;
            datagridview.Size = new Size(672, 225);
            datagridview.StateCommon.Background.Color1 = Color.White;
            datagridview.StateCommon.Background.Color2 = Color.White;
            datagridview.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            datagridview.TabIndex = 2;
            datagridview.CellClick += datagridview_CellClick;
            // 
            // datagridviewitem
            // 
            datagridviewitem.AllowUserToAddRows = false;
            datagridviewitem.AllowUserToOrderColumns = true;
            datagridviewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewitem.Location = new Point(12, 392);
            datagridviewitem.Name = "datagridviewitem";
            datagridviewitem.ReadOnly = true;
            datagridviewitem.RowTemplate.Height = 25;
            datagridviewitem.Size = new Size(881, 227);
            datagridviewitem.StateCommon.Background.Color1 = Color.White;
            datagridviewitem.StateCommon.Background.Color2 = Color.Black;
            datagridviewitem.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            datagridviewitem.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.CornerRoundingRadius = -1F;
            btnEdit.Location = new Point(496, 79);
            btnEdit.Name = "btnEdit";
            btnEdit.Palette = kryptonPalettebtn;
            btnEdit.PaletteMode = PaletteMode.Custom;
            btnEdit.Size = new Size(96, 37);
            btnEdit.TabIndex = 5;
            btnEdit.Values.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // kryptonPalettebtn
            // 
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = Color.Transparent;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 5F;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = Color.SteelBlue;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = PaletteTextHint.SystemDefault;
            // 
            // lblsearch
            // 
            lblsearch.Location = new Point(20, 21);
            lblsearch.Name = "lblsearch";
            lblsearch.Palette = kryptonPalettelbl;
            lblsearch.PaletteMode = PaletteMode.Custom;
            lblsearch.Size = new Size(60, 21);
            lblsearch.TabIndex = 7;
            lblsearch.Values.Text = "Search";
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // cbxsearch1
            // 
            cbxsearch1.CornerRoundingRadius = -1F;
            cbxsearch1.DropDownWidth = 121;
            cbxsearch1.FormattingEnabled = true;
            cbxsearch1.IntegralHeight = false;
            cbxsearch1.Location = new Point(3, 3);
            cbxsearch1.Name = "cbxsearch1";
            cbxsearch1.Size = new Size(121, 21);
            cbxsearch1.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.CornerRoundingRadius = -1F;
            btnAdd.Location = new Point(623, 79);
            btnAdd.Name = "btnAdd";
            btnAdd.Palette = kryptonPalettebtn;
            btnAdd.PaletteMode = PaletteMode.Custom;
            btnAdd.Size = new Size(96, 37);
            btnAdd.TabIndex = 9;
            btnAdd.Values.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblreqtable
            // 
            lblreqtable.Location = new Point(12, 79);
            lblreqtable.Name = "lblreqtable";
            lblreqtable.Palette = kryptonPaletteheader;
            lblreqtable.PaletteMode = PaletteMode.Custom;
            lblreqtable.Size = new Size(122, 23);
            lblreqtable.TabIndex = 10;
            lblreqtable.Values.Text = "Request Table";
            // 
            // kryptonPaletteheader
            // 
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = Color.DarkCyan;
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // lblitem
            // 
            lblitem.Location = new Point(12, 363);
            lblitem.Name = "lblitem";
            lblitem.Palette = kryptonPaletteheader;
            lblitem.PaletteMode = PaletteMode.Custom;
            lblitem.Size = new Size(79, 23);
            lblitem.TabIndex = 11;
            lblitem.Values.Text = "Item List";
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(747, 79);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = PaletteMode.Custom;
            btncancel.Size = new Size(96, 37);
            btncancel.TabIndex = 12;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // btnsearch
            // 
            btnsearch.CornerRoundingRadius = -1F;
            btnsearch.Location = new Point(633, 25);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(25, 21);
            btnsearch.TabIndex = 14;
            btnsearch.Values.Image = (Image)resources.GetObject("btnsearch.Values.Image");
            btnsearch.Values.Text = "";
            btnsearch.Click += btnsearch_Click;
            // 
            // cbxsearch2
            // 
            cbxsearch2.CornerRoundingRadius = -1F;
            cbxsearch2.DropDownWidth = 121;
            cbxsearch2.FormattingEnabled = true;
            cbxsearch2.IntegralHeight = false;
            cbxsearch2.Location = new Point(0, 3);
            cbxsearch2.Name = "cbxsearch2";
            cbxsearch2.Size = new Size(121, 21);
            cbxsearch2.TabIndex = 15;
            // 
            // txtsearch1
            // 
            txtsearch1.Location = new Point(127, 3);
            txtsearch1.Name = "txtsearch1";
            txtsearch1.Size = new Size(131, 23);
            txtsearch1.TabIndex = 16;
            // 
            // txtsearch2
            // 
            txtsearch2.Location = new Point(125, 3);
            txtsearch2.Name = "txtsearch2";
            txtsearch2.Size = new Size(131, 23);
            txtsearch2.TabIndex = 17;
            // 
            // lblnoresult
            // 
            lblnoresult.Location = new Point(20, 108);
            lblnoresult.Name = "lblnoresult";
            lblnoresult.Size = new Size(64, 20);
            lblnoresult.TabIndex = 18;
            lblnoresult.Values.Text = "No Result";
            // 
            // pnsearch2
            // 
            pnsearch2.Controls.Add(cbxsearch2);
            pnsearch2.Controls.Add(txtsearch2);
            pnsearch2.Location = new Point(371, 22);
            pnsearch2.Name = "pnsearch2";
            pnsearch2.Palette = kryptonPalettepanel;
            pnsearch2.PaletteMode = PaletteMode.Custom;
            pnsearch2.Size = new Size(256, 27);
            pnsearch2.TabIndex = 20;
            // 
            // kryptonPalettepanel
            // 
            kryptonPalettepanel.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettepanel.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // pnsearch1
            // 
            pnsearch1.Controls.Add(txtsearch1);
            pnsearch1.Controls.Add(cbxsearch1);
            pnsearch1.Location = new Point(86, 21);
            pnsearch1.Name = "pnsearch1";
            pnsearch1.Palette = kryptonPalettepanel;
            pnsearch1.PaletteMode = PaletteMode.Custom;
            pnsearch1.Size = new Size(261, 28);
            pnsearch1.TabIndex = 21;
            // 
            // RequestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1337, 514);
            Controls.Add(pnsearch1);
            Controls.Add(pnsearch2);
            Controls.Add(lblnoresult);
            Controls.Add(btnsearch);
            Controls.Add(btncancel);
            Controls.Add(lblitem);
            Controls.Add(lblreqtable);
            Controls.Add(btnAdd);
            Controls.Add(lblsearch);
            Controls.Add(btnEdit);
            Controls.Add(datagridviewitem);
            Controls.Add(datagridview);
            Name = "RequestView";
            Text = "RequestView";
            Load += RequestView_Load;
            ((System.ComponentModel.ISupportInitialize)createdbBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxsearch1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxsearch2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch2).EndInit();
            pnsearch2.ResumeLayout(false);
            pnsearch2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnsearch1).EndInit();
            pnsearch1.ResumeLayout(false);
            pnsearch1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource createdbBindingSource;
        private KryptonDataGridView datagridview;
        private KryptonDataGridView datagridviewitem;
        private KryptonButton btnEdit;
        private KryptonLabel lblsearch;
        private KryptonComboBox cbxsearch1;
        private KryptonButton btnAdd;
        private KryptonLabel lblreqtable;
        private KryptonLabel lblitem;
        private KryptonPalette kryptonPaletteheader;
        private KryptonPalette kryptonPalettebtn;
        private KryptonButton btncancel;
        private KryptonPalette kryptonPalettelbl;
        private KryptonButton btnsearch;
        private KryptonComboBox cbxsearch2;
        private KryptonTextBox txtsearch1;
        private KryptonTextBox txtsearch2;
        private KryptonLabel lblnoresult;
        private KryptonPanel pnsearch2;
        private KryptonPalette kryptonPalettepanel;
        private KryptonPanel pnsearch1;
    }
}