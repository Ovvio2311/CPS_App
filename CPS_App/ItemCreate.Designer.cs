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
            lblqty = new KryptonLabel();
            txtqty = new KryptonTextBox();
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
            txtitname.TabIndex = 2;
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
            lblcat.Values.Text = "Category";
            // 
            // lblloc
            // 
            lblloc.Location = new Point(67, 231);
            lblloc.Name = "lblloc";
            lblloc.Palette = kryptonPalettelbl;
            lblloc.PaletteMode = PaletteMode.Custom;
            lblloc.Size = new Size(70, 21);
            lblloc.TabIndex = 6;
            lblloc.Values.Text = "Location";
            // 
            // lblvid
            // 
            lblvid.Location = new Point(83, 280);
            lblvid.Name = "lblvid";
            lblvid.Palette = kryptonPalettelbl;
            lblvid.PaletteMode = PaletteMode.Custom;
            lblvid.Size = new Size(37, 21);
            lblvid.TabIndex = 7;
            lblvid.Values.Text = "VID";
            // 
            // lbluom
            // 
            lbluom.Location = new Point(3, 322);
            lbluom.Name = "lbluom";
            lbluom.Palette = kryptonPalettelbl;
            lbluom.PaletteMode = PaletteMode.Custom;
            lbluom.Size = new Size(155, 21);
            lbluom.TabIndex = 8;
            lbluom.Values.Text = "Unit of Measurement";
            // 
            // pnit
            // 
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
            // cbxsup
            // 
            cbxsup.CornerRoundingRadius = -1F;
            cbxsup.DropDownWidth = 177;
            cbxsup.FormattingEnabled = true;
            cbxsup.IntegralHeight = false;
            cbxsup.Location = new Point(479, 124);
            cbxsup.Name = "cbxsup";
            cbxsup.Size = new Size(177, 21);
            cbxsup.TabIndex = 15;
            // 
            // btnitsb
            // 
            btnitsb.CornerRoundingRadius = -1F;
            btnitsb.Location = new Point(491, 390);
            btnitsb.Name = "btnitsb";
            btnitsb.Palette = kryptonPalettebtn;
            btnitsb.PaletteMode = PaletteMode.Custom;
            btnitsb.Size = new Size(94, 48);
            btnitsb.TabIndex = 1;
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
            lblsup.Values.Text = "Supplier";
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(184, 390);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = PaletteMode.Custom;
            btncancel.Size = new Size(94, 48);
            btncancel.TabIndex = 16;
            btncancel.Values.Text = "Cancel";
            // 
            // cbxuom
            // 
            cbxuom.CornerRoundingRadius = -1F;
            cbxuom.DropDownWidth = 177;
            cbxuom.FormattingEnabled = true;
            cbxuom.IntegralHeight = false;
            cbxuom.Location = new Point(184, 322);
            cbxuom.Name = "cbxuom";
            cbxuom.Size = new Size(177, 21);
            cbxuom.TabIndex = 5;
            // 
            // cbxvid
            // 
            cbxvid.CornerRoundingRadius = -1F;
            cbxvid.DropDownWidth = 177;
            cbxvid.FormattingEnabled = true;
            cbxvid.IntegralHeight = false;
            cbxvid.Location = new Point(184, 280);
            cbxvid.Name = "cbxvid";
            cbxvid.Size = new Size(177, 21);
            cbxvid.TabIndex = 4;
            // 
            // cbxloc
            // 
            cbxloc.CornerRoundingRadius = -1F;
            cbxloc.DropDownWidth = 177;
            cbxloc.FormattingEnabled = true;
            cbxloc.IntegralHeight = false;
            cbxloc.Location = new Point(184, 231);
            cbxloc.Name = "cbxloc";
            cbxloc.Size = new Size(177, 21);
            cbxloc.TabIndex = 3;
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
            // 
            // btnitcr
            // 
            btnitcr.CornerRoundingRadius = -1F;
            btnitcr.Location = new Point(338, 390);
            btnitcr.Name = "btnitcr";
            btnitcr.Palette = kryptonPalettebtn;
            btnitcr.PaletteMode = PaletteMode.Custom;
            btnitcr.Size = new Size(94, 48);
            btnitcr.TabIndex = 0;
            btnitcr.Values.Text = "Clear";
            // 
            // kryptonPalettepanel
            // 
            kryptonPalettepanel.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettepanel.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // lblqty
            // 
            lblqty.Location = new Point(405, 178);
            lblqty.Name = "lblqty";
            lblqty.Palette = kryptonPalettelbl;
            lblqty.PaletteMode = PaletteMode.Custom;
            lblqty.Size = new Size(69, 21);
            lblqty.TabIndex = 17;
            lblqty.Values.Text = "Quantity";
            // 
            // txtqty
            // 
            txtqty.Location = new Point(479, 176);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(177, 23);
            txtqty.TabIndex = 18;
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
    }
}