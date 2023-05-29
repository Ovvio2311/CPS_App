using System.Windows.Forms;

namespace CPS_App
{
    partial class Maintenance
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
            kryptonDockingManager1 = new Krypton.Docking.KryptonDockingManager();
            btnAdd = new Krypton.Toolkit.KryptonButton();
            lblrole = new Krypton.Toolkit.KryptonLabel();
            txtrole = new Krypton.Toolkit.KryptonTextBox();
            multiDetailView = new Krypton.Toolkit.Suite.Extended.DataGridView.MultiDetailView();
            tabPageRole = new TabPage();
            kryptodatagrid = new Krypton.Toolkit.KryptonDataGridView();
            tabPageUser = new TabPage();
            kryptonDataGridViewUser = new Krypton.Toolkit.KryptonDataGridView();
            btnAddnewuser = new Krypton.Toolkit.KryptonButton();
            txtusername = new Krypton.Toolkit.KryptonTextBox();
            lblusername = new Krypton.Toolkit.KryptonWrapLabel();
            multiDetailView.SuspendLayout();
            tabPageRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptodatagrid).BeginInit();
            tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.CornerRoundingRadius = -1F;
            btnAdd.Location = new Point(16, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 25);
            btnAdd.TabIndex = 3;
            btnAdd.Values.Text = "+AddNew";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblrole
            // 
            lblrole.Location = new Point(16, 86);
            lblrole.Name = "lblrole";
            lblrole.Size = new Size(35, 20);
            lblrole.TabIndex = 5;
            lblrole.Values.Text = "Role";
            
            // 
            // txtrole
            // 
            txtrole.Location = new Point(57, 83);
            txtrole.Name = "txtrole";
            txtrole.Size = new Size(100, 23);
            txtrole.TabIndex = 6;
            // 
            // multiDetailView
            // 
            multiDetailView.Controls.Add(tabPageRole);
            multiDetailView.Controls.Add(tabPageUser);
            multiDetailView.Location = new Point(1, 1);
            multiDetailView.Name = "multiDetailView";
            multiDetailView.SelectedIndex = 0;
            multiDetailView.Size = new Size(797, 451);
            multiDetailView.TabIndex = 7;
            multiDetailView.Tag = "Role";
            multiDetailView.Visible = false;
            // 
            // tabPageRole
            // 
            tabPageRole.Controls.Add(kryptodatagrid);
            tabPageRole.Controls.Add(btnAdd);
            tabPageRole.Controls.Add(lblrole);
            tabPageRole.Controls.Add(txtrole);
            tabPageRole.Location = new Point(4, 24);
            tabPageRole.Name = "tabPageRole";
            tabPageRole.Padding = new Padding(3);
            tabPageRole.Size = new Size(789, 423);
            tabPageRole.TabIndex = 0;
            tabPageRole.Text = "Role";
            tabPageRole.UseVisualStyleBackColor = true;
            // 
            // kryptodatagrid
            // 
            kryptodatagrid.Location = new Point(3, 133);
            kryptodatagrid.Name = "kryptodatagrid";
            kryptodatagrid.RowTemplate.Height = 25;
            kryptodatagrid.Size = new Size(715, 186);
            kryptodatagrid.TabIndex = 3;
            // 
            // tabPageUser
            // 
            tabPageUser.Controls.Add(kryptonDataGridViewUser);
            tabPageUser.Controls.Add(btnAddnewuser);
            tabPageUser.Controls.Add(txtusername);
            tabPageUser.Controls.Add(lblusername);
            tabPageUser.Location = new Point(4, 24);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(789, 423);
            tabPageUser.TabIndex = 1;
            tabPageUser.Text = "User";
            tabPageUser.UseVisualStyleBackColor = true;
            
            // 
            // kryptonDataGridViewUser
            // 
            kryptonDataGridViewUser.Location = new Point(25, 112);
            kryptonDataGridViewUser.Name = "kryptonDataGridViewUser";
            kryptonDataGridViewUser.RowTemplate.Height = 25;
            kryptonDataGridViewUser.Size = new Size(694, 150);
            kryptonDataGridViewUser.TabIndex = 3;
            // 
            // btnAddnewuser
            // 
            btnAddnewuser.CornerRoundingRadius = -1F;
            btnAddnewuser.Location = new Point(25, 19);
            btnAddnewuser.Name = "btnAddnewuser";
            btnAddnewuser.Size = new Size(90, 25);
            btnAddnewuser.TabIndex = 2;
            btnAddnewuser.Values.Text = "+AddNew";
            btnAddnewuser.Click += btnAddnewuser_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(70, 56);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(100, 23);
            txtusername.TabIndex = 1;
            txtusername.Text = "Name";
            // 
            // lblusername
            // 
            lblusername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblusername.ForeColor = Color.FromArgb(30, 57, 91);
            lblusername.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            lblusername.Location = new Point(25, 56);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(39, 15);
            lblusername.Text = "Name";
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(multiDetailView);
            Name = "Maintenance";
            Text = "Maintenance";
            Load += Maintenance_Load;
            multiDetailView.ResumeLayout(false);
            tabPageRole.ResumeLayout(false);
            tabPageRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptodatagrid).EndInit();
            tabPageUser.ResumeLayout(false);
            tabPageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonLabel lblrole;
        private Krypton.Toolkit.KryptonTextBox txtrole;
        private Krypton.Toolkit.Suite.Extended.DataGridView.MultiDetailView multiDetailView;
        private TabPage tabPageRole;
        private Krypton.Toolkit.KryptonDataGridView kryptodatagrid;
        private TabPage tabPageUser;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewUser;
        private Krypton.Toolkit.KryptonButton btnAddnewuser;
        private Krypton.Toolkit.KryptonTextBox txtusername;
        private Krypton.Toolkit.KryptonWrapLabel lblusername;
    }
}