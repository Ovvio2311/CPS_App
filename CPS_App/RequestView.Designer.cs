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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datagridview = new Krypton.Toolkit.KryptonDataGridView();
            this.datagridviewitem = new Krypton.Toolkit.KryptonDataGridView();
            this.btnEdit = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.txtfield = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.cbxsearch = new System.Windows.Forms.ComboBox();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.lblreqtable = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPaletteheader = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblitem = new Krypton.Toolkit.KryptonLabel();
            this.btncancel = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.createdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // createdbBindingSource
            // 
            this.createdbBindingSource.DataSource = typeof(CPS_App.Migrations.createdb);
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(27, 81);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowTemplate.Height = 25;
            this.datagridview.Size = new System.Drawing.Size(672, 225);
            this.datagridview.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.datagridview.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.datagridview.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.datagridview.TabIndex = 2;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellClick);
            // 
            // datagridviewitem
            // 
            this.datagridviewitem.AllowUserToOrderColumns = true;
            this.datagridviewitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewitem.Location = new System.Drawing.Point(27, 350);
            this.datagridviewitem.Name = "datagridviewitem";
            this.datagridviewitem.ReadOnly = true;
            this.datagridviewitem.RowTemplate.Height = 25;
            this.datagridviewitem.Size = new System.Drawing.Size(881, 227);
            this.datagridviewitem.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.datagridviewitem.StateCommon.Background.Color2 = System.Drawing.Color.Black;
            this.datagridviewitem.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.datagridviewitem.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.CornerRoundingRadius = -1F;
            this.btnEdit.Location = new System.Drawing.Point(517, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Palette = this.kryptonPalettebtn;
            this.btnEdit.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnEdit.Size = new System.Drawing.Size(96, 37);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // txtfield
            // 
            this.txtfield.Location = new System.Drawing.Point(200, 18);
            this.txtfield.Name = "txtfield";
            this.txtfield.PlaceholderText = "Search for Request";
            this.txtfield.Size = new System.Drawing.Size(232, 23);
            this.txtfield.TabIndex = 6;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(29, 21);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(42, 15);
            this.lblsearch.TabIndex = 7;
            this.lblsearch.Text = "Search";
            // 
            // cbxsearch
            // 
            this.cbxsearch.FormattingEnabled = true;
            this.cbxsearch.Location = new System.Drawing.Point(73, 18);
            this.cbxsearch.Name = "cbxsearch";
            this.cbxsearch.Size = new System.Drawing.Size(121, 23);
            this.cbxsearch.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.CornerRoundingRadius = -1F;
            this.btnAdd.Location = new System.Drawing.Point(646, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Palette = this.kryptonPalettebtn;
            this.btnAdd.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnAdd.Size = new System.Drawing.Size(96, 37);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Values.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblreqtable
            // 
            this.lblreqtable.Location = new System.Drawing.Point(12, 55);
            this.lblreqtable.Name = "lblreqtable";
            this.lblreqtable.Palette = this.kryptonPaletteheader;
            this.lblreqtable.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblreqtable.Size = new System.Drawing.Size(122, 23);
            this.lblreqtable.TabIndex = 10;
            this.lblreqtable.Values.Text = "Request Table";
            // 
            // kryptonPaletteheader
            // 
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkCyan;
            this.kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // lblitem
            // 
            this.lblitem.Location = new System.Drawing.Point(12, 321);
            this.lblitem.Name = "lblitem";
            this.lblitem.Palette = this.kryptonPaletteheader;
            this.lblitem.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblitem.Size = new System.Drawing.Size(79, 23);
            this.lblitem.TabIndex = 11;
            this.lblitem.Values.Text = "Item List";
            // 
            // btncancel
            // 
            this.btncancel.CornerRoundingRadius = -1F;
            this.btncancel.Location = new System.Drawing.Point(773, 18);
            this.btncancel.Name = "btncancel";
            this.btncancel.Palette = this.kryptonPalettebtn;
            this.btncancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btncancel.Size = new System.Drawing.Size(96, 37);
            this.btncancel.TabIndex = 12;
            this.btncancel.Values.Text = "Cencel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // RequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 648);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblitem);
            this.Controls.Add(this.lblreqtable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtfield);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.datagridviewitem);
            this.Controls.Add(this.datagridview);
            this.Name = "RequestView";
            this.Text = "RequestView";
            this.Load += new System.EventHandler(this.RequestView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private KryptonButton btncancel;
    }
}