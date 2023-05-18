using System.Windows.Forms;

namespace CPS_App
{
    partial class RequestView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblReqView = new System.Windows.Forms.Label();
            this.createdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.lblItems = new System.Windows.Forms.Label();
            this.datagridviewitem = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtfield = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.cbxsearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.createdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReqView
            // 
            this.lblReqView.AutoSize = true;
            this.lblReqView.Location = new System.Drawing.Point(27, 61);
            this.lblReqView.Name = "lblReqView";
            this.lblReqView.Size = new System.Drawing.Size(49, 15);
            this.lblReqView.TabIndex = 0;
            this.lblReqView.Text = "Request";
            // 
            // createdbBindingSource
            // 
            this.createdbBindingSource.DataSource = typeof(CPS_App.Migrations.createdb);
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(27, 81);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowTemplate.Height = 25;
            this.datagridview.Size = new System.Drawing.Size(881, 291);
            this.datagridview.TabIndex = 2;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellClick);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(27, 375);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(36, 15);
            this.lblItems.TabIndex = 3;
            this.lblItems.Text = "Items";
            // 
            // datagridviewitem
            // 
            this.datagridviewitem.AllowUserToOrderColumns = true;
            this.datagridviewitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewitem.Location = new System.Drawing.Point(27, 393);
            this.datagridviewitem.Name = "datagridviewitem";
            this.datagridviewitem.ReadOnly = true;
            this.datagridviewitem.RowTemplate.Height = 25;
            this.datagridviewitem.Size = new System.Drawing.Size(881, 227);
            this.datagridviewitem.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(923, 81);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtfield
            // 
            this.txtfield.Location = new System.Drawing.Point(200, 18);
            this.txtfield.Name = "txtfield";
            this.txtfield.PlaceholderText = "Search for Request";
            this.txtfield.Size = new System.Drawing.Size(232, 23);
            this.txtfield.TabIndex = 6;
            this.txtfield.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfield_KeyPress);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(29, 21);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(42, 15);
            this.lblsearch.TabIndex = 7;
            this.lblsearch.Text = "Search";
            // 
            // cbxsearch
            // 
            this.cbxsearch.FormattingEnabled = true;
            this.cbxsearch.Location = new System.Drawing.Point(73, 18);
            this.cbxsearch.Name = "cbxsearch";
            this.cbxsearch.Size = new System.Drawing.Size(121, 23);
            this.cbxsearch.TabIndex = 8;
            // 
            // RequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 648);
            this.Controls.Add(this.cbxsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtfield);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.datagridviewitem);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.lblReqView);
            this.Name = "RequestView";
            this.Text = "RequestView";
            this.Load += new System.EventHandler(this.RequestView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblReqView;
        private BindingSource createdbBindingSource;
        private DataGridView datagridview;
        private Label lblItems;
        private DataGridView datagridviewitem;
        private Button btnEdit;
        private TextBox txtfield;
        private Label lblsearch;
        private ComboBox cbxsearch;
    }
}