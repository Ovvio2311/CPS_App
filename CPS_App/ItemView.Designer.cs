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
            components = new System.ComponentModel.Container();
            dataGridViewitem = new KryptonDataGridView();
            comboBox1 = new KryptonComboBox();
            txtfield = new KryptonTextBox();
            btncreate = new KryptonButton();
            btnupdate = new KryptonButton();
            kryptonPalettebtn = new KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewitem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewitem
            // 
            dataGridViewitem.AllowUserToOrderColumns = true;
            dataGridViewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewitem.Location = new Point(55, 81);
            dataGridViewitem.Name = "dataGridViewitem";
            dataGridViewitem.RowTemplate.Height = 25;
            dataGridViewitem.Size = new Size(715, 351);
            dataGridViewitem.TabIndex = 0;
            dataGridViewitem.AllowUserToAddRows = false;
            dataGridViewitem.CellClick += dataGridViewitem_CellClick;
            // 
            // comboBox1
            // 
            comboBox1.CornerRoundingRadius = -1F;
            comboBox1.DropDownWidth = 121;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(55, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 21);
            comboBox1.TabIndex = 1;
            // 
            // txtfield
            // 
            txtfield.Location = new Point(182, 29);
            txtfield.Name = "txtfield";
            txtfield.Size = new Size(218, 23);
            txtfield.TabIndex = 2;
            // 
            // btncreate
            // 
            btncreate.CornerRoundingRadius = -1F;
            btncreate.Location = new Point(564, 28);
            btncreate.Name = "btncreate";
            btncreate.Palette = kryptonPalettebtn;
            btncreate.PaletteMode = PaletteMode.Custom;
            btncreate.Size = new Size(93, 36);
            btncreate.TabIndex = 3;
            btncreate.Values.Text = "Create";
            btncreate.Click += btncreate_Click;
            // 
            // btnupdate
            // 
            btnupdate.CornerRoundingRadius = -1F;
            btnupdate.Location = new Point(683, 28);
            btnupdate.Name = "btnupdate";
            btnupdate.Palette = kryptonPalettebtn;
            btnupdate.PaletteMode = PaletteMode.Custom;
            btnupdate.Size = new Size(87, 36);
            btnupdate.TabIndex = 4;
            btnupdate.Values.Text = "Update";
            btnupdate.Click += btnupdate_Click;
            // 
            // kryptonPalettebtn
            // 
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = Color.Transparent;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 5F;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = Color.SteelBlue;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = PaletteTextHint.SystemDefault;
            // 
            // ItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 532);
            Controls.Add(btnupdate);
            Controls.Add(btncreate);
            Controls.Add(txtfield);
            Controls.Add(comboBox1);
            Controls.Add(dataGridViewitem);
            Name = "ItemView";
            Text = "ItemView";
            Load += ItemView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewitem).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonDataGridView dataGridViewitem;
        private KryptonComboBox comboBox1;
        private KryptonTextBox txtfield;
        private KryptonButton btncreate;
        private KryptonButton btnupdate;
        private KryptonPalette kryptonPalettebtn;

    }
}