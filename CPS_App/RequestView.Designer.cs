using Krypton.Toolkit;
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblReqView = new Label();
            createdbBindingSource = new BindingSource(components);
            datagridview = new KryptonDataGridView();
            lblItems = new Label();
            datagridviewitem = new KryptonDataGridView();
            btnEdit = new Button();
            txtfield = new TextBox();
            lblsearch = new Label();
            cbxsearch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)createdbBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).BeginInit();
            SuspendLayout();
            // 
            // lblReqView
            // 
            lblReqView.AutoSize = true;
            lblReqView.Location = new Point(27, 61);
            lblReqView.Name = "lblReqView";
            lblReqView.Size = new Size(49, 15);
            lblReqView.TabIndex = 0;
            lblReqView.Text = "Request";
            // 
            // createdbBindingSource
            // 
            createdbBindingSource.DataSource = typeof(Migrations.createdb);
            // 
            // datagridview
            // 
            datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview.Location = new Point(27, 81);
            datagridview.Name = "datagridview";
            datagridview.ReadOnly = true;
            datagridview.RowTemplate.Height = 25;
            datagridview.Size = new Size(881, 291);
            datagridview.TabIndex = 2;
            datagridview.CellClick += datagridview_CellClick;
            
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Location = new Point(27, 375);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(36, 15);
            lblItems.TabIndex = 3;
            lblItems.Text = "Items";
            // 
            // datagridviewitem
            // 
            datagridviewitem.AllowUserToOrderColumns = true;
            datagridviewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewitem.Location = new Point(27, 393);
            datagridviewitem.Name = "datagridviewitem";
            datagridviewitem.ReadOnly = true;
            datagridviewitem.RowTemplate.Height = 25;
            datagridviewitem.Size = new Size(881, 227);
            datagridviewitem.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(923, 81);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtfield
            // 
            txtfield.Location = new Point(200, 18);
            txtfield.Name = "txtfield";
            txtfield.PlaceholderText = "Search for Request";
            txtfield.Size = new Size(232, 23);
            txtfield.TabIndex = 6;
            txtfield.KeyPress += txtfield_KeyPress;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Location = new Point(29, 21);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(42, 15);
            lblsearch.TabIndex = 7;
            lblsearch.Text = "Search";
            // 
            // cbxsearch
            // 
            cbxsearch.FormattingEnabled = true;
            cbxsearch.Location = new Point(73, 18);
            cbxsearch.Name = "cbxsearch";
            cbxsearch.Size = new Size(121, 23);
            cbxsearch.TabIndex = 8;
            // 
            // RequestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 648);
            Controls.Add(cbxsearch);
            Controls.Add(lblsearch);
            Controls.Add(txtfield);
            Controls.Add(btnEdit);
            Controls.Add(datagridviewitem);
            Controls.Add(lblItems);
            Controls.Add(datagridview);
            Controls.Add(lblReqView);
            Name = "RequestView";
            Text = "RequestView";
            Load += RequestView_Load;
            ((System.ComponentModel.ISupportInitialize)createdbBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReqView;
        private BindingSource createdbBindingSource;
        private KryptonDataGridView datagridview;
        private Label lblItems;
        private KryptonDataGridView datagridviewitem;
        private Button btnEdit;
        private TextBox txtfield;
        private Label lblsearch;
        private ComboBox cbxsearch;
    }
}