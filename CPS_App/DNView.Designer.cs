namespace CPS_App
{
    partial class DNView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(components);
            lblnoresult = new Krypton.Toolkit.KryptonLabel();
            btncancel = new Krypton.Toolkit.KryptonButton();
            btndn = new Krypton.Toolkit.KryptonButton();
            btnreceive = new Krypton.Toolkit.KryptonButton();
            datagridview = new Krypton.Toolkit.KryptonDataGridView();
            lbldnnote = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)datagridview).BeginInit();
            SuspendLayout();
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
            // kryptonPalettebtn
            // 
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = Color.Transparent;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 5F;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = Color.SteelBlue;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.SystemDefault;
            // 
            // kryptonPalettedatagridview
            // 
            kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // lblnoresult
            // 
            lblnoresult.Location = new Point(54, 72);
            lblnoresult.Name = "lblnoresult";
            lblnoresult.Size = new Size(64, 20);
            lblnoresult.TabIndex = 25;
            lblnoresult.Values.Text = "No Result";
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(639, 55);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btncancel.Size = new Size(96, 37);
            btncancel.TabIndex = 24;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // btndn
            // 
            btndn.CornerRoundingRadius = -1F;
            btndn.Location = new Point(461, 55);
            btndn.Name = "btndn";
            btndn.Palette = kryptonPalettebtn;
            btndn.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btndn.Size = new Size(151, 37);
            btndn.TabIndex = 23;
            btndn.Values.Text = "Add Delivery Note";
            // 
            // btnreceive
            // 
            btnreceive.AutoSize = true;
            btnreceive.CornerRoundingRadius = -1F;
            btnreceive.Location = new Point(319, 55);
            btnreceive.Name = "btnreceive";
            btnreceive.Palette = kryptonPalettebtn;
            btnreceive.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnreceive.Size = new Size(125, 37);
            btnreceive.TabIndex = 22;
            btnreceive.Values.Text = "Order Received";
            btnreceive.Click += btnreceive_Click;
            // 
            // datagridview
            // 
            datagridview.AllowUserToAddRows = false;
            datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview.Location = new Point(54, 108);
            datagridview.Name = "datagridview";
            datagridview.Palette = kryptonPalettedatagridview;
            datagridview.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            datagridview.ReadOnly = true;
            datagridview.RowTemplate.Height = 25;
            datagridview.Size = new Size(672, 225);
            datagridview.StateCommon.Background.Color1 = Color.White;
            datagridview.StateCommon.Background.Color2 = Color.White;
            datagridview.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            datagridview.TabIndex = 21;
            datagridview.CellClick += datagridview_CellClick;
            // 
            // lbldnnote
            // 
            lbldnnote.Location = new Point(54, 42);
            lbldnnote.Name = "lbldnnote";
            lbldnnote.Palette = kryptonPaletteheader;
            lbldnnote.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lbldnnote.Size = new Size(117, 23);
            lbldnnote.TabIndex = 20;
            lbldnnote.Values.Text = "Delivery Note";
            // 
            // DNView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblnoresult);
            Controls.Add(btncancel);
            Controls.Add(btndn);
            Controls.Add(btnreceive);
            Controls.Add(datagridview);
            Controls.Add(lbldnnote);
            Name = "DNView";
            Text = "DNView";
            Load += DNView_Load;
            ((System.ComponentModel.ISupportInitialize)datagridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalettelbl;
        private Krypton.Toolkit.KryptonPalette kryptonPaletteheader;
        private Krypton.Toolkit.KryptonPalette kryptonPalettereadonly;
        private Krypton.Toolkit.KryptonPalette kryptonPalettepanel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettebtn;
        private Krypton.Toolkit.KryptonPalette kryptonPalettedatagridview;
        private Krypton.Toolkit.KryptonLabel lblnoresult;
        private Krypton.Toolkit.KryptonButton btncancel;
        private Krypton.Toolkit.KryptonButton btndn;
        private Krypton.Toolkit.KryptonButton btnreceive;
        private Krypton.Toolkit.KryptonDataGridView datagridview;
        private Krypton.Toolkit.KryptonLabel lbldnnote;
    }
}