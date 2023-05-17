using System.ComponentModel;
using System.Windows.Forms;

namespace CPS_App
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePage = new System.Windows.Forms.DataGridView();
            this.itemgridview = new System.Windows.Forms.DataGridView();
            this.lblDef = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.HomePage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HomePage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HomePage.Location = new System.Drawing.Point(12, 61);
            this.HomePage.Name = "HomePage";
            this.HomePage.RowTemplate.Height = 25;
            this.HomePage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.HomePage.Size = new System.Drawing.Size(1069, 375);
            this.HomePage.TabIndex = 2;
            this.HomePage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomePage_CellClick);
            this.HomePage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomePage_CellContentClick);
            this.HomePage.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //this.HomePage.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HomePage_ColumnHeaderMouseClick);
            this.HomePage.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Beige;
            this.HomePage.EnableHeadersVisualStyles = false;
            
            // 
            // itemgridview
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.itemgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.itemgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemgridview.Location = new System.Drawing.Point(12, 473);
            this.itemgridview.Name = "itemgridview";
            this.itemgridview.RowTemplate.Height = 25;
            this.itemgridview.Size = new System.Drawing.Size(873, 263);
            this.itemgridview.TabIndex = 4;
            this.itemgridview.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Beige;
            this.itemgridview.EnableHeadersVisualStyles = false;
            this.itemgridview.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //this.itemgridview.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.itemgridview_ColumnHeaderMouseClick);
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDef.Location = new System.Drawing.Point(15, 43);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(81, 17);
            this.lblDef.TabIndex = 6;
            this.lblDef.Text = "Request Table";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItem.Location = new System.Drawing.Point(15, 446);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(108, 17);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "Request Item Table";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 748);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblDef);
            this.Controls.Add(this.itemgridview);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private DataGridView HomePage;
        private DataGridView itemgridview;
        private Label lblDef;
        private Label lblItem;
    }
}