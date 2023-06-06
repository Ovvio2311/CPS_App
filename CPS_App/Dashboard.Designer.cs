using System.ComponentModel;
using System.Windows.Forms;

namespace CPS_App
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.stripreq = new System.Windows.Forms.ToolStripButton();
            this.stripitem = new System.Windows.Forms.ToolStripButton();
            this.strippoa = new System.Windows.Forms.ToolStripButton();
            this.strippo = new System.Windows.Forms.ToolStripButton();
            this.stripset = new System.Windows.Forms.ToolStripButton();
            this.kryptonEnhancedToolStrip3 = new Krypton.Toolkit.Suite.Extended.Tool.Strip.Items.KryptonEnhancedToolStrip();
            this.striplogout = new System.Windows.Forms.ToolStripButton();
            this.striplblwelcome = new System.Windows.Forms.ToolStripLabel();
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonEnhancedToolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonCommand.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonPalette1.ButtonStyles.ButtonCommand.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // stripreq
            // 
            this.stripreq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stripreq.Image = ((System.Drawing.Image)(resources.GetObject("stripreq.Image")));
            this.stripreq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripreq.Name = "stripreq";
            this.stripreq.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.stripreq.Size = new System.Drawing.Size(134, 32);
            this.stripreq.Text = "Request";
            this.stripreq.Click += new System.EventHandler(this.stripreq_Click);
            // 
            // stripitem
            // 
            this.stripitem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stripitem.Image = ((System.Drawing.Image)(resources.GetObject("stripitem.Image")));
            this.stripitem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripitem.Name = "stripitem";
            this.stripitem.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.stripitem.Size = new System.Drawing.Size(104, 32);
            this.stripitem.Text = "Item";
            this.stripitem.Click += new System.EventHandler(this.stripitem_Click);
            // 
            // strippoa
            // 
            this.strippoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strippoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.strippoa.Image = ((System.Drawing.Image)(resources.GetObject("strippoa.Image")));
            this.strippoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strippoa.Name = "strippoa";
            this.strippoa.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.strippoa.Size = new System.Drawing.Size(106, 32);
            this.strippoa.Text = "POA";
            this.strippoa.Click += new System.EventHandler(this.strippoa_Click);
            // 
            // strippo
            // 
            this.strippo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strippo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.strippo.Image = ((System.Drawing.Image)(resources.GetObject("strippo.Image")));
            this.strippo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strippo.Name = "strippo";
            this.strippo.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.strippo.Size = new System.Drawing.Size(96, 32);
            this.strippo.Text = "PO";
            this.strippo.Click += new System.EventHandler(this.strippo_Click);
            // 
            // stripset
            // 
            this.stripset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stripset.Image = ((System.Drawing.Image)(resources.GetObject("stripset.Image")));
            this.stripset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripset.Name = "stripset";
            this.stripset.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.stripset.Size = new System.Drawing.Size(124, 32);
            this.stripset.Text = "Setting";
            this.stripset.Click += new System.EventHandler(this.stripset_Click);
            // 
            // kryptonEnhancedToolStrip3
            // 
            this.kryptonEnhancedToolStrip3.BackColor = System.Drawing.Color.White;
            this.kryptonEnhancedToolStrip3.ClickThrough = false;
            this.kryptonEnhancedToolStrip3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonEnhancedToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripreq,
            this.stripitem,
            this.strippoa,
            this.strippo,
            this.stripset,
            this.striplogout,
            this.striplblwelcome});
            this.kryptonEnhancedToolStrip3.Location = new System.Drawing.Point(0, 0);
            this.kryptonEnhancedToolStrip3.Name = "kryptonEnhancedToolStrip3";
            this.kryptonEnhancedToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.kryptonEnhancedToolStrip3.Size = new System.Drawing.Size(1002, 35);
            this.kryptonEnhancedToolStrip3.TabIndex = 33;
            this.kryptonEnhancedToolStrip3.Text = "kryptonEnhancedToolStrip3";
            // 
            // striplogout
            // 
            this.striplogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.striplogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.striplogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.striplogout.Image = ((System.Drawing.Image)(resources.GetObject("striplogout.Image")));
            this.striplogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.striplogout.Name = "striplogout";
            this.striplogout.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.striplogout.Size = new System.Drawing.Size(124, 32);
            this.striplogout.Text = "Logout";
            this.striplogout.Click += new System.EventHandler(this.striplogout_Click);
            // 
            // striplblwelcome
            // 
            this.striplblwelcome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.striplblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.striplblwelcome.Name = "striplblwelcome";
            this.striplblwelcome.Size = new System.Drawing.Size(0, 32);
            // 
            // kryptonPalettelbl
            // 
            this.kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 529);
            this.Controls.Add(this.kryptonEnhancedToolStrip3);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.kryptonEnhancedToolStrip3.ResumeLayout(false);
            this.kryptonEnhancedToolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ContextMenuStrip settingMenuStrip;
        private ToolStripButton stripreq;
        private ToolStripButton stripitem;
        private ToolStripButton strippoa;
        private ToolStripButton strippo;
        private ToolStripButton stripset;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;


        private Krypton.Toolkit.Suite.Extended.Tool.Strip.Items.KryptonEnhancedToolStrip kryptonEnhancedToolStrip3;
        private ToolStripLabel striplblwelcome;
        private ToolStripButton striplogout;
        private Krypton.Toolkit.KryptonPalette kryptonPalettelbl;
    }
}