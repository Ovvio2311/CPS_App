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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            requestToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            itemToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            roleManagementToolStripMenuItem = new ToolStripMenuItem();
            reqMenustrip = new ContextMenuStrip(components);
            vieToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            itemMenuStrip = new ContextMenuStrip(components);
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            createToolStripMenuItem2 = new ToolStripMenuItem();
            editToolStripMenuItem2 = new ToolStripMenuItem();
            settingMenuStrip = new ContextMenuStrip(components);
            roleManagementToolStripMenuItem1 = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            btnReq = new Krypton.Toolkit.KryptonDropButton();
            btnItem = new Krypton.Toolkit.KryptonDropButton();
            btnsetting = new Krypton.Toolkit.KryptonDropButton();
            btnpoa = new Krypton.Toolkit.KryptonDropButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            menuStrip1.SuspendLayout();
            reqMenustrip.SuspendLayout();
            itemMenuStrip.SuspendLayout();
            settingMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, loginToolStripMenuItem, registerToolStripMenuItem, requestToolStripMenuItem, itemToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(200, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(839, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(61, 20);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // requestToolStripMenuItem
            // 
            requestToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem, createToolStripMenuItem, editToolStripMenuItem });
            requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            requestToolStripMenuItem.Size = new Size(61, 20);
            requestToolStripMenuItem.Text = "Request";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(108, 22);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(108, 22);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(108, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // itemToolStripMenuItem
            // 
            itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            itemToolStripMenuItem.Size = new Size(43, 20);
            itemToolStripMenuItem.Text = "Item";
            itemToolStripMenuItem.Click += itemToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { roleManagementToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // roleManagementToolStripMenuItem
            // 
            roleManagementToolStripMenuItem.Name = "roleManagementToolStripMenuItem";
            roleManagementToolStripMenuItem.Size = new Size(171, 22);
            roleManagementToolStripMenuItem.Text = "Role Management";
            roleManagementToolStripMenuItem.Click += roleManagementToolStripMenuItem_Click;
            // 
            // reqMenustrip
            // 
            reqMenustrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reqMenustrip.Items.AddRange(new ToolStripItem[] { vieToolStripMenuItem, createToolStripMenuItem1, editToolStripMenuItem1 });
            reqMenustrip.Name = "reqMenustrip";
            reqMenustrip.Size = new Size(109, 70);
            // 
            // vieToolStripMenuItem
            // 
            vieToolStripMenuItem.Name = "vieToolStripMenuItem";
            vieToolStripMenuItem.Size = new Size(108, 22);
            vieToolStripMenuItem.Text = "View";
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(108, 22);
            createToolStripMenuItem1.Text = "Create";
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(108, 22);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // itemMenuStrip
            // 
            itemMenuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            itemMenuStrip.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem1, createToolStripMenuItem2, editToolStripMenuItem2 });
            itemMenuStrip.Name = "contextMenuStrip1";
            itemMenuStrip.Size = new Size(109, 70);
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new Size(108, 22);
            viewToolStripMenuItem1.Text = "View";
            // 
            // createToolStripMenuItem2
            // 
            createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            createToolStripMenuItem2.Size = new Size(108, 22);
            createToolStripMenuItem2.Text = "Create";
            // 
            // editToolStripMenuItem2
            // 
            editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            editToolStripMenuItem2.Size = new Size(108, 22);
            editToolStripMenuItem2.Text = "Edit";
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
            // 
            // btnItem
            // 
            btnItem.ContextMenuStrip = itemMenuStrip;
            btnItem.Location = new Point(-1, 140);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(202, 67);
            btnItem.TabIndex = 20;
            btnItem.Values.Text = "Item Manage";
            // 
            // btnsetting
            // 
            btnsetting.ContextMenuStrip = settingMenuStrip;
            btnsetting.Location = new Point(-1, 213);
            btnsetting.Name = "btnsetting";
            btnsetting.Size = new Size(202, 73);
            btnsetting.TabIndex = 21;
            btnsetting.Values.Text = "Setting";
            // 
            // btnpoa
            // 
            btnpoa.Location = new Point(-1, 292);
            btnpoa.Name = "btnpoa";
            btnpoa.Size = new Size(202, 71);
            btnpoa.TabIndex = 23;
            btnpoa.Values.Text = "POA Manage";
            btnpoa.Click += btnpoa_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
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
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Padding = new Padding(200, 0, 0, 0);
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            reqMenustrip.ResumeLayout(false);
            itemMenuStrip.ResumeLayout(false);
            settingMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem requestToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem roleManagementToolStripMenuItem;

        
        private ContextMenuStrip reqMenustrip;
        private ToolStripMenuItem vieToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ContextMenuStrip itemMenuStrip;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem createToolStripMenuItem2;
        private ToolStripMenuItem editToolStripMenuItem2;
        private ContextMenuStrip settingMenuStrip;
        private ToolStripMenuItem roleManagementToolStripMenuItem1;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private Krypton.Toolkit.KryptonDropButton btnReq;
        private Krypton.Toolkit.KryptonDropButton btnItem;
        private Krypton.Toolkit.KryptonDropButton btnsetting;
        private Krypton.Toolkit.KryptonDropButton btnpoa;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}