namespace CPS_App
{
    partial class frmHome
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.targetModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upOperationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downOperationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeProviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.targetModelDataGridViewTextBoxColumn,
            this.upOperationsDataGridViewTextBoxColumn,
            this.downOperationsDataGridViewTextBoxColumn,
            this.activeProviderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.createdbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(606, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // createdbBindingSource
            // 
            this.createdbBindingSource.DataSource = typeof(CPS_App.Migrations.createdb);
            // 
            // targetModelDataGridViewTextBoxColumn
            // 
            this.targetModelDataGridViewTextBoxColumn.DataPropertyName = "TargetModel";
            this.targetModelDataGridViewTextBoxColumn.HeaderText = "TargetModel";
            this.targetModelDataGridViewTextBoxColumn.Name = "targetModelDataGridViewTextBoxColumn";
            this.targetModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // upOperationsDataGridViewTextBoxColumn
            // 
            this.upOperationsDataGridViewTextBoxColumn.DataPropertyName = "UpOperations";
            this.upOperationsDataGridViewTextBoxColumn.HeaderText = "UpOperations";
            this.upOperationsDataGridViewTextBoxColumn.Name = "upOperationsDataGridViewTextBoxColumn";
            this.upOperationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // downOperationsDataGridViewTextBoxColumn
            // 
            this.downOperationsDataGridViewTextBoxColumn.DataPropertyName = "DownOperations";
            this.downOperationsDataGridViewTextBoxColumn.HeaderText = "DownOperations";
            this.downOperationsDataGridViewTextBoxColumn.Name = "downOperationsDataGridViewTextBoxColumn";
            this.downOperationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeProviderDataGridViewTextBoxColumn
            // 
            this.activeProviderDataGridViewTextBoxColumn.DataPropertyName = "ActiveProvider";
            this.activeProviderDataGridViewTextBoxColumn.HeaderText = "ActiveProvider";
            this.activeProviderDataGridViewTextBoxColumn.Name = "activeProviderDataGridViewTextBoxColumn";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn targetModelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn upOperationsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn downOperationsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activeProviderDataGridViewTextBoxColumn;
        private BindingSource createdbBindingSource;
    }
}