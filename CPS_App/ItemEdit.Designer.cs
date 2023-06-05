using Krypton.Toolkit;
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
            this.components = new System.ComponentModel.Container();
            this.lblid = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblvid = new Krypton.Toolkit.KryptonLabel();
            this.lblname = new Krypton.Toolkit.KryptonLabel();
            this.lblcat = new Krypton.Toolkit.KryptonLabel();
            this.lbluom = new Krypton.Toolkit.KryptonLabel();
            this.lblloc = new Krypton.Toolkit.KryptonLabel();
            this.lblqty = new Krypton.Toolkit.KryptonLabel();
            this.lbluptime = new Krypton.Toolkit.KryptonLabel();
            this.txtvid = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(this.components);
            this.txtcat = new Krypton.Toolkit.KryptonTextBox();
            this.txtname = new Krypton.Toolkit.KryptonTextBox();
            this.txtid = new Krypton.Toolkit.KryptonTextBox();
            this.txtqty = new Krypton.Toolkit.KryptonTextBox();
            this.txtloc = new Krypton.Toolkit.KryptonTextBox();
            this.txtupdate = new Krypton.Toolkit.KryptonTextBox();
            this.txtuom = new Krypton.Toolkit.KryptonTextBox();
            this.dataGridViewitem = new Krypton.Toolkit.KryptonDataGridView();
            this.btnmod = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.btndel = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(29, 223);
            this.lblid.Name = "lblid";
            this.lblid.Palette = this.kryptonPalettelbl;
            this.lblid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblid.Size = new System.Drawing.Size(61, 21);
            this.lblid.TabIndex = 0;
            this.lblid.Values.Text = "Item ID";
            // 
            // kryptonPalettelbl
            // 
            this.kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblvid
            // 
            this.lblvid.Location = new System.Drawing.Point(22, 262);
            this.lblvid.Name = "lblvid";
            this.lblvid.Palette = this.kryptonPalettelbl;
            this.lblvid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblvid.Size = new System.Drawing.Size(71, 21);
            this.lblvid.TabIndex = 1;
            this.lblvid.Values.Text = "Item VID";
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(254, 223);
            this.lblname.Name = "lblname";
            this.lblname.Palette = this.kryptonPalettelbl;
            this.lblname.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblname.Size = new System.Drawing.Size(87, 21);
            this.lblname.TabIndex = 2;
            this.lblname.Values.Text = "Item Name";
            // 
            // lblcat
            // 
            this.lblcat.Location = new System.Drawing.Point(267, 262);
            this.lblcat.Name = "lblcat";
            this.lblcat.Palette = this.kryptonPalettelbl;
            this.lblcat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblcat.Size = new System.Drawing.Size(74, 21);
            this.lblcat.TabIndex = 3;
            this.lblcat.Values.Text = "Category";
            // 
            // lbluom
            // 
            this.lbluom.Location = new System.Drawing.Point(188, 304);
            this.lbluom.Name = "lbluom";
            this.lbluom.Palette = this.kryptonPalettelbl;
            this.lbluom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lbluom.Size = new System.Drawing.Size(155, 21);
            this.lbluom.TabIndex = 4;
            this.lbluom.Values.Text = "Unit of Measurement";
            // 
            // lblloc
            // 
            this.lblloc.Location = new System.Drawing.Point(533, 262);
            this.lblloc.Name = "lblloc";
            this.lblloc.Palette = this.kryptonPalettelbl;
            this.lblloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblloc.Size = new System.Drawing.Size(113, 21);
            this.lblloc.TabIndex = 5;
            this.lblloc.Values.Text = "Stock Loaction";
            // 
            // lblqty
            // 
            this.lblqty.Location = new System.Drawing.Point(533, 223);
            this.lblqty.Name = "lblqty";
            this.lblqty.Palette = this.kryptonPalettelbl;
            this.lblqty.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblqty.Size = new System.Drawing.Size(69, 21);
            this.lblqty.TabIndex = 6;
            this.lblqty.Values.Text = "Quantity";
            // 
            // lbluptime
            // 
            this.lbluptime.Location = new System.Drawing.Point(513, 304);
            this.lbluptime.Name = "lbluptime";
            this.lbluptime.Palette = this.kryptonPalettelbl;
            this.lbluptime.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lbluptime.Size = new System.Drawing.Size(142, 21);
            this.lbluptime.TabIndex = 7;
            this.lbluptime.Values.Text = "Last Updated Time";
            // 
            // txtvid
            // 
            this.txtvid.Location = new System.Drawing.Point(96, 259);
            this.txtvid.Name = "txtvid";
            this.txtvid.Palette = this.kryptonPalettereadonly;
            this.txtvid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtvid.ReadOnly = true;
            this.txtvid.Size = new System.Drawing.Size(120, 23);
            this.txtvid.TabIndex = 8;
            // 
            // kryptonPalettereadonly
            // 
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color2 = System.Drawing.SystemColors.Control;
            // 
            // txtcat
            // 
            this.txtcat.Location = new System.Drawing.Point(350, 259);
            this.txtcat.Name = "txtcat";
            this.txtcat.Palette = this.kryptonPalettereadonly;
            this.txtcat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtcat.ReadOnly = true;
            this.txtcat.Size = new System.Drawing.Size(120, 23);
            this.txtcat.TabIndex = 9;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(350, 220);
            this.txtname.Name = "txtname";
            this.txtname.Palette = this.kryptonPalettereadonly;
            this.txtname.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(120, 23);
            this.txtname.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(96, 220);
            this.txtid.Name = "txtid";
            this.txtid.Palette = this.kryptonPalettereadonly;
            this.txtid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(120, 23);
            this.txtid.TabIndex = 11;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(653, 220);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(120, 23);
            this.txtqty.TabIndex = 12;
            // 
            // txtloc
            // 
            this.txtloc.Location = new System.Drawing.Point(653, 259);
            this.txtloc.Name = "txtloc";
            this.txtloc.ReadOnly = true;
            this.txtloc.Size = new System.Drawing.Size(120, 23);
            this.txtloc.TabIndex = 13;
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(653, 301);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Palette = this.kryptonPalettereadonly;
            this.txtupdate.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtupdate.ReadOnly = true;
            this.txtupdate.Size = new System.Drawing.Size(120, 23);
            this.txtupdate.TabIndex = 14;
            // 
            // txtuom
            // 
            this.txtuom.Location = new System.Drawing.Point(349, 301);
            this.txtuom.Name = "txtuom";
            this.txtuom.Palette = this.kryptonPalettereadonly;
            this.txtuom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtuom.ReadOnly = true;
            this.txtuom.Size = new System.Drawing.Size(120, 23);
            this.txtuom.TabIndex = 15;
            // 
            // dataGridViewitem
            // 
            this.dataGridViewitem.AllowUserToAddRows = false;
            this.dataGridViewitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewitem.Location = new System.Drawing.Point(29, 39);
            this.dataGridViewitem.Name = "dataGridViewitem";
            this.dataGridViewitem.Palette = this.kryptonPalettedatagridview;
            this.dataGridViewitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dataGridViewitem.RowTemplate.Height = 25;
            this.dataGridViewitem.Size = new System.Drawing.Size(745, 150);
            this.dataGridViewitem.TabIndex = 16;
            this.dataGridViewitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewitem_CellClick);
            // 
            // btnmod
            // 
            this.btnmod.CornerRoundingRadius = -1F;
            this.btnmod.Location = new System.Drawing.Point(686, 347);
            this.btnmod.Name = "btnmod";
            this.btnmod.Palette = this.kryptonPalettebtn;
            this.btnmod.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnmod.Size = new System.Drawing.Size(87, 36);
            this.btnmod.TabIndex = 17;
            this.btnmod.Values.Text = "Update";
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
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
            // kryptonPaletteheader
            // 
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkCyan;
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // kryptonPalettepanel
            // 
            this.kryptonPalettepanel.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettepanel.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(433, 347);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(87, 36);
            this.btncancel.TabIndex = 21;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndel
            // 
            this.btndel.CornerRoundingRadius = -1F;
            this.btndel.Location = new System.Drawing.Point(559, 347);
            this.btndel.Name = "btndel";
            this.btndel.Palette = this.kryptonPalettebtn;
            this.btndel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btndel.Size = new System.Drawing.Size(87, 36);
            this.btndel.TabIndex = 22;
            this.btndel.Values.Text = "Delete";
            // 
            // kryptonPalettedatagridview
            // 
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // ItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.dataGridViewitem);
            this.Controls.Add(this.txtuom);
            this.Controls.Add(this.txtupdate);
            this.Controls.Add(this.txtloc);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.txtvid);
            this.Controls.Add(this.lbluptime);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.lblloc);
            this.Controls.Add(this.lbluom);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblvid);
            this.Controls.Add(this.lblid);
            this.Name = "ItemEdit";
            this.Text = "ItemEdit";
            this.Load += new System.EventHandler(this.ItemEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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