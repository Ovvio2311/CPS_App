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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestView));
            this.createdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datagridview = new Krypton.Toolkit.KryptonDataGridView();
            this.datagridviewitem = new Krypton.Toolkit.KryptonDataGridView();
            this.btnEdit = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblsearch = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.cbxsearch1 = new Krypton.Toolkit.KryptonComboBox();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.lblreqtable = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblitem = new Krypton.Toolkit.KryptonLabel();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnsearch = new Krypton.Toolkit.KryptonButton();
            this.cbxsearch2 = new Krypton.Toolkit.KryptonComboBox();
            this.txtsearch1 = new Krypton.Toolkit.KryptonTextBox();
            this.txtsearch2 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.createdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch2)).BeginInit();
            this.SuspendLayout();
            // 
            // createdbBindingSource
            // 
            this.createdbBindingSource.DataSource = typeof(CPS_App.Migrations.createdb);
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(12, 132);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowTemplate.Height = 25;
            this.datagridview.Size = new System.Drawing.Size(672, 225);
            this.datagridview.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.datagridview.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.datagridview.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.datagridview.TabIndex = 2;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellClick);
            // 
            // datagridviewitem
            // 
            this.datagridviewitem.AllowUserToAddRows = false;
            this.datagridviewitem.AllowUserToOrderColumns = true;
            this.datagridviewitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewitem.Location = new System.Drawing.Point(12, 392);
            this.datagridviewitem.Name = "datagridviewitem";
            this.datagridviewitem.ReadOnly = true;
            this.datagridviewitem.RowTemplate.Height = 25;
            this.datagridviewitem.Size = new System.Drawing.Size(881, 227);
            this.datagridviewitem.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.datagridviewitem.StateCommon.Background.Color2 = System.Drawing.Color.Black;
            this.datagridviewitem.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.datagridviewitem.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.CornerRoundingRadius = -1F;
            this.btnEdit.Location = new System.Drawing.Point(496, 79);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Palette = this.kryptonPalettebtn;
            this.btnEdit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnEdit.Size = new System.Drawing.Size(96, 37);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // kryptonPalettebtn
            // 
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 5F;
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.SystemDefault;
            // 
            // lblsearch
            // 
            this.lblsearch.Location = new System.Drawing.Point(20, 21);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Palette = this.kryptonPalettelbl;
            this.lblsearch.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblsearch.Size = new System.Drawing.Size(60, 21);
            this.lblsearch.TabIndex = 7;
            this.lblsearch.Values.Text = "Search";
            // 
            // kryptonPalettelbl
            // 
            this.kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // cbxsearch1
            // 
            this.cbxsearch1.CornerRoundingRadius = -1F;
            this.cbxsearch1.DropDownWidth = 121;
            this.cbxsearch1.FormattingEnabled = true;
            this.cbxsearch1.IntegralHeight = false;
            this.cbxsearch1.Location = new System.Drawing.Point(86, 21);
            this.cbxsearch1.Name = "cbxsearch1";
            this.cbxsearch1.Size = new System.Drawing.Size(121, 21);
            this.cbxsearch1.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.CornerRoundingRadius = -1F;
            this.btnAdd.Location = new System.Drawing.Point(623, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Palette = this.kryptonPalettebtn;
            this.btnAdd.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnAdd.Size = new System.Drawing.Size(96, 37);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Values.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblreqtable
            // 
            this.lblreqtable.Location = new System.Drawing.Point(12, 93);
            this.lblreqtable.Name = "lblreqtable";
            this.lblreqtable.Palette = this.kryptonPaletteheader;
            this.lblreqtable.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblreqtable.Size = new System.Drawing.Size(122, 23);
            this.lblreqtable.TabIndex = 10;
            this.lblreqtable.Values.Text = "Request Table";
            // 
            // kryptonPaletteheader
            // 
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkCyan;
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // lblitem
            // 
            this.lblitem.Location = new System.Drawing.Point(12, 363);
            this.lblitem.Name = "lblitem";
            this.lblitem.Palette = this.kryptonPaletteheader;
            this.lblitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblitem.Size = new System.Drawing.Size(79, 23);
            this.lblitem.TabIndex = 11;
            this.lblitem.Values.Text = "Item List";
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(747, 79);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(96, 37);
            this.btncancel.TabIndex = 12;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnsearch
            // 
            this.btnsearch.CornerRoundingRadius = -1F;
            this.btnsearch.Location = new System.Drawing.Point(633, 21);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(25, 21);
            this.btnsearch.TabIndex = 14;
            this.btnsearch.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.btnsearch.Values.Text = "";
            // 
            // cbxsearch2
            // 
            this.cbxsearch2.CornerRoundingRadius = -1F;
            this.cbxsearch2.DropDownWidth = 121;
            this.cbxsearch2.FormattingEnabled = true;
            this.cbxsearch2.IntegralHeight = false;
            this.cbxsearch2.Location = new System.Drawing.Point(369, 21);
            this.cbxsearch2.Name = "cbxsearch2";
            this.cbxsearch2.Size = new System.Drawing.Size(121, 21);
            this.cbxsearch2.TabIndex = 15;
            // 
            // txtsearch1
            // 
            this.txtsearch1.Location = new System.Drawing.Point(213, 21);
            this.txtsearch1.Name = "txtsearch1";
            this.txtsearch1.Size = new System.Drawing.Size(131, 23);
            this.txtsearch1.TabIndex = 16;
            // 
            // txtsearch2
            // 
            this.txtsearch2.Location = new System.Drawing.Point(496, 21);
            this.txtsearch2.Name = "txtsearch2";
            this.txtsearch2.Size = new System.Drawing.Size(131, 23);
            this.txtsearch2.TabIndex = 17;
            // 
            // RequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 514);
            this.Controls.Add(this.txtsearch2);
            this.Controls.Add(this.txtsearch1);
            this.Controls.Add(this.cbxsearch2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblitem);
            this.Controls.Add(this.lblreqtable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxsearch1);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.datagridviewitem);
            this.Controls.Add(this.datagridview);
            this.Name = "RequestView";
            this.Text = "RequestView";
            this.Load += new System.EventHandler(this.RequestView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private NotifyIcon notifyIcon1;
        private KryptonButton btnsearch;
        private KryptonComboBox cbxsearch2;
        private KryptonTextBox txtsearch1;
        private KryptonTextBox txtsearch2;
    }
}