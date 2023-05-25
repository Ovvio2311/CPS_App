using System.ComponentModel;
using System.Windows.Forms;

namespace CPS_App
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.reqMenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.roleManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReq = new Krypton.Toolkit.KryptonDropButton();
            this.btnItem = new Krypton.Toolkit.KryptonDropButton();
            this.btnsetting = new Krypton.Toolkit.KryptonDropButton();
            this.btnpoa = new Krypton.Toolkit.KryptonDropButton();
            this.POAMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reqMenustrip.SuspendLayout();
            this.itemMenuStrip.SuspendLayout();
            this.settingMenuStrip.SuspendLayout();
            this.POAMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reqMenustrip
            // 
            this.reqMenustrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reqMenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1});
            this.reqMenustrip.Name = "reqMenustrip";
            this.reqMenustrip.Size = new System.Drawing.Size(109, 26);
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // itemMenuStrip
            // 
            this.itemMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem2});
            this.itemMenuStrip.Name = "contextMenuStrip1";
            this.itemMenuStrip.Size = new System.Drawing.Size(109, 26);
            // 
            // createToolStripMenuItem2
            // 
            this.createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            this.createToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem2.Text = "Create";
            this.createToolStripMenuItem2.Click += new System.EventHandler(this.createToolStripMenuItem2_Click);
            // 
            // settingMenuStrip
            // 
            this.settingMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleManagementToolStripMenuItem1,
            this.userManagementToolStripMenuItem});
            this.settingMenuStrip.Name = "settingMenuStrip";
            this.settingMenuStrip.Size = new System.Drawing.Size(172, 48);
            // 
            // roleManagementToolStripMenuItem1
            // 
            this.roleManagementToolStripMenuItem1.Name = "roleManagementToolStripMenuItem1";
            this.roleManagementToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.roleManagementToolStripMenuItem1.Text = "Role Management";
            this.roleManagementToolStripMenuItem1.Click += new System.EventHandler(this.roleManagementToolStripMenuItem1_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // btnReq
            // 
            this.btnReq.ContextMenuStrip = this.reqMenustrip;
            this.btnReq.Location = new System.Drawing.Point(-1, 63);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(202, 71);
            this.btnReq.TabIndex = 19;
            this.btnReq.Values.Text = "Request Manage";
            this.btnReq.Click += new System.EventHandler(this.btnReq_Click);
            // 
            // btnItem
            // 
            this.btnItem.ContextMenuStrip = this.itemMenuStrip;
            this.btnItem.Location = new System.Drawing.Point(-1, 140);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(202, 67);
            this.btnItem.TabIndex = 20;
            this.btnItem.Values.Text = "Item Manage";
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.ContextMenuStrip = this.settingMenuStrip;
            this.btnsetting.Location = new System.Drawing.Point(-1, 290);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(202, 73);
            this.btnsetting.TabIndex = 21;
            this.btnsetting.Values.Text = "Setting";
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btnpoa
            // 
            this.btnpoa.ContextMenuStrip = this.POAMenuStrip;
            this.btnpoa.Location = new System.Drawing.Point(-1, 213);
            this.btnpoa.Name = "btnpoa";
            this.btnpoa.Size = new System.Drawing.Size(202, 71);
            this.btnpoa.TabIndex = 23;
            this.btnpoa.Values.Text = "POA Manage";
            this.btnpoa.Click += new System.EventHandler(this.btnpoa_Click);
            // 
            // POAMenuStrip
            // 
            this.POAMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.POAMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.POAMenuStrip.Name = "POAMenuStrip";
            this.POAMenuStrip.Size = new System.Drawing.Size(109, 26);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 589);
            this.Controls.Add(this.btnpoa);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnReq);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.Text = "Dashboard";
            this.reqMenustrip.ResumeLayout(false);
            this.itemMenuStrip.ResumeLayout(false);
            this.settingMenuStrip.ResumeLayout(false);
            this.POAMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion

        
        private ContextMenuStrip reqMenustrip;
        private ToolStripMenuItem createToolStripMenuItem1;
        private ContextMenuStrip itemMenuStrip;
        private ToolStripMenuItem createToolStripMenuItem2;
        private ContextMenuStrip settingMenuStrip;
        private ToolStripMenuItem roleManagementToolStripMenuItem1;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private Krypton.Toolkit.KryptonDropButton btnReq;
        private Krypton.Toolkit.KryptonDropButton btnItem;
        private Krypton.Toolkit.KryptonDropButton btnsetting;
        private Krypton.Toolkit.KryptonDropButton btnpoa;
        private ContextMenuStrip POAMenuStrip;
        private ToolStripMenuItem createToolStripMenuItem;
    }
}