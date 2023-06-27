namespace CPS_App
{
    partial class SchReleaseConfirm
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
            kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(components);
            lblreleasecon = new Krypton.Toolkit.KryptonLabel();
            lblnoresult = new Krypton.Toolkit.KryptonLabel();
            datagridview = new Krypton.Toolkit.KryptonDataGridView();
            btnreject = new Krypton.Toolkit.KryptonButton();
            btnconfirm = new Krypton.Toolkit.KryptonButton();
            btncancel = new Krypton.Toolkit.KryptonButton();
            datagridviewitem = new Krypton.Toolkit.KryptonDataGridView();
            lblitem = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)datagridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).BeginInit();
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
            // lblreleasecon
            // 
            lblreleasecon.Location = new Point(32, 43);
            lblreleasecon.Name = "lblreleasecon";
            lblreleasecon.Palette = kryptonPaletteheader;
            lblreleasecon.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblreleasecon.Size = new Size(212, 23);
            lblreleasecon.TabIndex = 11;
            lblreleasecon.Values.Text = "Schedule Release Confirm";
            // 
            // lblnoresult
            // 
            lblnoresult.Location = new Point(41, 72);
            lblnoresult.Name = "lblnoresult";
            lblnoresult.Size = new Size(61, 20);
            lblnoresult.TabIndex = 19;
            lblnoresult.Values.Text = "No result";
            // 
            // datagridview
            // 
            datagridview.AllowUserToAddRows = false;
            datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview.Location = new Point(64, 113);
            datagridview.Name = "datagridview";
            datagridview.ReadOnly = true;
            datagridview.RowTemplate.Height = 25;
            datagridview.Size = new Size(672, 86);
            datagridview.StateCommon.Background.Color1 = Color.White;
            datagridview.StateCommon.Background.Color2 = Color.White;
            datagridview.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            datagridview.TabIndex = 20;
            datagridview.CellClick += datagridview_CellClick;
            // 
            // btnreject
            // 
            btnreject.CornerRoundingRadius = -1F;
            btnreject.Location = new Point(517, 43);
            btnreject.Name = "btnreject";
            btnreject.Palette = kryptonPalettebtn;
            btnreject.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnreject.Size = new Size(96, 37);
            btnreject.TabIndex = 22;
            btnreject.Values.Text = "Reject";
            btnreject.Click += btnreject_Click;
            // 
            // btnconfirm
            // 
            btnconfirm.CornerRoundingRadius = -1F;
            btnconfirm.Location = new Point(393, 43);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Palette = kryptonPalettebtn;
            btnconfirm.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnconfirm.Size = new Size(96, 37);
            btnconfirm.TabIndex = 21;
            btnconfirm.Values.Text = "Confirm";
            btnconfirm.Click += btnconfirm_Click;
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(640, 43);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btncancel.Size = new Size(96, 37);
            btncancel.TabIndex = 23;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // datagridviewitem
            // 
            datagridviewitem.AllowUserToAddRows = false;
            datagridviewitem.AllowUserToOrderColumns = true;
            datagridviewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewitem.Location = new Point(64, 263);
            datagridviewitem.Name = "datagridviewitem";
            datagridviewitem.ReadOnly = true;
            datagridviewitem.RowTemplate.Height = 25;
            datagridviewitem.Size = new Size(672, 161);
            datagridviewitem.StateCommon.Background.Color1 = Color.White;
            datagridviewitem.StateCommon.Background.Color2 = Color.Black;
            datagridviewitem.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            datagridviewitem.TabIndex = 24;
            // 
            // lblitem
            // 
            lblitem.Location = new Point(32, 223);
            lblitem.Name = "lblitem";
            lblitem.Palette = kryptonPaletteheader;
            lblitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblitem.Size = new Size(79, 23);
            lblitem.TabIndex = 25;
            lblitem.Values.Text = "Item List";
            // 
            // SchReleaseConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblitem);
            Controls.Add(datagridviewitem);
            Controls.Add(btncancel);
            Controls.Add(btnreject);
            Controls.Add(btnconfirm);
            Controls.Add(datagridview);
            Controls.Add(lblnoresult);
            Controls.Add(lblreleasecon);
            Name = "SchReleaseConfirm";
            Text = "SchReleaseConfirm";
            Load += SchReleaseConfirm_Load;
            ((System.ComponentModel.ISupportInitialize)datagridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalettelbl;
        private Krypton.Toolkit.KryptonPalette kryptonPaletteheader;
        private Krypton.Toolkit.KryptonPalette kryptonPalettereadonly;
        private Krypton.Toolkit.KryptonPalette kryptonPalettepanel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettebtn;
        private Krypton.Toolkit.KryptonLabel lblreleasecon;
        private Krypton.Toolkit.KryptonLabel lblnoresult;
        private Krypton.Toolkit.KryptonDataGridView datagridview;
        private Krypton.Toolkit.KryptonButton btnreject;
        private Krypton.Toolkit.KryptonButton btnconfirm;
        private Krypton.Toolkit.KryptonButton btncancel;
        private Krypton.Toolkit.KryptonDataGridView datagridviewitem;
        private Krypton.Toolkit.KryptonLabel lblitem;
    }
}