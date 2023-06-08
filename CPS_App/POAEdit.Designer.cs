namespace CPS_App
{
    partial class POAEdit
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
            lblline = new Krypton.Toolkit.KryptonLabel();
            kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(components);
            lblit = new Krypton.Toolkit.KryptonLabel();
            lblsupid = new Krypton.Toolkit.KryptonLabel();
            lblpro = new Krypton.Toolkit.KryptonLabel();
            lbluom = new Krypton.Toolkit.KryptonLabel();
            lblmin = new Krypton.Toolkit.KryptonLabel();
            lblp = new Krypton.Toolkit.KryptonLabel();
            lblam = new Krypton.Toolkit.KryptonLabel();
            lblref = new Krypton.Toolkit.KryptonLabel();
            lblqu = new Krypton.Toolkit.KryptonLabel();
            txtline = new Krypton.Toolkit.KryptonTextBox();
            kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(components);
            txtsupid = new Krypton.Toolkit.KryptonTextBox();
            txtit = new Krypton.Toolkit.KryptonTextBox();
            txtpro = new Krypton.Toolkit.KryptonTextBox();
            txtuom = new Krypton.Toolkit.KryptonTextBox();
            txtmin = new Krypton.Toolkit.KryptonTextBox();
            txtp = new Krypton.Toolkit.KryptonTextBox();
            txtam = new Krypton.Toolkit.KryptonTextBox();
            txtref = new Krypton.Toolkit.KryptonTextBox();
            txtqu = new Krypton.Toolkit.KryptonTextBox();
            kryptonDataGridViewit = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(components);
            cbxdelisc = new Krypton.Toolkit.KryptonComboBox();
            kryptonDateTimePickerec = new Krypton.Toolkit.KryptonDateTimePicker();
            lblec = new Krypton.Toolkit.KryptonLabel();
            lbldelisc = new Krypton.Toolkit.KryptonLabel();
            txttype = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            lbltype = new Krypton.Toolkit.KryptonLabel();
            txtpoa = new Krypton.Toolkit.KryptonTextBox();
            lblpoa = new Krypton.Toolkit.KryptonLabel();
            btnmod = new Krypton.Toolkit.KryptonButton();
            kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(components);
            cbxst = new Krypton.Toolkit.KryptonComboBox();
            btncancel = new Krypton.Toolkit.KryptonButton();
            btndel = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxdelisc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxst).BeginInit();
            SuspendLayout();
            // 
            // lblline
            // 
            lblline.Location = new Point(33, 315);
            lblline.Name = "lblline";
            lblline.Palette = kryptonPalettelbl;
            lblline.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblline.Size = new Size(89, 21);
            lblline.TabIndex = 0;
            lblline.Values.Text = "Poa Line Id";
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // lblit
            // 
            lblit.Location = new Point(80, 357);
            lblit.Name = "lblit";
            lblit.Palette = kryptonPalettelbl;
            lblit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblit.Size = new Size(42, 21);
            lblit.TabIndex = 2;
            lblit.Values.Text = "Item";
            // 
            // lblsupid
            // 
            lblsupid.Location = new Point(12, 402);
            lblsupid.Name = "lblsupid";
            lblsupid.Palette = kryptonPalettelbl;
            lblsupid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblsupid.Size = new Size(119, 21);
            lblsupid.TabIndex = 3;
            lblsupid.Values.Text = "Supplier Item Id";
            // 
            // lblpro
            // 
            lblpro.Location = new Point(313, 359);
            lblpro.Name = "lblpro";
            lblpro.Palette = kryptonPalettelbl;
            lblpro.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblpro.Size = new Size(96, 21);
            lblpro.TabIndex = 4;
            lblpro.Values.Text = "Promise Qty";
            // 
            // lbluom
            // 
            lbluom.Location = new Point(610, 315);
            lbluom.Name = "lbluom";
            lbluom.Palette = kryptonPalettelbl;
            lbluom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lbluom.Size = new Size(155, 21);
            lbluom.TabIndex = 5;
            lbluom.Values.Text = "Unit of Measurement";
            // 
            // lblmin
            // 
            lblmin.Location = new Point(700, 357);
            lblmin.Name = "lblmin";
            lblmin.Palette = kryptonPalettelbl;
            lblmin.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblmin.Size = new Size(65, 21);
            lblmin.TabIndex = 6;
            lblmin.Values.Text = "Min Qty";
            // 
            // lblp
            // 
            lblp.Location = new Point(362, 450);
            lblp.Name = "lblp";
            lblp.Palette = kryptonPalettelbl;
            lblp.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblp.Size = new Size(47, 21);
            lblp.TabIndex = 7;
            lblp.Values.Text = "Price";
            // 
            // lblam
            // 
            lblam.Location = new Point(351, 402);
            lblam.Name = "lblam";
            lblam.Palette = kryptonPalettelbl;
            lblam.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblam.Size = new Size(65, 21);
            lblam.TabIndex = 8;
            lblam.Values.Text = "Amount";
            // 
            // lblref
            // 
            lblref.Location = new Point(682, 402);
            lblref.Name = "lblref";
            lblref.Palette = kryptonPalettelbl;
            lblref.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblref.Size = new Size(83, 21);
            lblref.TabIndex = 9;
            lblref.Values.Text = "Reference";
            // 
            // lblqu
            // 
            lblqu.Location = new Point(307, 315);
            lblqu.Name = "lblqu";
            lblqu.Palette = kryptonPalettelbl;
            lblqu.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblqu.Size = new Size(107, 21);
            lblqu.TabIndex = 10;
            lblqu.Values.Text = "Quotation No.";
            // 
            // txtline
            // 
            txtline.Enabled = false;
            txtline.Location = new Point(136, 315);
            txtline.Name = "txtline";
            txtline.Palette = kryptonPalettereadonly;
            txtline.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtline.ReadOnly = true;
            txtline.Size = new Size(160, 23);
            txtline.TabIndex = 12;
            // 
            // kryptonPalettereadonly
            // 
            kryptonPalettereadonly.Common.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonPalettereadonly.Common.StateCommon.Back.Color2 = SystemColors.Control;
            // 
            // txtsupid
            // 
            txtsupid.Enabled = false;
            txtsupid.Location = new Point(137, 402);
            txtsupid.Name = "txtsupid";
            txtsupid.Palette = kryptonPalettereadonly;
            txtsupid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtsupid.ReadOnly = true;
            txtsupid.Size = new Size(160, 23);
            txtsupid.TabIndex = 13;
            // 
            // txtit
            // 
            txtit.Enabled = false;
            txtit.Location = new Point(136, 357);
            txtit.Name = "txtit";
            txtit.Palette = kryptonPalettereadonly;
            txtit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtit.ReadOnly = true;
            txtit.Size = new Size(160, 23);
            txtit.TabIndex = 15;
            // 
            // txtpro
            // 
            txtpro.Enabled = false;
            txtpro.Location = new Point(422, 355);
            txtpro.Name = "txtpro";
            txtpro.Palette = kryptonPalettereadonly;
            txtpro.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtpro.Size = new Size(160, 23);
            txtpro.TabIndex = 16;
            // 
            // txtuom
            // 
            txtuom.Enabled = false;
            txtuom.Location = new Point(771, 315);
            txtuom.Name = "txtuom";
            txtuom.Palette = kryptonPalettereadonly;
            txtuom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtuom.ReadOnly = true;
            txtuom.Size = new Size(160, 23);
            txtuom.TabIndex = 17;
            // 
            // txtmin
            // 
            txtmin.Location = new Point(771, 357);
            txtmin.Name = "txtmin";
            txtmin.Size = new Size(160, 23);
            txtmin.TabIndex = 18;
            // 
            // txtp
            // 
            txtp.Location = new Point(422, 450);
            txtp.Name = "txtp";
            txtp.Size = new Size(160, 23);
            txtp.TabIndex = 19;
            // 
            // txtam
            // 
            txtam.Location = new Point(422, 402);
            txtam.Name = "txtam";
            txtam.Size = new Size(160, 23);
            txtam.TabIndex = 20;
            // 
            // txtref
            // 
            txtref.Location = new Point(771, 402);
            txtref.Name = "txtref";
            txtref.Size = new Size(160, 23);
            txtref.TabIndex = 21;
            // 
            // txtqu
            // 
            txtqu.Enabled = false;
            txtqu.Location = new Point(422, 315);
            txtqu.Name = "txtqu";
            txtqu.Palette = kryptonPalettereadonly;
            txtqu.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtqu.ReadOnly = true;
            txtqu.Size = new Size(160, 23);
            txtqu.TabIndex = 22;
            // 
            // kryptonDataGridViewit
            // 
            kryptonDataGridViewit.AllowUserToAddRows = false;
            kryptonDataGridViewit.Location = new Point(50, 46);
            kryptonDataGridViewit.Name = "kryptonDataGridViewit";
            kryptonDataGridViewit.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewit.RowTemplate.Height = 25;
            kryptonDataGridViewit.Size = new Size(881, 198);
            kryptonDataGridViewit.TabIndex = 24;
            kryptonDataGridViewit.CellClick += kryptonDataGridViewit_CellClick;
            // 
            // kryptonPalettedatagridview
            // 
            kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // cbxdelisc
            // 
            cbxdelisc.CornerRoundingRadius = -1F;
            cbxdelisc.DropDownWidth = 121;
            cbxdelisc.IntegralHeight = false;
            cbxdelisc.Location = new Point(771, 450);
            cbxdelisc.Name = "cbxdelisc";
            cbxdelisc.Size = new Size(160, 21);
            cbxdelisc.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbxdelisc.TabIndex = 28;
            // 
            // kryptonDateTimePickerec
            // 
            kryptonDateTimePickerec.CornerRoundingRadius = -1F;
            kryptonDateTimePickerec.Enabled = false;
            kryptonDateTimePickerec.Location = new Point(771, 270);
            kryptonDateTimePickerec.Name = "kryptonDateTimePickerec";
            kryptonDateTimePickerec.Palette = kryptonPalettereadonly;
            kryptonDateTimePickerec.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDateTimePickerec.Size = new Size(160, 21);
            kryptonDateTimePickerec.TabIndex = 27;
            // 
            // lblec
            // 
            lblec.Location = new Point(650, 270);
            lblec.Name = "lblec";
            lblec.Palette = kryptonPalettelbl;
            lblec.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblec.Size = new Size(108, 21);
            lblec.TabIndex = 26;
            lblec.Values.Text = "Effective Date";
            // 
            // lbldelisc
            // 
            lbldelisc.Location = new Point(622, 448);
            lbldelisc.Name = "lbldelisc";
            lbldelisc.Palette = kryptonPalettelbl;
            lbldelisc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lbldelisc.Size = new Size(136, 21);
            lbldelisc.TabIndex = 25;
            lbldelisc.Values.Text = "Delivery Schedule";
            // 
            // txttype
            // 
            txttype.Enabled = false;
            txttype.Location = new Point(422, 270);
            txttype.Name = "txttype";
            txttype.Palette = kryptonPalettereadonly;
            txttype.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txttype.ReadOnly = true;
            txttype.Size = new Size(160, 23);
            txttype.TabIndex = 17;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(66, 448);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Palette = kryptonPalettelbl;
            kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel3.Size = new Size(55, 21);
            kryptonLabel3.TabIndex = 16;
            kryptonLabel3.Values.Text = "Status";
            // 
            // lbltype
            // 
            lbltype.Location = new Point(368, 270);
            lbltype.Name = "lbltype";
            lbltype.Palette = kryptonPalettelbl;
            lbltype.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lbltype.Size = new Size(46, 21);
            lbltype.TabIndex = 15;
            lbltype.Values.Text = "Type";
            // 
            // txtpoa
            // 
            txtpoa.Enabled = false;
            txtpoa.Location = new Point(136, 270);
            txtpoa.Name = "txtpoa";
            txtpoa.Palette = kryptonPalettereadonly;
            txtpoa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtpoa.ReadOnly = true;
            txtpoa.Size = new Size(160, 23);
            txtpoa.TabIndex = 14;
            // 
            // lblpoa
            // 
            lblpoa.Location = new Point(66, 270);
            lblpoa.Name = "lblpoa";
            lblpoa.Palette = kryptonPalettelbl;
            lblpoa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblpoa.Size = new Size(56, 21);
            lblpoa.TabIndex = 13;
            lblpoa.Values.Text = "Poa Id";
            // 
            // btnmod
            // 
            btnmod.CornerRoundingRadius = -1F;
            btnmod.Location = new Point(835, 499);
            btnmod.Name = "btnmod";
            btnmod.Palette = kryptonPalettebtn;
            btnmod.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnmod.Size = new Size(96, 37);
            btnmod.TabIndex = 0;
            btnmod.Values.Text = "Update";
            btnmod.Click += btnmod_Click;
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
            // kryptonPaletteheader
            // 
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = Color.DarkCyan;
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // kryptonPalettepanel
            // 
            kryptonPalettepanel.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettepanel.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // cbxst
            // 
            cbxst.CornerRoundingRadius = -1F;
            cbxst.DropDownWidth = 121;
            cbxst.IntegralHeight = false;
            cbxst.Location = new Point(137, 450);
            cbxst.Name = "cbxst";
            cbxst.Size = new Size(160, 21);
            cbxst.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbxst.TabIndex = 29;
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(539, 499);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btncancel.Size = new Size(96, 37);
            btncancel.TabIndex = 30;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // btndel
            // 
            btndel.CornerRoundingRadius = -1F;
            btndel.Location = new Point(682, 499);
            btndel.Name = "btndel";
            btndel.Palette = kryptonPalettebtn;
            btndel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btndel.Size = new Size(96, 37);
            btndel.TabIndex = 31;
            btndel.Values.Text = "Delete";
            // 
            // POAEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 606);
            Controls.Add(btndel);
            Controls.Add(btncancel);
            Controls.Add(cbxst);
            Controls.Add(lbldelisc);
            Controls.Add(cbxdelisc);
            Controls.Add(kryptonDataGridViewit);
            Controls.Add(lblec);
            Controls.Add(kryptonDateTimePickerec);
            Controls.Add(txtqu);
            Controls.Add(txtref);
            Controls.Add(txtam);
            Controls.Add(btnmod);
            Controls.Add(lblmin);
            Controls.Add(lbluom);
            Controls.Add(txtp);
            Controls.Add(txttype);
            Controls.Add(kryptonLabel3);
            Controls.Add(txtmin);
            Controls.Add(lbltype);
            Controls.Add(txtuom);
            Controls.Add(txtpro);
            Controls.Add(txtpoa);
            Controls.Add(lblpoa);
            Controls.Add(txtit);
            Controls.Add(txtsupid);
            Controls.Add(txtline);
            Controls.Add(lblqu);
            Controls.Add(lblref);
            Controls.Add(lblam);
            Controls.Add(lblp);
            Controls.Add(lblpro);
            Controls.Add(lblsupid);
            Controls.Add(lblit);
            Controls.Add(lblline);
            Name = "POAEdit";
            Text = "POAEdit";
            Load += POAEdit_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewit).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxdelisc).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblline;
        private Krypton.Toolkit.KryptonLabel lblit;
        private Krypton.Toolkit.KryptonLabel lblsupid;
        private Krypton.Toolkit.KryptonLabel lblpro;
        private Krypton.Toolkit.KryptonLabel lbluom;
        private Krypton.Toolkit.KryptonLabel lblmin;
        private Krypton.Toolkit.KryptonLabel lblp;
        private Krypton.Toolkit.KryptonLabel lblam;
        private Krypton.Toolkit.KryptonLabel lblref;
        private Krypton.Toolkit.KryptonLabel lblqu;
        private Krypton.Toolkit.KryptonTextBox txtline;
        private Krypton.Toolkit.KryptonTextBox txtsupid;
        private Krypton.Toolkit.KryptonTextBox txtit;
        private Krypton.Toolkit.KryptonTextBox txtpro;
        private Krypton.Toolkit.KryptonTextBox txtuom;
        private Krypton.Toolkit.KryptonTextBox txtmin;
        private Krypton.Toolkit.KryptonTextBox txtp;
        private Krypton.Toolkit.KryptonTextBox txtam;
        private Krypton.Toolkit.KryptonTextBox txtref;
        private Krypton.Toolkit.KryptonTextBox txtqu;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewit;
        private Krypton.Toolkit.KryptonButton btnmod;
        private Krypton.Toolkit.KryptonTextBox txtpoa;
        private Krypton.Toolkit.KryptonLabel lblpoa;
        private Krypton.Toolkit.KryptonPalette kryptonPalettelbl;
        private Krypton.Toolkit.KryptonPalette kryptonPaletteheader;
        private Krypton.Toolkit.KryptonPalette kryptonPalettereadonly;
        private Krypton.Toolkit.KryptonPalette kryptonPalettepanel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettebtn;
        private Krypton.Toolkit.KryptonTextBox txttype;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lbltype;
        private Krypton.Toolkit.KryptonComboBox cbxdelisc;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePickerec;
        private Krypton.Toolkit.KryptonLabel lblec;
        private Krypton.Toolkit.KryptonLabel lbldelisc;
        private Krypton.Toolkit.KryptonComboBox cbxst;
        private Krypton.Toolkit.KryptonButton btncancel;
        private Krypton.Toolkit.KryptonButton btndel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettedatagridview;
    }
}