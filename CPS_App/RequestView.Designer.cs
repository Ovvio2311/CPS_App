using Krypton.Toolkit;
using System.Windows.Forms;

namespace CPS_App
{
    partial class RequestView
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
            createdbBindingSource = new BindingSource(components);
            datagridview = new KryptonDataGridView();
            datagridviewitem = new KryptonDataGridView();
            btnEdit = new KryptonButton();
            kryptonPalettebtn = new KryptonPalette(components);
            txtfield = new TextBox();
            lblsearch = new Label();
            cbxsearch = new ComboBox();
            btnAdd = new KryptonButton();
            lblreqtable = new KryptonLabel();
            kryptonPaletteheader = new KryptonPalette(components);
            lblitem = new KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)createdbBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).BeginInit();
            SuspendLayout();
            // 
            // createdbBindingSource
            // 
            createdbBindingSource.DataSource = typeof(Migrations.createdb);
            // 
            // datagridview
            // 
            datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview.Location = new Point(27, 81);
            datagridview.Name = "datagridview";
            datagridview.ReadOnly = true;
            datagridview.RowTemplate.Height = 25;
            datagridview.Size = new Size(672, 225);
            datagridview.StateCommon.Background.Color1 = Color.White;
            datagridview.StateCommon.Background.Color2 = Color.White;
            datagridview.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            datagridview.TabIndex = 2;
            datagridview.CellClick += datagridview_CellClick;
            // 
            // datagridviewitem
            // 
            datagridviewitem.AllowUserToOrderColumns = true;
            datagridviewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewitem.Location = new Point(27, 350);
            datagridviewitem.Name = "datagridviewitem";
            datagridviewitem.ReadOnly = true;
            datagridviewitem.RowTemplate.Height = 25;
            datagridviewitem.Size = new Size(881, 227);
            datagridviewitem.StateCommon.Background.Color1 = Color.White;
            datagridviewitem.StateCommon.Background.Color2 = Color.Black;
            datagridviewitem.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            datagridviewitem.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.CornerRoundingRadius = -1F;
            btnEdit.Location = new Point(517, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Palette = kryptonPalettebtn;
            btnEdit.PaletteMode = PaletteMode.Custom;
            btnEdit.Size = new Size(96, 37);
            btnEdit.TabIndex = 5;
            btnEdit.Values.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
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
            // txtfield
            // 
            txtfield.Location = new Point(200, 18);
            txtfield.Name = "txtfield";
            txtfield.PlaceholderText = "Search for Request";
            txtfield.Size = new Size(232, 23);
            txtfield.TabIndex = 6;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Location = new Point(29, 21);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(42, 15);
            lblsearch.TabIndex = 7;
            lblsearch.Text = "Search";
            // 
            // cbxsearch
            // 
            cbxsearch.FormattingEnabled = true;
            cbxsearch.Location = new Point(73, 18);
            cbxsearch.Name = "cbxsearch";
            cbxsearch.Size = new Size(121, 23);
            cbxsearch.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.CornerRoundingRadius = -1F;
            btnAdd.Location = new Point(646, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Palette = kryptonPalettebtn;
            btnAdd.PaletteMode = PaletteMode.Custom;
            btnAdd.Size = new Size(96, 37);
            btnAdd.TabIndex = 9;
            btnAdd.Values.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblreqtable
            // 
            lblreqtable.Location = new Point(12, 55);
            lblreqtable.Name = "lblreqtable";
            lblreqtable.Palette = kryptonPaletteheader;
            lblreqtable.PaletteMode = PaletteMode.Custom;
            lblreqtable.Size = new Size(122, 23);
            lblreqtable.TabIndex = 10;
            lblreqtable.Values.Text = "Request Table";
            lblreqtable.Click += lblreqtable_Click;
            // 
            // kryptonPaletteheader
            // 
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = Color.DarkCyan;
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // lblitem
            // 
            lblitem.Location = new Point(12, 321);
            lblitem.Name = "lblitem";
            lblitem.Palette = kryptonPaletteheader;
            lblitem.PaletteMode = PaletteMode.Custom;
            lblitem.Size = new Size(79, 23);
            lblitem.TabIndex = 11;
            lblitem.Values.Text = "Item List";
            lblitem.Click += lblitem_Click;
            // 
            // RequestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1010, 648);
            Controls.Add(lblitem);
            Controls.Add(lblreqtable);
            Controls.Add(btnAdd);
            Controls.Add(cbxsearch);
            Controls.Add(lblsearch);
            Controls.Add(txtfield);
            Controls.Add(btnEdit);
            Controls.Add(datagridviewitem);
            Controls.Add(datagridview);
            Name = "RequestView";
            Text = "RequestView";
            Load += RequestView_Load;
            ((System.ComponentModel.ISupportInitialize)createdbBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource createdbBindingSource;
        private KryptonDataGridView datagridview;
        private KryptonDataGridView datagridviewitem;
        private KryptonButton btnEdit;
        private TextBox txtfield;
        private Label lblsearch;
        private ComboBox cbxsearch;
        private KryptonButton btnAdd;
        private KryptonLabel lblreqtable;
        private KryptonLabel lblitem;
        private KryptonPalette kryptonPaletteheader;
        private KryptonPalette kryptonPalettebtn;
    }
}