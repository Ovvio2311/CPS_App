namespace CPS_App
{
    partial class ItemView
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
            this.dataGridViewitem = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtfield = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewitem
            // 
            this.dataGridViewitem.AllowUserToOrderColumns = true;
            this.dataGridViewitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewitem.Location = new System.Drawing.Point(55, 81);
            this.dataGridViewitem.Name = "dataGridViewitem";
            this.dataGridViewitem.RowTemplate.Height = 25;
            this.dataGridViewitem.Size = new System.Drawing.Size(715, 351);
            this.dataGridViewitem.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // txtfield
            // 
            this.txtfield.Location = new System.Drawing.Point(182, 29);
            this.txtfield.Name = "txtfield";
            this.txtfield.PlaceholderText = "Search for Items";
            this.txtfield.Size = new System.Drawing.Size(218, 23);
            this.txtfield.TabIndex = 2;
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 532);
            this.Controls.Add(this.txtfield);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridViewitem);
            this.Name = "ItemView";
            this.Text = "ItemView";
            this.Load += new System.EventHandler(this.ItemView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewitem;
        private ComboBox comboBox1;
        private TextBox txtfield;
    }
}