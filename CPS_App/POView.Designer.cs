namespace CPS_App
{
    partial class POView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POView));
            this.kryptonDataGridViewpo = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonDataGridViewitem = new Krypton.Toolkit.KryptonDataGridView();
            this.btnedit = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btnadd = new Krypton.Toolkit.KryptonButton();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.pnsearch1 = new Krypton.Toolkit.KryptonPanel();
            this.txtsearch1 = new Krypton.Toolkit.KryptonTextBox();
            this.cbxsearch1 = new Krypton.Toolkit.KryptonComboBox();
            this.pnsearch2 = new Krypton.Toolkit.KryptonPanel();
            this.cbxsearch2 = new Krypton.Toolkit.KryptonComboBox();
            this.txtsearch2 = new Krypton.Toolkit.KryptonTextBox();
            this.btnsearch = new Krypton.Toolkit.KryptonButton();
            this.lblsearch = new Krypton.Toolkit.KryptonLabel();
            this.lbltitle = new Krypton.Toolkit.KryptonLabel();
            this.lblnoresult = new Krypton.Toolkit.KryptonLabel();
            this.lblsubitemtitle = new Krypton.Toolkit.KryptonLabel();
            this.btnconfirmSchRe = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnsearch1)).BeginInit();
            this.pnsearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnsearch2)).BeginInit();
            this.pnsearch2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridViewpo
            // 
            this.kryptonDataGridViewpo.AllowUserToAddRows = false;
            this.kryptonDataGridViewpo.Location = new System.Drawing.Point(31, 123);
            this.kryptonDataGridViewpo.Name = "kryptonDataGridViewpo";
            this.kryptonDataGridViewpo.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewpo.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewpo.RowTemplate.Height = 25;
            this.kryptonDataGridViewpo.Size = new System.Drawing.Size(647, 221);
            this.kryptonDataGridViewpo.TabIndex = 0;
            this.kryptonDataGridViewpo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridViewpoa_CellClick);
            // 
            // kryptonPalettedatagridview
            // 
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // kryptonDataGridViewitem
            // 
            this.kryptonDataGridViewitem.AllowUserToAddRows = false;
            this.kryptonDataGridViewitem.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewitem.Location = new System.Drawing.Point(31, 394);
            this.kryptonDataGridViewitem.Name = "kryptonDataGridViewitem";
            this.kryptonDataGridViewitem.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewitem.ReadOnly = true;
            this.kryptonDataGridViewitem.RowTemplate.Height = 25;
            this.kryptonDataGridViewitem.Size = new System.Drawing.Size(647, 164);
            this.kryptonDataGridViewitem.TabIndex = 1;
            // 
            // btnedit
            // 
            this.btnedit.CornerRoundingRadius = -1F;
            this.btnedit.Location = new System.Drawing.Point(460, 56);
            this.btnedit.Name = "btnedit";
            this.btnedit.Palette = this.kryptonPalettebtn;
            this.btnedit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnedit.Size = new System.Drawing.Size(100, 35);
            this.btnedit.TabIndex = 2;
            this.btnedit.Values.Text = "Update";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
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
            // kryptonPalettelbl
            // 
            this.kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // kryptonPaletteheader
            // 
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkCyan;
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // kryptonPalettereadonly
            // 
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color2 = System.Drawing.SystemColors.Control;
            // 
            // kryptonPalettepanel
            // 
            this.kryptonPalettepanel.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettepanel.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // btnadd
            // 
            this.btnadd.CornerRoundingRadius = -1F;
            this.btnadd.Location = new System.Drawing.Point(333, 56);
            this.btnadd.Name = "btnadd";
            this.btnadd.Palette = this.kryptonPalettebtn;
            this.btnadd.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnadd.Size = new System.Drawing.Size(100, 35);
            this.btnadd.TabIndex = 25;
            this.btnadd.Values.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(589, 56);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(100, 35);
            this.btncancel.TabIndex = 27;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // pnsearch1
            // 
            this.pnsearch1.Controls.Add(this.txtsearch1);
            this.pnsearch1.Controls.Add(this.cbxsearch1);
            this.pnsearch1.Location = new System.Drawing.Point(97, 12);
            this.pnsearch1.Name = "pnsearch1";
            this.pnsearch1.Palette = this.kryptonPalettepanel;
            this.pnsearch1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.pnsearch1.Size = new System.Drawing.Size(261, 28);
            this.pnsearch1.TabIndex = 31;
            // 
            // txtsearch1
            // 
            this.txtsearch1.Location = new System.Drawing.Point(127, 3);
            this.txtsearch1.Name = "txtsearch1";
            this.txtsearch1.Size = new System.Drawing.Size(131, 23);
            this.txtsearch1.TabIndex = 16;
            // 
            // cbxsearch1
            // 
            this.cbxsearch1.CornerRoundingRadius = -1F;
            this.cbxsearch1.DropDownWidth = 121;
            this.cbxsearch1.FormattingEnabled = true;
            this.cbxsearch1.IntegralHeight = false;
            this.cbxsearch1.Location = new System.Drawing.Point(3, 3);
            this.cbxsearch1.Name = "cbxsearch1";
            this.cbxsearch1.Size = new System.Drawing.Size(121, 21);
            this.cbxsearch1.TabIndex = 8;
            // 
            // pnsearch2
            // 
            this.pnsearch2.Controls.Add(this.cbxsearch2);
            this.pnsearch2.Controls.Add(this.txtsearch2);
            this.pnsearch2.Location = new System.Drawing.Point(382, 13);
            this.pnsearch2.Name = "pnsearch2";
            this.pnsearch2.Palette = this.kryptonPalettepanel;
            this.pnsearch2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.pnsearch2.Size = new System.Drawing.Size(256, 27);
            this.pnsearch2.TabIndex = 30;
            // 
            // cbxsearch2
            // 
            this.cbxsearch2.CornerRoundingRadius = -1F;
            this.cbxsearch2.DropDownWidth = 121;
            this.cbxsearch2.FormattingEnabled = true;
            this.cbxsearch2.IntegralHeight = false;
            this.cbxsearch2.Location = new System.Drawing.Point(0, 3);
            this.cbxsearch2.Name = "cbxsearch2";
            this.cbxsearch2.Size = new System.Drawing.Size(121, 21);
            this.cbxsearch2.TabIndex = 15;
            // 
            // txtsearch2
            // 
            this.txtsearch2.Location = new System.Drawing.Point(125, 3);
            this.txtsearch2.Name = "txtsearch2";
            this.txtsearch2.Size = new System.Drawing.Size(131, 23);
            this.txtsearch2.TabIndex = 17;
            // 
            // btnsearch
            // 
            this.btnsearch.CornerRoundingRadius = -1F;
            this.btnsearch.Location = new System.Drawing.Point(644, 16);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(25, 21);
            this.btnsearch.TabIndex = 29;
            this.btnsearch.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Values.Image")));
            this.btnsearch.Values.Text = "";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.Location = new System.Drawing.Point(31, 12);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Palette = this.kryptonPalettelbl;
            this.lblsearch.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblsearch.Size = new System.Drawing.Size(60, 21);
            this.lblsearch.TabIndex = 28;
            this.lblsearch.Values.Text = "Search";
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(31, 68);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Palette = this.kryptonPaletteheader;
            this.lbltitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lbltitle.Size = new System.Drawing.Size(131, 23);
            this.lbltitle.TabIndex = 33;
            this.lbltitle.Values.Text = "Purchase Order";
            // 
            // lblnoresult
            // 
            this.lblnoresult.Location = new System.Drawing.Point(31, 97);
            this.lblnoresult.Name = "lblnoresult";
            this.lblnoresult.Size = new System.Drawing.Size(64, 20);
            this.lblnoresult.TabIndex = 32;
            this.lblnoresult.Values.Text = "No Result";
            // 
            // lblsubitemtitle
            // 
            this.lblsubitemtitle.Location = new System.Drawing.Point(31, 365);
            this.lblsubitemtitle.Name = "lblsubitemtitle";
            this.lblsubitemtitle.Palette = this.kryptonPaletteheader;
            this.lblsubitemtitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblsubitemtitle.Size = new System.Drawing.Size(79, 23);
            this.lblsubitemtitle.TabIndex = 34;
            this.lblsubitemtitle.Values.Text = "Sub Item";
            // 
            // btnconfirmSchRe
            // 
            this.btnconfirmSchRe.AutoSize = true;
            this.btnconfirmSchRe.CornerRoundingRadius = -1F;
            this.btnconfirmSchRe.Location = new System.Drawing.Point(710, 56);
            this.btnconfirmSchRe.Name = "btnconfirmSchRe";
            this.btnconfirmSchRe.Palette = this.kryptonPalettebtn;
            this.btnconfirmSchRe.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnconfirmSchRe.Size = new System.Drawing.Size(143, 35);
            this.btnconfirmSchRe.TabIndex = 35;
            this.btnconfirmSchRe.Values.Text = "Re-Confirm Order";
            this.btnconfirmSchRe.Click += new System.EventHandler(this.btnconfirmppo_Click);
            // 
            // POView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 638);
            this.Controls.Add(this.btnconfirmSchRe);
            this.Controls.Add(this.lblsubitemtitle);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblnoresult);
            this.Controls.Add(this.pnsearch1);
            this.Controls.Add(this.pnsearch2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.kryptonDataGridViewitem);
            this.Controls.Add(this.kryptonDataGridViewpo);
            this.Name = "POView";
            this.Text = "POView";
            this.Load += new System.EventHandler(this.POView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnsearch1)).EndInit();
            this.pnsearch1.ResumeLayout(false);
            this.pnsearch1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnsearch2)).EndInit();
            this.pnsearch2.ResumeLayout(false);
            this.pnsearch2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewpo;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewitem;
        private Krypton.Toolkit.KryptonButton btnedit;
        private Krypton.Toolkit.KryptonPalette kryptonPalettelbl;
        private Krypton.Toolkit.KryptonPalette kryptonPaletteheader;
        private Krypton.Toolkit.KryptonPalette kryptonPalettereadonly;
        private Krypton.Toolkit.KryptonPalette kryptonPalettepanel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettebtn;
        private Krypton.Toolkit.KryptonButton btnadd;
        private Krypton.Toolkit.KryptonButton btncancel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettedatagridview;
        private Krypton.Toolkit.KryptonPanel pnsearch1;
        private Krypton.Toolkit.KryptonTextBox txtsearch1;
        private Krypton.Toolkit.KryptonComboBox cbxsearch1;
        private Krypton.Toolkit.KryptonPanel pnsearch2;
        private Krypton.Toolkit.KryptonComboBox cbxsearch2;
        private Krypton.Toolkit.KryptonTextBox txtsearch2;
        private Krypton.Toolkit.KryptonButton btnsearch;
        private Krypton.Toolkit.KryptonLabel lblsearch;
        private Krypton.Toolkit.KryptonLabel lbltitle;
        private Krypton.Toolkit.KryptonLabel lblnoresult;
        private Krypton.Toolkit.KryptonLabel lblsubitemtitle;
        private Krypton.Toolkit.KryptonButton btnconfirmSchRe;
    }
}