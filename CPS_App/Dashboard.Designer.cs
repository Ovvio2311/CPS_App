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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Dashboard));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            stripreq = new ToolStripButton();
            stripitem = new ToolStripButton();
            strippoa = new ToolStripButton();
            strippo = new ToolStripButton();
            stripset = new ToolStripButton();
            kryptonEnhancedToolStrip3 = new Krypton.Toolkit.Suite.Extended.Tool.Strip.Items.KryptonEnhancedToolStrip();
            striplogout = new ToolStripButton();
            striplblwelcome = new ToolStripLabel();
            btndn = new ToolStripButton();
            kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(components);
            kryptonEnhancedToolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonStyles.ButtonCommand.StateCommon.Content.Padding = new Padding(0);
            kryptonPalette1.ButtonStyles.ButtonCommand.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color2 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = Color.Transparent;
            kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = Color.Transparent;
            kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = Color.Transparent;
            kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Color2 = Color.Transparent;
            kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // stripreq
            // 
            stripreq.DisplayStyle = ToolStripItemDisplayStyle.Text;
            stripreq.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            stripreq.Image = (Image)resources.GetObject("stripreq.Image");
            stripreq.ImageTransparentColor = Color.Magenta;
            stripreq.Name = "stripreq";
            stripreq.Padding = new Padding(20, 5, 20, 5);
            stripreq.Size = new Size(114, 32);
            stripreq.Text = "Request";
            stripreq.Click += stripreq_Click;
            // 
            // stripitem
            // 
            stripitem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            stripitem.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            stripitem.Image = (Image)resources.GetObject("stripitem.Image");
            stripitem.ImageTransparentColor = Color.Magenta;
            stripitem.Name = "stripitem";
            stripitem.Padding = new Padding(20, 5, 20, 5);
            stripitem.Size = new Size(84, 32);
            stripitem.Text = "Item";
            stripitem.Click += stripitem_Click;
            // 
            // strippoa
            // 
            strippoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            strippoa.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            strippoa.Image = (Image)resources.GetObject("strippoa.Image");
            strippoa.ImageTransparentColor = Color.Magenta;
            strippoa.Name = "strippoa";
            strippoa.Padding = new Padding(20, 5, 20, 5);
            strippoa.Size = new Size(86, 32);
            strippoa.Text = "POA";
            strippoa.Click += strippoa_Click;
            // 
            // strippo
            // 
            strippo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            strippo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            strippo.Image = (Image)resources.GetObject("strippo.Image");
            strippo.ImageTransparentColor = Color.Magenta;
            strippo.Name = "strippo";
            strippo.Padding = new Padding(20, 5, 20, 5);
            strippo.Size = new Size(76, 32);
            strippo.Text = "PO";
            strippo.Click += strippo_Click;
            // 
            // stripset
            // 
            stripset.DisplayStyle = ToolStripItemDisplayStyle.Text;
            stripset.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            stripset.Image = (Image)resources.GetObject("stripset.Image");
            stripset.ImageTransparentColor = Color.Magenta;
            stripset.Name = "stripset";
            stripset.Padding = new Padding(20, 5, 20, 5);
            stripset.Size = new Size(104, 32);
            stripset.Text = "Setting";
            stripset.Click += stripset_Click;
            // 
            // kryptonEnhancedToolStrip3
            // 
            kryptonEnhancedToolStrip3.BackColor = Color.White;
            kryptonEnhancedToolStrip3.ClickThrough = false;
            kryptonEnhancedToolStrip3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonEnhancedToolStrip3.Items.AddRange(new ToolStripItem[] { stripreq, stripitem, strippoa, strippo, btndn, stripset, striplogout, striplblwelcome });
            kryptonEnhancedToolStrip3.Location = new Point(0, 0);
            kryptonEnhancedToolStrip3.Name = "kryptonEnhancedToolStrip3";
            kryptonEnhancedToolStrip3.RenderMode = ToolStripRenderMode.System;
            kryptonEnhancedToolStrip3.Size = new Size(1002, 35);
            kryptonEnhancedToolStrip3.TabIndex = 33;
            kryptonEnhancedToolStrip3.Text = "kryptonEnhancedToolStrip3";
            // 
            // striplogout
            // 
            striplogout.Alignment = ToolStripItemAlignment.Right;
            striplogout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            striplogout.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            striplogout.Image = (Image)resources.GetObject("striplogout.Image");
            striplogout.ImageTransparentColor = Color.Magenta;
            striplogout.Name = "striplogout";
            striplogout.Padding = new Padding(30, 5, 30, 5);
            striplogout.Size = new Size(124, 32);
            striplogout.Text = "Logout";
            striplogout.Click += striplogout_Click;
            // 
            // striplblwelcome
            // 
            striplblwelcome.Alignment = ToolStripItemAlignment.Right;
            striplblwelcome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            striplblwelcome.Name = "striplblwelcome";
            striplblwelcome.Size = new Size(0, 32);
            // 
            // btndn
            // 
            btndn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btndn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btndn.Image = (Image)resources.GetObject("btndn.Image");
            btndn.ImageTransparentColor = Color.Magenta;
            btndn.Name = "btndn";
            btndn.Padding = new Padding(20, 5, 20, 5);
            btndn.Size = new Size(153, 32);
            btndn.Text = "Delivery Note";
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1002, 529);
            Controls.Add(kryptonEnhancedToolStrip3);
            IsMdiContainer = true;
            Name = "Dashboard";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            Text = "Dashboard";
            Load += Dashboard_Load;
            kryptonEnhancedToolStrip3.ResumeLayout(false);
            kryptonEnhancedToolStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripButton btndn;
    }
}