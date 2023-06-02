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
            components = new System.ComponentModel.Container();
            kryptonDataGridViewpoa = new Krypton.Toolkit.KryptonDataGridView();
            kryptonDataGridViewitem = new Krypton.Toolkit.KryptonDataGridView();
            btnedit = new Krypton.Toolkit.KryptonButton();
            kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(components);
            btnadd = new Krypton.Toolkit.KryptonButton();
            btncancel = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewitem).BeginInit();
            SuspendLayout();
            // 
            // kryptonDataGridViewpoa
            // 
            kryptonDataGridViewpoa.AllowUserToAddRows = false;
            kryptonDataGridViewpoa.Location = new Point(72, 97);
            kryptonDataGridViewpoa.Name = "kryptonDataGridViewpoa";
            kryptonDataGridViewpoa.RowTemplate.Height = 25;
            kryptonDataGridViewpoa.Size = new Size(647, 221);
            kryptonDataGridViewpoa.TabIndex = 0;
            kryptonDataGridViewpoa.CellClick += kryptonDataGridViewpoa_CellClick;
            // 
            // kryptonDataGridViewitem
            // 
            kryptonDataGridViewitem.AllowUserToAddRows = false;
            kryptonDataGridViewitem.Location = new Point(72, 365);
            kryptonDataGridViewitem.Name = "kryptonDataGridViewitem";
            kryptonDataGridViewitem.RowTemplate.Height = 25;
            kryptonDataGridViewitem.Size = new Size(647, 164);
            kryptonDataGridViewitem.TabIndex = 1;
            // 
            // btnedit
            // 
            btnedit.CornerRoundingRadius = -1F;
            btnedit.Location = new Point(190, 56);
            btnedit.Name = "btnedit";
            btnedit.Palette = kryptonPalettebtn;
            btnedit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnedit.Size = new Size(100, 35);
            btnedit.TabIndex = 2;
            btnedit.Values.Text = "Edit";
            btnedit.Click += btnedit_Click;
            // 
            // kryptonPalettebtn
            // 
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = Color.Transparent;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 5F;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = Color.SteelBlue;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.SystemDefault;
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // kryptonPaletteheader
            // 
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = Color.DarkCyan;
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // kryptonPalettereadonly
            // 
            kryptonPalettereadonly.Common.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonPalettereadonly.Common.StateCommon.Back.Color2 = SystemColors.Control;
            // 
            // kryptonPalettepanel
            // 
            kryptonPalettepanel.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettepanel.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // btnadd
            // 
            btnadd.CornerRoundingRadius = -1F;
            btnadd.Location = new Point(72, 56);
            btnadd.Name = "btnadd";
            btnadd.Palette = kryptonPalettebtn;
            btnadd.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnadd.Size = new Size(100, 35);
            btnadd.TabIndex = 25;
            btnadd.Values.Text = "Add";
            btnadd.Click += btnadd_Click;
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(619, 56);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btncancel.Size = new Size(100, 35);
            btncancel.TabIndex = 27;
            btncancel.Values.Text = "Cancel";
            // 
            // POAView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 638);
            Controls.Add(btncancel);
            Controls.Add(btnadd);
            Controls.Add(btnedit);
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
        private Krypton.Toolkit.KryptonButton btnedit;
        private Krypton.Toolkit.KryptonPalette kryptonPalettelbl;
        private Krypton.Toolkit.KryptonPalette kryptonPaletteheader;
        private Krypton.Toolkit.KryptonPalette kryptonPalettereadonly;
        private Krypton.Toolkit.KryptonPalette kryptonPalettepanel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettebtn;
        private Krypton.Toolkit.KryptonButton btnadd;
        private Krypton.Toolkit.KryptonButton btncancel;
    }
}