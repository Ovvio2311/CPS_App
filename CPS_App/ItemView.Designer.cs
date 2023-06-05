using Krypton.Toolkit;

namespace CPS_App
{
    partial class ItemView
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
            this.dataGridViewitem = new Krypton.Toolkit.KryptonDataGridView();
            this.comboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.txtfield = new Krypton.Toolkit.KryptonTextBox();
            this.btncreate = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btnupdate = new Krypton.Toolkit.KryptonButton();
            this.lblnoresult = new Krypton.Toolkit.KryptonLabel();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewitem
            // 
            this.dataGridViewitem.AllowUserToAddRows = false;
            this.dataGridViewitem.AllowUserToOrderColumns = true;
            this.dataGridViewitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewitem.Location = new System.Drawing.Point(55, 81);
            this.dataGridViewitem.Name = "dataGridViewitem";
            this.dataGridViewitem.Palette = this.kryptonPalettedatagridview;
            this.dataGridViewitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dataGridViewitem.RowTemplate.Height = 25;
            this.dataGridViewitem.Size = new System.Drawing.Size(715, 351);
            this.dataGridViewitem.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.dataGridViewitem.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.dataGridViewitem.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewitem.TabIndex = 0;
            this.dataGridViewitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewitem_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.CornerRoundingRadius = -1F;
            this.comboBox1.DropDownWidth = 121;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(55, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // txtfield
            // 
            this.txtfield.Location = new System.Drawing.Point(182, 29);
            this.txtfield.Name = "txtfield";
            this.txtfield.Size = new System.Drawing.Size(218, 23);
            this.txtfield.TabIndex = 2;
            // 
            // btncreate
            // 
            this.btncreate.CornerRoundingRadius = -1F;
            this.btncreate.Location = new System.Drawing.Point(470, 28);
            this.btncreate.Name = "btncreate";
            this.btncreate.Palette = this.kryptonPalettebtn;
            this.btncreate.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncreate.Size = new System.Drawing.Size(93, 36);
            this.btncreate.TabIndex = 3;
            this.btncreate.Values.Text = "Create";
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
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
            // btnupdate
            // 
            this.btnupdate.CornerRoundingRadius = -1F;
            this.btnupdate.Location = new System.Drawing.Point(601, 28);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Palette = this.kryptonPalettebtn;
            this.btnupdate.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnupdate.Size = new System.Drawing.Size(87, 36);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Values.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblnoresult
            // 
            this.lblnoresult.Location = new System.Drawing.Point(55, 55);
            this.lblnoresult.Name = "lblnoresult";
            this.lblnoresult.Size = new System.Drawing.Size(64, 20);
            this.lblnoresult.TabIndex = 19;
            this.lblnoresult.Values.Text = "No Result";
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(728, 28);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(87, 36);
            this.btncancel.TabIndex = 20;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // kryptonPalettedatagridview
            // 
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 532);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblnoresult);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtfield);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridViewitem);
            this.Name = "ItemView";
            this.Text = "ItemView";
            this.Load += new System.EventHandler(this.ItemView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonDataGridView dataGridViewitem;
        private KryptonComboBox comboBox1;
        private KryptonTextBox txtfield;
        private KryptonButton btncreate;
        private KryptonButton btnupdate;
        private KryptonPalette kryptonPalettebtn;
        private KryptonLabel lblnoresult;
        private KryptonButton btncancel;
        private KryptonPalette kryptonPalettedatagridview;
    }
}