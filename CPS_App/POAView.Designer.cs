namespace CPS_App
{
    partial class POAView
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
            kryptonDataGridViewpoa = new Krypton.Toolkit.KryptonDataGridView();
            kryptonDataGridViewitem = new Krypton.Toolkit.KryptonDataGridView();
            btnedit = new Krypton.Toolkit.KryptonButton();
            lblpoa = new Krypton.Toolkit.KryptonLabel();
            lbltype = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            lblloc = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            lblcur = new Krypton.Toolkit.KryptonLabel();
            lbltc = new Krypton.Toolkit.KryptonLabel();
            lbldelisc = new Krypton.Toolkit.KryptonLabel();
            lblec = new Krypton.Toolkit.KryptonLabel();
            txtpoa = new Krypton.Toolkit.KryptonTextBox();
            txttype = new Krypton.Toolkit.KryptonTextBox();
            txtst = new Krypton.Toolkit.KryptonTextBox();
            txtloc = new Krypton.Toolkit.KryptonTextBox();
            txtsup = new Krypton.Toolkit.KryptonTextBox();
            txtcur = new Krypton.Toolkit.KryptonTextBox();
            txttc = new Krypton.Toolkit.KryptonTextBox();
            txtconNo = new Krypton.Toolkit.KryptonTextBox();
            lblConNo = new Krypton.Toolkit.KryptonLabel();
            kryptonDateTimePickerec = new Krypton.Toolkit.KryptonDateTimePicker();
            cbxdelisc = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewitem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxdelisc).BeginInit();
            SuspendLayout();
            // 
            // kryptonDataGridViewpoa
            // 
            kryptonDataGridViewpoa.Location = new Point(72, 185);
            kryptonDataGridViewpoa.Name = "kryptonDataGridViewpoa";
            kryptonDataGridViewpoa.RowTemplate.Height = 25;
            kryptonDataGridViewpoa.Size = new Size(647, 221);
            kryptonDataGridViewpoa.TabIndex = 0;
            kryptonDataGridViewpoa.CellClick += kryptonDataGridViewpoa_CellClick;
            // 
            // kryptonDataGridViewitem
            // 
            kryptonDataGridViewitem.Location = new Point(72, 444);
            kryptonDataGridViewitem.Name = "kryptonDataGridViewitem";
            kryptonDataGridViewitem.RowTemplate.Height = 25;
            kryptonDataGridViewitem.Size = new Size(647, 164);
            kryptonDataGridViewitem.TabIndex = 1;
            // 
            // btnedit
            // 
            btnedit.CornerRoundingRadius = -1F;
            btnedit.Location = new Point(620, 144);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(90, 25);
            btnedit.TabIndex = 2;
            btnedit.Values.Text = "Edit";
            btnedit.Click += btnedit_Click;
            // 
            // lblpoa
            // 
            lblpoa.Location = new Point(59, 23);
            lblpoa.Name = "lblpoa";
            lblpoa.Size = new Size(45, 20);
            lblpoa.TabIndex = 3;
            lblpoa.Values.Text = "Poa Id";
            // 
            // lbltype
            // 
            lbltype.Location = new Point(67, 61);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(37, 20);
            lbltype.TabIndex = 4;
            lbltype.Values.Text = "Type";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(60, 105);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(44, 20);
            kryptonLabel3.TabIndex = 5;
            kryptonLabel3.Values.Text = "Status";
            // 
            // lblloc
            // 
            lblloc.Location = new Point(235, 23);
            lblloc.Name = "lblloc";
            lblloc.Size = new Size(104, 20);
            lblloc.TabIndex = 6;
            lblloc.Values.Text = "Delivery Location";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(284, 61);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(55, 20);
            kryptonLabel5.TabIndex = 7;
            kryptonLabel5.Values.Text = "Supplier";
            // 
            // lblcur
            // 
            lblcur.Location = new Point(280, 102);
            lblcur.Name = "lblcur";
            lblcur.Size = new Size(59, 20);
            lblcur.TabIndex = 8;
            lblcur.Values.Text = "Currency";
            // 
            // lbltc
            // 
            lbltc.Location = new Point(474, 23);
            lbltc.Name = "lbltc";
            lbltc.Size = new Size(130, 20);
            lbltc.TabIndex = 9;
            lbltc.Values.Text = "Terms and Conditions";
            // 
            // lbldelisc
            // 
            lbldelisc.Location = new Point(493, 61);
            lbldelisc.Name = "lbldelisc";
            lbldelisc.Size = new Size(107, 20);
            lbldelisc.TabIndex = 10;
            lbldelisc.Values.Text = "Delivery Schedule";
            // 
            // lblec
            // 
            lblec.Location = new Point(515, 102);
            lblec.Name = "lblec";
            lblec.Size = new Size(85, 20);
            lblec.TabIndex = 11;
            lblec.Values.Text = "Effective Date";
            // 
            // txtpoa
            // 
            txtpoa.Location = new Point(110, 23);
            txtpoa.Name = "txtpoa";
            txtpoa.ReadOnly = true;
            txtpoa.Size = new Size(100, 23);
            txtpoa.TabIndex = 12;
            // 
            // txttype
            // 
            txttype.Location = new Point(110, 60);
            txttype.Name = "txttype";
            txttype.ReadOnly = true;
            txttype.Size = new Size(100, 23);
            txttype.TabIndex = 13;
            // 
            // txtst
            // 
            txtst.Location = new Point(110, 105);
            txtst.Name = "txtst";
            txtst.Size = new Size(100, 23);
            txtst.TabIndex = 14;
            // 
            // txtloc
            // 
            txtloc.Location = new Point(345, 23);
            txtloc.Name = "txtloc";
            txtloc.ReadOnly = true;
            txtloc.Size = new Size(100, 23);
            txtloc.TabIndex = 15;
            // 
            // txtsup
            // 
            txtsup.Location = new Point(345, 61);
            txtsup.Name = "txtsup";
            txtsup.ReadOnly = true;
            txtsup.Size = new Size(100, 23);
            txtsup.TabIndex = 16;
            // 
            // txtcur
            // 
            txtcur.Location = new Point(345, 105);
            txtcur.Name = "txtcur";
            txtcur.ReadOnly = true;
            txtcur.Size = new Size(100, 23);
            txtcur.TabIndex = 17;
            // 
            // txttc
            // 
            txttc.Location = new Point(610, 23);
            txttc.Name = "txttc";
            txttc.ReadOnly = true;
            txttc.Size = new Size(121, 23);
            txttc.TabIndex = 18;
            // 
            // txtconNo
            // 
            txtconNo.Location = new Point(345, 144);
            txtconNo.Name = "txtconNo";
            txtconNo.ReadOnly = true;
            txtconNo.Size = new Size(100, 23);
            txtconNo.TabIndex = 21;
            // 
            // lblConNo
            // 
            lblConNo.Location = new Point(255, 144);
            lblConNo.Name = "lblConNo";
            lblConNo.Size = new Size(80, 20);
            lblConNo.TabIndex = 22;
            lblConNo.Values.Text = "Contract No.";
            // 
            // kryptonDateTimePickerec
            // 
            kryptonDateTimePickerec.CornerRoundingRadius = -1F;
            kryptonDateTimePickerec.Enabled = false;
            kryptonDateTimePickerec.Location = new Point(610, 105);
            kryptonDateTimePickerec.Name = "kryptonDateTimePickerec";
            kryptonDateTimePickerec.Size = new Size(121, 21);
            kryptonDateTimePickerec.TabIndex = 23;
            // 
            // cbxdelisc
            // 
            cbxdelisc.CornerRoundingRadius = -1F;
            cbxdelisc.DropDownWidth = 121;
            cbxdelisc.IntegralHeight = false;
            cbxdelisc.Location = new Point(610, 60);
            cbxdelisc.Name = "cbxdelisc";
            cbxdelisc.Size = new Size(121, 21);
            cbxdelisc.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbxdelisc.TabIndex = 24;
            // 
            // POAView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 638);
            Controls.Add(cbxdelisc);
            Controls.Add(kryptonDateTimePickerec);
            Controls.Add(lblConNo);
            Controls.Add(txtconNo);
            Controls.Add(txttc);
            Controls.Add(txtcur);
            Controls.Add(txtsup);
            Controls.Add(txtloc);
            Controls.Add(txtst);
            Controls.Add(txttype);
            Controls.Add(txtpoa);
            Controls.Add(lblec);
            Controls.Add(lbldelisc);
            Controls.Add(lbltc);
            Controls.Add(lblcur);
            Controls.Add(kryptonLabel5);
            Controls.Add(lblloc);
            Controls.Add(kryptonLabel3);
            Controls.Add(lbltype);
            Controls.Add(lblpoa);
            Controls.Add(btnedit);
            Controls.Add(kryptonDataGridViewitem);
            Controls.Add(kryptonDataGridViewpoa);
            Name = "POAView";
            Text = "POAView";
            Load += POAView_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewitem).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxdelisc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewpoa;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewitem;
        private Krypton.Toolkit.KryptonButton btnedit;
        private Krypton.Toolkit.KryptonLabel lblpoa;
        private Krypton.Toolkit.KryptonLabel lbltype;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblloc;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel lblcur;
        private Krypton.Toolkit.KryptonLabel lbltc;
        private Krypton.Toolkit.KryptonLabel lbldelisc;
        private Krypton.Toolkit.KryptonLabel lblec;
        private Krypton.Toolkit.KryptonTextBox txtpoa;
        private Krypton.Toolkit.KryptonTextBox txttype;
        private Krypton.Toolkit.KryptonTextBox txtst;
        private Krypton.Toolkit.KryptonTextBox txtloc;
        private Krypton.Toolkit.KryptonTextBox txtsup;
        private Krypton.Toolkit.KryptonTextBox txtcur;
        private Krypton.Toolkit.KryptonTextBox txttc;
        private Krypton.Toolkit.KryptonTextBox txtconNo;
        private Krypton.Toolkit.KryptonLabel lblConNo;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePickerec;
        private Krypton.Toolkit.KryptonComboBox cbxdelisc;
    }
}