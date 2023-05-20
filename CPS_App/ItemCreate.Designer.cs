namespace CPS_App
{
    partial class ItemCreate
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
            this.lblcrcat = new System.Windows.Forms.Label();
            this.pncat = new System.Windows.Forms.Panel();
            this.btncatclear = new System.Windows.Forms.Button();
            this.btncatsb = new System.Windows.Forms.Button();
            this.txtcatname = new System.Windows.Forms.TextBox();
            this.lblcatname = new System.Windows.Forms.Label();
            this.txtitname = new System.Windows.Forms.TextBox();
            this.lblcrit = new System.Windows.Forms.Label();
            this.lblitname = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.lblloc = new System.Windows.Forms.Label();
            this.lblvid = new System.Windows.Forms.Label();
            this.lbluom = new System.Windows.Forms.Label();
            this.txtcat = new System.Windows.Forms.TextBox();
            this.txtloc = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtuom = new System.Windows.Forms.TextBox();
            this.pnit = new System.Windows.Forms.Panel();
            this.btnitsb = new System.Windows.Forms.Button();
            this.btnitcr = new System.Windows.Forms.Button();
            this.pncat.SuspendLayout();
            this.pnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcrcat
            // 
            this.lblcrcat.AutoSize = true;
            this.lblcrcat.Location = new System.Drawing.Point(41, 54);
            this.lblcrcat.Name = "lblcrcat";
            this.lblcrcat.Size = new System.Drawing.Size(92, 15);
            this.lblcrcat.TabIndex = 0;
            this.lblcrcat.Text = "Create Category";
            // 
            // pncat
            // 
            this.pncat.Controls.Add(this.btncatclear);
            this.pncat.Controls.Add(this.btncatsb);
            this.pncat.Controls.Add(this.txtcatname);
            this.pncat.Controls.Add(this.lblcatname);
            this.pncat.Controls.Add(this.lblcrcat);
            this.pncat.Location = new System.Drawing.Point(2, 0);
            this.pncat.Name = "pncat";
            this.pncat.Size = new System.Drawing.Size(300, 448);
            this.pncat.TabIndex = 1;
            // 
            // btncatclear
            // 
            this.btncatclear.Location = new System.Drawing.Point(41, 305);
            this.btncatclear.Name = "btncatclear";
            this.btncatclear.Size = new System.Drawing.Size(87, 45);
            this.btncatclear.TabIndex = 4;
            this.btncatclear.Text = "Clear";
            this.btncatclear.UseVisualStyleBackColor = true;
            // 
            // btncatsb
            // 
            this.btncatsb.Location = new System.Drawing.Point(159, 305);
            this.btncatsb.Name = "btncatsb";
            this.btncatsb.Size = new System.Drawing.Size(88, 45);
            this.btncatsb.TabIndex = 3;
            this.btncatsb.Text = "Submit";
            this.btncatsb.UseVisualStyleBackColor = true;
            this.btncatsb.Click += new System.EventHandler(this.btncatsb_Click);
            // 
            // txtcatname
            // 
            this.txtcatname.Location = new System.Drawing.Point(86, 120);
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.Size = new System.Drawing.Size(100, 23);
            this.txtcatname.TabIndex = 2;
            this.txtcatname.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // lblcatname
            // 
            this.lblcatname.AutoSize = true;
            this.lblcatname.Location = new System.Drawing.Point(41, 123);
            this.lblcatname.Name = "lblcatname";
            this.lblcatname.Size = new System.Drawing.Size(39, 15);
            this.lblcatname.TabIndex = 1;
            this.lblcatname.Text = "Name";
            this.lblcatname.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtitname
            // 
            this.txtitname.Location = new System.Drawing.Point(436, 123);
            this.txtitname.Name = "txtitname";
            this.txtitname.Size = new System.Drawing.Size(144, 23);
            this.txtitname.TabIndex = 2;
            this.txtitname.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // lblcrit
            // 
            this.lblcrit.AutoSize = true;
            this.lblcrit.Location = new System.Drawing.Point(377, 54);
            this.lblcrit.Name = "lblcrit";
            this.lblcrit.Size = new System.Drawing.Size(68, 15);
            this.lblcrit.TabIndex = 3;
            this.lblcrit.Text = "Create Item";
            // 
            // lblitname
            // 
            this.lblitname.AutoSize = true;
            this.lblitname.Location = new System.Drawing.Point(391, 126);
            this.lblitname.Name = "lblitname";
            this.lblitname.Size = new System.Drawing.Size(39, 15);
            this.lblitname.TabIndex = 4;
            this.lblitname.Text = "Name";
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Location = new System.Drawing.Point(375, 177);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(55, 15);
            this.lblcat.TabIndex = 5;
            this.lblcat.Text = "Category";
            // 
            // lblloc
            // 
            this.lblloc.AutoSize = true;
            this.lblloc.Location = new System.Drawing.Point(377, 236);
            this.lblloc.Name = "lblloc";
            this.lblloc.Size = new System.Drawing.Size(53, 15);
            this.lblloc.TabIndex = 6;
            this.lblloc.Text = "Location";
            // 
            // lblvid
            // 
            this.lblvid.AutoSize = true;
            this.lblvid.Location = new System.Drawing.Point(377, 282);
            this.lblvid.Name = "lblvid";
            this.lblvid.Size = new System.Drawing.Size(25, 15);
            this.lblvid.TabIndex = 7;
            this.lblvid.Text = "VID";
            // 
            // lbluom
            // 
            this.lbluom.AutoSize = true;
            this.lbluom.Location = new System.Drawing.Point(311, 330);
            this.lbluom.Name = "lbluom";
            this.lbluom.Size = new System.Drawing.Size(119, 15);
            this.lbluom.TabIndex = 8;
            this.lbluom.Text = "Unit of Measurement";
            // 
            // txtcat
            // 
            this.txtcat.Location = new System.Drawing.Point(436, 174);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(144, 23);
            this.txtcat.TabIndex = 9;
            this.txtcat.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtloc
            // 
            this.txtloc.Location = new System.Drawing.Point(436, 233);
            this.txtloc.Name = "txtloc";
            this.txtloc.Size = new System.Drawing.Size(144, 23);
            this.txtloc.TabIndex = 10;
            this.txtloc.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(436, 279);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(144, 23);
            this.txtqty.TabIndex = 11;
            this.txtqty.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // txtuom
            // 
            this.txtuom.Location = new System.Drawing.Point(436, 327);
            this.txtuom.Name = "txtuom";
            this.txtuom.Size = new System.Drawing.Size(144, 23);
            this.txtuom.TabIndex = 12;
            this.txtuom.Validating += new System.ComponentModel.CancelEventHandler(this.requiredFieldCheck);
            // 
            // pnit
            // 
            this.pnit.Controls.Add(this.btnitsb);
            this.pnit.Controls.Add(this.btnitcr);
            this.pnit.Location = new System.Drawing.Point(308, 0);
            this.pnit.Name = "pnit";
            this.pnit.Size = new System.Drawing.Size(440, 448);
            this.pnit.TabIndex = 13;
            this.pnit.Paint += new System.Windows.Forms.PaintEventHandler(this.pnit_Paint);
            // 
            // btnitsb
            // 
            this.btnitsb.Location = new System.Drawing.Point(226, 390);
            this.btnitsb.Name = "btnitsb";
            this.btnitsb.Size = new System.Drawing.Size(94, 48);
            this.btnitsb.TabIndex = 1;
            this.btnitsb.Text = "Submit";
            this.btnitsb.UseVisualStyleBackColor = true;
            this.btnitsb.Click += new System.EventHandler(this.btnitsb_Click);
            // 
            // btnitcr
            // 
            this.btnitcr.Location = new System.Drawing.Point(83, 390);
            this.btnitcr.Name = "btnitcr";
            this.btnitcr.Size = new System.Drawing.Size(94, 48);
            this.btnitcr.TabIndex = 0;
            this.btnitcr.Text = "Clear";
            this.btnitcr.UseVisualStyleBackColor = true;
            // 
            // ItemCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtuom);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtloc);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.lbluom);
            this.Controls.Add(this.lblvid);
            this.Controls.Add(this.lblloc);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lblitname);
            this.Controls.Add(this.lblcrit);
            this.Controls.Add(this.txtitname);
            this.Controls.Add(this.pncat);
            this.Controls.Add(this.pnit);
            this.Name = "ItemCreate";
            this.Text = "ItemCreate";
            this.Load += new System.EventHandler(this.ItemCreate_Load);
            this.pncat.ResumeLayout(false);
            this.pncat.PerformLayout();
            this.pnit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblcrcat;
        private Panel pncat;
        private TextBox txtcatname;
        private Label lblcatname;
        private TextBox txtitname;
        private Label lblcrit;
        private Label lblitname;
        private Label lblcat;
        private Label lblloc;
        private Label lblvid;
        private Label lbluom;
        private TextBox txtcat;
        private TextBox txtloc;
        private TextBox txtqty;
        private TextBox txtuom;
        private Panel pnit;
        private Button btncatclear;
        private Button btncatsb;
        private Button btnitsb;
        private Button btnitcr;
    }
}