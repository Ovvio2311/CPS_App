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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblExpDli = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txtloc = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelItem = new System.Windows.Forms.Panel();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.lblremark = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.panelItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(50, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Request Create";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(41, 44);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(45, 15);
            this.lblStaff.TabIndex = 1;
            this.lblStaff.Text = "Staff ID";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(24, 115);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(80, 15);
            this.lblLoc.TabIndex = 2;
            this.lblLoc.Text = "Your Location";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(31, 36);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(45, 15);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Name";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(31, 118);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(53, 15);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Quantity";
            // 
            // lblExpDli
            // 
            this.lblExpDli.AutoSize = true;
            this.lblExpDli.Location = new System.Drawing.Point(31, 160);
            this.lblExpDli.Name = "lblExpDli";
            this.lblExpDli.Size = new System.Drawing.Size(127, 15);
            this.lblExpDli.TabIndex = 6;
            this.lblExpDli.Text = "Expected Delivery Date";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(133, 41);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.ReadOnly = true;
            this.txtStaff.Size = new System.Drawing.Size(121, 23);
            this.txtStaff.TabIndex = 11;
            this.txtStaff.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(186, 76);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 23);
            this.txtItemName.TabIndex = 13;
            this.txtItemName.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(186, 118);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 23);
            this.txtQty.TabIndex = 14;
            this.txtQty.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(186, 36);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(200, 23);
            this.txtItemId.TabIndex = 16;
            this.txtItemId.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(430, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(558, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(685, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
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
            this.panelInfo.TabIndex = 24;
            // 
            // txtloc
            // 
            this.txtloc.Location = new System.Drawing.Point(135, 114);
            this.txtloc.Name = "txtloc";
            this.txtloc.ReadOnly = true;
            this.txtloc.Size = new System.Drawing.Size(119, 23);
            this.txtloc.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(186, 160);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.dateTimePicker);
            this.panelItem.Controls.Add(this.lblExpDli);
            this.panelItem.Controls.Add(this.txtremark);
            this.panelItem.Controls.Add(this.lblremark);
            this.panelItem.Controls.Add(this.txtItemId);
            this.panelItem.Controls.Add(this.txtQty);
            this.panelItem.Controls.Add(this.txtItemName);
            this.panelItem.Controls.Add(this.lblQty);
            this.panelItem.Controls.Add(this.label4);
            this.panelItem.Controls.Add(this.lblItem);
            this.panelItem.Location = new System.Drawing.Point(430, 80);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(519, 278);
            this.panelItem.TabIndex = 25;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(186, 203);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(200, 23);
            this.txtremark.TabIndex = 18;
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Location = new System.Drawing.Point(31, 206);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(47, 15);
            this.lblremark.TabIndex = 17;
            this.lblremark.Text = "Remark";
            // 
            // Request_Create
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
            this.Name = "Request_Create";
            this.Text = "RequestCreate";
            this.Load += new System.EventHandler(this.RequestCreate_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblStaff;
        private Label lblLoc;
        private Label lblItem;
        private Label label4;
        private Label lblQty;
        private Label lblExpDli;
        
        private TextBox txtStaff;
        private TextBox txtItemName;
        private TextBox txtQty;
        private TextBox txtItemId;
        
        private Button btnAdd;
        private Button btnSubmit;
        private Button btnClear;
        private Panel panelInfo;
        private Panel panelItem;
        private DateTimePicker dateTimePicker;
        private TextBox txtremark;
        private Label lblremark;
        private TextBox txtloc;
    }
}