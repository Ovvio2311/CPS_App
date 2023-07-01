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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettereadonly = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblnoresult = new Krypton.Toolkit.KryptonLabel();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.btnreceive = new Krypton.Toolkit.KryptonButton();
            this.datagridview = new Krypton.Toolkit.KryptonDataGridView();
            this.lbldnnote = new Krypton.Toolkit.KryptonLabel();
            this.btncsv = new Krypton.Toolkit.KryptonButton();
            this.kryptonPaletteCsv = new Krypton.Toolkit.KryptonPalette(this.components);
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
            // kryptonPalettedatagridview
            // 
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // lblnoresult
            // 
            this.lblnoresult.Location = new System.Drawing.Point(54, 72);
            this.lblnoresult.Name = "lblnoresult";
            this.lblnoresult.Size = new System.Drawing.Size(64, 20);
            this.lblnoresult.TabIndex = 25;
            this.lblnoresult.Values.Text = "No Result";
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(523, 55);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(96, 37);
            this.btncancel.TabIndex = 24;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnreceive
            // 
            this.btnreceive.AutoSize = true;
            this.btnreceive.CornerRoundingRadius = -1F;
            this.btnreceive.Location = new System.Drawing.Point(347, 55);
            this.btnreceive.Name = "btnreceive";
            this.btnreceive.Palette = this.kryptonPalettebtn;
            this.btnreceive.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnreceive.Size = new System.Drawing.Size(125, 37);
            this.btnreceive.TabIndex = 22;
            this.btnreceive.Values.Text = "Order Received";
            this.btnreceive.Click += new System.EventHandler(this.btnreceive_Click);
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(54, 108);
            this.datagridview.Name = "datagridview";
            this.datagridview.Palette = this.kryptonPalettedatagridview;
            this.datagridview.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.datagridview.ReadOnly = true;
            this.datagridview.RowTemplate.Height = 25;
            this.datagridview.Size = new System.Drawing.Size(672, 225);
            this.datagridview.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.datagridview.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.datagridview.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.datagridview.TabIndex = 21;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellClick);
            // 
            // lbldnnote
            // 
            this.lbldnnote.Location = new System.Drawing.Point(54, 42);
            this.lbldnnote.Name = "lbldnnote";
            this.lbldnnote.Palette = this.kryptonPaletteheader;
            this.lbldnnote.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lbldnnote.Size = new System.Drawing.Size(117, 23);
            this.lbldnnote.TabIndex = 20;
            this.lbldnnote.Values.Text = "Delivery Note";
            // 
            // btncsv
            // 
            this.btncsv.CornerRoundingRadius = -1F;
            this.btncsv.Location = new System.Drawing.Point(661, 55);
            this.btncsv.Name = "btncsv";
            this.btncsv.Palette = this.kryptonPalettebtn;
            this.btncsv.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncsv.Size = new System.Drawing.Size(65, 37);
            this.btncsv.TabIndex = 26;
            this.btncsv.Values.Text = "CSV";
            this.btncsv.Click += new System.EventHandler(this.btncsv_Click);
            // 
            // kryptonPaletteCsv
            // 
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.PaleTurquoise;
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.PaleTurquoise;
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 5F;
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPaletteCsv.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.SystemDefault;
            // 
            // DNView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncsv);
            this.Controls.Add(this.lblnoresult);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnreceive);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.lbldnnote);
            this.Name = "DNView";
            this.Text = "DNView";
            this.Load += new System.EventHandler(this.DNView_Load);
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
        private Krypton.Toolkit.KryptonPalette kryptonPalettedatagridview;
        private Krypton.Toolkit.KryptonLabel lblnoresult;
        private Krypton.Toolkit.KryptonButton btncancel;
        private Krypton.Toolkit.KryptonButton btnreceive;
        private Krypton.Toolkit.KryptonDataGridView datagridview;
        private Krypton.Toolkit.KryptonLabel lbldnnote;
        private Krypton.Toolkit.KryptonButton btncsv;
        private Krypton.Toolkit.KryptonPalette kryptonPaletteCsv;
    }
}