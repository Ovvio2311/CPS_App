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
            createReq = new ToolStripMenuItem();
            ItemCreate = new ContextMenuStrip(components);
            createItem = new ToolStripMenuItem();
            btnReq = new Krypton.Toolkit.KryptonDropButton();
            btnItem = new Krypton.Toolkit.KryptonDropButton();
            btnsetting = new Krypton.Toolkit.KryptonDropButton();
            btnpoa = new Krypton.Toolkit.KryptonDropButton();
            POAMenuStrip = new ContextMenuStrip(components);
            createpoa = new ToolStripMenuItem();
            reqMenustrip.SuspendLayout();
            ItemCreate.SuspendLayout();
            POAMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // reqMenustrip
            // 
            reqMenustrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reqMenustrip.Items.AddRange(new ToolStripItem[] { createReq });
            reqMenustrip.Name = "reqMenustrip";
            reqMenustrip.Size = new Size(109, 26);
            // 
            // createReq
            // 
            createReq.Name = "createReq";
            createReq.Size = new Size(108, 22);
            createReq.Text = "Create";
            createReq.Click += createReq_Click;
            // 
            // ItemCreate
            // 
            ItemCreate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemCreate.Items.AddRange(new ToolStripItem[] { createItem });
            ItemCreate.Name = "contextMenuStrip1";
            ItemCreate.Size = new Size(109, 26);
            ItemCreate.Click += createItem_Click;
            // 
            // createItem
            // 
            createItem.Name = "createItem";
            createItem.Size = new Size(108, 22);
            createItem.Text = "Create";
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
            btnItem.ContextMenuStrip = ItemCreate;
            btnItem.Location = new Point(-1, 140);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(202, 67);
            btnItem.TabIndex = 20;
            btnItem.Values.Text = "Item Manage";
            btnItem.Click += btnItem_Click;
            // 
            // btnsetting
            // 
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
            POAMenuStrip.Items.AddRange(new ToolStripItem[] { createpoa });
            POAMenuStrip.Name = "POAMenuStrip";
            POAMenuStrip.Size = new Size(181, 48);
            POAMenuStrip.Click += createpoa_Click;
            // 
            // createpoa
            // 
            createpoa.Name = "createpoa";
            createpoa.Size = new Size(180, 22);
            createpoa.Text = "Create";
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
            ItemCreate.ResumeLayout(false);
            POAMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }




        #endregion


        private ContextMenuStrip reqMenustrip;
        private ToolStripMenuItem createReq;
        private ContextMenuStrip ItemCreate;
        private ToolStripMenuItem createItem;
        private ContextMenuStrip settingMenuStrip;
        private ToolStripMenuItem roleManagementToolStripMenuItem1;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private Krypton.Toolkit.KryptonDropButton btnReq;
        private Krypton.Toolkit.KryptonDropButton btnItem;
        private Krypton.Toolkit.KryptonDropButton btnsetting;
        private Krypton.Toolkit.KryptonDropButton btnpoa;
        private ContextMenuStrip POAMenuStrip;
        private ToolStripMenuItem createpoa;
    }
}