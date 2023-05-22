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
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewitem).BeginInit();
            SuspendLayout();
            // 
            // kryptonDataGridViewpoa
            // 
            kryptonDataGridViewpoa.Location = new Point(72, 48);
            kryptonDataGridViewpoa.Name = "kryptonDataGridViewpoa";
            kryptonDataGridViewpoa.RowTemplate.Height = 25;
            kryptonDataGridViewpoa.Size = new Size(647, 221);
            kryptonDataGridViewpoa.TabIndex = 0;
            kryptonDataGridViewpoa.CellClick += kryptonDataGridViewpoa_CellClick;
            // 
            // kryptonDataGridViewitem
            // 
            kryptonDataGridViewitem.Location = new Point(72, 306);
            kryptonDataGridViewitem.Name = "kryptonDataGridViewitem";
            kryptonDataGridViewitem.RowTemplate.Height = 25;
            kryptonDataGridViewitem.Size = new Size(647, 164);
            kryptonDataGridViewitem.TabIndex = 1;
            // 
            // POAView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 541);
            Controls.Add(kryptonDataGridViewitem);
            Controls.Add(kryptonDataGridViewpoa);
            Name = "POAView";
            Text = "POAView";
            Load += POAView_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewitem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewpoa;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewitem;
    }
}