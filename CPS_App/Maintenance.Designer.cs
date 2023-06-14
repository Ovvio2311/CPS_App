using ScintillaNET;
using System.Linq.Dynamic.Core;
using System.Windows.Forms;

namespace CPS_App
{
    partial class Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            kryptonDockingManager1 = new Krypton.Docking.KryptonDockingManager();
            btnroleadd = new Krypton.Toolkit.KryptonButton();
            kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(components);
            lblrole = new Krypton.Toolkit.KryptonLabel();
            txtrole = new Krypton.Toolkit.KryptonTextBox();
            multiDetailView = new Krypton.Toolkit.Suite.Extended.DataGridView.MultiDetailView();
            tabPageRole = new TabPage();
            kryptodatagridrole = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(components);
            tabPageUser = new TabPage();
            btnadduser = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewUser = new Krypton.Toolkit.KryptonDataGridView();
            tabPagedelisc = new TabPage();
            txtdelisc = new Krypton.Toolkit.KryptonTextBox();
            lbldelisc = new Krypton.Toolkit.KryptonLabel();
            btndelisc = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewdelisc = new Krypton.Toolkit.KryptonDataGridView();
            tabPagetpoatype = new TabPage();
            txtpoa = new Krypton.Toolkit.KryptonTextBox();
            lblpoa = new Krypton.Toolkit.KryptonLabel();
            btnpoa = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewpoa = new Krypton.Toolkit.KryptonDataGridView();
            tabPagetc = new TabPage();
            txttc = new Krypton.Toolkit.KryptonTextBox();
            lbltc = new Krypton.Toolkit.KryptonLabel();
            btntc = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewtc = new Krypton.Toolkit.KryptonDataGridView();
            tabPageuom = new TabPage();
            txtuom = new Krypton.Toolkit.KryptonTextBox();
            lbluom = new Krypton.Toolkit.KryptonLabel();
            btnuom = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewuom = new Krypton.Toolkit.KryptonDataGridView();
            tabPageloc = new TabPage();
            txtaddr = new Krypton.Toolkit.KryptonTextBox();
            lbladdr = new Krypton.Toolkit.KryptonLabel();
            txtloc = new Krypton.Toolkit.KryptonTextBox();
            lblloc = new Krypton.Toolkit.KryptonLabel();
            btnloc = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewloc = new Krypton.Toolkit.KryptonDataGridView();
            tabPagepo = new TabPage();
            txtpo = new Krypton.Toolkit.KryptonTextBox();
            lblpo = new Krypton.Toolkit.KryptonLabel();
            btnpo = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewpo = new Krypton.Toolkit.KryptonDataGridView();
            tabPagesup = new TabPage();
            txtsup = new Krypton.Toolkit.KryptonTextBox();
            lblsup = new Krypton.Toolkit.KryptonLabel();
            btnsup = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewsup = new Krypton.Toolkit.KryptonDataGridView();
            tabroleclaim = new TabPage();
            cbxroleinroleclaim = new Krypton.Toolkit.KryptonComboBox();
            txtclaimv = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(components);
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            txtclaimt = new Krypton.Toolkit.KryptonTextBox();
            lblroleclaim = new Krypton.Toolkit.KryptonLabel();
            btnaddclaim = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridViewroleclaim = new Krypton.Toolkit.KryptonDataGridView();
            tabpagevid = new TabPage();
            cbxvidmaploc = new Krypton.Toolkit.KryptonComboBox();
            lblvipmaploc = new Krypton.Toolkit.KryptonLabel();
            btnidinsert = new Button();
            btniddrop = new Button();
            cbxvidmapitemid = new Krypton.Toolkit.KryptonComboBox();
            lblvidmapitemid = new Krypton.Toolkit.KryptonLabel();
            lstbox = new Krypton.Toolkit.KryptonListBox();
            cbxvidmapvid = new Krypton.Toolkit.KryptonComboBox();
            lblvid = new Krypton.Toolkit.KryptonLabel();
            multiDetailView.SuspendLayout();
            tabPageRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptodatagridrole).BeginInit();
            tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewUser).BeginInit();
            tabPagedelisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewdelisc).BeginInit();
            tabPagetpoatype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).BeginInit();
            tabPagetc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewtc).BeginInit();
            tabPageuom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewuom).BeginInit();
            tabPageloc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewloc).BeginInit();
            tabPagepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpo).BeginInit();
            tabPagesup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewsup).BeginInit();
            tabroleclaim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxroleinroleclaim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewroleclaim).BeginInit();
            tabpagevid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxvidmaploc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxvidmapitemid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxvidmapvid).BeginInit();
            SuspendLayout();
            // 
            // btnroleadd
            // 
            btnroleadd.CornerRoundingRadius = -1F;
            btnroleadd.Location = new Point(44, 25);
            btnroleadd.Name = "btnroleadd";
            btnroleadd.Palette = kryptonPalettebtn;
            btnroleadd.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnroleadd.Size = new Size(100, 35);
            btnroleadd.TabIndex = 3;
            btnroleadd.Values.Text = "Add";
            btnroleadd.Click += btnroleadd_Click;
            // 
            // kryptonPalettebtn
            // 
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = Color.Transparent;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 5F;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = Color.SteelBlue;
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettebtn.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.SystemDefault;
            // 
            // lblrole
            // 
            lblrole.Location = new Point(44, 86);
            lblrole.Name = "lblrole";
            lblrole.Size = new Size(35, 20);
            lblrole.TabIndex = 5;
            lblrole.Values.Text = "Role";
            // 
            // txtrole
            // 
            txtrole.Location = new Point(91, 86);
            txtrole.Name = "txtrole";
            txtrole.Size = new Size(100, 23);
            txtrole.TabIndex = 6;
            // 
            // multiDetailView
            // 
            multiDetailView.Controls.Add(tabPageRole);
            multiDetailView.Controls.Add(tabPageUser);
            multiDetailView.Controls.Add(tabPagedelisc);
            multiDetailView.Controls.Add(tabPagetpoatype);
            multiDetailView.Controls.Add(tabPagetc);
            multiDetailView.Controls.Add(tabPageuom);
            multiDetailView.Controls.Add(tabPageloc);
            multiDetailView.Controls.Add(tabPagepo);
            multiDetailView.Controls.Add(tabPagesup);
            multiDetailView.Controls.Add(tabroleclaim);
            multiDetailView.Controls.Add(tabpagevid);
            multiDetailView.Location = new Point(1, 1);
            multiDetailView.Name = "multiDetailView";
            multiDetailView.SelectedIndex = 0;
            multiDetailView.Size = new Size(797, 451);
            multiDetailView.TabIndex = 7;
            multiDetailView.Tag = "Role";
            multiDetailView.Visible = false;
            // 
            // tabPageRole
            // 
            tabPageRole.Controls.Add(kryptodatagridrole);
            tabPageRole.Controls.Add(btnroleadd);
            tabPageRole.Controls.Add(lblrole);
            tabPageRole.Controls.Add(txtrole);
            tabPageRole.Location = new Point(4, 24);
            tabPageRole.Name = "tabPageRole";
            tabPageRole.Padding = new Padding(3);
            tabPageRole.Size = new Size(789, 423);
            tabPageRole.TabIndex = 0;
            tabPageRole.Text = "Role";
            tabPageRole.UseVisualStyleBackColor = true;
            // 
            // kryptodatagridrole
            // 
            kryptodatagridrole.Location = new Point(44, 133);
            kryptodatagridrole.Name = "kryptodatagridrole";
            kryptodatagridrole.Palette = kryptonPalettedatagridview;
            kryptodatagridrole.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptodatagridrole.RowTemplate.Height = 25;
            kryptodatagridrole.Size = new Size(715, 186);
            kryptodatagridrole.TabIndex = 3;
            // 
            // kryptonPalettedatagridview
            // 
            kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // tabPageUser
            // 
            tabPageUser.Controls.Add(btnadduser);
            tabPageUser.Controls.Add(kryptonDataGridViewUser);
            tabPageUser.Location = new Point(4, 24);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(789, 423);
            tabPageUser.TabIndex = 1;
            tabPageUser.Text = "User";
            tabPageUser.UseVisualStyleBackColor = true;
            // 
            // btnadduser
            // 
            btnadduser.CornerRoundingRadius = -1F;
            btnadduser.Location = new Point(47, 29);
            btnadduser.Name = "btnadduser";
            btnadduser.Palette = kryptonPalettebtn;
            btnadduser.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnadduser.Size = new Size(100, 35);
            btnadduser.TabIndex = 5;
            btnadduser.Values.Text = "Add";
            btnadduser.Click += btnAddnewuser_Click;
            // 
            // kryptonDataGridViewUser
            // 
            kryptonDataGridViewUser.Location = new Point(47, 113);
            kryptonDataGridViewUser.Name = "kryptonDataGridViewUser";
            kryptonDataGridViewUser.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewUser.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewUser.ReadOnly = true;
            kryptonDataGridViewUser.RowTemplate.Height = 25;
            kryptonDataGridViewUser.Size = new Size(694, 150);
            kryptonDataGridViewUser.TabIndex = 3;
            // 
            // tabPagedelisc
            // 
            tabPagedelisc.Controls.Add(txtdelisc);
            tabPagedelisc.Controls.Add(lbldelisc);
            tabPagedelisc.Controls.Add(btndelisc);
            tabPagedelisc.Controls.Add(kryptonDataGridViewdelisc);
            tabPagedelisc.Location = new Point(4, 24);
            tabPagedelisc.Name = "tabPagedelisc";
            tabPagedelisc.Padding = new Padding(3);
            tabPagedelisc.Size = new Size(789, 423);
            tabPagedelisc.TabIndex = 2;
            tabPagedelisc.Text = "Delivery Schedule";
            tabPagedelisc.UseVisualStyleBackColor = true;
            // 
            // txtdelisc
            // 
            txtdelisc.Location = new Point(112, 87);
            txtdelisc.Name = "txtdelisc";
            txtdelisc.Size = new Size(170, 23);
            txtdelisc.TabIndex = 4;
            // 
            // lbldelisc
            // 
            lbldelisc.Location = new Point(45, 90);
            lbldelisc.Name = "lbldelisc";
            lbldelisc.Size = new Size(43, 20);
            lbldelisc.TabIndex = 3;
            lbldelisc.Values.Text = "Name";
            // 
            // btndelisc
            // 
            btndelisc.CornerRoundingRadius = -1F;
            btndelisc.Location = new Point(45, 31);
            btndelisc.Name = "btndelisc";
            btndelisc.Palette = kryptonPalettebtn;
            btndelisc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btndelisc.Size = new Size(93, 38);
            btndelisc.TabIndex = 2;
            btndelisc.Values.Text = "Add";
            btndelisc.Click += btndelisc_Click;
            // 
            // kryptonDataGridViewdelisc
            // 
            kryptonDataGridViewdelisc.Location = new Point(45, 134);
            kryptonDataGridViewdelisc.Name = "kryptonDataGridViewdelisc";
            kryptonDataGridViewdelisc.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewdelisc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewdelisc.RowTemplate.Height = 25;
            kryptonDataGridViewdelisc.Size = new Size(621, 240);
            kryptonDataGridViewdelisc.TabIndex = 1;
            // 
            // tabPagetpoatype
            // 
            tabPagetpoatype.Controls.Add(txtpoa);
            tabPagetpoatype.Controls.Add(lblpoa);
            tabPagetpoatype.Controls.Add(btnpoa);
            tabPagetpoatype.Controls.Add(kryptonDataGridViewpoa);
            tabPagetpoatype.Location = new Point(4, 24);
            tabPagetpoatype.Name = "tabPagetpoatype";
            tabPagetpoatype.Padding = new Padding(3);
            tabPagetpoatype.Size = new Size(789, 423);
            tabPagetpoatype.TabIndex = 3;
            tabPagetpoatype.Text = "POA Type";
            tabPagetpoatype.UseVisualStyleBackColor = true;
            // 
            // txtpoa
            // 
            txtpoa.Location = new Point(103, 88);
            txtpoa.Name = "txtpoa";
            txtpoa.Size = new Size(170, 23);
            txtpoa.TabIndex = 5;
            // 
            // lblpoa
            // 
            lblpoa.Location = new Point(54, 91);
            lblpoa.Name = "lblpoa";
            lblpoa.Size = new Size(43, 20);
            lblpoa.TabIndex = 4;
            lblpoa.Values.Text = "Name";
            // 
            // btnpoa
            // 
            btnpoa.CornerRoundingRadius = -1F;
            btnpoa.Location = new Point(54, 27);
            btnpoa.Name = "btnpoa";
            btnpoa.Palette = kryptonPalettebtn;
            btnpoa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnpoa.Size = new Size(93, 38);
            btnpoa.TabIndex = 3;
            btnpoa.Values.Text = "Add";
            btnpoa.Click += btnpoa_Click;
            // 
            // kryptonDataGridViewpoa
            // 
            kryptonDataGridViewpoa.Location = new Point(54, 129);
            kryptonDataGridViewpoa.Name = "kryptonDataGridViewpoa";
            kryptonDataGridViewpoa.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewpoa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewpoa.RowTemplate.Height = 25;
            kryptonDataGridViewpoa.Size = new Size(621, 240);
            kryptonDataGridViewpoa.TabIndex = 0;
            // 
            // tabPagetc
            // 
            tabPagetc.Controls.Add(txttc);
            tabPagetc.Controls.Add(lbltc);
            tabPagetc.Controls.Add(btntc);
            tabPagetc.Controls.Add(kryptonDataGridViewtc);
            tabPagetc.Location = new Point(4, 24);
            tabPagetc.Name = "tabPagetc";
            tabPagetc.Padding = new Padding(3);
            tabPagetc.Size = new Size(789, 423);
            tabPagetc.TabIndex = 4;
            tabPagetc.Text = "Terms and Conditions";
            tabPagetc.UseVisualStyleBackColor = true;
            // 
            // txttc
            // 
            txttc.Location = new Point(98, 91);
            txttc.Name = "txttc";
            txttc.Size = new Size(170, 23);
            txttc.TabIndex = 5;
            // 
            // lbltc
            // 
            lbltc.Location = new Point(49, 94);
            lbltc.Name = "lbltc";
            lbltc.Size = new Size(43, 20);
            lbltc.TabIndex = 4;
            lbltc.Values.Text = "Name";
            // 
            // btntc
            // 
            btntc.CornerRoundingRadius = -1F;
            btntc.Location = new Point(49, 25);
            btntc.Name = "btntc";
            btntc.Palette = kryptonPalettebtn;
            btntc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btntc.Size = new Size(93, 38);
            btntc.TabIndex = 3;
            btntc.Values.Text = "Add";
            btntc.Click += btntc_Click;
            // 
            // kryptonDataGridViewtc
            // 
            kryptonDataGridViewtc.Location = new Point(49, 136);
            kryptonDataGridViewtc.Name = "kryptonDataGridViewtc";
            kryptonDataGridViewtc.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewtc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewtc.RowTemplate.Height = 25;
            kryptonDataGridViewtc.Size = new Size(621, 240);
            kryptonDataGridViewtc.TabIndex = 1;
            // 
            // tabPageuom
            // 
            tabPageuom.Controls.Add(txtuom);
            tabPageuom.Controls.Add(lbluom);
            tabPageuom.Controls.Add(btnuom);
            tabPageuom.Controls.Add(kryptonDataGridViewuom);
            tabPageuom.Location = new Point(4, 24);
            tabPageuom.Name = "tabPageuom";
            tabPageuom.Padding = new Padding(3);
            tabPageuom.Size = new Size(789, 423);
            tabPageuom.TabIndex = 5;
            tabPageuom.Text = "UOM";
            tabPageuom.UseVisualStyleBackColor = true;
            // 
            // txtuom
            // 
            txtuom.Location = new Point(91, 96);
            txtuom.Name = "txtuom";
            txtuom.Size = new Size(170, 23);
            txtuom.TabIndex = 5;
            // 
            // lbluom
            // 
            lbluom.Location = new Point(42, 99);
            lbluom.Name = "lbluom";
            lbluom.Size = new Size(43, 20);
            lbluom.TabIndex = 4;
            lbluom.Values.Text = "Name";
            // 
            // btnuom
            // 
            btnuom.CornerRoundingRadius = -1F;
            btnuom.Location = new Point(42, 31);
            btnuom.Name = "btnuom";
            btnuom.Palette = kryptonPalettebtn;
            btnuom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnuom.Size = new Size(93, 38);
            btnuom.TabIndex = 3;
            btnuom.Values.Text = "Add";
            btnuom.Click += btnuom_Click;
            // 
            // kryptonDataGridViewuom
            // 
            kryptonDataGridViewuom.Location = new Point(42, 148);
            kryptonDataGridViewuom.Name = "kryptonDataGridViewuom";
            kryptonDataGridViewuom.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewuom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewuom.RowTemplate.Height = 25;
            kryptonDataGridViewuom.Size = new Size(621, 240);
            kryptonDataGridViewuom.TabIndex = 1;
            // 
            // tabPageloc
            // 
            tabPageloc.Controls.Add(txtaddr);
            tabPageloc.Controls.Add(lbladdr);
            tabPageloc.Controls.Add(txtloc);
            tabPageloc.Controls.Add(lblloc);
            tabPageloc.Controls.Add(btnloc);
            tabPageloc.Controls.Add(kryptonDataGridViewloc);
            tabPageloc.Location = new Point(4, 24);
            tabPageloc.Name = "tabPageloc";
            tabPageloc.Padding = new Padding(3);
            tabPageloc.Size = new Size(789, 423);
            tabPageloc.TabIndex = 6;
            tabPageloc.Text = "Location";
            tabPageloc.UseVisualStyleBackColor = true;
            // 
            // txtaddr
            // 
            txtaddr.Location = new Point(113, 109);
            txtaddr.Name = "txtaddr";
            txtaddr.Size = new Size(170, 23);
            txtaddr.TabIndex = 7;
            // 
            // lbladdr
            // 
            lbladdr.Location = new Point(51, 112);
            lbladdr.Name = "lbladdr";
            lbladdr.Size = new Size(54, 20);
            lbladdr.TabIndex = 6;
            lbladdr.Values.Text = "Address";
            // 
            // txtloc
            // 
            txtloc.Location = new Point(113, 72);
            txtloc.Name = "txtloc";
            txtloc.Size = new Size(170, 23);
            txtloc.TabIndex = 5;
            // 
            // lblloc
            // 
            lblloc.Location = new Point(51, 75);
            lblloc.Name = "lblloc";
            lblloc.Size = new Size(43, 20);
            lblloc.TabIndex = 4;
            lblloc.Values.Text = "Name";
            // 
            // btnloc
            // 
            btnloc.CornerRoundingRadius = -1F;
            btnloc.Location = new Point(51, 18);
            btnloc.Name = "btnloc";
            btnloc.Palette = kryptonPalettebtn;
            btnloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnloc.Size = new Size(93, 38);
            btnloc.TabIndex = 3;
            btnloc.Values.Text = "Add";
            btnloc.Click += btnloc_Click;
            // 
            // kryptonDataGridViewloc
            // 
            kryptonDataGridViewloc.Location = new Point(51, 141);
            kryptonDataGridViewloc.Name = "kryptonDataGridViewloc";
            kryptonDataGridViewloc.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewloc.RowTemplate.Height = 25;
            kryptonDataGridViewloc.Size = new Size(621, 240);
            kryptonDataGridViewloc.TabIndex = 1;
            // 
            // tabPagepo
            // 
            tabPagepo.Controls.Add(txtpo);
            tabPagepo.Controls.Add(lblpo);
            tabPagepo.Controls.Add(btnpo);
            tabPagepo.Controls.Add(kryptonDataGridViewpo);
            tabPagepo.Location = new Point(4, 24);
            tabPagepo.Name = "tabPagepo";
            tabPagepo.Padding = new Padding(3);
            tabPagepo.Size = new Size(789, 423);
            tabPagepo.TabIndex = 7;
            tabPagepo.Text = "PO type";
            tabPagepo.UseVisualStyleBackColor = true;
            // 
            // txtpo
            // 
            txtpo.Location = new Point(104, 87);
            txtpo.Name = "txtpo";
            txtpo.Size = new Size(170, 23);
            txtpo.TabIndex = 5;
            // 
            // lblpo
            // 
            lblpo.Location = new Point(55, 90);
            lblpo.Name = "lblpo";
            lblpo.Size = new Size(43, 20);
            lblpo.TabIndex = 4;
            lblpo.Values.Text = "Name";
            // 
            // btnpo
            // 
            btnpo.CornerRoundingRadius = -1F;
            btnpo.Location = new Point(55, 27);
            btnpo.Name = "btnpo";
            btnpo.Palette = kryptonPalettebtn;
            btnpo.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnpo.Size = new Size(93, 38);
            btnpo.TabIndex = 3;
            btnpo.Values.Text = "Add";
            btnpo.Click += btnpo_Click;
            // 
            // kryptonDataGridViewpo
            // 
            kryptonDataGridViewpo.Location = new Point(55, 140);
            kryptonDataGridViewpo.Name = "kryptonDataGridViewpo";
            kryptonDataGridViewpo.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewpo.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewpo.RowTemplate.Height = 25;
            kryptonDataGridViewpo.Size = new Size(621, 240);
            kryptonDataGridViewpo.TabIndex = 1;
            // 
            // tabPagesup
            // 
            tabPagesup.Controls.Add(txtsup);
            tabPagesup.Controls.Add(lblsup);
            tabPagesup.Controls.Add(btnsup);
            tabPagesup.Controls.Add(kryptonDataGridViewsup);
            tabPagesup.Location = new Point(4, 24);
            tabPagesup.Name = "tabPagesup";
            tabPagesup.Padding = new Padding(3);
            tabPagesup.Size = new Size(789, 423);
            tabPagesup.TabIndex = 8;
            tabPagesup.Text = "Supplier";
            tabPagesup.UseVisualStyleBackColor = true;
            // 
            // txtsup
            // 
            txtsup.Location = new Point(92, 80);
            txtsup.Name = "txtsup";
            txtsup.Size = new Size(170, 23);
            txtsup.TabIndex = 5;
            // 
            // lblsup
            // 
            lblsup.Location = new Point(43, 80);
            lblsup.Name = "lblsup";
            lblsup.Size = new Size(43, 20);
            lblsup.TabIndex = 4;
            lblsup.Values.Text = "Name";
            // 
            // btnsup
            // 
            btnsup.CornerRoundingRadius = -1F;
            btnsup.Location = new Point(43, 25);
            btnsup.Name = "btnsup";
            btnsup.Palette = kryptonPalettebtn;
            btnsup.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnsup.Size = new Size(93, 38);
            btnsup.TabIndex = 3;
            btnsup.Values.Text = "Add";
            btnsup.Click += btnsup_Click;
            // 
            // kryptonDataGridViewsup
            // 
            kryptonDataGridViewsup.Location = new Point(43, 109);
            kryptonDataGridViewsup.Name = "kryptonDataGridViewsup";
            kryptonDataGridViewsup.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewsup.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewsup.RowTemplate.Height = 25;
            kryptonDataGridViewsup.Size = new Size(621, 240);
            kryptonDataGridViewsup.TabIndex = 1;
            // 
            // tabroleclaim
            // 
            tabroleclaim.Controls.Add(cbxroleinroleclaim);
            tabroleclaim.Controls.Add(txtclaimv);
            tabroleclaim.Controls.Add(kryptonLabel2);
            tabroleclaim.Controls.Add(kryptonLabel1);
            tabroleclaim.Controls.Add(txtclaimt);
            tabroleclaim.Controls.Add(lblroleclaim);
            tabroleclaim.Controls.Add(btnaddclaim);
            tabroleclaim.Controls.Add(kryptonDataGridViewroleclaim);
            tabroleclaim.Location = new Point(4, 24);
            tabroleclaim.Name = "tabroleclaim";
            tabroleclaim.Padding = new Padding(3);
            tabroleclaim.Size = new Size(789, 423);
            tabroleclaim.TabIndex = 9;
            tabroleclaim.Text = "RoleClaim";
            tabroleclaim.UseVisualStyleBackColor = true;
            // 
            // cbxroleinroleclaim
            // 
            cbxroleinroleclaim.CornerRoundingRadius = -1F;
            cbxroleinroleclaim.DropDownWidth = 146;
            cbxroleinroleclaim.IntegralHeight = false;
            cbxroleinroleclaim.Location = new Point(83, 72);
            cbxroleinroleclaim.Name = "cbxroleinroleclaim";
            cbxroleinroleclaim.Size = new Size(146, 21);
            cbxroleinroleclaim.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbxroleinroleclaim.TabIndex = 11;
            // 
            // txtclaimv
            // 
            txtclaimv.Location = new Point(598, 68);
            txtclaimv.Name = "txtclaimv";
            txtclaimv.Size = new Size(160, 23);
            txtclaimv.TabIndex = 10;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(500, 70);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Palette = kryptonPalettelbl;
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel2.Size = new Size(92, 21);
            kryptonLabel2.TabIndex = 9;
            kryptonLabel2.Values.Text = "Claim value";
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(33, 72);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Palette = kryptonPalettelbl;
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel1.Size = new Size(43, 21);
            kryptonLabel1.TabIndex = 7;
            kryptonLabel1.Values.Text = "Role";
            // 
            // txtclaimt
            // 
            txtclaimt.Location = new Point(320, 70);
            txtclaimt.Name = "txtclaimt";
            txtclaimt.Size = new Size(160, 23);
            txtclaimt.TabIndex = 6;
            // 
            // lblroleclaim
            // 
            lblroleclaim.Location = new Point(235, 70);
            lblroleclaim.Name = "lblroleclaim";
            lblroleclaim.Palette = kryptonPalettelbl;
            lblroleclaim.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblroleclaim.Size = new Size(90, 21);
            lblroleclaim.TabIndex = 5;
            lblroleclaim.Values.Text = "Claim Type";
            // 
            // btnaddclaim
            // 
            btnaddclaim.CornerRoundingRadius = -1F;
            btnaddclaim.Location = new Point(33, 20);
            btnaddclaim.Name = "btnaddclaim";
            btnaddclaim.Palette = kryptonPalettebtn;
            btnaddclaim.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnaddclaim.Size = new Size(93, 38);
            btnaddclaim.TabIndex = 4;
            btnaddclaim.Values.Text = "Add";
            btnaddclaim.Click += btnaddclaim_Click;
            // 
            // kryptonDataGridViewroleclaim
            // 
            kryptonDataGridViewroleclaim.Location = new Point(33, 109);
            kryptonDataGridViewroleclaim.Name = "kryptonDataGridViewroleclaim";
            kryptonDataGridViewroleclaim.Palette = kryptonPalettedatagridview;
            kryptonDataGridViewroleclaim.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridViewroleclaim.RowTemplate.Height = 25;
            kryptonDataGridViewroleclaim.Size = new Size(659, 213);
            kryptonDataGridViewroleclaim.TabIndex = 0;
            // 
            // tabpagevid
            // 
            tabpagevid.Controls.Add(cbxvidmaploc);
            tabpagevid.Controls.Add(lblvipmaploc);
            tabpagevid.Controls.Add(btnidinsert);
            tabpagevid.Controls.Add(btniddrop);
            tabpagevid.Controls.Add(cbxvidmapitemid);
            tabpagevid.Controls.Add(lblvidmapitemid);
            tabpagevid.Controls.Add(lstbox);
            tabpagevid.Controls.Add(cbxvidmapvid);
            tabpagevid.Controls.Add(lblvid);
            tabpagevid.Location = new Point(4, 24);
            tabpagevid.Name = "tabpagevid";
            tabpagevid.Padding = new Padding(3);
            tabpagevid.Size = new Size(789, 423);
            tabpagevid.TabIndex = 10;
            tabpagevid.Text = "Vid Mapping";
            tabpagevid.UseVisualStyleBackColor = true;
            // 
            // cbxvidmaploc
            // 
            cbxvidmaploc.CornerRoundingRadius = -1F;
            cbxvidmaploc.DropDownWidth = 146;
            cbxvidmaploc.IntegralHeight = false;
            cbxvidmaploc.Location = new Point(646, 204);
            cbxvidmaploc.Name = "cbxvidmaploc";
            cbxvidmaploc.Size = new Size(124, 21);
            cbxvidmaploc.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbxvidmaploc.TabIndex = 27;
            cbxvidmaploc.Tag = "bi_prefer_loc_id";
            // 
            // lblvipmaploc
            // 
            lblvipmaploc.Location = new Point(575, 204);
            lblvipmaploc.Name = "lblvipmaploc";
            lblvipmaploc.Palette = kryptonPalettelbl;
            lblvipmaploc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblvipmaploc.Size = new Size(70, 21);
            lblvipmaploc.TabIndex = 26;
            lblvipmaploc.Values.Text = "Location";
            // 
            // btnidinsert
            // 
            btnidinsert.Image = (Image)resources.GetObject("btnidinsert.Image");
            btnidinsert.Location = new Point(586, 102);
            btnidinsert.Name = "btnidinsert";
            btnidinsert.Size = new Size(71, 34);
            btnidinsert.TabIndex = 25;
            btnidinsert.UseVisualStyleBackColor = true;
            btnidinsert.Click += btnidinsert_Click;
            // 
            // btniddrop
            // 
            btniddrop.Image = (Image)resources.GetObject("btniddrop.Image");
            btniddrop.Location = new Point(586, 247);
            btniddrop.Name = "btniddrop";
            btniddrop.RightToLeft = RightToLeft.No;
            btniddrop.Size = new Size(71, 34);
            btniddrop.TabIndex = 24;
            btniddrop.UseVisualStyleBackColor = true;
            btniddrop.Click += btniddrop_Click;
            // 
            // cbxvidmapitemid
            // 
            cbxvidmapitemid.CornerRoundingRadius = -1F;
            cbxvidmapitemid.DropDownWidth = 146;
            cbxvidmapitemid.IntegralHeight = false;
            cbxvidmapitemid.Location = new Point(646, 177);
            cbxvidmapitemid.Name = "cbxvidmapitemid";
            cbxvidmapitemid.Size = new Size(124, 21);
            cbxvidmapitemid.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbxvidmapitemid.TabIndex = 22;
            cbxvidmapitemid.Tag = "bi_item_id";
            // 
            // lblvidmapitemid
            // 
            lblvidmapitemid.Location = new Point(586, 177);
            lblvidmapitemid.Name = "lblvidmapitemid";
            lblvidmapitemid.Palette = kryptonPalettelbl;
            lblvidmapitemid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblvidmapitemid.Size = new Size(59, 21);
            lblvidmapitemid.TabIndex = 21;
            lblvidmapitemid.Values.Text = "Item Id";
            // 
            // lstbox
            // 
            lstbox.Location = new Point(81, 55);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(488, 265);
            lstbox.TabIndex = 19;
            lstbox.Tag = "bi_item_id:bi_prefer_loc_id";
            // 
            // cbxvidmapvid
            // 
            cbxvidmapvid.CornerRoundingRadius = -1F;
            cbxvidmapvid.DropDownWidth = 146;
            cbxvidmapvid.IntegralHeight = false;
            cbxvidmapvid.Location = new Point(81, 341);
            cbxvidmapvid.Name = "cbxvidmapvid";
            cbxvidmapvid.Size = new Size(124, 21);
            cbxvidmapvid.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbxvidmapvid.TabIndex = 18;
            cbxvidmapvid.Tag = "bi_item_vid";
            cbxvidmapvid.SelectedIndexChanged += cbxvidmap_SelectedIndexChanged;
            // 
            // lblvid
            // 
            lblvid.Location = new Point(7, 341);
            lblvid.Name = "lblvid";
            lblvid.Palette = kryptonPalettelbl;
            lblvid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            lblvid.Size = new Size(68, 21);
            lblvid.TabIndex = 15;
            lblvid.Values.Text = "Item Vid";
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 444);
            Controls.Add(multiDetailView);
            Name = "Maintenance";
            Text = "Maintenance";
            Load += Maintenance_Load;
            multiDetailView.ResumeLayout(false);
            tabPageRole.ResumeLayout(false);
            tabPageRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptodatagridrole).EndInit();
            tabPageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewUser).EndInit();
            tabPagedelisc.ResumeLayout(false);
            tabPagedelisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewdelisc).EndInit();
            tabPagetpoatype.ResumeLayout(false);
            tabPagetpoatype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpoa).EndInit();
            tabPagetc.ResumeLayout(false);
            tabPagetc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewtc).EndInit();
            tabPageuom.ResumeLayout(false);
            tabPageuom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewuom).EndInit();
            tabPageloc.ResumeLayout(false);
            tabPageloc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewloc).EndInit();
            tabPagepo.ResumeLayout(false);
            tabPagepo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewpo).EndInit();
            tabPagesup.ResumeLayout(false);
            tabPagesup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewsup).EndInit();
            tabroleclaim.ResumeLayout(false);
            tabroleclaim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxroleinroleclaim).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewroleclaim).EndInit();
            tabpagevid.ResumeLayout(false);
            tabpagevid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxvidmaploc).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxvidmapitemid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxvidmapvid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private Krypton.Toolkit.KryptonButton btnroleadd;
        private Krypton.Toolkit.KryptonLabel lblrole;
        private Krypton.Toolkit.KryptonTextBox txtrole;
        private Krypton.Toolkit.Suite.Extended.DataGridView.MultiDetailView multiDetailView;
        private TabPage tabPageRole;
        private Krypton.Toolkit.KryptonDataGridView kryptodatagridrole;
        private TabPage tabPageUser;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewUser;
        private TabPage tabPagedelisc;
        private TabPage tabPagetpoatype;
        private TabPage tabPagetc;
        private TabPage tabPageuom;
        private TabPage tabPageloc;
        private TabPage tabPagepo;
        private TabPage tabPagesup;
        private TabPage tabroleclaim;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewdelisc;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewpoa;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewtc;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewuom;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewloc;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewpo;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewsup;
        private Krypton.Toolkit.KryptonButton btndelisc;
        private Krypton.Toolkit.KryptonButton btnpoa;
        private Krypton.Toolkit.KryptonTextBox txtdelisc;
        private Krypton.Toolkit.KryptonLabel lbldelisc;
        private Krypton.Toolkit.KryptonTextBox txtpoa;
        private Krypton.Toolkit.KryptonLabel lblpoa;
        private Krypton.Toolkit.KryptonTextBox txttc;
        private Krypton.Toolkit.KryptonLabel lbltc;
        private Krypton.Toolkit.KryptonButton btntc;
        private Krypton.Toolkit.KryptonTextBox txtuom;
        private Krypton.Toolkit.KryptonLabel lbluom;
        private Krypton.Toolkit.KryptonButton btnuom;
        private Krypton.Toolkit.KryptonTextBox txtloc;
        private Krypton.Toolkit.KryptonLabel lblloc;
        private Krypton.Toolkit.KryptonButton btnloc;
        private Krypton.Toolkit.KryptonTextBox txtpo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonButton btnpo;
        private Krypton.Toolkit.KryptonTextBox txtsup;
        private Krypton.Toolkit.KryptonLabel lblsup;
        private Krypton.Toolkit.KryptonButton btnsup;
        private Krypton.Toolkit.KryptonLabel lblpo;
        private Krypton.Toolkit.KryptonTextBox txtaddr;
        private Krypton.Toolkit.KryptonLabel lbladdr;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewroleclaim;
        private Krypton.Toolkit.KryptonPalette kryptonPalettelbl;
        private Krypton.Toolkit.KryptonTextBox txtclaimt;
        private Krypton.Toolkit.KryptonLabel lblroleclaim;
        private Krypton.Toolkit.KryptonButton btnaddclaim;
        private Krypton.Toolkit.KryptonTextBox txtclaimv;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbxroleinroleclaim;
        private Krypton.Toolkit.KryptonPalette kryptonPalettebtn;
        private Krypton.Toolkit.KryptonButton btnadduser;
        private Krypton.Toolkit.KryptonPalette kryptonPalettedatagridview;
        private TabPage tabpagevid;
        private Krypton.Toolkit.KryptonListBox lstbox;
        private Krypton.Toolkit.KryptonComboBox cbxvidmapvid;
        private Krypton.Toolkit.KryptonLabel lblvid;
        private Krypton.Toolkit.KryptonComboBox cbxvidmapitemid;
        private Krypton.Toolkit.KryptonLabel lblvidmapitemid;
        private Button btniddrop;
        private Button btnidinsert;
        private Krypton.Toolkit.KryptonComboBox cbxvidmaploc;
        private Krypton.Toolkit.KryptonLabel lblvipmaploc;
    }
}