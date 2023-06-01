using Krypton.Toolkit;

namespace CPS_App
{
    partial class RequestCreate
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
            lblTitle = new KryptonLabel();
            lblStaff = new KryptonLabel();
            kryptonPalettelbl = new KryptonPalette(components);
            lblLoc = new KryptonLabel();
            label4 = new KryptonLabel();
            lblQty = new KryptonLabel();
            lblExpDli = new KryptonLabel();
            txtStaff = new KryptonTextBox();
            kryptonPalettereadonly = new KryptonPalette(components);
            txtQty = new KryptonTextBox();
            btnAdd = new KryptonButton();
            kryptonPalettebtn = new KryptonPalette(components);
            btnSubmit = new KryptonButton();
            btnClear = new KryptonButton();
            panelInfo = new KryptonPanel();
            txtloc = new KryptonTextBox();
            dateTimePicker = new DateTimePicker();
            panelItem = new KryptonPanel();
            cbxname = new KryptonComboBox();
            txtremark = new KryptonTextBox();
            lblremark = new KryptonLabel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)panelInfo).BeginInit();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelItem).BeginInit();
            panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxname).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(50, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(93, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "Request Create";
            // 
            // lblStaff
            // 
            lblStaff.Location = new Point(41, 44);
            lblStaff.Name = "lblStaff";
            lblStaff.Palette = kryptonPalettelbl;
            lblStaff.PaletteMode = PaletteMode.Custom;
            lblStaff.Size = new Size(63, 21);
            lblStaff.TabIndex = 1;
            lblStaff.Values.Text = "Staff ID";
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // lblLoc
            // 
            lblLoc.Location = new Point(24, 115);
            lblLoc.Name = "lblLoc";
            lblLoc.Palette = kryptonPalettelbl;
            lblLoc.PaletteMode = PaletteMode.Custom;
            lblLoc.Size = new Size(107, 21);
            lblLoc.TabIndex = 2;
            lblLoc.Values.Text = "Your Location";
            // 
            // label4
            // 
            label4.Location = new Point(24, 46);
            label4.Name = "label4";
            label4.Palette = kryptonPalettelbl;
            label4.PaletteMode = PaletteMode.Custom;
            label4.Size = new Size(87, 21);
            label4.TabIndex = 4;
            label4.Values.Text = "Item Name";
            // 
            // lblQty
            // 
            lblQty.Location = new Point(24, 85);
            lblQty.Name = "lblQty";
            lblQty.Palette = kryptonPalettelbl;
            lblQty.PaletteMode = PaletteMode.Custom;
            lblQty.Size = new Size(69, 21);
            lblQty.TabIndex = 5;
            lblQty.Values.Text = "Quantity";
            // 
            // lblExpDli
            // 
            lblExpDli.Location = new Point(24, 127);
            lblExpDli.Name = "lblExpDli";
            lblExpDli.Palette = kryptonPalettelbl;
            lblExpDli.PaletteMode = PaletteMode.Custom;
            lblExpDli.Size = new Size(173, 21);
            lblExpDli.TabIndex = 6;
            lblExpDli.Values.Text = "Expected Delivery Date";
            // 
            // txtStaff
            // 
            txtStaff.Location = new Point(133, 41);
            txtStaff.Name = "txtStaff";
            txtStaff.Palette = kryptonPalettereadonly;
            txtStaff.PaletteMode = PaletteMode.Custom;
            txtStaff.ReadOnly = true;
            txtStaff.Size = new Size(121, 23);
            txtStaff.TabIndex = 11;
            txtStaff.Validating += requiredFieldCheck;
            // 
            // kryptonPalettereadonly
            // 
            kryptonPalettereadonly.Common.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonPalettereadonly.Common.StateCommon.Back.Color2 = SystemColors.Control;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(201, 85);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(200, 23);
            txtQty.TabIndex = 14;
            txtQty.Validating += requiredFieldCheck;
            // 
            // btnAdd
            // 
            btnAdd.CornerRoundingRadius = -1F;
            btnAdd.Location = new Point(430, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Palette = kryptonPalettebtn;
            btnAdd.PaletteMode = PaletteMode.Custom;
            btnAdd.Size = new Size(97, 39);
            btnAdd.TabIndex = 21;
            btnAdd.Values.Text = "Add Item";
            btnAdd.Click += btnAdd_Click;
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
            // btnSubmit
            // 
            btnSubmit.CornerRoundingRadius = -1F;
            btnSubmit.Location = new Point(554, 383);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Palette = kryptonPalettebtn;
            btnSubmit.PaletteMode = PaletteMode.Custom;
            btnSubmit.Size = new Size(102, 39);
            btnSubmit.TabIndex = 22;
            btnSubmit.Values.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.CornerRoundingRadius = -1F;
            btnClear.Location = new Point(679, 383);
            btnClear.Name = "btnClear";
            btnClear.Palette = kryptonPalettebtn;
            btnClear.PaletteMode = PaletteMode.Custom;
            btnClear.Size = new Size(102, 39);
            btnClear.TabIndex = 23;
            btnClear.Values.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(txtloc);
            panelInfo.Controls.Add(lblStaff);
            panelInfo.Controls.Add(txtStaff);
            panelInfo.Controls.Add(lblLoc);
            panelInfo.Location = new Point(26, 80);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(352, 232);
            panelInfo.StateCommon.Color1 = Color.Transparent;
            panelInfo.StateCommon.Color2 = Color.Transparent;
            panelInfo.TabIndex = 24;
            // 
            // txtloc
            // 
            txtloc.Location = new Point(135, 114);
            txtloc.Name = "txtloc";
            txtloc.Palette = kryptonPalettereadonly;
            txtloc.PaletteMode = PaletteMode.Custom;
            txtloc.ReadOnly = true;
            txtloc.Size = new Size(119, 23);
            txtloc.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(201, 127);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 12;
            dateTimePicker.Validating += requiredFieldCheck;
            // 
            // panelItem
            // 
            panelItem.Controls.Add(cbxname);
            panelItem.Controls.Add(dateTimePicker);
            panelItem.Controls.Add(lblExpDli);
            panelItem.Controls.Add(txtremark);
            panelItem.Controls.Add(lblremark);
            panelItem.Controls.Add(txtQty);
            panelItem.Controls.Add(lblQty);
            panelItem.Controls.Add(label4);
            panelItem.Location = new Point(430, 80);
            panelItem.Name = "panelItem";
            panelItem.Size = new Size(519, 278);
            panelItem.StateCommon.Color1 = Color.Transparent;
            panelItem.StateCommon.Color2 = Color.Transparent;
            panelItem.TabIndex = 25;
            panelItem.Paint += panelItem_Paint;
            // 
            // cbxname
            // 
            cbxname.CornerRoundingRadius = -1F;
            cbxname.DropDownWidth = 200;
            cbxname.IntegralHeight = false;
            cbxname.Location = new Point(201, 41);
            cbxname.Name = "cbxname";
            cbxname.Size = new Size(200, 21);
            cbxname.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cbxname.TabIndex = 19;
            // 
            // txtremark
            // 
            txtremark.Location = new Point(201, 170);
            txtremark.Name = "txtremark";
            txtremark.Size = new Size(200, 23);
            txtremark.TabIndex = 18;
            // 
            // lblremark
            // 
            lblremark.Location = new Point(24, 173);
            lblremark.Name = "lblremark";
            lblremark.Palette = kryptonPalettelbl;
            lblremark.PaletteMode = PaletteMode.Custom;
            lblremark.Size = new Size(66, 21);
            lblremark.TabIndex = 17;
            lblremark.Values.Text = "Remark";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // RequestCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 571);
            Controls.Add(panelItem);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(btnAdd);
            Controls.Add(lblTitle);
            Controls.Add(panelInfo);
            Name = "RequestCreate";
            Text = "RequestCreate";
            Load += RequestCreate_Load;
            ((System.ComponentModel.ISupportInitialize)panelInfo).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelItem).EndInit();
            panelItem.ResumeLayout(false);
            panelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxname).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonLabel lblTitle;
        private KryptonLabel lblStaff;
        private KryptonLabel lblLoc;
        private KryptonLabel label4;
        private KryptonLabel lblQty;
        private KryptonLabel lblExpDli;

        private KryptonTextBox txtStaff;
        private KryptonTextBox txtQty;

        private KryptonButton btnAdd;
        private KryptonButton btnSubmit;
        private KryptonButton btnClear;
        private KryptonPanel panelInfo;
        private KryptonPanel panelItem;
        private DateTimePicker dateTimePicker;
        private KryptonTextBox txtremark;
        private KryptonLabel lblremark;
        private KryptonTextBox txtloc;
        private KryptonPalette kryptonPalettebtn;
        private KryptonPalette kryptonPalettelbl;
        private KryptonPalette kryptonPalettereadonly;
        private ContextMenuStrip contextMenuStrip1;
        private KryptonComboBox cbxname;
    }
}