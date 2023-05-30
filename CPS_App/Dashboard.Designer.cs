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
            this.createReq = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCreate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReq = new Krypton.Toolkit.KryptonDropButton();
            this.btnItem = new Krypton.Toolkit.KryptonDropButton();
            this.btnsetting = new Krypton.Toolkit.KryptonDropButton();
            this.btnpoa = new Krypton.Toolkit.KryptonDropButton();
            this.POAMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createpoa = new System.Windows.Forms.ToolStripMenuItem();
            this.vIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reqMenustrip.SuspendLayout();
            this.ItemCreate.SuspendLayout();
            this.POAMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reqMenustrip
            // 
            this.reqMenustrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reqMenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReq,
            this.vIDToolStripMenuItem});
            this.reqMenustrip.Name = "reqMenustrip";
            this.reqMenustrip.Size = new System.Drawing.Size(181, 70);
            // 
            // createReq
            // 
            this.createReq.Name = "createReq";
            this.createReq.Size = new System.Drawing.Size(180, 22);
            this.createReq.Text = "Create";
            this.createReq.Click += new System.EventHandler(this.createReq_Click);
            // 
            // ItemCreate
            // 
            this.ItemCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemCreate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createItem});
            this.ItemCreate.Name = "contextMenuStrip1";
            this.ItemCreate.Size = new System.Drawing.Size(109, 26);
            this.ItemCreate.Click += new System.EventHandler(this.createItem_Click);
            // 
            // createItem
            // 
            this.createItem.Name = "createItem";
            this.createItem.Size = new System.Drawing.Size(108, 22);
            this.createItem.Text = "Create";
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
            this.btnItem.ContextMenuStrip = this.ItemCreate;
            this.btnItem.Location = new System.Drawing.Point(-1, 140);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(202, 67);
            this.btnItem.TabIndex = 20;
            this.btnItem.Values.Text = "Item Manage";
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnsetting
            // 
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
            this.createpoa});
            this.POAMenuStrip.Name = "POAMenuStrip";
            this.POAMenuStrip.Size = new System.Drawing.Size(109, 26);
            this.POAMenuStrip.Click += new System.EventHandler(this.createpoa_Click);
            // 
            // createpoa
            // 
            this.createpoa.Name = "createpoa";
            this.createpoa.Size = new System.Drawing.Size(108, 22);
            this.createpoa.Text = "Create";
            // 
            // vIDToolStripMenuItem
            // 
            this.vIDToolStripMenuItem.Name = "vIDToolStripMenuItem";
            this.vIDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vIDToolStripMenuItem.Text = "VID";
            this.vIDToolStripMenuItem.Click += new System.EventHandler(this.vIDToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 749);
            this.Controls.Add(this.btnpoa);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnReq);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
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
        private ToolStripMenuItem vIDToolStripMenuItem;
    }
}