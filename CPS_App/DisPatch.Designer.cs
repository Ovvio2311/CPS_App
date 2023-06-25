namespace CPS_App
{
    partial class DisPatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lbldispatch = new Krypton.Toolkit.KryptonLabel();
            this.datagridview = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btnall = new Krypton.Toolkit.KryptonButton();
            this.btndn = new Krypton.Toolkit.KryptonButton();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.lblnoresult = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
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
            // lbldispatch
            // 
            this.lbldispatch.Location = new System.Drawing.Point(64, 47);
            this.lbldispatch.Name = "lbldispatch";
            this.lbldispatch.Palette = this.kryptonPaletteheader;
            this.lbldispatch.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lbldispatch.Size = new System.Drawing.Size(166, 23);
            this.lbldispatch.TabIndex = 11;
            this.lbldispatch.Values.Text = "Dispatch Instruction";
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(64, 113);
            this.datagridview.Name = "datagridview";
            this.datagridview.Palette = this.kryptonPalettedatagridview;
            this.datagridview.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.datagridview.ReadOnly = true;
            this.datagridview.RowTemplate.Height = 25;
            this.datagridview.Size = new System.Drawing.Size(672, 225);
            this.datagridview.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.datagridview.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.datagridview.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.datagridview.TabIndex = 12;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellClick);
            // 
            // kryptonPalettedatagridview
            // 
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // btnall
            // 
            this.btnall.CornerRoundingRadius = -1F;
            this.btnall.Location = new System.Drawing.Point(329, 60);
            this.btnall.Name = "btnall";
            this.btnall.Palette = this.kryptonPalettebtn;
            this.btnall.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnall.Size = new System.Drawing.Size(96, 37);
            this.btnall.TabIndex = 13;
            this.btnall.Values.Text = "Add All";
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btndn
            // 
            this.btndn.CornerRoundingRadius = -1F;
            this.btndn.Location = new System.Drawing.Point(471, 60);
            this.btndn.Name = "btndn";
            this.btndn.Palette = this.kryptonPalettebtn;
            this.btndn.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btndn.Size = new System.Drawing.Size(151, 37);
            this.btndn.TabIndex = 14;
            this.btndn.Values.Text = "Add Delivery Note";
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(649, 60);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(96, 37);
            this.btncancel.TabIndex = 15;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lblnoresult
            // 
            this.lblnoresult.Location = new System.Drawing.Point(64, 77);
            this.lblnoresult.Name = "lblnoresult";
            this.lblnoresult.Size = new System.Drawing.Size(64, 20);
            this.lblnoresult.TabIndex = 19;
            this.lblnoresult.Values.Text = "No Result";
            // 
            // DisPatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnoresult);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.btnall);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.lbldispatch);
            this.Name = "DisPatch";
            this.Text = "DisPatch";
            this.Load += new System.EventHandler(this.DisPatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalettelbl;
        private Krypton.Toolkit.KryptonPalette kryptonPaletteheader;
        private Krypton.Toolkit.KryptonPalette kryptonPalettereadonly;
        private Krypton.Toolkit.KryptonPalette kryptonPalettepanel;
        private Krypton.Toolkit.KryptonPalette kryptonPalettebtn;
        private Krypton.Toolkit.KryptonLabel lbldispatch;
        private Krypton.Toolkit.KryptonDataGridView datagridview;
        private Krypton.Toolkit.KryptonButton btnall;
        private Krypton.Toolkit.KryptonButton btndn;
        private Krypton.Toolkit.KryptonButton btncancel;
        private Krypton.Toolkit.KryptonLabel lblnoresult;
        private Krypton.Toolkit.KryptonPalette kryptonPalettedatagridview;
    }
}