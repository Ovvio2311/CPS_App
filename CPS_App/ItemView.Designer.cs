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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemView));
            this.dataGridViewitem = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btncreate = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btnupdate = new Krypton.Toolkit.KryptonButton();
            this.lblnoresult = new Krypton.Toolkit.KryptonLabel();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewsubitem = new Krypton.Toolkit.KryptonDataGridView();
            this.lblsubitemtitle = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lbltitle = new Krypton.Toolkit.KryptonLabel();
            this.pnsearch1 = new Krypton.Toolkit.KryptonPanel();
            this.txtsearch1 = new Krypton.Toolkit.KryptonTextBox();
            this.cbxsearch1 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonPalettepanel = new Krypton.Toolkit.KryptonPalette(this.components);
            this.pnsearch2 = new Krypton.Toolkit.KryptonPanel();
            this.cbxsearch2 = new Krypton.Toolkit.KryptonComboBox();
            this.txtsearch2 = new Krypton.Toolkit.KryptonTextBox();
            this.btnsearch = new Krypton.Toolkit.KryptonButton();
            this.lblsearch = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btndispatch = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewsubitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnsearch1)).BeginInit();
            this.pnsearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnsearch2)).BeginInit();
            this.pnsearch2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewitem
            // 
            this.dataGridViewitem.AllowUserToAddRows = false;
            this.dataGridViewitem.AllowUserToOrderColumns = true;
            this.dataGridViewitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewitem.Location = new System.Drawing.Point(35, 116);
            this.dataGridViewitem.Name = "dataGridViewitem";
            this.dataGridViewitem.Palette = this.kryptonPalettedatagridview;
            this.dataGridViewitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dataGridViewitem.RowTemplate.Height = 25;
            this.dataGridViewitem.Size = new System.Drawing.Size(715, 238);
            this.dataGridViewitem.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.dataGridViewitem.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.dataGridViewitem.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewitem.TabIndex = 0;
            this.dataGridViewitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewitem_CellClick);
            // 
            // kryptonPalettedatagridview
            // 
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // btncreate
            // 
            this.btncreate.CornerRoundingRadius = -1F;
            this.btncreate.Location = new System.Drawing.Point(463, 68);
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
            this.btnupdate.Location = new System.Drawing.Point(586, 68);
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
            this.lblnoresult.Location = new System.Drawing.Point(35, 97);
            this.lblnoresult.Name = "lblnoresult";
            this.lblnoresult.Size = new System.Drawing.Size(64, 20);
            this.lblnoresult.TabIndex = 19;
            this.lblnoresult.Values.Text = "No Result";
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(704, 68);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(87, 36);
            this.btncancel.TabIndex = 20;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // kryptonDataGridViewsubitem
            // 
            this.kryptonDataGridViewsubitem.AllowUserToAddRows = false;
            this.kryptonDataGridViewsubitem.AllowUserToOrderColumns = true;
            this.kryptonDataGridViewsubitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewsubitem.Location = new System.Drawing.Point(35, 400);
            this.kryptonDataGridViewsubitem.Name = "kryptonDataGridViewsubitem";
            this.kryptonDataGridViewsubitem.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewsubitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewsubitem.ReadOnly = true;
            this.kryptonDataGridViewsubitem.RowTemplate.Height = 25;
            this.kryptonDataGridViewsubitem.Size = new System.Drawing.Size(715, 227);
            this.kryptonDataGridViewsubitem.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDataGridViewsubitem.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.kryptonDataGridViewsubitem.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridViewsubitem.TabIndex = 21;
            // 
            // lblsubitemtitle
            // 
            this.lblsubitemtitle.Location = new System.Drawing.Point(35, 371);
            this.lblsubitemtitle.Name = "lblsubitemtitle";
            this.lblsubitemtitle.Palette = this.kryptonPaletteheader;
            this.lblsubitemtitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblsubitemtitle.Size = new System.Drawing.Size(79, 23);
            this.lblsubitemtitle.TabIndex = 22;
            this.lblsubitemtitle.Values.Text = "Sub Item";
            // 
            // kryptonPaletteheader
            // 
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkCyan;
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(35, 68);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Palette = this.kryptonPaletteheader;
            this.lbltitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lbltitle.Size = new System.Drawing.Size(47, 23);
            this.lbltitle.TabIndex = 23;
            this.lbltitle.Values.Text = "Item";
            // 
            // pnsearch1
            // 
            this.pnsearch1.Controls.Add(this.txtsearch1);
            this.pnsearch1.Controls.Add(this.cbxsearch1);
            this.pnsearch1.Location = new System.Drawing.Point(101, 29);
            this.pnsearch1.Name = "pnsearch1";
            this.pnsearch1.Palette = this.kryptonPalettepanel;
            this.pnsearch1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.pnsearch1.Size = new System.Drawing.Size(261, 28);
            this.pnsearch1.TabIndex = 27;
            // 
            // txtsearch1
            // 
            this.txtsearch1.Location = new System.Drawing.Point(127, 3);
            this.txtsearch1.Name = "txtsearch1";
            this.txtsearch1.Size = new System.Drawing.Size(131, 23);
            this.txtsearch1.TabIndex = 16;
            // 
            // cbxsearch1
            // 
            this.cbxsearch1.CornerRoundingRadius = -1F;
            this.cbxsearch1.DropDownWidth = 121;
            this.cbxsearch1.FormattingEnabled = true;
            this.cbxsearch1.IntegralHeight = false;
            this.cbxsearch1.Location = new System.Drawing.Point(3, 3);
            this.cbxsearch1.Name = "cbxsearch1";
            this.cbxsearch1.Size = new System.Drawing.Size(121, 21);
            this.cbxsearch1.TabIndex = 8;
            // 
            // kryptonPalettepanel
            // 
            this.kryptonPalettepanel.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettepanel.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // pnsearch2
            // 
            this.pnsearch2.Controls.Add(this.cbxsearch2);
            this.pnsearch2.Controls.Add(this.txtsearch2);
            this.pnsearch2.Location = new System.Drawing.Point(386, 30);
            this.pnsearch2.Name = "pnsearch2";
            this.pnsearch2.Palette = this.kryptonPalettepanel;
            this.pnsearch2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.pnsearch2.Size = new System.Drawing.Size(256, 27);
            this.pnsearch2.TabIndex = 26;
            // 
            // cbxsearch2
            // 
            this.cbxsearch2.CornerRoundingRadius = -1F;
            this.cbxsearch2.DropDownWidth = 121;
            this.cbxsearch2.FormattingEnabled = true;
            this.cbxsearch2.IntegralHeight = false;
            this.cbxsearch2.Location = new System.Drawing.Point(0, 3);
            this.cbxsearch2.Name = "cbxsearch2";
            this.cbxsearch2.Size = new System.Drawing.Size(121, 21);
            this.cbxsearch2.TabIndex = 15;
            // 
            // txtsearch2
            // 
            this.txtsearch2.Location = new System.Drawing.Point(125, 3);
            this.txtsearch2.Name = "txtsearch2";
            this.txtsearch2.Size = new System.Drawing.Size(131, 23);
            this.txtsearch2.TabIndex = 17;
            // 
            // btnsearch
            // 
            this.btnsearch.CornerRoundingRadius = -1F;
            this.btnsearch.Location = new System.Drawing.Point(648, 33);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(25, 21);
            this.btnsearch.TabIndex = 25;
            this.btnsearch.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Values.Image")));
            this.btnsearch.Values.Text = "";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.Location = new System.Drawing.Point(35, 29);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Palette = this.kryptonPalettelbl;
            this.lblsearch.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblsearch.Size = new System.Drawing.Size(60, 21);
            this.lblsearch.TabIndex = 24;
            this.lblsearch.Values.Text = "Search";
            // 
            // kryptonPalettelbl
            // 
            this.kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // btndispatch
            // 
            this.btndispatch.CornerRoundingRadius = -1F;
            this.btndispatch.Location = new System.Drawing.Point(348, 68);
            this.btndispatch.Name = "btndispatch";
            this.btndispatch.Palette = this.kryptonPalettebtn;
            this.btndispatch.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btndispatch.Size = new System.Drawing.Size(87, 36);
            this.btndispatch.TabIndex = 28;
            this.btndispatch.Values.Text = "Dispatch";
            this.btndispatch.Click += new System.EventHandler(this.btndispatch_Click);
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 532);
            this.Controls.Add(this.btndispatch);
            this.Controls.Add(this.pnsearch1);
            this.Controls.Add(this.pnsearch2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblsubitemtitle);
            this.Controls.Add(this.kryptonDataGridViewsubitem);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblnoresult);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.dataGridViewitem);
            this.Name = "ItemView";
            this.Text = "ItemView";
            this.Load += new System.EventHandler(this.ItemView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewsubitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnsearch1)).EndInit();
            this.pnsearch1.ResumeLayout(false);
            this.pnsearch1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnsearch2)).EndInit();
            this.pnsearch2.ResumeLayout(false);
            this.pnsearch2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxsearch2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private KryptonButton btndispatch;
    }
}