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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemView));
            dataGridViewitem = new KryptonDataGridView();
            kryptonPalettedatagridview = new KryptonPalette(components);
            btncreate = new KryptonButton();
            kryptonPalettebtn = new KryptonPalette(components);
            btnupdate = new KryptonButton();
            lblnoresult = new KryptonLabel();
            btncancel = new KryptonButton();
            kryptonDataGridViewsubitem = new KryptonDataGridView();
            lblsubitemtitle = new KryptonLabel();
            kryptonPaletteheader = new KryptonPalette(components);
            lbltitle = new KryptonLabel();
            pnsearch1 = new KryptonPanel();
            txtsearch1 = new KryptonTextBox();
            cbxsearch1 = new KryptonComboBox();
            kryptonPalettepanel = new KryptonPalette(components);
            pnsearch2 = new KryptonPanel();
            cbxsearch2 = new KryptonComboBox();
            txtsearch2 = new KryptonTextBox();
            btnsearch = new KryptonButton();
            lblsearch = new KryptonLabel();
            kryptonPalettelbl = new KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewitem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewsubitem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch1).BeginInit();
            pnsearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsearch1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch2).BeginInit();
            pnsearch2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsearch2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewitem
            // 
            dataGridViewitem.AllowUserToAddRows = false;
            dataGridViewitem.AllowUserToOrderColumns = true;
            dataGridViewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewitem.Location = new Point(35, 116);
            dataGridViewitem.Name = "dataGridViewitem";
            dataGridViewitem.Palette = kryptonPalettedatagridview;
            dataGridViewitem.PaletteMode = PaletteMode.Custom;
            dataGridViewitem.RowTemplate.Height = 25;
            dataGridViewitem.Size = new Size(715, 238);
            dataGridViewitem.StateCommon.Background.Color1 = Color.Transparent;
            dataGridViewitem.StateCommon.Background.Color2 = Color.Transparent;
            dataGridViewitem.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            dataGridViewitem.TabIndex = 0;
            dataGridViewitem.CellClick += dataGridViewitem_CellClick;
            // 
            // kryptonPalettedatagridview
            // 
            kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // btncreate
            // 
            btncreate.CornerRoundingRadius = -1F;
            btncreate.Location = new Point(452, 68);
            btncreate.Name = "btncreate";
            btncreate.Palette = kryptonPalettebtn;
            btncreate.PaletteMode = PaletteMode.Custom;
            btncreate.Size = new Size(93, 36);
            btncreate.TabIndex = 3;
            btncreate.Values.Text = "Create";
            btncreate.Click += btncreate_Click;
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
            // btnupdate
            // 
            btnupdate.CornerRoundingRadius = -1F;
            btnupdate.Location = new Point(586, 68);
            btnupdate.Name = "btnupdate";
            btnupdate.Palette = kryptonPalettebtn;
            btnupdate.PaletteMode = PaletteMode.Custom;
            btnupdate.Size = new Size(87, 36);
            btnupdate.TabIndex = 4;
            btnupdate.Values.Text = "Update";
            btnupdate.Click += btnupdate_Click;
            // 
            // lblnoresult
            // 
            lblnoresult.Location = new Point(35, 97);
            lblnoresult.Name = "lblnoresult";
            lblnoresult.Size = new Size(64, 20);
            lblnoresult.TabIndex = 19;
            lblnoresult.Values.Text = "No Result";
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(704, 68);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = PaletteMode.Custom;
            btncancel.Size = new Size(87, 36);
            btncancel.TabIndex = 20;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // kryptonDataGridViewsubitem
            // 
            kryptonDataGridViewsubitem.AllowUserToAddRows = false;
            kryptonDataGridViewsubitem.AllowUserToOrderColumns = true;
            kryptonDataGridViewsubitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridViewsubitem.Location = new Point(35, 400);
            kryptonDataGridViewsubitem.Name = "kryptonDataGridViewsubitem";
            kryptonDataGridViewsubitem.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewsubitem.PaletteMode = PaletteMode.Custom;
            kryptonDataGridViewsubitem.ReadOnly = true;
            kryptonDataGridViewsubitem.RowTemplate.Height = 25;
            kryptonDataGridViewsubitem.Size = new Size(715, 227);
            kryptonDataGridViewsubitem.StateCommon.Background.Color1 = Color.Transparent;
            kryptonDataGridViewsubitem.StateCommon.Background.Color2 = Color.Transparent;
            kryptonDataGridViewsubitem.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            kryptonDataGridViewsubitem.TabIndex = 21;
            // 
            // lblsubitemtitle
            // 
            lblsubitemtitle.Location = new Point(35, 371);
            lblsubitemtitle.Name = "lblsubitemtitle";
            lblsubitemtitle.Palette = kryptonPaletteheader;
            lblsubitemtitle.PaletteMode = PaletteMode.Custom;
            lblsubitemtitle.Size = new Size(79, 23);
            lblsubitemtitle.TabIndex = 22;
            lblsubitemtitle.Values.Text = "Sub Item";
            // 
            // kryptonPaletteheader
            // 
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = Color.DarkCyan;
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // lbltitle
            // 
            lbltitle.Location = new Point(35, 68);
            lbltitle.Name = "lbltitle";
            lbltitle.Palette = kryptonPaletteheader;
            lbltitle.PaletteMode = PaletteMode.Custom;
            lbltitle.Size = new Size(47, 23);
            lbltitle.TabIndex = 23;
            lbltitle.Values.Text = "Item";
            // 
            // pnsearch1
            // 
            pnsearch1.Controls.Add(txtsearch1);
            pnsearch1.Controls.Add(cbxsearch1);
            pnsearch1.Location = new Point(101, 29);
            pnsearch1.Name = "pnsearch1";
            pnsearch1.Palette = kryptonPalettepanel;
            pnsearch1.PaletteMode = PaletteMode.Custom;
            pnsearch1.Size = new Size(261, 28);
            pnsearch1.TabIndex = 27;
            // 
            // txtsearch1
            // 
            txtsearch1.Location = new Point(127, 3);
            txtsearch1.Name = "txtsearch1";
            txtsearch1.Size = new Size(131, 23);
            txtsearch1.TabIndex = 16;
            // 
            // cbxsearch1
            // 
            cbxsearch1.CornerRoundingRadius = -1F;
            cbxsearch1.DropDownWidth = 121;
            cbxsearch1.FormattingEnabled = true;
            cbxsearch1.IntegralHeight = false;
            cbxsearch1.Location = new Point(3, 3);
            cbxsearch1.Name = "cbxsearch1";
            cbxsearch1.Size = new Size(121, 21);
            cbxsearch1.TabIndex = 8;
            // 
            // kryptonPalettepanel
            // 
            kryptonPalettepanel.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettepanel.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // pnsearch2
            // 
            pnsearch2.Controls.Add(cbxsearch2);
            pnsearch2.Controls.Add(txtsearch2);
            pnsearch2.Location = new Point(386, 30);
            pnsearch2.Name = "pnsearch2";
            pnsearch2.Palette = kryptonPalettepanel;
            pnsearch2.PaletteMode = PaletteMode.Custom;
            pnsearch2.Size = new Size(256, 27);
            pnsearch2.TabIndex = 26;
            // 
            // cbxsearch2
            // 
            cbxsearch2.CornerRoundingRadius = -1F;
            cbxsearch2.DropDownWidth = 121;
            cbxsearch2.FormattingEnabled = true;
            cbxsearch2.IntegralHeight = false;
            cbxsearch2.Location = new Point(0, 3);
            cbxsearch2.Name = "cbxsearch2";
            cbxsearch2.Size = new Size(121, 21);
            cbxsearch2.TabIndex = 15;
            // 
            // txtsearch2
            // 
            txtsearch2.Location = new Point(125, 3);
            txtsearch2.Name = "txtsearch2";
            txtsearch2.Size = new Size(131, 23);
            txtsearch2.TabIndex = 17;
            // 
            // btnsearch
            // 
            btnsearch.CornerRoundingRadius = -1F;
            btnsearch.Location = new Point(648, 33);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(25, 21);
            btnsearch.TabIndex = 25;
            btnsearch.Values.Image = (Image)resources.GetObject("btnsearch.Values.Image");
            btnsearch.Values.Text = "";
            btnsearch.Click += btnsearch_Click;
            // 
            // lblsearch
            // 
            lblsearch.Location = new Point(35, 29);
            lblsearch.Name = "lblsearch";
            lblsearch.Palette = kryptonPalettelbl;
            lblsearch.PaletteMode = PaletteMode.Custom;
            lblsearch.Size = new Size(60, 21);
            lblsearch.TabIndex = 24;
            lblsearch.Values.Text = "Search";
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // ItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 532);
            Controls.Add(pnsearch1);
            Controls.Add(pnsearch2);
            Controls.Add(btnsearch);
            Controls.Add(lblsearch);
            Controls.Add(lbltitle);
            Controls.Add(lblsubitemtitle);
            Controls.Add(kryptonDataGridViewsubitem);
            Controls.Add(btncancel);
            Controls.Add(lblnoresult);
            Controls.Add(btnupdate);
            Controls.Add(btncreate);
            Controls.Add(dataGridViewitem);
            Name = "ItemView";
            Text = "ItemView";
            Load += ItemView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewitem).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewsubitem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch1).EndInit();
            pnsearch1.ResumeLayout(false);
            pnsearch1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsearch1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnsearch2).EndInit();
            pnsearch2.ResumeLayout(false);
            pnsearch2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxsearch2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonDataGridView dataGridViewitem;
        private KryptonButton btncreate;
        private KryptonButton btnupdate;
        private KryptonPalette kryptonPalettebtn;
        private KryptonLabel lblnoresult;
        private KryptonButton btncancel;
        private KryptonPalette kryptonPalettedatagridview;
        private KryptonDataGridView kryptonDataGridViewsubitem;
        private KryptonLabel lblsubitemtitle;
        private KryptonPalette kryptonPaletteheader;
        private KryptonLabel lbltitle;
        private KryptonPanel pnsearch1;
        private KryptonTextBox txtsearch1;
        private KryptonComboBox cbxsearch1;
        private KryptonPanel pnsearch2;
        private KryptonComboBox cbxsearch2;
        private KryptonTextBox txtsearch2;
        private KryptonButton btnsearch;
        private KryptonLabel lblsearch;
        private KryptonPalette kryptonPalettelbl;
        private KryptonPalette kryptonPalettepanel;
    }
}