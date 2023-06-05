namespace CPS_App
{
    partial class Register
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
            this.Uname = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.re_pw = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePw = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.GroupType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.errorProviderClick = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBasic = new System.Windows.Forms.Panel();
            this.txtstaffname = new System.Windows.Forms.TextBox();
            this.lblstaffname = new System.Windows.Forms.Label();
            this.txtStaffRole = new System.Windows.Forms.TextBox();
            this.lblStaffRole = new System.Windows.Forms.Label();
            this.locDesc = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClick)).BeginInit();
            this.grpBasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Location = new System.Drawing.Point(41, 24);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(62, 15);
            this.Uname.TabIndex = 0;
            this.Uname.Text = "UserName";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(41, 67);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(57, 15);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // re_pw
            // 
            this.re_pw.AutoSize = true;
            this.re_pw.Location = new System.Drawing.Point(41, 107);
            this.re_pw.Name = "re_pw";
            this.re_pw.Size = new System.Drawing.Size(105, 15);
            this.re_pw.TabIndex = 2;
            this.re_pw.Text = "Re-enter Password";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(41, 150);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(30, 15);
            this.type.TabIndex = 3;
            this.type.Text = "Role";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 23);
            this.txtName.TabIndex = 4;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtRePw
            // 
            this.txtRePw.Location = new System.Drawing.Point(187, 99);
            this.txtRePw.Name = "txtRePw";
            this.txtRePw.Size = new System.Drawing.Size(216, 23);
            this.txtRePw.TabIndex = 6;
            this.txtRePw.UseSystemPasswordChar = true;
            this.txtRePw.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(316, 458);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(97, 47);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // clear
            // 
            this.clear.CausesValidation = false;
            this.clear.Location = new System.Drawing.Point(124, 458);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(109, 47);
            this.clear.TabIndex = 9;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // GroupType
            // 
            this.GroupType.FormattingEnabled = true;
            this.GroupType.Location = new System.Drawing.Point(187, 142);
            this.GroupType.Name = "GroupType";
            this.GroupType.Size = new System.Drawing.Size(216, 23);
            this.GroupType.TabIndex = 10;
            this.GroupType.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(187, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 23);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(41, 196);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 12;
            this.Email.Text = "Email";
            // 
            // errorProviderClick
            // 
            this.errorProviderClick.ContainerControl = this;
            // 
            // grpBasic
            // 
            this.grpBasic.Controls.Add(this.txtstaffname);
            this.grpBasic.Controls.Add(this.lblstaffname);
            this.grpBasic.Controls.Add(this.txtStaffRole);
            this.grpBasic.Controls.Add(this.lblStaffRole);
            this.grpBasic.Controls.Add(this.locDesc);
            this.grpBasic.Controls.Add(this.lblLocation);
            this.grpBasic.Controls.Add(this.txtEmpID);
            this.grpBasic.Controls.Add(this.lblEmpID);
            this.grpBasic.Controls.Add(this.Email);
            this.grpBasic.Controls.Add(this.txtEmail);
            this.grpBasic.Controls.Add(this.GroupType);
            this.grpBasic.Controls.Add(this.txtRePw);
            this.grpBasic.Controls.Add(this.txtPassword);
            this.grpBasic.Controls.Add(this.txtName);
            this.grpBasic.Controls.Add(this.type);
            this.grpBasic.Controls.Add(this.re_pw);
            this.grpBasic.Controls.Add(this.password);
            this.grpBasic.Controls.Add(this.Uname);
            this.grpBasic.Location = new System.Drawing.Point(48, 26);
            this.grpBasic.Name = "grpBasic";
            this.grpBasic.Size = new System.Drawing.Size(441, 403);
            this.grpBasic.TabIndex = 19;
            // 
            // txtstaffname
            // 
            this.txtstaffname.Location = new System.Drawing.Point(186, 363);
            this.txtstaffname.Name = "txtstaffname";
            this.txtstaffname.Size = new System.Drawing.Size(217, 23);
            this.txtstaffname.TabIndex = 20;
            this.txtstaffname.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // lblstaffname
            // 
            this.lblstaffname.AutoSize = true;
            this.lblstaffname.Location = new System.Drawing.Point(41, 366);
            this.lblstaffname.Name = "lblstaffname";
            this.lblstaffname.Size = new System.Drawing.Size(66, 15);
            this.lblstaffname.TabIndex = 19;
            this.lblstaffname.Text = "Staff Name";
            // 
            // txtStaffRole
            // 
            this.txtStaffRole.Location = new System.Drawing.Point(187, 279);
            this.txtStaffRole.Name = "txtStaffRole";
            this.txtStaffRole.Size = new System.Drawing.Size(217, 23);
            this.txtStaffRole.TabIndex = 16;
            this.txtStaffRole.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // lblStaffRole
            // 
            this.lblStaffRole.AutoSize = true;
            this.lblStaffRole.Location = new System.Drawing.Point(41, 282);
            this.lblStaffRole.Name = "lblStaffRole";
            this.lblStaffRole.Size = new System.Drawing.Size(57, 15);
            this.lblStaffRole.TabIndex = 15;
            this.lblStaffRole.Text = "Staff Role";
            // 
            // locDesc
            // 
            this.locDesc.FormattingEnabled = true;
            this.locDesc.Location = new System.Drawing.Point(188, 319);
            this.locDesc.Name = "locDesc";
            this.locDesc.Size = new System.Drawing.Size(216, 23);
            this.locDesc.TabIndex = 18;
            this.locDesc.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(41, 319);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(53, 15);
            this.lblLocation.TabIndex = 17;
            this.lblLocation.Text = "Location";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(187, 233);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(216, 23);
            this.txtEmpID.TabIndex = 14;
            this.txtEmpID.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(41, 241);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(73, 15);
            this.lblEmpID.TabIndex = 13;
            this.lblEmpID.Text = "Employee ID";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(521, 561);
            this.Controls.Add(this.grpBasic);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.submit);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClick)).EndInit();
            this.grpBasic.ResumeLayout(false);
            this.grpBasic.PerformLayout();
            this.ResumeLayout(false);

        }
        
        #endregion

        private Label Uname;
        private Label password;
        private Label re_pw;
        private Label type;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtRePw;
        private Button submit;
        private Button clear;
        private ComboBox GroupType;
        private Label Email;
        private TextBox txtEmail;
        private ErrorProvider errorProviderClick;
        private Panel grpBasic;
        private Label lblLocation;
        private TextBox txtEmpID;
        private Label lblEmpID;
        private ComboBox locDesc;
        private TextBox txtStaffRole;
        private Label lblStaffRole;
        private TextBox txtstaffname;
        private Label lblstaffname;
    }
}