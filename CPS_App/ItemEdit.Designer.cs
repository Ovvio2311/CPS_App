namespace CPS_App
{
    partial class ItemEdit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtvid = new TextBox();
            txtcat = new TextBox();
            txtname = new TextBox();
            txtid = new TextBox();
            txtqty = new TextBox();
            txtloc = new TextBox();
            txtupdate = new TextBox();
            txtuom = new TextBox();
            dataGridViewitem = new DataGridView();
            btnmod = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewitem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 78);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Item ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 117);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Item VID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 78);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 117);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 159);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 4;
            label5.Text = "Unit of Measurement";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 117);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 5;
            label6.Text = "Stock Loaction";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(530, 78);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 6;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(510, 159);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 7;
            label8.Text = "Last Updated Time";
            // 
            // txtvid
            // 
            txtvid.Location = new Point(77, 114);
            txtvid.Name = "txtvid";
            txtvid.ReadOnly = true;
            txtvid.Size = new Size(169, 23);
            txtvid.TabIndex = 8;
            // 
            // txtcat
            // 
            txtcat.Location = new Point(347, 114);
            txtcat.Name = "txtcat";
            txtcat.ReadOnly = true;
            txtcat.Size = new Size(155, 23);
            txtcat.TabIndex = 9;
            // 
            // txtname
            // 
            txtname.Location = new Point(347, 75);
            txtname.Name = "txtname";
            txtname.ReadOnly = true;
            txtname.Size = new Size(155, 23);
            txtname.TabIndex = 10;
            // 
            // txtid
            // 
            txtid.Location = new Point(77, 75);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(169, 23);
            txtid.TabIndex = 11;
            // 
            // txtqty
            // 
            txtqty.Location = new Point(622, 75);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(149, 23);
            txtqty.TabIndex = 12;
            // 
            // txtloc
            // 
            txtloc.Location = new Point(622, 114);
            txtloc.Name = "txtloc";
            txtloc.ReadOnly = true;
            txtloc.Size = new Size(150, 23);
            txtloc.TabIndex = 13;
            // 
            // txtupdate
            // 
            txtupdate.Location = new Point(622, 156);
            txtupdate.Name = "txtupdate";
            txtupdate.ReadOnly = true;
            txtupdate.Size = new Size(149, 23);
            txtupdate.TabIndex = 14;
            // 
            // txtuom
            // 
            txtuom.Location = new Point(346, 156);
            txtuom.Name = "txtuom";
            txtuom.ReadOnly = true;
            txtuom.Size = new Size(156, 23);
            txtuom.TabIndex = 15;
            // 
            // dataGridViewitem
            // 
            dataGridViewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewitem.Location = new Point(26, 254);
            dataGridViewitem.Name = "dataGridViewitem";
            dataGridViewitem.RowTemplate.Height = 25;
            dataGridViewitem.Size = new Size(745, 150);
            dataGridViewitem.TabIndex = 16;
            dataGridViewitem.CellClick += dataGridViewitem_CellClick;
            // 
            // btnmod
            // 
            btnmod.Location = new Point(661, 202);
            btnmod.Name = "btnmod";
            btnmod.Size = new Size(110, 29);
            btnmod.TabIndex = 17;
            btnmod.Text = "Modify";
            btnmod.UseVisualStyleBackColor = true;
            btnmod.Click += btnmod_Click;
            // 
            // ItemEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnmod);
            Controls.Add(dataGridViewitem);
            Controls.Add(txtuom);
            Controls.Add(txtupdate);
            Controls.Add(txtloc);
            Controls.Add(txtqty);
            Controls.Add(txtid);
            Controls.Add(txtname);
            Controls.Add(txtcat);
            Controls.Add(txtvid);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ItemEdit";
            Text = "ItemEdit";
            Load += ItemEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewitem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtvid;
        private TextBox txtcat;
        private TextBox txtname;
        private TextBox txtid;
        private TextBox txtqty;
        private TextBox txtloc;
        private TextBox txtupdate;
        private TextBox txtuom;
        private DataGridView dataGridViewitem;
        private Button btnmod;
    }
}