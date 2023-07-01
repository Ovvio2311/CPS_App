using Krypton.Toolkit;
namespace CPS_App
{
    partial class ItemCreate
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
            this.txtitname = new Krypton.Toolkit.KryptonTextBox();
            this.lblcrit = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblitname = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblcat = new Krypton.Toolkit.KryptonLabel();
            this.lblloc = new Krypton.Toolkit.KryptonLabel();
            this.lblvid = new Krypton.Toolkit.KryptonLabel();
            this.lbluom = new Krypton.Toolkit.KryptonLabel();
            this.pnit = new Krypton.Toolkit.KryptonPanel();
            this.chkcrloc = new Krypton.Toolkit.KryptonCheckBox();
            this.chkstock = new Krypton.Toolkit.KryptonCheckBox();
            this.txtqty = new Krypton.Toolkit.KryptonTextBox();
            this.lblqty = new Krypton.Toolkit.KryptonLabel();
            this.cbxsup = new Krypton.Toolkit.KryptonComboBox();
            this.btnitsb = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblsup = new Krypton.Toolkit.KryptonLabel();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.cbxuom = new Krypton.Toolkit.KryptonComboBox();
            this.cbxvid = new Krypton.Toolkit.KryptonComboBox();
            this.cbxloc = new Krypton.Toolkit.KryptonComboBox();
            this.cbxcat = new Krypton.Toolkit.KryptonComboBox();
            this.btnitcr = new Krypton.Toolkit.KryptonButton();
            this.cbxitid = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnit)).BeginInit();
            this.pnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxuom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxvid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxloc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxcat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxitid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtitname
            // 
            this.txtitname.Location = new System.Drawing.Point(184, 124);
            this.txtitname.Name = "txtitname";
            this.txtitname.Size = new System.Drawing.Size(177, 23);
            this.txtitname.TabIndex = 1;
            this.txtitname.Tag = "vc_item_desc";
            // 
            // lblcrit
            // 
            this.lblcrit.Location = new System.Drawing.Point(25, 62);
            this.lblcrit.Name = "lblcrit";
            this.lblcrit.Palette = this.kryptonPaletteheader;
            this.lblcrit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblcrit.Size = new System.Drawing.Size(103, 23);
            this.lblcrit.TabIndex = 3;
            this.lblcrit.Values.Text = "Create Item";
            // 
            // kryptonPaletteheader
            // 
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkCyan;
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // lblitname
            // 
            this.lblitname.Location = new System.Drawing.Point(81, 126);
            this.lblitname.Name = "lblitname";
            this.lblitname.Palette = this.kryptonPalettelbl;
            this.lblitname.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblitname.Size = new System.Drawing.Size(53, 21);
            this.lblitname.TabIndex = 4;
            this.lblitname.Tag = "vc_item_desc";
            this.lblitname.Values.Text = "Name";
            // 
            // kryptonPalettelbl
            // 
            this.kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblcat
            // 
            this.lblcat.Location = new System.Drawing.Point(64, 178);
            this.lblcat.Name = "lblcat";
            this.lblcat.Palette = this.kryptonPalettelbl;
            this.lblcat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblcat.Size = new System.Drawing.Size(74, 21);
            this.lblcat.TabIndex = 5;
            this.lblcat.Tag = "vc_category_desc";
            this.lblcat.Values.Text = "Category";
            // 
            // lblloc
            // 
            this.lblloc.Location = new System.Drawing.Point(403, 231);
            this.lblloc.Name = "lblloc";
            this.lblloc.Palette = this.kryptonPalettelbl;
            this.lblloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblloc.Size = new System.Drawing.Size(70, 21);
            this.lblloc.TabIndex = 6;
            this.lblloc.Tag = "vc_location_desc";
            this.lblloc.Values.Text = "Location";
            // 
            // lblvid
            // 
            this.lblvid.Location = new System.Drawing.Point(91, 231);
            this.lblvid.Name = "lblvid";
            this.lblvid.Palette = this.kryptonPalettelbl;
            this.lblvid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblvid.Size = new System.Drawing.Size(37, 21);
            this.lblvid.TabIndex = 7;
            this.lblvid.Tag = "bi_item_vid";
            this.lblvid.Values.Text = "VID";
            // 
            // lbluom
            // 
            this.lbluom.Location = new System.Drawing.Point(3, 285);
            this.lbluom.Name = "lbluom";
            this.lbluom.Palette = this.kryptonPalettelbl;
            this.lbluom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lbluom.Size = new System.Drawing.Size(155, 21);
            this.lbluom.TabIndex = 8;
            this.lbluom.Tag = "vc_uom_desc";
            this.lbluom.Values.Text = "Unit of Measurement";
            // 
            // pnit
            // 
            this.pnit.Controls.Add(this.chkcrloc);
            this.pnit.Controls.Add(this.chkstock);
            this.pnit.Controls.Add(this.txtqty);
            this.pnit.Controls.Add(this.lblqty);
            this.pnit.Controls.Add(this.cbxsup);
            this.pnit.Controls.Add(this.btnitsb);
            this.pnit.Controls.Add(this.lblsup);
            this.pnit.Controls.Add(this.btncancel);
            this.pnit.Controls.Add(this.lblvid);
            this.pnit.Controls.Add(this.lbluom);
            this.pnit.Controls.Add(this.lblcat);
            this.pnit.Controls.Add(this.cbxuom);
            this.pnit.Controls.Add(this.lblitname);
            this.pnit.Controls.Add(this.cbxvid);
            this.pnit.Controls.Add(this.lblcrit);
            this.pnit.Controls.Add(this.lblloc);
            this.pnit.Controls.Add(this.cbxloc);
            this.pnit.Controls.Add(this.cbxcat);
            this.pnit.Controls.Add(this.btnitcr);
            this.pnit.Controls.Add(this.cbxitid);
            this.pnit.Controls.Add(this.txtitname);
            this.pnit.Location = new System.Drawing.Point(-5, 0);
            this.pnit.Name = "pnit";
            this.pnit.Palette = this.kryptonPalettepanel;
            this.pnit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.pnit.Size = new System.Drawing.Size(755, 448);
            this.pnit.TabIndex = 13;
            // 
            // chkcrloc
            // 
            this.chkcrloc.Location = new System.Drawing.Point(184, 98);
            this.chkcrloc.Name = "chkcrloc";
            this.chkcrloc.Size = new System.Drawing.Size(184, 20);
            this.chkcrloc.TabIndex = 19;
            this.chkcrloc.Values.Text = "Existing Stock Create location";
            this.chkcrloc.CheckedChanged += new System.EventHandler(this.chkcrloc_CheckedChanged);
            // 
            // chkstock
            // 
            this.chkstock.Location = new System.Drawing.Point(405, 65);
            this.chkstock.Name = "chkstock";
            this.chkstock.Size = new System.Drawing.Size(152, 20);
            this.chkstock.TabIndex = 18;
            this.chkstock.Values.Text = "Insert Stock Import Info";
            this.chkstock.CheckedChanged += new System.EventHandler(this.chkstock_CheckedChanged);
            // 
            // txtqty
            // 
            this.txtqty.Enabled = false;
            this.txtqty.Location = new System.Drawing.Point(479, 176);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(177, 23);
            this.txtqty.TabIndex = 7;
            this.txtqty.Tag = "i_item_qty";
            // 
            // lblqty
            // 
            this.lblqty.Location = new System.Drawing.Point(405, 178);
            this.lblqty.Name = "lblqty";
            this.lblqty.Palette = this.kryptonPalettelbl;
            this.lblqty.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblqty.Size = new System.Drawing.Size(69, 21);
            this.lblqty.TabIndex = 17;
            this.lblqty.Tag = "i_item_qty";
            this.lblqty.Values.Text = "Quantity";
            // 
            // cbxsup
            // 
            this.cbxsup.CornerRoundingRadius = -1F;
            this.cbxsup.DropDownWidth = 177;
            this.cbxsup.Enabled = false;
            this.cbxsup.FormattingEnabled = true;
            this.cbxsup.IntegralHeight = false;
            this.cbxsup.Location = new System.Drawing.Point(479, 124);
            this.cbxsup.Name = "cbxsup";
            this.cbxsup.Size = new System.Drawing.Size(177, 21);
            this.cbxsup.TabIndex = 6;
            this.cbxsup.Tag = "bi_supp_id:vc_supp_desc";
            // 
            // btnitsb
            // 
            this.btnitsb.CornerRoundingRadius = -1F;
            this.btnitsb.Location = new System.Drawing.Point(562, 390);
            this.btnitsb.Name = "btnitsb";
            this.btnitsb.Palette = this.kryptonPalettebtn;
            this.btnitsb.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnitsb.Size = new System.Drawing.Size(94, 48);
            this.btnitsb.TabIndex = 10;
            this.btnitsb.Values.Text = "Submit";
            this.btnitsb.Click += new System.EventHandler(this.btnitsb_Click);
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
            // lblsup
            // 
            this.lblsup.Location = new System.Drawing.Point(405, 126);
            this.lblsup.Name = "lblsup";
            this.lblsup.Palette = this.kryptonPalettelbl;
            this.lblsup.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblsup.Size = new System.Drawing.Size(68, 21);
            this.lblsup.TabIndex = 14;
            this.lblsup.Tag = "vc_supp_desc";
            this.lblsup.Values.Text = "Supplier";
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(242, 390);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(94, 48);
            this.btncancel.TabIndex = 8;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cbxuom
            // 
            this.cbxuom.CornerRoundingRadius = -1F;
            this.cbxuom.DropDownWidth = 177;
            this.cbxuom.FormattingEnabled = true;
            this.cbxuom.IntegralHeight = false;
            this.cbxuom.Location = new System.Drawing.Point(184, 285);
            this.cbxuom.Name = "cbxuom";
            this.cbxuom.Size = new System.Drawing.Size(177, 21);
            this.cbxuom.TabIndex = 5;
            this.cbxuom.Tag = "i_uom_id:vc_uom_desc";
            // 
            // cbxvid
            // 
            this.cbxvid.CornerRoundingRadius = -1F;
            this.cbxvid.DropDownWidth = 177;
            this.cbxvid.FormattingEnabled = true;
            this.cbxvid.IntegralHeight = false;
            this.cbxvid.Location = new System.Drawing.Point(184, 231);
            this.cbxvid.Name = "cbxvid";
            this.cbxvid.Size = new System.Drawing.Size(177, 21);
            this.cbxvid.TabIndex = 4;
            this.cbxvid.Tag = "bi_item_vid";
            // 
            // cbxloc
            // 
            this.cbxloc.CornerRoundingRadius = -1F;
            this.cbxloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxloc.DropDownWidth = 177;
            this.cbxloc.Enabled = false;
            this.cbxloc.FormattingEnabled = true;
            this.cbxloc.IntegralHeight = false;
            this.cbxloc.Location = new System.Drawing.Point(479, 231);
            this.cbxloc.Name = "cbxloc";
            this.cbxloc.Size = new System.Drawing.Size(177, 21);
            this.cbxloc.TabIndex = 3;
            this.cbxloc.Tag = "bi_location_id:vc_location_desc";
            // 
            // cbxcat
            // 
            this.cbxcat.CornerRoundingRadius = -1F;
            this.cbxcat.DropDownWidth = 177;
            this.cbxcat.FormattingEnabled = true;
            this.cbxcat.IntegralHeight = false;
            this.cbxcat.Location = new System.Drawing.Point(184, 178);
            this.cbxcat.Name = "cbxcat";
            this.cbxcat.Size = new System.Drawing.Size(177, 21);
            this.cbxcat.TabIndex = 2;
            this.cbxcat.Tag = "bi_category_id:vc_category_desc";
            // 
            // btnitcr
            // 
            this.btnitcr.CornerRoundingRadius = -1F;
            this.btnitcr.Location = new System.Drawing.Point(405, 390);
            this.btnitcr.Name = "btnitcr";
            this.btnitcr.Palette = this.kryptonPalettebtn;
            this.btnitcr.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnitcr.Size = new System.Drawing.Size(94, 48);
            this.btnitcr.TabIndex = 9;
            this.btnitcr.Values.Text = "Clear";
            this.btnitcr.Click += new System.EventHandler(this.btnitcr_Click);
            // 
            // cbxitid
            // 
            this.cbxitid.CornerRoundingRadius = -1F;
            this.cbxitid.DropDownWidth = 177;
            this.cbxitid.Enabled = false;
            this.cbxitid.FormattingEnabled = true;
            this.cbxitid.IntegralHeight = false;
            this.cbxitid.Location = new System.Drawing.Point(184, 126);
            this.cbxitid.Name = "cbxitid";
            this.cbxitid.Size = new System.Drawing.Size(177, 21);
            this.cbxitid.TabIndex = 20;
            this.cbxitid.Tag = "bi_item_id:vc_item_desc";
            this.cbxitid.SelectedIndexChanged += new System.EventHandler(this.cbxitid_SelectedIndexChanged);
            // 
            // kryptonPalettepanel
            // 
            this.kryptonPalettepanel.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettepanel.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // ItemCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.pnit);
            this.Name = "ItemCreate";
            this.Text = "ItemCreate";
            this.Load += new System.EventHandler(this.ItemCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnit)).EndInit();
            this.pnit.ResumeLayout(false);
            this.pnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxuom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxvid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxloc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxcat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxitid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KryptonTextBox txtitname;
        private KryptonLabel lblcrit;
        private KryptonLabel lblitname;
        private KryptonLabel lblcat;
        private KryptonLabel lblloc;
        private KryptonLabel lblvid;
        private KryptonLabel lbluom;
        private KryptonPanel pnit;
        private KryptonButton btnitsb;
        private KryptonButton btnitcr;
        private KryptonComboBox cbxuom;
        private KryptonComboBox cbxvid;
        private KryptonComboBox cbxloc;
        private KryptonComboBox cbxcat;
        private KryptonPalette kryptonPalettebtn;
        private KryptonPalette kryptonPaletteheader;
        private KryptonPalette kryptonPalettepanel;
        private KryptonPalette kryptonPalettelbl;
        private KryptonComboBox cbxsup;
        private KryptonLabel lblsup;
        private KryptonButton btncancel;
        private KryptonTextBox txtqty;
        private KryptonLabel lblqty;
        private KryptonCheckBox chkstock;
        private KryptonCheckBox chkcrloc;
        private KryptonComboBox cbxitid;
    }
}