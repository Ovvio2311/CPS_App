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
            components = new Container();
            reqMenustrip = new ContextMenuStrip(components);
            createToolStripMenuItem1 = new ToolStripMenuItem();
            itemMenuStrip = new ContextMenuStrip(components);
            createToolStripMenuItem2 = new ToolStripMenuItem();
            settingMenuStrip = new ContextMenuStrip(components);
            roleManagementToolStripMenuItem1 = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            btnReq = new Krypton.Toolkit.KryptonDropButton();
            btnItem = new Krypton.Toolkit.KryptonDropButton();
            btnsetting = new Krypton.Toolkit.KryptonDropButton();
            btnpoa = new Krypton.Toolkit.KryptonDropButton();
            POAMenuStrip = new ContextMenuStrip(components);
            createToolStripMenuItem = new ToolStripMenuItem();
            reqMenustrip.SuspendLayout();
            itemMenuStrip.SuspendLayout();
            settingMenuStrip.SuspendLayout();
            POAMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // reqMenustrip
            // 
            reqMenustrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reqMenustrip.Items.AddRange(new ToolStripItem[] { createToolStripMenuItem1 });
            reqMenustrip.Name = "reqMenustrip";
            reqMenustrip.Size = new Size(109, 26);
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(108, 22);
            createToolStripMenuItem1.Text = "Create";
            createToolStripMenuItem1.Click += createToolStripMenuItem1_Click;
            // 
            // itemMenuStrip
            // 
            itemMenuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            itemMenuStrip.Items.AddRange(new ToolStripItem[] { createToolStripMenuItem2 });
            itemMenuStrip.Name = "contextMenuStrip1";
            itemMenuStrip.Size = new Size(109, 26);
            // 
            // createToolStripMenuItem2
            // 
            createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            createToolStripMenuItem2.Size = new Size(108, 22);
            createToolStripMenuItem2.Text = "Create";
            createToolStripMenuItem2.Click += createToolStripMenuItem2_Click;
            // 
            // settingMenuStrip
            // 
            settingMenuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            settingMenuStrip.Items.AddRange(new ToolStripItem[] { roleManagementToolStripMenuItem1, userManagementToolStripMenuItem });
            settingMenuStrip.Name = "settingMenuStrip";
            settingMenuStrip.Size = new Size(172, 48);
            // 
            // roleManagementToolStripMenuItem1
            // 
            roleManagementToolStripMenuItem1.Name = "roleManagementToolStripMenuItem1";
            roleManagementToolStripMenuItem1.Size = new Size(171, 22);
            roleManagementToolStripMenuItem1.Text = "Role Management";
            roleManagementToolStripMenuItem1.Click += roleManagementToolStripMenuItem1_Click;
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new Size(171, 22);
            userManagementToolStripMenuItem.Text = "User Management";
            // 
            // btnReq
            // 
            btnReq.ContextMenuStrip = reqMenustrip;
            btnReq.Location = new Point(-1, 63);
            btnReq.Name = "btnReq";
            btnReq.Size = new Size(202, 71);
            btnReq.TabIndex = 19;
            btnReq.Values.Text = "Request Manage";
            btnReq.Click += btnReq_Click;
            // 
            // btnItem
            // 
            btnItem.ContextMenuStrip = itemMenuStrip;
            btnItem.Location = new Point(-1, 140);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(202, 67);
            btnItem.TabIndex = 20;
            btnItem.Values.Text = "Item Manage";
            btnItem.Click += btnItem_Click;
            // 
            // btnsetting
            // 
            btnsetting.ContextMenuStrip = settingMenuStrip;
            btnsetting.Location = new Point(-1, 290);
            btnsetting.Name = "btnsetting";
            btnsetting.Size = new Size(202, 73);
            btnsetting.TabIndex = 21;
            btnsetting.Values.Text = "Setting";
            btnsetting.Click += btnsetting_Click;
            // 
            // btnpoa
            // 
            btnpoa.ContextMenuStrip = POAMenuStrip;
            btnpoa.Location = new Point(-1, 213);
            btnpoa.Name = "btnpoa";
            btnpoa.Size = new Size(202, 71);
            btnpoa.TabIndex = 23;
            btnpoa.Values.Text = "POA Manage";
            btnpoa.Click += btnpoa_Click;
            // 
            // POAMenuStrip
            // 
            POAMenuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            POAMenuStrip.Items.AddRange(new ToolStripItem[] { createToolStripMenuItem });
            POAMenuStrip.Name = "POAMenuStrip";
            POAMenuStrip.Size = new Size(109, 26);
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(108, 22);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click_1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 589);
            Controls.Add(btnpoa);
            Controls.Add(btnsetting);
            Controls.Add(btnItem);
            Controls.Add(btnReq);
            IsMdiContainer = true;
            Name = "Dashboard";
            Padding = new Padding(200, 0, 0, 0);
            Text = "Dashboard";
            Load += Dashboard_Load;
            reqMenustrip.ResumeLayout(false);
            itemMenuStrip.ResumeLayout(false);
            settingMenuStrip.ResumeLayout(false);
            POAMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
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