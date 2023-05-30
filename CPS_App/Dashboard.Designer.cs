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
            this.components = new Container();
            this.reqMenustrip = new ContextMenuStrip(components);
            this.createReq = new ToolStripMenuItem();
            this.ItemCreate = new ContextMenuStrip(components);
            this.createItem = new ToolStripMenuItem();
            this.btnReq = new Krypton.Toolkit.KryptonDropButton();
            this.btnItem = new Krypton.Toolkit.KryptonDropButton();
            this.btnsetting = new Krypton.Toolkit.KryptonDropButton();
            this.btnpoa = new Krypton.Toolkit.KryptonDropButton();
            this.POAMenuStrip = new ContextMenuStrip(components);
            this.createpoa = new ToolStripMenuItem();
            this.reqMenustrip.SuspendLayout();
            this.ItemCreate.SuspendLayout();
            this.POAMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reqMenustrip
            // 
            this.reqMenustrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.reqMenustrip.Items.AddRange(new ToolStripItem[] { createReq });
            this.reqMenustrip.Name = "reqMenustrip";
            this.reqMenustrip.Size = new Size(109, 26);
            // 
            // createReq
            // 
            this.createReq.Name = "createReq";
            this.createReq.Size = new Size(108, 22);
            this.createReq.Text = "Create";
            this.createReq.Click += new System.EventHandler(this.createReq_Click);
            // 
            // ItemCreate
            // 
            this.ItemCreate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.ItemCreate.Items.AddRange(new ToolStripItem[] { createItem });
            this.ItemCreate.Name = "contextMenuStrip1";
            this.ItemCreate.Size = new Size(109, 26);
            this.ItemCreate.Click += new System.EventHandler(this.createItem_Click);
            // 
            // createItem
            // 
            this.createItem.Name = "createItem";
            this.createItem.Size = new Size(108, 22);
            this.createItem.Text = "Create";
            // 
            // btnReq
            // 
            this.btnReq.ContextMenuStrip = reqMenustrip;
            this.btnReq.Location = new Point(-1, 63);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new Size(202, 71);
            this.btnReq.TabIndex = 19;
            this.btnReq.Values.Text = "Request Manage";
            this.btnReq.Click += new System.EventHandler(this.btnReq_Click);
            // 
            // btnItem
            // 
            this.btnItem.ContextMenuStrip = ItemCreate;
            this.btnItem.Location = new Point(-1, 140);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new Size(202, 67);
            this.btnItem.TabIndex = 20;
            this.btnItem.Values.Text = "Item Manage";
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.Location = new Point(-1, 290);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new Size(202, 73);
            this.btnsetting.TabIndex = 21;
            this.btnsetting.Values.Text = "Setting";
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btnpoa
            // 
            this.btnpoa.ContextMenuStrip = POAMenuStrip;
            this.btnpoa.Location = new Point(-1, 213);
            this.btnpoa.Name = "btnpoa";
            this.btnpoa.Size = new Size(202, 71);
            this.btnpoa.TabIndex = 23;
            this.btnpoa.Values.Text = "POA Manage";
            this.btnpoa.Click += new System.EventHandler(this.btnpoa_Click);
            // 
            // POAMenuStrip
            // 
            this.POAMenuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.POAMenuStrip.Items.AddRange(new ToolStripItem[] { createpoa });
            this.POAMenuStrip.Name = "POAMenuStrip";
            this.POAMenuStrip.Size = new Size(181, 48);
            this.POAMenuStrip.Click += new System.EventHandler(this.createpoa_Click);
            // 
            // createpoa
            // 
            this.createpoa.Name = "createpoa";
            this.createpoa.Size = new Size(180, 22);
            this.createpoa.Text = "Create";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode =  AutoScaleMode.Font;
            this.ClientSize = new Size(1039, 589);
            this.Controls.Add(btnpoa);
            this.Controls.Add(btnsetting);
            this.Controls.Add(btnItem);
            this.Controls.Add(btnReq);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Padding = new Padding(200, 0, 0, 0);
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.reqMenustrip.ResumeLayout(false);
            this.ItemCreate.ResumeLayout(false);
            this.POAMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
        }




        #endregion


        private ContextMenuStrip reqMenustrip;
        private ToolStripMenuItem createReq;
        private ContextMenuStrip ItemCreate;
        private ToolStripMenuItem createItem;
        private ContextMenuStrip settingMenuStrip;
        private Krypton.Toolkit.KryptonDropButton btnReq;
        private Krypton.Toolkit.KryptonDropButton btnItem;
        private Krypton.Toolkit.KryptonDropButton btnsetting;
        private Krypton.Toolkit.KryptonDropButton btnpoa;
        private ContextMenuStrip POAMenuStrip;
        private ToolStripMenuItem createpoa;
    }
}