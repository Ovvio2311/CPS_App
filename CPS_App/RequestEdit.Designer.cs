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
            components = new System.ComponentModel.Container();
            lblreqid = new KryptonLabel();
            kryptonPalette1 = new KryptonPalette(components);
            lblstaffName = new KryptonLabel();
            lblloc = new KryptonLabel();
            lblreqSta = new KryptonLabel();
            lblCrDate = new KryptonLabel();
            txtreqid = new KryptonTextBox();
            kryptonPalettereadonly = new KryptonPalette(components);
            txtstaName = new KryptonTextBox();
            txtloc = new KryptonTextBox();
            txtreqst = new KryptonTextBox();
            txtcrDate = new KryptonTextBox();
            lblvid = new KryptonLabel();
            datagridviewitem = new KryptonDataGridView();
            kryptonPalettedatagridview = new KryptonPalette(components);
            lblqty = new KryptonLabel();
            lblremain = new KryptonLabel();
            lblitname = new KryptonLabel();
            lblcat = new KryptonLabel();
            lblrs = new KryptonLabel();
            lblEDD = new KryptonLabel();
            txtvid = new KryptonTextBox();
            txtitname = new KryptonTextBox();
            txtrs = new KryptonTextBox();
            txtcat = new KryptonTextBox();
            txtremain = new KryptonTextBox();
            txtqty = new KryptonTextBox();
            btnchange = new KryptonButton();
            kryptonPalettebtn = new KryptonPalette(components);
            btndel = new KryptonButton();
            dateTimePickerEDD = new DateTimePicker();
            btncancel = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).BeginInit();
            SuspendLayout();
            // 
            // lblreqid
            // 
            lblreqid.Location = new Point(44, 390);
            lblreqid.Name = "lblreqid";
            lblreqid.Palette = kryptonPalette1;
            lblreqid.PaletteMode = PaletteMode.Custom;
            lblreqid.Size = new Size(89, 21);
            lblreqid.TabIndex = 0;
            lblreqid.Values.Text = "Request ID";
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalette1.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // lblstaffName
            // 
            lblstaffName.Location = new Point(257, 390);
            lblstaffName.Name = "lblstaffName";
            lblstaffName.Palette = kryptonPalette1;
            lblstaffName.PaletteMode = PaletteMode.Custom;
            lblstaffName.Size = new Size(89, 21);
            lblstaffName.TabIndex = 1;
            lblstaffName.Values.Text = "Staff Name";
            // 
            // lblloc
            // 
            lblloc.Location = new Point(51, 443);
            lblloc.Name = "lblloc";
            lblloc.Palette = kryptonPalette1;
            lblloc.PaletteMode = PaletteMode.Custom;
            lblloc.Size = new Size(70, 21);
            lblloc.TabIndex = 2;
            lblloc.Values.Text = "Location";
            // 
            // lblreqSta
            // 
            lblreqSta.Location = new Point(243, 444);
            lblreqSta.Name = "lblreqSta";
            lblreqSta.Palette = kryptonPalette1;
            lblreqSta.PaletteMode = PaletteMode.Custom;
            lblreqSta.Size = new Size(119, 21);
            lblreqSta.TabIndex = 3;
            lblreqSta.Values.Text = "Mapping Status";
            // 
            // lblCrDate
            // 
            lblCrDate.Location = new Point(600, 390);
            lblCrDate.Name = "lblCrDate";
            lblCrDate.Palette = kryptonPalette1;
            lblCrDate.PaletteMode = PaletteMode.Custom;
            lblCrDate.Size = new Size(95, 21);
            lblCrDate.TabIndex = 4;
            lblCrDate.Values.Text = "Create Date";
            // 
            // txtreqid
            // 
            txtreqid.Enabled = false;
            txtreqid.Location = new Point(130, 390);
            txtreqid.Name = "txtreqid";
            txtreqid.Palette = kryptonPalettereadonly;
            txtreqid.PaletteMode = PaletteMode.Custom;
            txtreqid.ReadOnly = true;
            txtreqid.Size = new Size(100, 23);
            txtreqid.TabIndex = 6;
            txtreqid.Tag = "bi_req_id";
            // 
            // kryptonPalettereadonly
            // 
            kryptonPalettereadonly.Common.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonPalettereadonly.Common.StateCommon.Back.Color2 = SystemColors.Control;
            // 
            // txtstaName
            // 
            txtstaName.Enabled = false;
            txtstaName.Location = new Point(365, 390);
            txtstaName.Name = "txtstaName";
            txtstaName.Palette = kryptonPalettereadonly;
            txtstaName.PaletteMode = PaletteMode.Custom;
            txtstaName.ReadOnly = true;
            txtstaName.Size = new Size(100, 23);
            txtstaName.StateCommon.Back.Color1 = SystemColors.Control;
            txtstaName.StateDisabled.Back.Color1 = Color.LightGray;
            txtstaName.StateNormal.Back.Color1 = Color.DarkGray;
            txtstaName.TabIndex = 7;
            txtstaName.Tag = "vc_staff_name";
            // 
            // txtloc
            // 
            txtloc.Enabled = false;
            txtloc.Location = new Point(130, 444);
            txtloc.Name = "txtloc";
            txtloc.Palette = kryptonPalettereadonly;
            txtloc.PaletteMode = PaletteMode.Custom;
            txtloc.ReadOnly = true;
            txtloc.Size = new Size(100, 23);
            txtloc.TabIndex = 8;
            txtloc.Tag = "vc_location_desc";
            // 
            // txtreqst
            // 
            txtreqst.Enabled = false;
            txtreqst.Location = new Point(365, 445);
            txtreqst.Name = "txtreqst";
            txtreqst.Palette = kryptonPalettereadonly;
            txtreqst.PaletteMode = PaletteMode.Custom;
            txtreqst.ReadOnly = true;
            txtreqst.Size = new Size(100, 23);
            txtreqst.TabIndex = 9;
            txtreqst.Tag = "item_mapping_status";
            // 
            // txtcrDate
            // 
            txtcrDate.Enabled = false;
            txtcrDate.Location = new Point(701, 391);
            txtcrDate.Name = "txtcrDate";
            txtcrDate.Palette = kryptonPalettereadonly;
            txtcrDate.PaletteMode = PaletteMode.Custom;
            txtcrDate.ReadOnly = true;
            txtcrDate.Size = new Size(158, 23);
            txtcrDate.StateCommon.Back.Color1 = SystemColors.Control;
            txtcrDate.TabIndex = 10;
            txtcrDate.Tag = "dt_created_date";
            // 
            // lblvid
            // 
            lblvid.Location = new Point(39, 510);
            lblvid.Name = "lblvid";
            lblvid.Palette = kryptonPalette1;
            lblvid.PaletteMode = PaletteMode.Custom;
            lblvid.Size = new Size(68, 21);
            lblvid.TabIndex = 11;
            lblvid.Values.Text = "Item Vid";
            // 
            // datagridviewitem
            // 
            datagridviewitem.AllowUserToAddRows = false;
            datagridviewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewitem.Location = new Point(51, 29);
            datagridviewitem.Name = "datagridviewitem";
            datagridviewitem.Palette = kryptonPalettedatagridview;
            datagridviewitem.PaletteMode = PaletteMode.Custom;
            datagridviewitem.RowTemplate.Height = 25;
            datagridviewitem.Size = new Size(783, 252);
            datagridviewitem.TabIndex = 13;
            datagridviewitem.CellClick += datagridviewitem_CellClick;
            // 
            // kryptonPalettedatagridview
            // 
            kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // lblqty
            // 
            lblqty.Location = new Point(564, 510);
            lblqty.Name = "lblqty";
            lblqty.Palette = kryptonPalette1;
            lblqty.PaletteMode = PaletteMode.Custom;
            lblqty.Size = new Size(131, 21);
            lblqty.TabIndex = 14;
            lblqty.Values.Text = "Request Quantity";
            // 
            // lblremain
            // 
            lblremain.Location = new Point(564, 560);
            lblremain.Name = "lblremain";
            lblremain.Palette = kryptonPalette1;
            lblremain.PaletteMode = PaletteMode.Custom;
            lblremain.Size = new Size(122, 21);
            lblremain.TabIndex = 15;
            lblremain.Tag = "i_remain_req_qty";
            lblremain.Values.Text = "Remain Quanity";
            // 
            // lblitname
            // 
            lblitname.Location = new Point(20, 560);
            lblitname.Name = "lblitname";
            lblitname.Palette = kryptonPalette1;
            lblitname.PaletteMode = PaletteMode.Custom;
            lblitname.Size = new Size(87, 21);
            lblitname.TabIndex = 16;
            lblitname.Values.Text = "Item Name";
            // 
            // lblcat
            // 
            lblcat.Location = new Point(297, 560);
            lblcat.Name = "lblcat";
            lblcat.Palette = kryptonPalette1;
            lblcat.PaletteMode = PaletteMode.Custom;
            lblcat.Size = new Size(74, 21);
            lblcat.TabIndex = 17;
            lblcat.Values.Text = "Category";
            // 
            // lblrs
            // 
            lblrs.Location = new Point(289, 510);
            lblrs.Name = "lblrs";
            lblrs.Palette = kryptonPalette1;
            lblrs.PaletteMode = PaletteMode.Custom;
            lblrs.Size = new Size(82, 21);
            lblrs.TabIndex = 18;
            lblrs.Values.Text = "PO Status";
            // 
            // lblEDD
            // 
            lblEDD.Location = new Point(471, 444);
            lblEDD.Name = "lblEDD";
            lblEDD.Palette = kryptonPalette1;
            lblEDD.PaletteMode = PaletteMode.Custom;
            lblEDD.Size = new Size(181, 21);
            lblEDD.TabIndex = 19;
            lblEDD.Tag = "dt_exp_deli_date";
            lblEDD.Values.Text = "Expected Delievery Date";
            // 
            // txtvid
            // 
            txtvid.Enabled = false;
            txtvid.Location = new Point(113, 510);
            txtvid.Name = "txtvid";
            txtvid.Palette = kryptonPalettereadonly;
            txtvid.PaletteMode = PaletteMode.Custom;
            txtvid.ReadOnly = true;
            txtvid.Size = new Size(158, 23);
            txtvid.TabIndex = 20;
            txtvid.Tag = "bi_item_vid";
            // 
            // txtitname
            // 
            txtitname.Enabled = false;
            txtitname.Location = new Point(113, 560);
            txtitname.Name = "txtitname";
            txtitname.Palette = kryptonPalettereadonly;
            txtitname.PaletteMode = PaletteMode.Custom;
            txtitname.ReadOnly = true;
            txtitname.Size = new Size(158, 23);
            txtitname.TabIndex = 21;
            txtitname.Tag = "vc_item_desc";
            // 
            // txtrs
            // 
            txtrs.Enabled = false;
            txtrs.Location = new Point(388, 510);
            txtrs.Name = "txtrs";
            txtrs.Palette = kryptonPalettereadonly;
            txtrs.PaletteMode = PaletteMode.Custom;
            txtrs.ReadOnly = true;
            txtrs.Size = new Size(158, 23);
            txtrs.TabIndex = 22;
            txtrs.Tag = "vc_po_status_desc";
            // 
            // txtcat
            // 
            txtcat.Enabled = false;
            txtcat.Location = new Point(388, 560);
            txtcat.Name = "txtcat";
            txtcat.Palette = kryptonPalettereadonly;
            txtcat.PaletteMode = PaletteMode.Custom;
            txtcat.ReadOnly = true;
            txtcat.Size = new Size(158, 23);
            txtcat.TabIndex = 23;
            txtcat.Tag = "vc_category_desc";
            // 
            // txtremain
            // 
            txtremain.Location = new Point(701, 560);
            txtremain.Name = "txtremain";
            txtremain.Size = new Size(158, 23);
            txtremain.TabIndex = 24;
            txtremain.Tag = "i_remain_req_qty";
            // 
            // txtqty
            // 
            txtqty.Enabled = false;
            txtqty.Location = new Point(701, 510);
            txtqty.Name = "txtqty";
            txtqty.Palette = kryptonPalettereadonly;
            txtqty.PaletteMode = PaletteMode.Custom;
            txtqty.ReadOnly = true;
            txtqty.Size = new Size(158, 23);
            txtqty.TabIndex = 25;
            txtqty.Tag = "i_item_req_qty";
            // 
            // btnchange
            // 
            btnchange.CornerRoundingRadius = -1F;
            btnchange.Location = new Point(51, 307);
            btnchange.Name = "btnchange";
            btnchange.Palette = kryptonPalettebtn;
            btnchange.PaletteMode = PaletteMode.Custom;
            btnchange.Size = new Size(95, 40);
            btnchange.TabIndex = 27;
            btnchange.Values.Text = "Update";
            btnchange.Click += btnchange_Click;
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
            // btndel
            // 
            btndel.CornerRoundingRadius = -1F;
            btndel.Location = new Point(169, 307);
            btndel.Name = "btndel";
            btndel.Palette = kryptonPalettebtn;
            btndel.PaletteMode = PaletteMode.Custom;
            btndel.Size = new Size(102, 40);
            btndel.TabIndex = 28;
            btndel.Values.Text = "Delete";
            btndel.Click += btndel_Click;
            // 
            // dateTimePickerEDD
            // 
            dateTimePickerEDD.Location = new Point(659, 444);
            dateTimePickerEDD.Name = "dateTimePickerEDD";
            dateTimePickerEDD.Size = new Size(200, 23);
            dateTimePickerEDD.TabIndex = 29;
            dateTimePickerEDD.Tag = "dt_exp_deli_date";
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(297, 307);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = PaletteMode.Custom;
            btncancel.Size = new Size(102, 40);
            btncancel.TabIndex = 30;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // RequestEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(935, 743);
            Controls.Add(btncancel);
            Controls.Add(dateTimePickerEDD);
            Controls.Add(btndel);
            Controls.Add(btnchange);
            Controls.Add(txtqty);
            Controls.Add(txtremain);
            Controls.Add(txtcat);
            Controls.Add(txtrs);
            Controls.Add(txtitname);
            Controls.Add(txtvid);
            Controls.Add(lblEDD);
            Controls.Add(lblrs);
            Controls.Add(lblcat);
            Controls.Add(lblitname);
            Controls.Add(lblremain);
            Controls.Add(lblqty);
            Controls.Add(datagridviewitem);
            Controls.Add(lblvid);
            Controls.Add(txtcrDate);
            Controls.Add(txtreqst);
            Controls.Add(txtloc);
            Controls.Add(txtstaName);
            Controls.Add(txtreqid);
            Controls.Add(lblCrDate);
            Controls.Add(lblreqSta);
            Controls.Add(lblloc);
            Controls.Add(lblstaffName);
            Controls.Add(lblreqid);
            Name = "RequestEdit";
            Text = "RequestEdit";
            Load += RequestEdit_Load;
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).EndInit();
            ResumeLayout(false);
            PerformLayout();
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