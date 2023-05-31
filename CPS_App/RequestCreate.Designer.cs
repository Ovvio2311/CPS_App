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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.lblStaff = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblLoc = new Krypton.Toolkit.KryptonLabel();
            this.label4 = new Krypton.Toolkit.KryptonLabel();
            this.lblQty = new Krypton.Toolkit.KryptonLabel();
            this.lblExpDli = new Krypton.Toolkit.KryptonLabel();
            this.txtStaff = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(this.components);
            this.txtQty = new Krypton.Toolkit.KryptonTextBox();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btnSubmit = new Krypton.Toolkit.KryptonButton();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.panelInfo = new Krypton.Toolkit.KryptonPanel();
            this.txtloc = new Krypton.Toolkit.KryptonTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelItem = new Krypton.Toolkit.KryptonPanel();
            this.txtremark = new Krypton.Toolkit.KryptonTextBox();
            this.lblremark = new Krypton.Toolkit.KryptonLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbxname = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelItem)).BeginInit();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxname)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(50, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Values.Text = "Request Create";
            // 
            // lblStaff
            // 
            this.lblStaff.Location = new System.Drawing.Point(41, 44);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Palette = this.kryptonPalette1;
            this.lblStaff.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblStaff.Size = new System.Drawing.Size(63, 21);
            this.lblStaff.TabIndex = 1;
            this.lblStaff.Values.Text = "Staff ID";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblLoc
            // 
            this.lblLoc.Location = new System.Drawing.Point(24, 115);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Palette = this.kryptonPalette1;
            this.lblLoc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblLoc.Size = new System.Drawing.Size(107, 21);
            this.lblLoc.TabIndex = 2;
            this.lblLoc.Values.Text = "Your Location";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 46);
            this.label4.Name = "label4";
            this.label4.Palette = this.kryptonPalette1;
            this.label4.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 4;
            this.label4.Values.Text = "Item Name";
            // 
            // lblQty
            // 
            this.lblQty.Location = new System.Drawing.Point(24, 85);
            this.lblQty.Name = "lblQty";
            this.lblQty.Palette = this.kryptonPalette1;
            this.lblQty.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblQty.Size = new System.Drawing.Size(69, 21);
            this.lblQty.TabIndex = 5;
            this.lblQty.Values.Text = "Quantity";
            // 
            // lblExpDli
            // 
            this.lblExpDli.Location = new System.Drawing.Point(24, 127);
            this.lblExpDli.Name = "lblExpDli";
            this.lblExpDli.Palette = this.kryptonPalette1;
            this.lblExpDli.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblExpDli.Size = new System.Drawing.Size(173, 21);
            this.lblExpDli.TabIndex = 6;
            this.lblExpDli.Values.Text = "Expected Delivery Date";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(133, 41);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Palette = this.kryptonPalettereadonly;
            this.txtStaff.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtStaff.ReadOnly = true;
            this.txtStaff.Size = new System.Drawing.Size(121, 23);
            this.txtStaff.TabIndex = 11;
            this.txtStaff.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // kryptonPalettereadonly
            // 
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color2 = System.Drawing.SystemColors.Control;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(201, 85);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 23);
            this.txtQty.TabIndex = 14;
            this.txtQty.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // btnAdd
            // 
            this.btnAdd.CornerRoundingRadius = -1F;
            this.btnAdd.Location = new System.Drawing.Point(430, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Palette = this.kryptonPalettebtn;
            this.btnAdd.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnAdd.Size = new System.Drawing.Size(97, 39);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Values.Text = "Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // btnSubmit
            // 
            this.btnSubmit.CornerRoundingRadius = -1F;
            this.btnSubmit.Location = new System.Drawing.Point(554, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Palette = this.kryptonPalettebtn;
            this.btnSubmit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnSubmit.Size = new System.Drawing.Size(102, 39);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.CornerRoundingRadius = -1F;
            this.btnClear.Location = new System.Drawing.Point(679, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Palette = this.kryptonPalettebtn;
            this.btnClear.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnClear.Size = new System.Drawing.Size(102, 39);
            this.btnClear.TabIndex = 23;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.txtloc);
            this.panelInfo.Controls.Add(this.lblStaff);
            this.panelInfo.Controls.Add(this.txtStaff);
            this.panelInfo.Controls.Add(this.lblLoc);
            this.panelInfo.Location = new System.Drawing.Point(26, 80);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(352, 232);
            this.panelInfo.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelInfo.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelInfo.TabIndex = 24;
            // 
            // txtloc
            // 
            this.txtloc.Location = new System.Drawing.Point(135, 114);
            this.txtloc.Name = "txtloc";
            this.txtloc.Palette = this.kryptonPalettereadonly;
            this.txtloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtloc.ReadOnly = true;
            this.txtloc.Size = new System.Drawing.Size(119, 23);
            this.txtloc.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(201, 127);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.cbxname);
            this.panelItem.Controls.Add(this.dateTimePicker);
            this.panelItem.Controls.Add(this.lblExpDli);
            this.panelItem.Controls.Add(this.txtremark);
            this.panelItem.Controls.Add(this.lblremark);
            this.panelItem.Controls.Add(this.txtQty);
            this.panelItem.Controls.Add(this.lblQty);
            this.panelItem.Controls.Add(this.label4);
            this.panelItem.Location = new System.Drawing.Point(430, 80);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(519, 278);
            this.panelItem.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelItem.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelItem.TabIndex = 25;
            this.panelItem.Paint += new System.Windows.Forms.PaintEventHandler(this.panelItem_Paint);
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(201, 170);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(200, 23);
            this.txtremark.TabIndex = 18;
            // 
            // lblremark
            // 
            this.lblremark.Location = new System.Drawing.Point(24, 173);
            this.lblremark.Name = "lblremark";
            this.lblremark.Palette = this.kryptonPalette1;
            this.lblremark.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblremark.Size = new System.Drawing.Size(66, 21);
            this.lblremark.TabIndex = 17;
            this.lblremark.Values.Text = "Remark";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbxname
            // 
            this.cbxname.CornerRoundingRadius = -1F;
            this.cbxname.DropDownWidth = 200;
            this.cbxname.IntegralHeight = false;
            this.cbxname.Location = new System.Drawing.Point(201, 41);
            this.cbxname.Name = "cbxname";
            this.cbxname.Size = new System.Drawing.Size(200, 21);
            this.cbxname.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxname.TabIndex = 19;
            // 
            // RequestCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 571);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelInfo);
            this.Name = "RequestCreate";
            this.Text = "RequestCreate";
            this.Load += new System.EventHandler(this.RequestCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelItem)).EndInit();
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Krypton.Toolkit.KryptonPalette kryptonPalettebtn;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private KryptonPalette kryptonPalettereadonly;
        private ContextMenuStrip contextMenuStrip1;
        private KryptonComboBox cbxname;
    }
}