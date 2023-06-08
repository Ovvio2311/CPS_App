﻿using Krypton.Toolkit;
namespace CPS_App
{
    partial class ItemEdit
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
            lblid = new KryptonLabel();
            kryptonPalettelbl = new KryptonPalette(components);
            lblvid = new KryptonLabel();
            lblname = new KryptonLabel();
            lblcat = new KryptonLabel();
            lbluom = new KryptonLabel();
            lblloc = new KryptonLabel();
            lblqty = new KryptonLabel();
            lbluptime = new KryptonLabel();
            txtvid = new KryptonTextBox();
            kryptonPalettereadonly = new KryptonPalette(components);
            txtcat = new KryptonTextBox();
            txtname = new KryptonTextBox();
            txtid = new KryptonTextBox();
            txtqty = new KryptonTextBox();
            txtloc = new KryptonTextBox();
            txtupdate = new KryptonTextBox();
            txtuom = new KryptonTextBox();
            dataGridViewitem = new KryptonDataGridView();
            kryptonPalettedatagridview = new KryptonPalette(components);
            btnmod = new KryptonButton();
            kryptonPalettebtn = new KryptonPalette(components);
            kryptonPaletteheader = new KryptonPalette(components);
            kryptonPalettepanel = new KryptonPalette(components);
            btncancel = new KryptonButton();
            btndel = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewitem).BeginInit();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.Location = new Point(29, 223);
            lblid.Name = "lblid";
            lblid.Palette = kryptonPalettelbl;
            lblid.PaletteMode = PaletteMode.Custom;
            lblid.Size = new Size(61, 21);
            lblid.TabIndex = 0;
            lblid.Tag = "bi_item_id";
            lblid.Values.Text = "Item ID";
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // lblvid
            // 
            lblvid.Location = new Point(22, 262);
            lblvid.Name = "lblvid";
            lblvid.Palette = kryptonPalettelbl;
            lblvid.PaletteMode = PaletteMode.Custom;
            lblvid.Size = new Size(71, 21);
            lblvid.TabIndex = 1;
            lblvid.Tag = "bi_item_vid";
            lblvid.Values.Text = "Item VID";
            // 
            // lblname
            // 
            lblname.Location = new Point(254, 223);
            lblname.Name = "lblname";
            lblname.Palette = kryptonPalettelbl;
            lblname.PaletteMode = PaletteMode.Custom;
            lblname.Size = new Size(87, 21);
            lblname.TabIndex = 2;
            lblname.Values.Text = "Item Name";
            // 
            // lblcat
            // 
            lblcat.Location = new Point(267, 262);
            lblcat.Name = "lblcat";
            lblcat.Palette = kryptonPalettelbl;
            lblcat.PaletteMode = PaletteMode.Custom;
            lblcat.Size = new Size(74, 21);
            lblcat.TabIndex = 3;
            lblcat.Tag = "vc_category_desc";
            lblcat.Values.Text = "Category";
            // 
            // lbluom
            // 
            lbluom.Location = new Point(188, 304);
            lbluom.Name = "lbluom";
            lbluom.Palette = kryptonPalettelbl;
            lbluom.PaletteMode = PaletteMode.Custom;
            lbluom.Size = new Size(155, 21);
            lbluom.TabIndex = 4;
            lbluom.Tag = "vc_uom_desc";
            lbluom.Values.Text = "Unit of Measurement";
            // 
            // lblloc
            // 
            lblloc.Location = new Point(533, 262);
            lblloc.Name = "lblloc";
            lblloc.Palette = kryptonPalettelbl;
            lblloc.PaletteMode = PaletteMode.Custom;
            lblloc.Size = new Size(113, 21);
            lblloc.TabIndex = 5;
            lblloc.Tag = "vc_location_desc";
            lblloc.Values.Text = "Stock Loaction";
            // 
            // lblqty
            // 
            lblqty.Location = new Point(533, 223);
            lblqty.Name = "lblqty";
            lblqty.Palette = kryptonPalettelbl;
            lblqty.PaletteMode = PaletteMode.Custom;
            lblqty.Size = new Size(69, 21);
            lblqty.TabIndex = 6;
            lblqty.Tag = "i_item_qty";
            lblqty.Values.Text = "Quantity";
            // 
            // lbluptime
            // 
            lbluptime.Location = new Point(513, 304);
            lbluptime.Name = "lbluptime";
            lbluptime.Palette = kryptonPalettelbl;
            lbluptime.PaletteMode = PaletteMode.Custom;
            lbluptime.Size = new Size(142, 21);
            lbluptime.TabIndex = 7;
            lbluptime.Tag = "dt_updated_datetime";
            lbluptime.Values.Text = "Last Updated Time";
            // 
            // txtvid
            // 
            txtvid.Enabled = false;
            txtvid.Location = new Point(96, 259);
            txtvid.Name = "txtvid";
            txtvid.Palette = kryptonPalettereadonly;
            txtvid.PaletteMode = PaletteMode.Custom;
            txtvid.ReadOnly = true;
            txtvid.Size = new Size(120, 23);
            txtvid.TabIndex = 8;
            txtvid.Tag = "bi_item_vid";
            // 
            // kryptonPalettereadonly
            // 
            kryptonPalettereadonly.Common.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonPalettereadonly.Common.StateCommon.Back.Color2 = SystemColors.Control;
            // 
            // txtcat
            // 
            txtcat.Enabled = false;
            txtcat.Location = new Point(350, 259);
            txtcat.Name = "txtcat";
            txtcat.Palette = kryptonPalettereadonly;
            txtcat.PaletteMode = PaletteMode.Custom;
            txtcat.ReadOnly = true;
            txtcat.Size = new Size(120, 23);
            txtcat.TabIndex = 9;
            txtcat.Tag = "vc_category_desc";
            // 
            // txtname
            // 
            txtname.Enabled = false;
            txtname.Location = new Point(350, 220);
            txtname.Name = "txtname";
            txtname.Palette = kryptonPalettereadonly;
            txtname.PaletteMode = PaletteMode.Custom;
            txtname.ReadOnly = true;
            txtname.Size = new Size(120, 23);
            txtname.TabIndex = 10;
            txtname.Tag = "vc_item_desc";
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(96, 220);
            txtid.Name = "txtid";
            txtid.Palette = kryptonPalettereadonly;
            txtid.PaletteMode = PaletteMode.Custom;
            txtid.ReadOnly = true;
            txtid.Size = new Size(120, 23);
            txtid.TabIndex = 11;
            txtid.Tag = "bi_item_id";
            // 
            // txtqty
            // 
            txtqty.Location = new Point(653, 220);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(120, 23);
            txtqty.TabIndex = 12;
            txtqty.Tag = "i_item_qty";
            // 
            // txtloc
            // 
            txtloc.Enabled = false;
            txtloc.Location = new Point(653, 259);
            txtloc.Name = "txtloc";
            txtloc.Palette = kryptonPalettereadonly;
            txtloc.PaletteMode = PaletteMode.Custom;
            txtloc.Size = new Size(120, 23);
            txtloc.TabIndex = 13;
            txtloc.Tag = "vc_location_desc";
            // 
            // txtupdate
            // 
            txtupdate.Enabled = false;
            txtupdate.Location = new Point(653, 301);
            txtupdate.Name = "txtupdate";
            txtupdate.Palette = kryptonPalettereadonly;
            txtupdate.PaletteMode = PaletteMode.Custom;
            txtupdate.ReadOnly = true;
            txtupdate.Size = new Size(120, 23);
            txtupdate.TabIndex = 14;
            txtupdate.Tag = "dt_updated_datetime";
            // 
            // txtuom
            // 
            txtuom.Enabled = false;
            txtuom.Location = new Point(349, 301);
            txtuom.Name = "txtuom";
            txtuom.Palette = kryptonPalettereadonly;
            txtuom.PaletteMode = PaletteMode.Custom;
            txtuom.ReadOnly = true;
            txtuom.Size = new Size(120, 23);
            txtuom.TabIndex = 15;
            txtuom.Tag = "vc_uom_desc";
            // 
            // dataGridViewitem
            // 
            dataGridViewitem.AllowUserToAddRows = false;
            dataGridViewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewitem.Location = new Point(38, 39);
            dataGridViewitem.Name = "dataGridViewitem";
            dataGridViewitem.Palette = kryptonPalettedatagridview;
            dataGridViewitem.PaletteMode = PaletteMode.Custom;
            dataGridViewitem.RowTemplate.Height = 25;
            dataGridViewitem.Size = new Size(745, 150);
            dataGridViewitem.TabIndex = 16;
            dataGridViewitem.CellClick += dataGridViewitem_CellClick;
            // 
            // kryptonPalettedatagridview
            // 
            kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // btnmod
            // 
            btnmod.CornerRoundingRadius = -1F;
            btnmod.Location = new Point(687, 347);
            btnmod.Name = "btnmod";
            btnmod.Palette = kryptonPalettebtn;
            btnmod.PaletteMode = PaletteMode.Custom;
            btnmod.Size = new Size(87, 36);
            btnmod.TabIndex = 17;
            btnmod.Values.Text = "Update";
            btnmod.Click += btnmod_Click;
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
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(428, 347);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = PaletteMode.Custom;
            btncancel.Size = new Size(87, 36);
            btncancel.TabIndex = 21;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // btndel
            // 
            btndel.CornerRoundingRadius = -1F;
            btndel.Location = new Point(559, 347);
            btndel.Name = "btndel";
            btndel.Palette = kryptonPalettebtn;
            btndel.PaletteMode = PaletteMode.Custom;
            btndel.Size = new Size(87, 36);
            btndel.TabIndex = 22;
            btndel.Values.Text = "Delete";
            // 
            // ItemEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 477);
            Controls.Add(btndel);
            Controls.Add(btncancel);
            Controls.Add(btnmod);
            Controls.Add(dataGridViewitem);
            Controls.Add(txtuom);
            Controls.Add(txtupdate);
            Controls.Add(txtloc);
            Controls.Add(txtqty);
            Controls.Add(txtid);
            Controls.Add(txtname);
            Controls.Add(txtcat);
            Controls.Add(txtvid);
            Controls.Add(lbluptime);
            Controls.Add(lblqty);
            Controls.Add(lblloc);
            Controls.Add(lbluom);
            Controls.Add(lblcat);
            Controls.Add(lblname);
            Controls.Add(lblvid);
            Controls.Add(lblid);
            Name = "ItemEdit";
            Text = "ItemEdit";
            Load += ItemEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewitem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonLabel lblid;
        private KryptonLabel lblvid;
        private KryptonLabel lblname;
        private KryptonLabel lblcat;
        private KryptonLabel lbluom;
        private KryptonLabel lblloc;
        private KryptonLabel lblqty;
        private KryptonLabel lbluptime;
        private KryptonTextBox txtvid;
        private KryptonTextBox txtcat;
        private KryptonTextBox txtname;
        private KryptonTextBox txtid;
        private KryptonTextBox txtqty;
        private KryptonTextBox txtloc;
        private KryptonTextBox txtupdate;
        private KryptonTextBox txtuom;
        private KryptonDataGridView dataGridViewitem;
        private KryptonButton btnmod;
        private KryptonPalette kryptonPalettelbl;
        private KryptonPalette kryptonPaletteheader;
        private KryptonPalette kryptonPalettebtn;
        private KryptonPalette kryptonPalettepanel;
        private KryptonPalette kryptonPalettereadonly;
        private KryptonButton btncancel;
        private KryptonButton btndel;
        private KryptonPalette kryptonPalettedatagridview;
    }
}