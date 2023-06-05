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
            this.components = new System.ComponentModel.Container();
            this.kryptonDataGridViewpoa = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonDataGridViewitem = new Krypton.Toolkit.KryptonDataGridView();
            this.btnedit = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btnadd = new Krypton.Toolkit.KryptonButton();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewpoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridViewpoa
            // 
            this.kryptonDataGridViewpoa.AllowUserToAddRows = false;
            this.kryptonDataGridViewpoa.Location = new System.Drawing.Point(72, 97);
            this.kryptonDataGridViewpoa.Name = "kryptonDataGridViewpoa";
            this.kryptonDataGridViewpoa.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewpoa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewpoa.RowTemplate.Height = 25;
            this.kryptonDataGridViewpoa.Size = new System.Drawing.Size(647, 221);
            this.kryptonDataGridViewpoa.TabIndex = 0;
            this.kryptonDataGridViewpoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridViewpoa_CellClick);
            // 
            // kryptonDataGridViewitem
            // 
            this.kryptonDataGridViewitem.AllowUserToAddRows = false;
            this.kryptonDataGridViewitem.Location = new System.Drawing.Point(72, 365);
            this.kryptonDataGridViewitem.Name = "kryptonDataGridViewitem";
            this.kryptonDataGridViewitem.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewitem.RowTemplate.Height = 25;
            this.kryptonDataGridViewitem.Size = new System.Drawing.Size(647, 164);
            this.kryptonDataGridViewitem.TabIndex = 1;
            // 
            // btnedit
            // 
            this.btnedit.CornerRoundingRadius = -1F;
            this.btnedit.Location = new System.Drawing.Point(190, 56);
            this.btnedit.Name = "btnedit";
            this.btnedit.Palette = this.kryptonPalettebtn;
            this.btnedit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnedit.Size = new System.Drawing.Size(100, 35);
            this.btnedit.TabIndex = 2;
            this.btnedit.Values.Text = "Update";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // kryptonPalettebtn
            // 
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 5F;
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.SystemDefault;
            // 
            // kryptonPalettelbl
            // 
            this.kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // kryptonPaletteheader
            // 
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkCyan;
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // kryptonPalettereadonly
            // 
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPalettereadonly.Common.StateCommon.Back.Color2 = System.Drawing.SystemColors.Control;
            // 
            // kryptonPalettepanel
            // 
            this.kryptonPalettepanel.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettepanel.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // btnadd
            // 
            this.btnadd.CornerRoundingRadius = -1F;
            this.btnadd.Location = new System.Drawing.Point(72, 56);
            this.btnadd.Name = "btnadd";
            this.btnadd.Palette = this.kryptonPalettebtn;
            this.btnadd.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnadd.Size = new System.Drawing.Size(100, 35);
            this.btnadd.TabIndex = 25;
            this.btnadd.Values.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(619, 56);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(100, 35);
            this.btncancel.TabIndex = 27;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // kryptonPalettedatagridview
            // 
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // POAView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 638);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.kryptonDataGridViewitem);
            this.Controls.Add(this.kryptonDataGridViewpoa);
            this.Name = "POAView";
            this.Text = "POAView";
            this.Load += new System.EventHandler(this.POAView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewpoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewpoa;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewitem;
        private Krypton.Toolkit.KryptonButton btnedit;
        private Krypton.Toolkit.KryptonPalette kryptonPalettelbl;
        private Krypton.Toolkit.KryptonPalette kryptonPaletteheader;
        private Krypton.Toolkit.KryptonPalette kryptonPalettereadonly;
        private Krypton.Toolkit.KryptonPalette kryptonPalettepanel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettebtn;
        private Krypton.Toolkit.KryptonButton btnadd;
        private Krypton.Toolkit.KryptonButton btncancel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettedatagridview;
    }
}