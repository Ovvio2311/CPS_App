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
            components = new System.ComponentModel.Container();
            txtitname = new KryptonTextBox();
            lblcrit = new KryptonLabel();
            kryptonPaletteheader = new KryptonPalette(components);
            lblitname = new KryptonLabel();
            kryptonPalettelbl = new KryptonPalette(components);
            lblcat = new KryptonLabel();
            lblloc = new KryptonLabel();
            lblvid = new KryptonLabel();
            lbluom = new KryptonLabel();
            pnit = new KryptonPanel();
            chkstock = new KryptonCheckBox();
            txtqty = new KryptonTextBox();
            lblqty = new KryptonLabel();
            cbxsup = new KryptonComboBox();
            btnitsb = new KryptonButton();
            kryptonPalettebtn = new KryptonPalette(components);
            lblsup = new KryptonLabel();
            btncancel = new KryptonButton();
            cbxuom = new KryptonComboBox();
            cbxvid = new KryptonComboBox();
            cbxloc = new KryptonComboBox();
            cbxcat = new KryptonComboBox();
            btnitcr = new KryptonButton();
            kryptonPalettepanel = new KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)pnit).BeginInit();
            pnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxuom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxvid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxloc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxcat).BeginInit();
            SuspendLayout();
            // 
            // txtitname
            // 
            txtitname.Location = new Point(184, 124);
            txtitname.Name = "txtitname";
            txtitname.Size = new Size(177, 23);
            txtitname.TabIndex = 1;
            txtitname.Tag = "vc_item_desc";
            txtitname.TextChanged += requiredFieldCheck;
            txtitname.Validating += requiredFieldCheck;
            // 
            // lblcrit
            // 
            lblcrit.Location = new Point(25, 62);
            lblcrit.Name = "lblcrit";
            lblcrit.Palette = kryptonPaletteheader;
            lblcrit.PaletteMode = PaletteMode.Custom;
            lblcrit.Size = new Size(103, 23);
            lblcrit.TabIndex = 3;
            lblcrit.Values.Text = "Create Item";
            // 
            // kryptonPaletteheader
            // 
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = Color.DarkCyan;
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // lblitname
            // 
            lblitname.Location = new Point(81, 126);
            lblitname.Name = "lblitname";
            lblitname.Palette = kryptonPalettelbl;
            lblitname.PaletteMode = PaletteMode.Custom;
            lblitname.Size = new Size(53, 21);
            lblitname.TabIndex = 4;
            lblitname.Tag = "vc_item_desc";
            lblitname.Values.Text = "Name";
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // lblcat
            // 
            lblcat.Location = new Point(64, 178);
            lblcat.Name = "lblcat";
            lblcat.Palette = kryptonPalettelbl;
            lblcat.PaletteMode = PaletteMode.Custom;
            lblcat.Size = new Size(74, 21);
            lblcat.TabIndex = 5;
            lblcat.Tag = "vc_category_desc";
            lblcat.Values.Text = "Category";
            // 
            // lblloc
            // 
            lblloc.Location = new Point(403, 231);
            lblloc.Name = "lblloc";
            lblloc.Palette = kryptonPalettelbl;
            lblloc.PaletteMode = PaletteMode.Custom;
            lblloc.Size = new Size(70, 21);
            lblloc.TabIndex = 6;
            lblloc.Tag = "vc_location_desc";
            lblloc.Values.Text = "Location";
            // 
            // lblvid
            // 
            lblvid.Location = new Point(91, 231);
            lblvid.Name = "lblvid";
            lblvid.Palette = kryptonPalettelbl;
            lblvid.PaletteMode = PaletteMode.Custom;
            lblvid.Size = new Size(37, 21);
            lblvid.TabIndex = 7;
            lblvid.Tag = "bi_item_vid";
            lblvid.Values.Text = "VID";
            // 
            // lbluom
            // 
            lbluom.Location = new Point(3, 285);
            lbluom.Name = "lbluom";
            lbluom.Palette = kryptonPalettelbl;
            lbluom.PaletteMode = PaletteMode.Custom;
            lbluom.Size = new Size(155, 21);
            lbluom.TabIndex = 8;
            lbluom.Tag = "vc_uom_desc";
            lbluom.Values.Text = "Unit of Measurement";
            // 
            // pnit
            // 
            pnit.Controls.Add(chkstock);
            pnit.Controls.Add(txtqty);
            pnit.Controls.Add(lblqty);
            pnit.Controls.Add(cbxsup);
            pnit.Controls.Add(btnitsb);
            pnit.Controls.Add(lblsup);
            pnit.Controls.Add(btncancel);
            pnit.Controls.Add(lblvid);
            pnit.Controls.Add(lbluom);
            pnit.Controls.Add(lblcat);
            pnit.Controls.Add(cbxuom);
            pnit.Controls.Add(lblitname);
            pnit.Controls.Add(cbxvid);
            pnit.Controls.Add(lblcrit);
            pnit.Controls.Add(lblloc);
            pnit.Controls.Add(cbxloc);
            pnit.Controls.Add(cbxcat);
            pnit.Controls.Add(txtitname);
            pnit.Controls.Add(btnitcr);
            pnit.Location = new Point(-5, 0);
            pnit.Name = "pnit";
            pnit.Palette = kryptonPalettepanel;
            pnit.PaletteMode = PaletteMode.Custom;
            pnit.Size = new Size(755, 448);
            pnit.TabIndex = 13;
            // 
            // chkstock
            // 
            chkstock.Location = new Point(405, 65);
            chkstock.Name = "chkstock";
            chkstock.Size = new Size(152, 20);
            chkstock.TabIndex = 18;
            chkstock.Values.Text = "Insert Stock Import Info";
            chkstock.CheckedChanged += chkstock_CheckedChanged;
            // 
            // txtqty
            // 
            txtqty.Enabled = false;
            txtqty.Location = new Point(479, 176);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(177, 23);
            txtqty.TabIndex = 7;
            txtqty.Tag = "i_item_qty";
            txtqty.TextChanged += requiredFieldCheck;
            txtqty.Validating += requiredFieldCheck;
            // 
            // lblqty
            // 
            lblqty.Location = new Point(405, 178);
            lblqty.Name = "lblqty";
            lblqty.Palette = kryptonPalettelbl;
            lblqty.PaletteMode = PaletteMode.Custom;
            lblqty.Size = new Size(69, 21);
            lblqty.TabIndex = 17;
            lblqty.Tag = "i_item_qty";
            lblqty.Values.Text = "Quantity";
            // 
            // cbxsup
            // 
            cbxsup.CornerRoundingRadius = -1F;
            cbxsup.DropDownWidth = 177;
            cbxsup.Enabled = false;
            cbxsup.FormattingEnabled = true;
            cbxsup.IntegralHeight = false;
            cbxsup.Location = new Point(479, 124);
            cbxsup.Name = "cbxsup";
            cbxsup.Size = new Size(177, 21);
            cbxsup.TabIndex = 6;
            cbxsup.Tag = "bi_supp_id:vc_supp_desc";
            cbxsup.SelectedIndexChanged += requiredFieldCheck;
            cbxsup.Validating += requiredFieldCheck;
            // 
            // btnitsb
            // 
            btnitsb.CornerRoundingRadius = -1F;
            btnitsb.Location = new Point(562, 390);
            btnitsb.Name = "btnitsb";
            btnitsb.Palette = kryptonPalettebtn;
            btnitsb.PaletteMode = PaletteMode.Custom;
            btnitsb.Size = new Size(94, 48);
            btnitsb.TabIndex = 10;
            btnitsb.Values.Text = "Submit";
            btnitsb.Click += btnitsb_Click;
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
            // lblsup
            // 
            lblsup.Location = new Point(405, 126);
            lblsup.Name = "lblsup";
            lblsup.Palette = kryptonPalettelbl;
            lblsup.PaletteMode = PaletteMode.Custom;
            lblsup.Size = new Size(68, 21);
            lblsup.TabIndex = 14;
            lblsup.Tag = "vc_supp_desc";
            lblsup.Values.Text = "Supplier";
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(242, 390);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = PaletteMode.Custom;
            btncancel.Size = new Size(94, 48);
            btncancel.TabIndex = 8;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // cbxuom
            // 
            cbxuom.CornerRoundingRadius = -1F;
            cbxuom.DropDownWidth = 177;
            cbxuom.FormattingEnabled = true;
            cbxuom.IntegralHeight = false;
            cbxuom.Location = new Point(184, 285);
            cbxuom.Name = "cbxuom";
            cbxuom.Size = new Size(177, 21);
            cbxuom.TabIndex = 5;
            cbxuom.Tag = "i_uom_id:vc_uom_desc";
            cbxuom.SelectedIndexChanged += requiredFieldCheck;
            cbxuom.Validating += requiredFieldCheck;
            // 
            // cbxvid
            // 
            cbxvid.CornerRoundingRadius = -1F;
            cbxvid.DropDownWidth = 177;
            cbxvid.FormattingEnabled = true;
            cbxvid.IntegralHeight = false;
            cbxvid.Location = new Point(184, 231);
            cbxvid.Name = "cbxvid";
            cbxvid.Size = new Size(177, 21);
            cbxvid.TabIndex = 4;
            cbxvid.Tag = "bi_item_vid";
            cbxvid.SelectedIndexChanged += requiredFieldCheck;
            cbxvid.Validating += requiredFieldCheck;
            // 
            // cbxloc
            // 
            cbxloc.CornerRoundingRadius = -1F;
            cbxloc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxloc.DropDownWidth = 177;
            cbxloc.Enabled = false;
            cbxloc.FormattingEnabled = true;
            cbxloc.IntegralHeight = false;
            cbxloc.Location = new Point(479, 231);
            cbxloc.Name = "cbxloc";
            cbxloc.Size = new Size(177, 21);
            cbxloc.TabIndex = 3;
            cbxloc.Tag = "bi_location_id:vc_location_desc";
            cbxloc.SelectedIndexChanged += requiredFieldCheck;
            cbxloc.Validating += requiredFieldCheck;
            // 
            // cbxcat
            // 
            cbxcat.CornerRoundingRadius = -1F;
            cbxcat.DropDownWidth = 177;
            cbxcat.FormattingEnabled = true;
            cbxcat.IntegralHeight = false;
            cbxcat.Location = new Point(184, 178);
            cbxcat.Name = "cbxcat";
            cbxcat.Size = new Size(177, 21);
            cbxcat.TabIndex = 2;
            cbxcat.Tag = "bi_category_id:vc_category_desc";
            cbxcat.SelectedIndexChanged += requiredFieldCheck;
            cbxcat.Validating += requiredFieldCheck;
            // 
            // btnitcr
            // 
            btnitcr.CornerRoundingRadius = -1F;
            btnitcr.Location = new Point(405, 390);
            btnitcr.Name = "btnitcr";
            btnitcr.Palette = kryptonPalettebtn;
            btnitcr.PaletteMode = PaletteMode.Custom;
            btnitcr.Size = new Size(94, 48);
            btnitcr.TabIndex = 9;
            btnitcr.Values.Text = "Clear";
            btnitcr.Click += btnitcr_Click;
            // 
            // kryptonPalettepanel
            // 
            kryptonPalettepanel.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettepanel.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // ItemCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            Controls.Add(pnit);
            Name = "ItemCreate";
            Text = "ItemCreate";
            Load += ItemCreate_Load;
            ((System.ComponentModel.ISupportInitialize)pnit).EndInit();
            pnit.ResumeLayout(false);
            pnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsup).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxuom).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxvid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxloc).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxcat).EndInit();
            ResumeLayout(false);
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
    }
}