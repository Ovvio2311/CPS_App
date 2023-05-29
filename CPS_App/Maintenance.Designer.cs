using ScintillaNET;
using System.Linq.Dynamic.Core;
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
            tabPagedelisc = new TabPage();
            txtdelisc = new Krypton.Toolkit.KryptonTextBox();
            lbldelisc = new Krypton.Toolkit.KryptonLabel();
            btndelisc = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewdelisc = new Krypton.Toolkit.KryptonDataGridView();
            tabPagetpoatype = new TabPage();
            txtpoa = new Krypton.Toolkit.KryptonTextBox();
            lblpoa = new Krypton.Toolkit.KryptonLabel();
            btnpoa = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewpoa = new Krypton.Toolkit.KryptonDataGridView();
            tabPagetc = new TabPage();
            txttc = new Krypton.Toolkit.KryptonTextBox();
            lbltc = new Krypton.Toolkit.KryptonLabel();
            btntc = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewtc = new Krypton.Toolkit.KryptonDataGridView();
            tabPageuom = new TabPage();
            txtuom = new Krypton.Toolkit.KryptonTextBox();
            lbluom = new Krypton.Toolkit.KryptonLabel();
            btnuom = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewuom = new Krypton.Toolkit.KryptonDataGridView();
            tabPageloc = new TabPage();
            txtloc = new Krypton.Toolkit.KryptonTextBox();
            lblloc = new Krypton.Toolkit.KryptonLabel();
            btnloc = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewloc = new Krypton.Toolkit.KryptonDataGridView();
            tabPagepo = new TabPage();
            txtpo = new Krypton.Toolkit.KryptonTextBox();
            lblpo = new Krypton.Toolkit.KryptonLabel();
            btnpo = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewpo = new Krypton.Toolkit.KryptonDataGridView();
            tabPagesup = new TabPage();
            txtsup = new Krypton.Toolkit.KryptonTextBox();
            lblsup = new Krypton.Toolkit.KryptonLabel();
            btnsup = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewsup = new Krypton.Toolkit.KryptonDataGridView();
            tabPage2 = new TabPage();
            lbladdr = new Krypton.Toolkit.KryptonLabel();
            txtaddr = new Krypton.Toolkit.KryptonTextBox();
            multiDetailView.SuspendLayout();
            tabPageRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptodatagrid).BeginInit();
            tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewUser).BeginInit();
            tabPagedelisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewdelisc).BeginInit();
            tabPagetpoatype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).BeginInit();
            tabPagetc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewtc).BeginInit();
            tabPageuom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewuom).BeginInit();
            tabPageloc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewloc).BeginInit();
            tabPagepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpo).BeginInit();
            tabPagesup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewsup).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.CornerRoundingRadius = -1F;
            btnAdd.Location = new Point(16, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
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
            multiDetailView.Controls.Add(tabPagedelisc);
            multiDetailView.Controls.Add(tabPagetpoatype);
            multiDetailView.Controls.Add(tabPagetc);
            multiDetailView.Controls.Add(tabPageuom);
            multiDetailView.Controls.Add(tabPageloc);
            multiDetailView.Controls.Add(tabPagepo);
            multiDetailView.Controls.Add(tabPagesup);
            multiDetailView.Controls.Add(tabPage2);
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
            kryptonDataGridViewUser.ReadOnly = true;            
           
            // 
            // btnAddnewuser
            // 
            btnAddnewuser.CornerRoundingRadius = -1F;
            btnAddnewuser.Location = new Point(25, 19);
            btnAddnewuser.Name = "btnAddnewuser";
            btnAddnewuser.Size = new Size(99, 35);
            btnAddnewuser.TabIndex = 2;
            btnAddnewuser.Values.Text = "+AddNew";
            btnAddnewuser.Click += btnAddnewuser_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(70, 69);
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
            lblusername.Location = new Point(25, 69);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(39, 15);
            lblusername.Text = "Name";
            // 
            // tabPagedelisc
            // 
            tabPagedelisc.Controls.Add(txtdelisc);
            tabPagedelisc.Controls.Add(lbldelisc);
            tabPagedelisc.Controls.Add(btndelisc);
            tabPagedelisc.Controls.Add(kryptonDataGridViewdelisc);
            tabPagedelisc.Location = new Point(4, 24);
            tabPagedelisc.Name = "tabPagedelisc";
            tabPagedelisc.Padding = new Padding(3);
            tabPagedelisc.Size = new Size(789, 423);
            tabPagedelisc.TabIndex = 2;
            tabPagedelisc.Text = "Delivery Schedule";
            tabPagedelisc.UseVisualStyleBackColor = true;
            // 
            // txtdelisc
            // 
            txtdelisc.Location = new Point(197, 90);
            txtdelisc.Name = "txtdelisc";
            txtdelisc.Size = new Size(170, 23);
            txtdelisc.TabIndex = 4;
            // 
            // lbldelisc
            // 
            lbldelisc.Location = new Point(84, 93);
            lbldelisc.Name = "lbldelisc";
            lbldelisc.Size = new Size(43, 20);
            lbldelisc.TabIndex = 3;
            lbldelisc.Values.Text = "Name";
            // 
            // btndelisc
            // 
            btndelisc.CornerRoundingRadius = -1F;
            btndelisc.Location = new Point(84, 32);
            btndelisc.Name = "btndelisc";
            btndelisc.Size = new Size(93, 38);
            btndelisc.TabIndex = 2;
            btndelisc.Values.Text = "+AddNew";
            btndelisc.Click += btndelisc_Click;
            // 
            // kryptonDataGridViewdelisc
            // 
            kryptonDataGridViewdelisc.Location = new Point(84, 131);
            kryptonDataGridViewdelisc.Name = "kryptonDataGridViewdelisc";
            kryptonDataGridViewdelisc.RowTemplate.Height = 25;
            kryptonDataGridViewdelisc.Size = new Size(621, 240);
            kryptonDataGridViewdelisc.TabIndex = 1;
            // 
            // tabPagetpoatype
            // 
            tabPagetpoatype.Controls.Add(txtpoa);
            tabPagetpoatype.Controls.Add(lblpoa);
            tabPagetpoatype.Controls.Add(btnpoa);
            tabPagetpoatype.Controls.Add(kryptonDataGridViewpoa);
            tabPagetpoatype.Location = new Point(4, 24);
            tabPagetpoatype.Name = "tabPagetpoatype";
            tabPagetpoatype.Padding = new Padding(3);
            tabPagetpoatype.Size = new Size(789, 423);
            tabPagetpoatype.TabIndex = 3;
            tabPagetpoatype.Text = "POA Type";
            tabPagetpoatype.UseVisualStyleBackColor = true;
            // 
            // txtpoa
            // 
            txtpoa.Location = new Point(196, 88);
            txtpoa.Name = "txtpoa";
            txtpoa.Size = new Size(170, 23);
            txtpoa.TabIndex = 5;
            // 
            // lblpoa
            // 
            lblpoa.Location = new Point(78, 91);
            lblpoa.Name = "lblpoa";
            lblpoa.Size = new Size(43, 20);
            lblpoa.TabIndex = 4;
            lblpoa.Values.Text = "Name";
            // 
            // btnpoa
            // 
            btnpoa.CornerRoundingRadius = -1F;
            btnpoa.Location = new Point(78, 29);
            btnpoa.Name = "btnpoa";
            btnpoa.Size = new Size(93, 38);
            btnpoa.TabIndex = 3;
            btnpoa.Values.Text = "+AddNew";
            btnpoa.Click += btnpoa_Click;
            // 
            // kryptonDataGridViewpoa
            // 
            kryptonDataGridViewpoa.Location = new Point(78, 129);
            kryptonDataGridViewpoa.Name = "kryptonDataGridViewpoa";
            kryptonDataGridViewpoa.RowTemplate.Height = 25;
            kryptonDataGridViewpoa.Size = new Size(621, 240);
            kryptonDataGridViewpoa.TabIndex = 0;
            // 
            // tabPagetc
            // 
            tabPagetc.Controls.Add(txttc);
            tabPagetc.Controls.Add(lbltc);
            tabPagetc.Controls.Add(btntc);
            tabPagetc.Controls.Add(kryptonDataGridViewtc);
            tabPagetc.Location = new Point(4, 24);
            tabPagetc.Name = "tabPagetc";
            tabPagetc.Padding = new Padding(3);
            tabPagetc.Size = new Size(789, 423);
            tabPagetc.TabIndex = 4;
            tabPagetc.Text = "Terms and Conditions";
            tabPagetc.UseVisualStyleBackColor = true;
            // 
            // txttc
            // 
            txttc.Location = new Point(200, 94);
            txttc.Name = "txttc";
            txttc.Size = new Size(170, 23);
            txttc.TabIndex = 5;
            // 
            // lbltc
            // 
            lbltc.Location = new Point(89, 94);
            lbltc.Name = "lbltc";
            lbltc.Size = new Size(43, 20);
            lbltc.TabIndex = 4;
            lbltc.Values.Text = "Name";
            // 
            // btntc
            // 
            btntc.CornerRoundingRadius = -1F;
            btntc.Location = new Point(84, 26);
            btntc.Name = "btntc";
            btntc.Size = new Size(93, 38);
            btntc.TabIndex = 3;
            btntc.Values.Text = "+AddNew";
            btntc.Click += btntc_Click;
            // 
            // kryptonDataGridViewtc
            // 
            kryptonDataGridViewtc.Location = new Point(84, 139);
            kryptonDataGridViewtc.Name = "kryptonDataGridViewtc";
            kryptonDataGridViewtc.RowTemplate.Height = 25;
            kryptonDataGridViewtc.Size = new Size(621, 240);
            kryptonDataGridViewtc.TabIndex = 1;
            // 
            // tabPageuom
            // 
            tabPageuom.Controls.Add(txtuom);
            tabPageuom.Controls.Add(lbluom);
            tabPageuom.Controls.Add(btnuom);
            tabPageuom.Controls.Add(kryptonDataGridViewuom);
            tabPageuom.Location = new Point(4, 24);
            tabPageuom.Name = "tabPageuom";
            tabPageuom.Padding = new Padding(3);
            tabPageuom.Size = new Size(789, 423);
            tabPageuom.TabIndex = 5;
            tabPageuom.Text = "UOM";
            tabPageuom.UseVisualStyleBackColor = true;
            // 
            // txtuom
            // 
            txtuom.Location = new Point(207, 96);
            txtuom.Name = "txtuom";
            txtuom.Size = new Size(170, 23);
            txtuom.TabIndex = 5;
            // 
            // lbluom
            // 
            lbluom.Location = new Point(84, 99);
            lbluom.Name = "lbluom";
            lbluom.Size = new Size(43, 20);
            lbluom.TabIndex = 4;
            lbluom.Values.Text = "Name";
            // 
            // btnuom
            // 
            btnuom.CornerRoundingRadius = -1F;
            btnuom.Location = new Point(84, 32);
            btnuom.Name = "btnuom";
            btnuom.Size = new Size(93, 38);
            btnuom.TabIndex = 3;
            btnuom.Values.Text = "+AddNew";
            btnuom.Click += btnuom_Click;
            // 
            // kryptonDataGridViewuom
            // 
            kryptonDataGridViewuom.Location = new Point(84, 152);
            kryptonDataGridViewuom.Name = "kryptonDataGridViewuom";
            kryptonDataGridViewuom.RowTemplate.Height = 25;
            kryptonDataGridViewuom.Size = new Size(621, 240);
            kryptonDataGridViewuom.TabIndex = 1;
            // 
            // tabPageloc
            // 
            tabPageloc.Controls.Add(txtaddr);
            tabPageloc.Controls.Add(lbladdr);
            tabPageloc.Controls.Add(txtloc);
            tabPageloc.Controls.Add(lblloc);
            tabPageloc.Controls.Add(btnloc);
            tabPageloc.Controls.Add(kryptonDataGridViewloc);
            tabPageloc.Location = new Point(4, 24);
            tabPageloc.Name = "tabPageloc";
            tabPageloc.Padding = new Padding(3);
            tabPageloc.Size = new Size(789, 423);
            tabPageloc.TabIndex = 6;
            tabPageloc.Text = "Location";
            tabPageloc.UseVisualStyleBackColor = true;
            // 
            // txtloc
            // 
            txtloc.Location = new Point(181, 75);
            txtloc.Name = "txtloc";
            txtloc.Size = new Size(170, 23);
            txtloc.TabIndex = 5;
            // 
            // lblloc
            // 
            lblloc.Location = new Point(84, 78);
            lblloc.Name = "lblloc";
            lblloc.Size = new Size(43, 20);
            lblloc.TabIndex = 4;
            lblloc.Values.Text = "Name";
            // 
            // btnloc
            // 
            btnloc.CornerRoundingRadius = -1F;
            btnloc.Location = new Point(84, 24);
            btnloc.Name = "btnloc";
            btnloc.Size = new Size(93, 38);
            btnloc.TabIndex = 3;
            btnloc.Values.Text = "+AddNew";
            btnloc.Click += btnloc_Click;
            // 
            // kryptonDataGridViewloc
            // 
            kryptonDataGridViewloc.Location = new Point(84, 141);
            kryptonDataGridViewloc.Name = "kryptonDataGridViewloc";
            kryptonDataGridViewloc.RowTemplate.Height = 25;
            kryptonDataGridViewloc.Size = new Size(621, 240);
            kryptonDataGridViewloc.TabIndex = 1;
            // 
            // tabPagepo
            // 
            tabPagepo.Controls.Add(txtpo);
            tabPagepo.Controls.Add(lblpo);
            tabPagepo.Controls.Add(btnpo);
            tabPagepo.Controls.Add(kryptonDataGridViewpo);
            tabPagepo.Location = new Point(4, 24);
            tabPagepo.Name = "tabPagepo";
            tabPagepo.Padding = new Padding(3);
            tabPagepo.Size = new Size(789, 423);
            tabPagepo.TabIndex = 7;
            tabPagepo.Text = "PO type";
            tabPagepo.UseVisualStyleBackColor = true;
            // 
            // txtpo
            // 
            txtpo.Location = new Point(203, 93);
            txtpo.Name = "txtpo";
            txtpo.Size = new Size(170, 23);
            txtpo.TabIndex = 5;
            // 
            // lblpo
            // 
            lblpo.Location = new Point(84, 93);
            lblpo.Name = "lblpo";
            lblpo.Size = new Size(43, 20);
            lblpo.TabIndex = 4;
            lblpo.Values.Text = "Name";
            // 
            // btnpo
            // 
            btnpo.CornerRoundingRadius = -1F;
            btnpo.Location = new Point(84, 27);
            btnpo.Name = "btnpo";
            btnpo.Size = new Size(93, 38);
            btnpo.TabIndex = 3;
            btnpo.Values.Text = "+AddNew";
            btnpo.Click += btnpo_Click;
            // 
            // kryptonDataGridViewpo
            // 
            kryptonDataGridViewpo.Location = new Point(84, 145);
            kryptonDataGridViewpo.Name = "kryptonDataGridViewpo";
            kryptonDataGridViewpo.RowTemplate.Height = 25;
            kryptonDataGridViewpo.Size = new Size(621, 240);
            kryptonDataGridViewpo.TabIndex = 1;
            // 
            // tabPagesup
            // 
            tabPagesup.Controls.Add(txtsup);
            tabPagesup.Controls.Add(lblsup);
            tabPagesup.Controls.Add(btnsup);
            tabPagesup.Controls.Add(kryptonDataGridViewsup);
            tabPagesup.Location = new Point(4, 24);
            tabPagesup.Name = "tabPagesup";
            tabPagesup.Padding = new Padding(3);
            tabPagesup.Size = new Size(789, 423);
            tabPagesup.TabIndex = 8;
            tabPagesup.Text = "Supplier";
            tabPagesup.UseVisualStyleBackColor = true;
            // 
            // txtsup
            // 
            txtsup.Location = new Point(193, 80);
            txtsup.Name = "txtsup";
            txtsup.Size = new Size(170, 23);
            txtsup.TabIndex = 5;
            // 
            // lblsup
            // 
            lblsup.Location = new Point(84, 80);
            lblsup.Name = "lblsup";
            lblsup.Size = new Size(43, 20);
            lblsup.TabIndex = 4;
            lblsup.Values.Text = "Name";
            // 
            // btnsup
            // 
            btnsup.CornerRoundingRadius = -1F;
            btnsup.Location = new Point(84, 25);
            btnsup.Name = "btnsup";
            btnsup.Size = new Size(93, 38);
            btnsup.TabIndex = 3;
            btnsup.Values.Text = "+AddNew";
            btnsup.Click += btnsup_Click;
            // 
            // kryptonDataGridViewsup
            // 
            kryptonDataGridViewsup.Location = new Point(84, 117);
            kryptonDataGridViewsup.Name = "kryptonDataGridViewsup";
            kryptonDataGridViewsup.RowTemplate.Height = 25;
            kryptonDataGridViewsup.Size = new Size(621, 240);
            kryptonDataGridViewsup.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 423);
            tabPage2.TabIndex = 9;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbladdr
            // 
            lbladdr.Location = new Point(84, 115);
            lbladdr.Name = "lbladdr";
            lbladdr.Size = new Size(54, 20);
            lbladdr.TabIndex = 6;
            lbladdr.Values.Text = "Address";
            // 
            // txtaddr
            // 
            txtaddr.Location = new Point(181, 112);
            txtaddr.Name = "txtaddr";
            txtaddr.Size = new Size(170, 23);
            txtaddr.TabIndex = 7;
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
            tabPagedelisc.ResumeLayout(false);
            tabPagedelisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewdelisc).EndInit();
            tabPagetpoatype.ResumeLayout(false);
            tabPagetpoatype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).EndInit();
            tabPagetc.ResumeLayout(false);
            tabPagetc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewtc).EndInit();
            tabPageuom.ResumeLayout(false);
            tabPageuom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewuom).EndInit();
            tabPageloc.ResumeLayout(false);
            tabPageloc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewloc).EndInit();
            tabPagepo.ResumeLayout(false);
            tabPagepo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpo).EndInit();
            tabPagesup.ResumeLayout(false);
            tabPagesup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewsup).EndInit();
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
        private TabPage tabPagedelisc;
        private TabPage tabPagetpoatype;
        private TabPage tabPagetc;
        private TabPage tabPageuom;
        private TabPage tabPageloc;
        private TabPage tabPagepo;
        private TabPage tabPagesup;
        private TabPage tabPage2;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewdelisc;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewpoa;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewtc;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewuom;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewloc;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewpo;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewsup;
        private Krypton.Toolkit.KryptonButton btndelisc;
        private Krypton.Toolkit.KryptonButton btnpoa;
        private Krypton.Toolkit.KryptonTextBox txtdelisc;
        private Krypton.Toolkit.KryptonLabel lbldelisc;
        private Krypton.Toolkit.KryptonTextBox txtpoa;
        private Krypton.Toolkit.KryptonLabel lblpoa;
        private Krypton.Toolkit.KryptonTextBox txttc;
        private Krypton.Toolkit.KryptonLabel lbltc;
        private Krypton.Toolkit.KryptonButton btntc;
        private Krypton.Toolkit.KryptonTextBox txtuom;
        private Krypton.Toolkit.KryptonLabel lbluom;
        private Krypton.Toolkit.KryptonButton btnuom;
        private Krypton.Toolkit.KryptonTextBox txtloc;
        private Krypton.Toolkit.KryptonLabel lblloc;
        private Krypton.Toolkit.KryptonButton btnloc;
        private Krypton.Toolkit.KryptonTextBox txtpo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonButton btnpo;
        private Krypton.Toolkit.KryptonTextBox txtsup;
        private Krypton.Toolkit.KryptonLabel lblsup;
        private Krypton.Toolkit.KryptonButton btnsup;
        private Krypton.Toolkit.KryptonLabel lblpo;
        private Krypton.Toolkit.KryptonTextBox txtaddr;
        private Krypton.Toolkit.KryptonLabel lbladdr;
    }
}