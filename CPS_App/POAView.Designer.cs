namespace CPS_App
{
    partial class POAView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POAView));
            kryptonDataGridViewpoa = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(components);
            kryptonDataGridViewitem = new Krypton.Toolkit.KryptonDataGridView();
            btnedit = new Krypton.Toolkit.KryptonButton();
            kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(components);
            btnadd = new Krypton.Toolkit.KryptonButton();
            btncancel = new Krypton.Toolkit.KryptonButton();
            pnsearch1 = new Krypton.Toolkit.KryptonPanel();
            txtsearch1 = new Krypton.Toolkit.KryptonTextBox();
            cbxsearch1 = new Krypton.Toolkit.KryptonComboBox();
            pnsearch2 = new Krypton.Toolkit.KryptonPanel();
            cbxsearch2 = new Krypton.Toolkit.KryptonComboBox();
            txtsearch2 = new Krypton.Toolkit.KryptonTextBox();
            btnsearch = new Krypton.Toolkit.KryptonButton();
            lblsearch = new Krypton.Toolkit.KryptonLabel();
            lbltitle = new Krypton.Toolkit.KryptonLabel();
            lblnoresult = new Krypton.Toolkit.KryptonLabel();
            lblsubitemtitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewitem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch1).BeginInit();
            pnsearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsearch1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch2).BeginInit();
            pnsearch2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsearch2).BeginInit();
            SuspendLayout();
            // 
            // kryptonDataGridViewpoa
            // 
            kryptonDataGridViewpoa.AllowUserToAddRows = false;
            kryptonDataGridViewpoa.Location = new Point(31, 123);
            kryptonDataGridViewpoa.Name = "kryptonDataGridViewpoa";
            kryptonDataGridViewpoa.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewpoa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewpoa.RowTemplate.Height = 25;
            kryptonDataGridViewpoa.Size = new Size(647, 221);
            kryptonDataGridViewpoa.TabIndex = 0;
            kryptonDataGridViewpoa.CellClick += kryptonDataGridViewpoa_CellClick;
            // 
            // kryptonPalettedatagridview
            // 
            kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // kryptonDataGridViewitem
            // 
            kryptonDataGridViewitem.AllowUserToAddRows = false;
            kryptonDataGridViewitem.Location = new Point(31, 394);
            kryptonDataGridViewitem.Name = "kryptonDataGridViewitem";
            kryptonDataGridViewitem.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewitem.RowTemplate.Height = 25;
            kryptonDataGridViewitem.Size = new Size(647, 164);
            kryptonDataGridViewitem.TabIndex = 1;
            // 
            // btnedit
            // 
            btnedit.CornerRoundingRadius = -1F;
            btnedit.Location = new Point(492, 56);
            btnedit.Name = "btnedit";
            btnedit.Palette = kryptonPalettebtn;
            btnedit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnedit.Size = new Size(100, 35);
            btnedit.TabIndex = 2;
            btnedit.Values.Text = "Update";
            btnedit.Click += btnedit_Click;
            // 
            // kryptonPalettebtn
            // 
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = Color.Transparent;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 5F;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = Color.SteelBlue;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.SystemDefault;
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // kryptonPaletteheader
            // 
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = Color.DarkCyan;
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // kryptonPalettereadonly
            // 
            kryptonPalettereadonly.Common.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonPalettereadonly.Common.StateCommon.Back.Color2 = SystemColors.Control;
            // 
            // kryptonPalettepanel
            // 
            kryptonPalettepanel.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettepanel.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // btnadd
            // 
            btnadd.CornerRoundingRadius = -1F;
            btnadd.Location = new Point(362, 56);
            btnadd.Name = "btnadd";
            btnadd.Palette = kryptonPalettebtn;
            btnadd.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnadd.Size = new Size(100, 35);
            btnadd.TabIndex = 25;
            btnadd.Values.Text = "Add";
            btnadd.Click += btnadd_Click;
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(619, 56);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btncancel.Size = new Size(100, 35);
            btncancel.TabIndex = 27;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // pnsearch1
            // 
            pnsearch1.Controls.Add(txtsearch1);
            pnsearch1.Controls.Add(cbxsearch1);
            pnsearch1.Location = new Point(97, 12);
            pnsearch1.Name = "pnsearch1";
            pnsearch1.Palette = kryptonPalettepanel;
            pnsearch1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            pnsearch1.Size = new Size(261, 28);
            pnsearch1.TabIndex = 31;
            // 
            // txtsearch1
            // 
            txtsearch1.Location = new Point(127, 3);
            txtsearch1.Name = "txtsearch1";
            txtsearch1.Size = new Size(131, 23);
            txtsearch1.TabIndex = 16;
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
            // pnsearch2
            // 
            pnsearch2.Controls.Add(cbxsearch2);
            pnsearch2.Controls.Add(txtsearch2);
            pnsearch2.Location = new Point(382, 13);
            pnsearch2.Name = "pnsearch2";
            pnsearch2.Palette = kryptonPalettepanel;
            pnsearch2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            pnsearch2.Size = new Size(256, 27);
            pnsearch2.TabIndex = 30;
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
            // txtsearch2
            // 
            txtsearch2.Location = new Point(125, 3);
            txtsearch2.Name = "txtsearch2";
            txtsearch2.Size = new Size(131, 23);
            txtsearch2.TabIndex = 17;
            // 
            // btnsearch
            // 
            btnsearch.CornerRoundingRadius = -1F;
            btnsearch.Location = new Point(644, 16);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(25, 21);
            btnsearch.TabIndex = 29;
            btnsearch.Values.Image = (Image)resources.GetObject("btnsearch.Values.Image");
            btnsearch.Values.Text = "";
            // 
            // lblsearch
            // 
            lblsearch.Location = new Point(31, 12);
            lblsearch.Name = "lblsearch";
            lblsearch.Palette = kryptonPalettelbl;
            lblsearch.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblsearch.Size = new Size(60, 21);
            lblsearch.TabIndex = 28;
            lblsearch.Values.Text = "Search";
            // 
            // lbltitle
            // 
            lbltitle.Location = new Point(31, 68);
            lbltitle.Name = "lbltitle";
            lbltitle.Palette = kryptonPaletteheader;
            lbltitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lbltitle.Size = new Size(221, 23);
            lbltitle.TabIndex = 33;
            lbltitle.Values.Text = "Purchase Order Agreement";
            // 
            // lblnoresult
            // 
            lblnoresult.Location = new Point(31, 97);
            lblnoresult.Name = "lblnoresult";
            lblnoresult.Size = new Size(64, 20);
            lblnoresult.TabIndex = 32;
            lblnoresult.Values.Text = "No Result";
            // 
            // lblsubitemtitle
            // 
            lblsubitemtitle.Location = new Point(31, 365);
            lblsubitemtitle.Name = "lblsubitemtitle";
            lblsubitemtitle.Palette = kryptonPaletteheader;
            lblsubitemtitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblsubitemtitle.Size = new Size(79, 23);
            lblsubitemtitle.TabIndex = 34;
            lblsubitemtitle.Values.Text = "Sub Item";
            // 
            // POAView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 638);
            Controls.Add(lblsubitemtitle);
            Controls.Add(lbltitle);
            Controls.Add(lblnoresult);
            Controls.Add(pnsearch1);
            Controls.Add(pnsearch2);
            Controls.Add(btnsearch);
            Controls.Add(lblsearch);
            Controls.Add(btncancel);
            Controls.Add(btnadd);
            Controls.Add(btnedit);
            Controls.Add(kryptonDataGridViewitem);
            Controls.Add(kryptonDataGridViewpoa);
            Name = "POAView";
            Text = "POAView";
            Load += POAView_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewitem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch1).EndInit();
            pnsearch1.ResumeLayout(false);
            pnsearch1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsearch1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch2).EndInit();
            pnsearch2.ResumeLayout(false);
            pnsearch2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsearch2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewpoa;
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
    }
}