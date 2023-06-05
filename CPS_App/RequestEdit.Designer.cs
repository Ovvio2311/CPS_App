using Krypton.Toolkit;

namespace CPS_App
{
    partial class RequestEdit
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
            this.lblreqid = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblstaffName = new Krypton.Toolkit.KryptonLabel();
            this.lblloc = new Krypton.Toolkit.KryptonLabel();
            this.lblreqSta = new Krypton.Toolkit.KryptonLabel();
            this.lblCrDate = new Krypton.Toolkit.KryptonLabel();
            this.txtreqid = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(this.components);
            this.txtstaName = new Krypton.Toolkit.KryptonTextBox();
            this.txtloc = new Krypton.Toolkit.KryptonTextBox();
            this.txtreqst = new Krypton.Toolkit.KryptonTextBox();
            this.txtcrDate = new Krypton.Toolkit.KryptonTextBox();
            this.lblvid = new Krypton.Toolkit.KryptonLabel();
            this.datagridviewitem = new Krypton.Toolkit.KryptonDataGridView();
            this.lblqty = new Krypton.Toolkit.KryptonLabel();
            this.lblremain = new Krypton.Toolkit.KryptonLabel();
            this.lblitname = new Krypton.Toolkit.KryptonLabel();
            this.lblcat = new Krypton.Toolkit.KryptonLabel();
            this.lblrs = new Krypton.Toolkit.KryptonLabel();
            this.lblEDD = new Krypton.Toolkit.KryptonLabel();
            this.txtvid = new Krypton.Toolkit.KryptonTextBox();
            this.txtitname = new Krypton.Toolkit.KryptonTextBox();
            this.txtrs = new Krypton.Toolkit.KryptonTextBox();
            this.txtcat = new Krypton.Toolkit.KryptonTextBox();
            this.txtremain = new Krypton.Toolkit.KryptonTextBox();
            this.txtqty = new Krypton.Toolkit.KryptonTextBox();
            this.btnchange = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btndel = new Krypton.Toolkit.KryptonButton();
            this.dateTimePickerEDD = new System.Windows.Forms.DateTimePicker();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblreqid
            // 
            this.lblreqid.Location = new System.Drawing.Point(44, 390);
            this.lblreqid.Name = "lblreqid";
            this.lblreqid.Palette = this.kryptonPalette1;
            this.lblreqid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblreqid.Size = new System.Drawing.Size(89, 21);
            this.lblreqid.TabIndex = 0;
            this.lblreqid.Values.Text = "Request ID";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblstaffName
            // 
            this.lblstaffName.Location = new System.Drawing.Point(257, 390);
            this.lblstaffName.Name = "lblstaffName";
            this.lblstaffName.Palette = this.kryptonPalette1;
            this.lblstaffName.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblstaffName.Size = new System.Drawing.Size(89, 21);
            this.lblstaffName.TabIndex = 1;
            this.lblstaffName.Values.Text = "Staff Name";
            // 
            // lblloc
            // 
            this.lblloc.Location = new System.Drawing.Point(51, 443);
            this.lblloc.Name = "lblloc";
            this.lblloc.Palette = this.kryptonPalette1;
            this.lblloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblloc.Size = new System.Drawing.Size(70, 21);
            this.lblloc.TabIndex = 2;
            this.lblloc.Values.Text = "Location";
            // 
            // lblreqSta
            // 
            this.lblreqSta.Location = new System.Drawing.Point(243, 444);
            this.lblreqSta.Name = "lblreqSta";
            this.lblreqSta.Palette = this.kryptonPalette1;
            this.lblreqSta.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblreqSta.Size = new System.Drawing.Size(119, 21);
            this.lblreqSta.TabIndex = 3;
            this.lblreqSta.Values.Text = "Mapping Status";
            // 
            // lblCrDate
            // 
            this.lblCrDate.Location = new System.Drawing.Point(600, 390);
            this.lblCrDate.Name = "lblCrDate";
            this.lblCrDate.Palette = this.kryptonPalette1;
            this.lblCrDate.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblCrDate.Size = new System.Drawing.Size(95, 21);
            this.lblCrDate.TabIndex = 4;
            this.lblCrDate.Values.Text = "Create Date";
            // 
            // txtreqid
            // 
            this.txtreqid.Location = new System.Drawing.Point(130, 390);
            this.txtreqid.Name = "txtreqid";
            this.txtreqid.Palette = this.kryptonPalettereadonly;
            this.txtreqid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtreqid.ReadOnly = true;
            this.txtreqid.Size = new System.Drawing.Size(100, 23);
            this.txtreqid.TabIndex = 6;
            // 
            // kryptonPalettereadonly
            // 
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color2 = System.Drawing.SystemColors.Control;
            // 
            // txtstaName
            // 
            this.txtstaName.Location = new System.Drawing.Point(365, 390);
            this.txtstaName.Name = "txtstaName";
            this.txtstaName.Palette = this.kryptonPalettereadonly;
            this.txtstaName.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtstaName.ReadOnly = true;
            this.txtstaName.Size = new System.Drawing.Size(100, 23);
            this.txtstaName.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.txtstaName.StateDisabled.Back.Color1 = System.Drawing.Color.LightGray;
            this.txtstaName.StateNormal.Back.Color1 = System.Drawing.Color.DarkGray;
            this.txtstaName.TabIndex = 7;
            // 
            // txtloc
            // 
            this.txtloc.Location = new System.Drawing.Point(130, 444);
            this.txtloc.Name = "txtloc";
            this.txtloc.Palette = this.kryptonPalettereadonly;
            this.txtloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtloc.ReadOnly = true;
            this.txtloc.Size = new System.Drawing.Size(100, 23);
            this.txtloc.TabIndex = 8;
            // 
            // txtreqst
            // 
            this.txtreqst.Location = new System.Drawing.Point(365, 445);
            this.txtreqst.Name = "txtreqst";
            this.txtreqst.Palette = this.kryptonPalettereadonly;
            this.txtreqst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtreqst.ReadOnly = true;
            this.txtreqst.Size = new System.Drawing.Size(100, 23);
            this.txtreqst.TabIndex = 9;
            // 
            // txtcrDate
            // 
            this.txtcrDate.Location = new System.Drawing.Point(701, 391);
            this.txtcrDate.Name = "txtcrDate";
            this.txtcrDate.Palette = this.kryptonPalettereadonly;
            this.txtcrDate.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtcrDate.ReadOnly = true;
            this.txtcrDate.Size = new System.Drawing.Size(158, 23);
            this.txtcrDate.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.txtcrDate.TabIndex = 10;
            // 
            // lblvid
            // 
            this.lblvid.Location = new System.Drawing.Point(39, 510);
            this.lblvid.Name = "lblvid";
            this.lblvid.Palette = this.kryptonPalette1;
            this.lblvid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblvid.Size = new System.Drawing.Size(68, 21);
            this.lblvid.TabIndex = 11;
            this.lblvid.Values.Text = "Item Vid";
            // 
            // datagridviewitem
            // 
            this.datagridviewitem.AllowUserToAddRows = false;
            this.datagridviewitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewitem.Location = new System.Drawing.Point(51, 29);
            this.datagridviewitem.Name = "datagridviewitem";
            this.datagridviewitem.Palette = this.kryptonPalettedatagridview;
            this.datagridviewitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.datagridviewitem.RowTemplate.Height = 25;
            this.datagridviewitem.Size = new System.Drawing.Size(783, 252);
            this.datagridviewitem.TabIndex = 13;
            this.datagridviewitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewitem_CellClick);
            // 
            // lblqty
            // 
            this.lblqty.Location = new System.Drawing.Point(564, 510);
            this.lblqty.Name = "lblqty";
            this.lblqty.Palette = this.kryptonPalette1;
            this.lblqty.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblqty.Size = new System.Drawing.Size(131, 21);
            this.lblqty.TabIndex = 14;
            this.lblqty.Values.Text = "Request Quantity";
            // 
            // lblremain
            // 
            this.lblremain.Location = new System.Drawing.Point(564, 560);
            this.lblremain.Name = "lblremain";
            this.lblremain.Palette = this.kryptonPalette1;
            this.lblremain.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblremain.Size = new System.Drawing.Size(122, 21);
            this.lblremain.TabIndex = 15;
            this.lblremain.Values.Text = "Remain Quanity";
            // 
            // lblitname
            // 
            this.lblitname.Location = new System.Drawing.Point(20, 560);
            this.lblitname.Name = "lblitname";
            this.lblitname.Palette = this.kryptonPalette1;
            this.lblitname.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblitname.Size = new System.Drawing.Size(87, 21);
            this.lblitname.TabIndex = 16;
            this.lblitname.Values.Text = "Item Name";
            // 
            // lblcat
            // 
            this.lblcat.Location = new System.Drawing.Point(297, 560);
            this.lblcat.Name = "lblcat";
            this.lblcat.Palette = this.kryptonPalette1;
            this.lblcat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblcat.Size = new System.Drawing.Size(74, 21);
            this.lblcat.TabIndex = 17;
            this.lblcat.Values.Text = "Category";
            // 
            // lblrs
            // 
            this.lblrs.Location = new System.Drawing.Point(289, 510);
            this.lblrs.Name = "lblrs";
            this.lblrs.Palette = this.kryptonPalette1;
            this.lblrs.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblrs.Size = new System.Drawing.Size(82, 21);
            this.lblrs.TabIndex = 18;
            this.lblrs.Values.Text = "PO Status";
            // 
            // lblEDD
            // 
            this.lblEDD.Location = new System.Drawing.Point(471, 444);
            this.lblEDD.Name = "lblEDD";
            this.lblEDD.Palette = this.kryptonPalette1;
            this.lblEDD.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblEDD.Size = new System.Drawing.Size(181, 21);
            this.lblEDD.TabIndex = 19;
            this.lblEDD.Values.Text = "Expected Delievery Date";
            // 
            // txtvid
            // 
            this.txtvid.Location = new System.Drawing.Point(113, 510);
            this.txtvid.Name = "txtvid";
            this.txtvid.Palette = this.kryptonPalettereadonly;
            this.txtvid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtvid.ReadOnly = true;
            this.txtvid.Size = new System.Drawing.Size(158, 23);
            this.txtvid.TabIndex = 20;
            // 
            // txtitname
            // 
            this.txtitname.Location = new System.Drawing.Point(113, 560);
            this.txtitname.Name = "txtitname";
            this.txtitname.Palette = this.kryptonPalettereadonly;
            this.txtitname.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtitname.ReadOnly = true;
            this.txtitname.Size = new System.Drawing.Size(158, 23);
            this.txtitname.TabIndex = 21;
            // 
            // txtrs
            // 
            this.txtrs.Location = new System.Drawing.Point(388, 510);
            this.txtrs.Name = "txtrs";
            this.txtrs.Palette = this.kryptonPalettereadonly;
            this.txtrs.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtrs.ReadOnly = true;
            this.txtrs.Size = new System.Drawing.Size(158, 23);
            this.txtrs.TabIndex = 22;
            // 
            // txtcat
            // 
            this.txtcat.Location = new System.Drawing.Point(388, 560);
            this.txtcat.Name = "txtcat";
            this.txtcat.Palette = this.kryptonPalettereadonly;
            this.txtcat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtcat.ReadOnly = true;
            this.txtcat.Size = new System.Drawing.Size(158, 23);
            this.txtcat.TabIndex = 23;
            // 
            // txtremain
            // 
            this.txtremain.Location = new System.Drawing.Point(701, 560);
            this.txtremain.Name = "txtremain";
            this.txtremain.Size = new System.Drawing.Size(158, 23);
            this.txtremain.TabIndex = 24;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(701, 510);
            this.txtqty.Name = "txtqty";
            this.txtqty.Palette = this.kryptonPalettereadonly;
            this.txtqty.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtqty.ReadOnly = true;
            this.txtqty.Size = new System.Drawing.Size(158, 23);
            this.txtqty.TabIndex = 25;
            // 
            // btnchange
            // 
            this.btnchange.CornerRoundingRadius = -1F;
            this.btnchange.Location = new System.Drawing.Point(51, 307);
            this.btnchange.Name = "btnchange";
            this.btnchange.Palette = this.kryptonPalettebtn;
            this.btnchange.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnchange.Size = new System.Drawing.Size(95, 40);
            this.btnchange.TabIndex = 27;
            this.btnchange.Values.Text = "Update";
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
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
            // btndel
            // 
            this.btndel.CornerRoundingRadius = -1F;
            this.btndel.Location = new System.Drawing.Point(169, 307);
            this.btndel.Name = "btndel";
            this.btndel.Palette = this.kryptonPalettebtn;
            this.btndel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btndel.Size = new System.Drawing.Size(102, 40);
            this.btndel.TabIndex = 28;
            this.btndel.Values.Text = "Delete";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // dateTimePickerEDD
            // 
            this.dateTimePickerEDD.Location = new System.Drawing.Point(659, 444);
            this.dateTimePickerEDD.Name = "dateTimePickerEDD";
            this.dateTimePickerEDD.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerEDD.TabIndex = 29;
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(297, 307);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(102, 40);
            this.btncancel.TabIndex = 30;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // kryptonPalettedatagridview
            // 
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // RequestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(935, 743);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.dateTimePickerEDD);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtremain);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.txtrs);
            this.Controls.Add(this.txtitname);
            this.Controls.Add(this.txtvid);
            this.Controls.Add(this.lblEDD);
            this.Controls.Add(this.lblrs);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lblitname);
            this.Controls.Add(this.lblremain);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.datagridviewitem);
            this.Controls.Add(this.lblvid);
            this.Controls.Add(this.txtcrDate);
            this.Controls.Add(this.txtreqst);
            this.Controls.Add(this.txtloc);
            this.Controls.Add(this.txtstaName);
            this.Controls.Add(this.txtreqid);
            this.Controls.Add(this.lblCrDate);
            this.Controls.Add(this.lblreqSta);
            this.Controls.Add(this.lblloc);
            this.Controls.Add(this.lblstaffName);
            this.Controls.Add(this.lblreqid);
            this.Name = "RequestEdit";
            this.Text = "RequestEdit";
            this.Load += new System.EventHandler(this.RequestEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonLabel lblreqid;
        private KryptonLabel lblstaffName;
        private KryptonLabel lblloc;
        private KryptonLabel lblreqSta;
        private KryptonLabel lblCrDate;
        private KryptonTextBox txtreqid;
        private KryptonTextBox txtstaName;
        private KryptonTextBox txtloc;
        private KryptonTextBox txtreqst;
        private KryptonTextBox txtcrDate;
        private KryptonLabel lblvid;
        private KryptonDataGridView datagridviewitem;
        private KryptonLabel lblqty;
        private KryptonLabel lblremain;
        private KryptonLabel lblitname;
        private KryptonLabel lblcat;
        private KryptonLabel lblrs;
        private KryptonLabel lblEDD;
        private KryptonTextBox txtvid;
        private KryptonTextBox txtitname;
        private KryptonTextBox txtrs;
        private KryptonTextBox txtcat;
        private KryptonTextBox txtremain;
        private KryptonTextBox txtqty;
        private KryptonButton btnchange;
        private KryptonButton btndel;
        private DateTimePicker dateTimePickerEDD;
        private KryptonPalette kryptonPalette1;
        private KryptonPalette kryptonPalettebtn;
        private KryptonPalette kryptonPalettereadonly;
        private KryptonButton btncancel;
        private KryptonPalette kryptonPalettedatagridview;
    }
}