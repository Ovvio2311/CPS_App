﻿using ScintillaNET;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            this.kryptonDockingManager1 = new Krypton.Docking.KryptonDockingManager();
            this.btnroleadd = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalettebtn = new Krypton.Toolkit.KryptonPalette(this.components);
            this.lblrole = new Krypton.Toolkit.KryptonLabel();
            this.txtrole = new Krypton.Toolkit.KryptonTextBox();
            this.multiDetailView = new Krypton.Toolkit.Suite.Extended.DataGridView.MultiDetailView();
            this.tabPageRole = new System.Windows.Forms.TabPage();
            this.kryptodatagridrole = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPalettedatagridview = new Krypton.Toolkit.KryptonPalette(this.components);
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.btnadduser = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewUser = new Krypton.Toolkit.KryptonDataGridView();
            this.tabPagedelisc = new System.Windows.Forms.TabPage();
            this.btnEditdelic = new Krypton.Toolkit.KryptonButton();
            this.txtdelisc = new Krypton.Toolkit.KryptonTextBox();
            this.lbldelisc = new Krypton.Toolkit.KryptonLabel();
            this.btndelisc = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewdelisc = new Krypton.Toolkit.KryptonDataGridView();
            this.tabPagetpoatype = new System.Windows.Forms.TabPage();
            this.btneditpoatype = new Krypton.Toolkit.KryptonButton();
            this.txtpoa = new Krypton.Toolkit.KryptonTextBox();
            this.lblpoa = new Krypton.Toolkit.KryptonLabel();
            this.btnpoa = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewpoa = new Krypton.Toolkit.KryptonDataGridView();
            this.tabPagetc = new System.Windows.Forms.TabPage();
            this.btnedittc = new Krypton.Toolkit.KryptonButton();
            this.txttc = new Krypton.Toolkit.KryptonTextBox();
            this.lbltc = new Krypton.Toolkit.KryptonLabel();
            this.btntc = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewtc = new Krypton.Toolkit.KryptonDataGridView();
            this.tabPageuom = new System.Windows.Forms.TabPage();
            this.btnedituom = new Krypton.Toolkit.KryptonButton();
            this.txtuom = new Krypton.Toolkit.KryptonTextBox();
            this.lbluom = new Krypton.Toolkit.KryptonLabel();
            this.btnuom = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewuom = new Krypton.Toolkit.KryptonDataGridView();
            this.tabPageloc = new System.Windows.Forms.TabPage();
            this.btneditloc = new Krypton.Toolkit.KryptonButton();
            this.txtaddr = new Krypton.Toolkit.KryptonTextBox();
            this.lbladdr = new Krypton.Toolkit.KryptonLabel();
            this.txtloc = new Krypton.Toolkit.KryptonTextBox();
            this.lblloc = new Krypton.Toolkit.KryptonLabel();
            this.btnloc = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewloc = new Krypton.Toolkit.KryptonDataGridView();
            this.tabPagepo = new System.Windows.Forms.TabPage();
            this.btneditpotype = new Krypton.Toolkit.KryptonButton();
            this.txtpo = new Krypton.Toolkit.KryptonTextBox();
            this.lblpo = new Krypton.Toolkit.KryptonLabel();
            this.btnpo = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewpo = new Krypton.Toolkit.KryptonDataGridView();
            this.tabPagesup = new System.Windows.Forms.TabPage();
            this.btneditsupp = new Krypton.Toolkit.KryptonButton();
            this.txtsup = new Krypton.Toolkit.KryptonTextBox();
            this.lblsup = new Krypton.Toolkit.KryptonLabel();
            this.btnsup = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewsup = new Krypton.Toolkit.KryptonDataGridView();
            this.tabroleclaim = new System.Windows.Forms.TabPage();
            this.btneditroleclaim = new Krypton.Toolkit.KryptonButton();
            this.cbxroleinroleclaim = new Krypton.Toolkit.KryptonComboBox();
            this.txtclaimv = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPalettelbl = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtclaimt = new Krypton.Toolkit.KryptonTextBox();
            this.lblroleclaim = new Krypton.Toolkit.KryptonLabel();
            this.btnaddclaim = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewroleclaim = new Krypton.Toolkit.KryptonDataGridView();
            this.tabpagevid = new System.Windows.Forms.TabPage();
            this.cbxvidmaploc = new Krypton.Toolkit.KryptonComboBox();
            this.lblvipmaploc = new Krypton.Toolkit.KryptonLabel();
            this.btnidinsert = new System.Windows.Forms.Button();
            this.btniddrop = new System.Windows.Forms.Button();
            this.cbxvidmapitemid = new Krypton.Toolkit.KryptonComboBox();
            this.lblvidmapitemid = new Krypton.Toolkit.KryptonLabel();
            this.lstbox = new Krypton.Toolkit.KryptonListBox();
            this.cbxvidmapvid = new Krypton.Toolkit.KryptonComboBox();
            this.lblvid = new Krypton.Toolkit.KryptonLabel();
            this.tabPagecat = new System.Windows.Forms.TabPage();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.btnaddcat = new Krypton.Toolkit.KryptonButton();
            this.btneditcat = new Krypton.Toolkit.KryptonButton();
            this.kryptonPaletteCsv = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btneditrole = new Krypton.Toolkit.KryptonButton();
            this.multiDetailView.SuspendLayout();
            this.tabPageRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptodatagridrole)).BeginInit();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewUser)).BeginInit();
            this.tabPagedelisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewdelisc)).BeginInit();
            this.tabPagetpoatype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewpoa)).BeginInit();
            this.tabPagetc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewtc)).BeginInit();
            this.tabPageuom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewuom)).BeginInit();
            this.tabPageloc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewloc)).BeginInit();
            this.tabPagepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewpo)).BeginInit();
            this.tabPagesup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewsup)).BeginInit();
            this.tabroleclaim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxroleinroleclaim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewroleclaim)).BeginInit();
            this.tabpagevid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxvidmaploc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxvidmapitemid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxvidmapvid)).BeginInit();
            this.tabPagecat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnroleadd
            // 
            this.btnroleadd.CornerRoundingRadius = -1F;
            this.btnroleadd.Location = new System.Drawing.Point(44, 25);
            this.btnroleadd.Name = "btnroleadd";
            this.btnroleadd.Palette = this.kryptonPalettebtn;
            this.btnroleadd.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnroleadd.Size = new System.Drawing.Size(100, 35);
            this.btnroleadd.TabIndex = 3;
            this.btnroleadd.Values.Text = "Add";
            this.btnroleadd.Click += new System.EventHandler(this.btnroleadd_Click);
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
            // lblrole
            // 
            this.lblrole.Location = new System.Drawing.Point(44, 86);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(35, 20);
            this.lblrole.TabIndex = 5;
            this.lblrole.Values.Text = "Role";
            // 
            // txtrole
            // 
            this.txtrole.Location = new System.Drawing.Point(91, 86);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(100, 23);
            this.txtrole.TabIndex = 6;
            // 
            // multiDetailView
            // 
            this.multiDetailView.Controls.Add(this.tabPageRole);
            this.multiDetailView.Controls.Add(this.tabPageUser);
            this.multiDetailView.Controls.Add(this.tabPagedelisc);
            this.multiDetailView.Controls.Add(this.tabPagetpoatype);
            this.multiDetailView.Controls.Add(this.tabPagetc);
            this.multiDetailView.Controls.Add(this.tabPageuom);
            this.multiDetailView.Controls.Add(this.tabPageloc);
            this.multiDetailView.Controls.Add(this.tabPagepo);
            this.multiDetailView.Controls.Add(this.tabPagesup);
            this.multiDetailView.Controls.Add(this.tabroleclaim);
            this.multiDetailView.Controls.Add(this.tabpagevid);
            this.multiDetailView.Controls.Add(this.tabPagecat);
            this.multiDetailView.Location = new System.Drawing.Point(1, 1);
            this.multiDetailView.Name = "multiDetailView";
            this.multiDetailView.SelectedIndex = 0;
            this.multiDetailView.Size = new System.Drawing.Size(797, 451);
            this.multiDetailView.TabIndex = 7;
            this.multiDetailView.Tag = "Role";
            this.multiDetailView.Visible = false;
            // 
            // tabPageRole
            // 
            this.tabPageRole.Controls.Add(this.btneditrole);
            this.tabPageRole.Controls.Add(this.kryptodatagridrole);
            this.tabPageRole.Controls.Add(this.btnroleadd);
            this.tabPageRole.Controls.Add(this.lblrole);
            this.tabPageRole.Controls.Add(this.txtrole);
            this.tabPageRole.Location = new System.Drawing.Point(4, 24);
            this.tabPageRole.Name = "tabPageRole";
            this.tabPageRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRole.Size = new System.Drawing.Size(789, 423);
            this.tabPageRole.TabIndex = 0;
            this.tabPageRole.Text = "Role";
            this.tabPageRole.UseVisualStyleBackColor = true;
            // 
            // kryptodatagridrole
            // 
            this.kryptodatagridrole.Location = new System.Drawing.Point(44, 133);
            this.kryptodatagridrole.Name = "kryptodatagridrole";
            this.kryptodatagridrole.Palette = this.kryptonPalettedatagridview;
            this.kryptodatagridrole.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptodatagridrole.RowTemplate.Height = 25;
            this.kryptodatagridrole.Size = new System.Drawing.Size(715, 186);
            this.kryptodatagridrole.TabIndex = 3;
            // 
            // kryptonPalettedatagridview
            // 
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalettedatagridview.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.btnadduser);
            this.tabPageUser.Controls.Add(this.kryptonDataGridViewUser);
            this.tabPageUser.Location = new System.Drawing.Point(4, 24);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(789, 423);
            this.tabPageUser.TabIndex = 1;
            this.tabPageUser.Text = "User";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // btnadduser
            // 
            this.btnadduser.CornerRoundingRadius = -1F;
            this.btnadduser.Location = new System.Drawing.Point(47, 29);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Palette = this.kryptonPalettebtn;
            this.btnadduser.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnadduser.Size = new System.Drawing.Size(100, 35);
            this.btnadduser.TabIndex = 5;
            this.btnadduser.Values.Text = "Add";
            this.btnadduser.Click += new System.EventHandler(this.btnAddnewuser_Click);
            // 
            // kryptonDataGridViewUser
            // 
            this.kryptonDataGridViewUser.Location = new System.Drawing.Point(47, 113);
            this.kryptonDataGridViewUser.Name = "kryptonDataGridViewUser";
            this.kryptonDataGridViewUser.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewUser.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewUser.ReadOnly = true;
            this.kryptonDataGridViewUser.RowTemplate.Height = 25;
            this.kryptonDataGridViewUser.Size = new System.Drawing.Size(694, 150);
            this.kryptonDataGridViewUser.TabIndex = 3;
            // 
            // tabPagedelisc
            // 
            this.tabPagedelisc.Controls.Add(this.btnEditdelic);
            this.tabPagedelisc.Controls.Add(this.txtdelisc);
            this.tabPagedelisc.Controls.Add(this.lbldelisc);
            this.tabPagedelisc.Controls.Add(this.btndelisc);
            this.tabPagedelisc.Controls.Add(this.kryptonDataGridViewdelisc);
            this.tabPagedelisc.Location = new System.Drawing.Point(4, 24);
            this.tabPagedelisc.Name = "tabPagedelisc";
            this.tabPagedelisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagedelisc.Size = new System.Drawing.Size(789, 423);
            this.tabPagedelisc.TabIndex = 2;
            this.tabPagedelisc.Text = "Delivery Schedule";
            this.tabPagedelisc.UseVisualStyleBackColor = true;
            // 
            // btnEditdelic
            // 
            this.btnEditdelic.CornerRoundingRadius = -1F;
            this.btnEditdelic.Location = new System.Drawing.Point(169, 31);
            this.btnEditdelic.Name = "btnEditdelic";
            this.btnEditdelic.Palette = this.kryptonPalettebtn;
            this.btnEditdelic.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnEditdelic.Size = new System.Drawing.Size(93, 38);
            this.btnEditdelic.TabIndex = 5;
            this.btnEditdelic.Values.Text = "Update";
            this.btnEditdelic.Click += new System.EventHandler(this.btnEditdelic_Click);
            // 
            // txtdelisc
            // 
            this.txtdelisc.Location = new System.Drawing.Point(112, 87);
            this.txtdelisc.Name = "txtdelisc";
            this.txtdelisc.Size = new System.Drawing.Size(170, 23);
            this.txtdelisc.TabIndex = 4;
            // 
            // lbldelisc
            // 
            this.lbldelisc.Location = new System.Drawing.Point(45, 90);
            this.lbldelisc.Name = "lbldelisc";
            this.lbldelisc.Size = new System.Drawing.Size(43, 20);
            this.lbldelisc.TabIndex = 3;
            this.lbldelisc.Values.Text = "Name";
            // 
            // btndelisc
            // 
            this.btndelisc.CornerRoundingRadius = -1F;
            this.btndelisc.Location = new System.Drawing.Point(45, 31);
            this.btndelisc.Name = "btndelisc";
            this.btndelisc.Palette = this.kryptonPalettebtn;
            this.btndelisc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btndelisc.Size = new System.Drawing.Size(93, 38);
            this.btndelisc.TabIndex = 2;
            this.btndelisc.Values.Text = "Add";
            this.btndelisc.Click += new System.EventHandler(this.btndelisc_Click);
            // 
            // kryptonDataGridViewdelisc
            // 
            this.kryptonDataGridViewdelisc.Location = new System.Drawing.Point(45, 134);
            this.kryptonDataGridViewdelisc.Name = "kryptonDataGridViewdelisc";
            this.kryptonDataGridViewdelisc.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewdelisc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewdelisc.RowTemplate.Height = 25;
            this.kryptonDataGridViewdelisc.Size = new System.Drawing.Size(621, 240);
            this.kryptonDataGridViewdelisc.TabIndex = 1;
            // 
            // tabPagetpoatype
            // 
            this.tabPagetpoatype.Controls.Add(this.btneditpoatype);
            this.tabPagetpoatype.Controls.Add(this.txtpoa);
            this.tabPagetpoatype.Controls.Add(this.lblpoa);
            this.tabPagetpoatype.Controls.Add(this.btnpoa);
            this.tabPagetpoatype.Controls.Add(this.kryptonDataGridViewpoa);
            this.tabPagetpoatype.Location = new System.Drawing.Point(4, 24);
            this.tabPagetpoatype.Name = "tabPagetpoatype";
            this.tabPagetpoatype.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagetpoatype.Size = new System.Drawing.Size(789, 423);
            this.tabPagetpoatype.TabIndex = 3;
            this.tabPagetpoatype.Text = "POA Type";
            this.tabPagetpoatype.UseVisualStyleBackColor = true;
            // 
            // btneditpoatype
            // 
            this.btneditpoatype.CornerRoundingRadius = -1F;
            this.btneditpoatype.Location = new System.Drawing.Point(195, 27);
            this.btneditpoatype.Name = "btneditpoatype";
            this.btneditpoatype.Palette = this.kryptonPalettebtn;
            this.btneditpoatype.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btneditpoatype.Size = new System.Drawing.Size(93, 38);
            this.btneditpoatype.TabIndex = 6;
            this.btneditpoatype.Values.Text = "Update";
            this.btneditpoatype.Click += new System.EventHandler(this.btneditpoatype_Click);
            // 
            // txtpoa
            // 
            this.txtpoa.Location = new System.Drawing.Point(103, 88);
            this.txtpoa.Name = "txtpoa";
            this.txtpoa.Size = new System.Drawing.Size(170, 23);
            this.txtpoa.TabIndex = 5;
            // 
            // lblpoa
            // 
            this.lblpoa.Location = new System.Drawing.Point(54, 91);
            this.lblpoa.Name = "lblpoa";
            this.lblpoa.Size = new System.Drawing.Size(43, 20);
            this.lblpoa.TabIndex = 4;
            this.lblpoa.Values.Text = "Name";
            // 
            // btnpoa
            // 
            this.btnpoa.CornerRoundingRadius = -1F;
            this.btnpoa.Location = new System.Drawing.Point(54, 27);
            this.btnpoa.Name = "btnpoa";
            this.btnpoa.Palette = this.kryptonPalettebtn;
            this.btnpoa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnpoa.Size = new System.Drawing.Size(93, 38);
            this.btnpoa.TabIndex = 3;
            this.btnpoa.Values.Text = "Add";
            this.btnpoa.Click += new System.EventHandler(this.btnpoa_Click);
            // 
            // kryptonDataGridViewpoa
            // 
            this.kryptonDataGridViewpoa.Location = new System.Drawing.Point(54, 129);
            this.kryptonDataGridViewpoa.Name = "kryptonDataGridViewpoa";
            this.kryptonDataGridViewpoa.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewpoa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewpoa.RowTemplate.Height = 25;
            this.kryptonDataGridViewpoa.Size = new System.Drawing.Size(621, 240);
            this.kryptonDataGridViewpoa.TabIndex = 0;
            // 
            // tabPagetc
            // 
            this.tabPagetc.Controls.Add(this.btnedittc);
            this.tabPagetc.Controls.Add(this.txttc);
            this.tabPagetc.Controls.Add(this.lbltc);
            this.tabPagetc.Controls.Add(this.btntc);
            this.tabPagetc.Controls.Add(this.kryptonDataGridViewtc);
            this.tabPagetc.Location = new System.Drawing.Point(4, 24);
            this.tabPagetc.Name = "tabPagetc";
            this.tabPagetc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagetc.Size = new System.Drawing.Size(789, 423);
            this.tabPagetc.TabIndex = 4;
            this.tabPagetc.Text = "Terms and Conditions";
            this.tabPagetc.UseVisualStyleBackColor = true;
            // 
            // btnedittc
            // 
            this.btnedittc.CornerRoundingRadius = -1F;
            this.btnedittc.Location = new System.Drawing.Point(185, 25);
            this.btnedittc.Name = "btnedittc";
            this.btnedittc.Palette = this.kryptonPalettebtn;
            this.btnedittc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnedittc.Size = new System.Drawing.Size(93, 38);
            this.btnedittc.TabIndex = 7;
            this.btnedittc.Values.Text = "Update";
            this.btnedittc.Click += new System.EventHandler(this.btnedittc_Click);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(98, 91);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(170, 23);
            this.txttc.TabIndex = 5;
            // 
            // lbltc
            // 
            this.lbltc.Location = new System.Drawing.Point(49, 94);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(43, 20);
            this.lbltc.TabIndex = 4;
            this.lbltc.Values.Text = "Name";
            // 
            // btntc
            // 
            this.btntc.CornerRoundingRadius = -1F;
            this.btntc.Location = new System.Drawing.Point(49, 25);
            this.btntc.Name = "btntc";
            this.btntc.Palette = this.kryptonPalettebtn;
            this.btntc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btntc.Size = new System.Drawing.Size(93, 38);
            this.btntc.TabIndex = 3;
            this.btntc.Values.Text = "Add";
            this.btntc.Click += new System.EventHandler(this.btntc_Click);
            // 
            // kryptonDataGridViewtc
            // 
            this.kryptonDataGridViewtc.Location = new System.Drawing.Point(49, 136);
            this.kryptonDataGridViewtc.Name = "kryptonDataGridViewtc";
            this.kryptonDataGridViewtc.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewtc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewtc.RowTemplate.Height = 25;
            this.kryptonDataGridViewtc.Size = new System.Drawing.Size(621, 240);
            this.kryptonDataGridViewtc.TabIndex = 1;
            // 
            // tabPageuom
            // 
            this.tabPageuom.Controls.Add(this.btnedituom);
            this.tabPageuom.Controls.Add(this.txtuom);
            this.tabPageuom.Controls.Add(this.lbluom);
            this.tabPageuom.Controls.Add(this.btnuom);
            this.tabPageuom.Controls.Add(this.kryptonDataGridViewuom);
            this.tabPageuom.Location = new System.Drawing.Point(4, 24);
            this.tabPageuom.Name = "tabPageuom";
            this.tabPageuom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageuom.Size = new System.Drawing.Size(789, 423);
            this.tabPageuom.TabIndex = 5;
            this.tabPageuom.Text = "UOM";
            this.tabPageuom.UseVisualStyleBackColor = true;
            // 
            // btnedituom
            // 
            this.btnedituom.CornerRoundingRadius = -1F;
            this.btnedituom.Location = new System.Drawing.Point(186, 31);
            this.btnedituom.Name = "btnedituom";
            this.btnedituom.Palette = this.kryptonPalettebtn;
            this.btnedituom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnedituom.Size = new System.Drawing.Size(93, 38);
            this.btnedituom.TabIndex = 8;
            this.btnedituom.Values.Text = "Update";
            this.btnedituom.Click += new System.EventHandler(this.btnedituom_Click);
            // 
            // txtuom
            // 
            this.txtuom.Location = new System.Drawing.Point(91, 96);
            this.txtuom.Name = "txtuom";
            this.txtuom.Size = new System.Drawing.Size(170, 23);
            this.txtuom.TabIndex = 5;
            // 
            // lbluom
            // 
            this.lbluom.Location = new System.Drawing.Point(42, 99);
            this.lbluom.Name = "lbluom";
            this.lbluom.Size = new System.Drawing.Size(43, 20);
            this.lbluom.TabIndex = 4;
            this.lbluom.Values.Text = "Name";
            // 
            // btnuom
            // 
            this.btnuom.CornerRoundingRadius = -1F;
            this.btnuom.Location = new System.Drawing.Point(42, 31);
            this.btnuom.Name = "btnuom";
            this.btnuom.Palette = this.kryptonPalettebtn;
            this.btnuom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnuom.Size = new System.Drawing.Size(93, 38);
            this.btnuom.TabIndex = 3;
            this.btnuom.Values.Text = "Add";
            this.btnuom.Click += new System.EventHandler(this.btnuom_Click);
            // 
            // kryptonDataGridViewuom
            // 
            this.kryptonDataGridViewuom.Location = new System.Drawing.Point(42, 148);
            this.kryptonDataGridViewuom.Name = "kryptonDataGridViewuom";
            this.kryptonDataGridViewuom.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewuom.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewuom.RowTemplate.Height = 25;
            this.kryptonDataGridViewuom.Size = new System.Drawing.Size(621, 240);
            this.kryptonDataGridViewuom.TabIndex = 1;
            // 
            // tabPageloc
            // 
            this.tabPageloc.Controls.Add(this.btneditloc);
            this.tabPageloc.Controls.Add(this.txtaddr);
            this.tabPageloc.Controls.Add(this.lbladdr);
            this.tabPageloc.Controls.Add(this.txtloc);
            this.tabPageloc.Controls.Add(this.lblloc);
            this.tabPageloc.Controls.Add(this.btnloc);
            this.tabPageloc.Controls.Add(this.kryptonDataGridViewloc);
            this.tabPageloc.Location = new System.Drawing.Point(4, 24);
            this.tabPageloc.Name = "tabPageloc";
            this.tabPageloc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageloc.Size = new System.Drawing.Size(789, 423);
            this.tabPageloc.TabIndex = 6;
            this.tabPageloc.Text = "Location";
            this.tabPageloc.UseVisualStyleBackColor = true;
            // 
            // btneditloc
            // 
            this.btneditloc.CornerRoundingRadius = -1F;
            this.btneditloc.Location = new System.Drawing.Point(190, 18);
            this.btneditloc.Name = "btneditloc";
            this.btneditloc.Palette = this.kryptonPalettebtn;
            this.btneditloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btneditloc.Size = new System.Drawing.Size(93, 38);
            this.btneditloc.TabIndex = 9;
            this.btneditloc.Values.Text = "Update";
            this.btneditloc.Click += new System.EventHandler(this.btneditloc_Click);
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(113, 109);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(170, 23);
            this.txtaddr.TabIndex = 7;
            // 
            // lbladdr
            // 
            this.lbladdr.Location = new System.Drawing.Point(51, 112);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(54, 20);
            this.lbladdr.TabIndex = 6;
            this.lbladdr.Values.Text = "Address";
            // 
            // txtloc
            // 
            this.txtloc.Location = new System.Drawing.Point(113, 72);
            this.txtloc.Name = "txtloc";
            this.txtloc.Size = new System.Drawing.Size(170, 23);
            this.txtloc.TabIndex = 5;
            // 
            // lblloc
            // 
            this.lblloc.Location = new System.Drawing.Point(51, 75);
            this.lblloc.Name = "lblloc";
            this.lblloc.Size = new System.Drawing.Size(43, 20);
            this.lblloc.TabIndex = 4;
            this.lblloc.Values.Text = "Name";
            // 
            // btnloc
            // 
            this.btnloc.CornerRoundingRadius = -1F;
            this.btnloc.Location = new System.Drawing.Point(51, 18);
            this.btnloc.Name = "btnloc";
            this.btnloc.Palette = this.kryptonPalettebtn;
            this.btnloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnloc.Size = new System.Drawing.Size(93, 38);
            this.btnloc.TabIndex = 3;
            this.btnloc.Values.Text = "Add";
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // kryptonDataGridViewloc
            // 
            this.kryptonDataGridViewloc.Location = new System.Drawing.Point(51, 141);
            this.kryptonDataGridViewloc.Name = "kryptonDataGridViewloc";
            this.kryptonDataGridViewloc.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewloc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewloc.RowTemplate.Height = 25;
            this.kryptonDataGridViewloc.Size = new System.Drawing.Size(621, 240);
            this.kryptonDataGridViewloc.TabIndex = 1;
            // 
            // tabPagepo
            // 
            this.tabPagepo.Controls.Add(this.btneditpotype);
            this.tabPagepo.Controls.Add(this.txtpo);
            this.tabPagepo.Controls.Add(this.lblpo);
            this.tabPagepo.Controls.Add(this.btnpo);
            this.tabPagepo.Controls.Add(this.kryptonDataGridViewpo);
            this.tabPagepo.Location = new System.Drawing.Point(4, 24);
            this.tabPagepo.Name = "tabPagepo";
            this.tabPagepo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagepo.Size = new System.Drawing.Size(789, 423);
            this.tabPagepo.TabIndex = 7;
            this.tabPagepo.Text = "PO type";
            this.tabPagepo.UseVisualStyleBackColor = true;
            // 
            // btneditpotype
            // 
            this.btneditpotype.CornerRoundingRadius = -1F;
            this.btneditpotype.Location = new System.Drawing.Point(195, 27);
            this.btneditpotype.Name = "btneditpotype";
            this.btneditpotype.Palette = this.kryptonPalettebtn;
            this.btneditpotype.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btneditpotype.Size = new System.Drawing.Size(93, 38);
            this.btneditpotype.TabIndex = 10;
            this.btneditpotype.Values.Text = "Update";
            this.btneditpotype.Click += new System.EventHandler(this.btneditpotype_Click);
            // 
            // txtpo
            // 
            this.txtpo.Location = new System.Drawing.Point(104, 87);
            this.txtpo.Name = "txtpo";
            this.txtpo.Size = new System.Drawing.Size(170, 23);
            this.txtpo.TabIndex = 5;
            // 
            // lblpo
            // 
            this.lblpo.Location = new System.Drawing.Point(55, 90);
            this.lblpo.Name = "lblpo";
            this.lblpo.Size = new System.Drawing.Size(43, 20);
            this.lblpo.TabIndex = 4;
            this.lblpo.Values.Text = "Name";
            // 
            // btnpo
            // 
            this.btnpo.CornerRoundingRadius = -1F;
            this.btnpo.Location = new System.Drawing.Point(55, 27);
            this.btnpo.Name = "btnpo";
            this.btnpo.Palette = this.kryptonPalettebtn;
            this.btnpo.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnpo.Size = new System.Drawing.Size(93, 38);
            this.btnpo.TabIndex = 3;
            this.btnpo.Values.Text = "Add";
            this.btnpo.Click += new System.EventHandler(this.btnpo_Click);
            // 
            // kryptonDataGridViewpo
            // 
            this.kryptonDataGridViewpo.Location = new System.Drawing.Point(55, 140);
            this.kryptonDataGridViewpo.Name = "kryptonDataGridViewpo";
            this.kryptonDataGridViewpo.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewpo.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewpo.RowTemplate.Height = 25;
            this.kryptonDataGridViewpo.Size = new System.Drawing.Size(621, 240);
            this.kryptonDataGridViewpo.TabIndex = 1;
            // 
            // tabPagesup
            // 
            this.tabPagesup.Controls.Add(this.btneditsupp);
            this.tabPagesup.Controls.Add(this.txtsup);
            this.tabPagesup.Controls.Add(this.lblsup);
            this.tabPagesup.Controls.Add(this.btnsup);
            this.tabPagesup.Controls.Add(this.kryptonDataGridViewsup);
            this.tabPagesup.Location = new System.Drawing.Point(4, 24);
            this.tabPagesup.Name = "tabPagesup";
            this.tabPagesup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagesup.Size = new System.Drawing.Size(789, 423);
            this.tabPagesup.TabIndex = 8;
            this.tabPagesup.Text = "Supplier";
            this.tabPagesup.UseVisualStyleBackColor = true;
            // 
            // btneditsupp
            // 
            this.btneditsupp.CornerRoundingRadius = -1F;
            this.btneditsupp.Location = new System.Drawing.Point(188, 25);
            this.btneditsupp.Name = "btneditsupp";
            this.btneditsupp.Palette = this.kryptonPalettebtn;
            this.btneditsupp.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btneditsupp.Size = new System.Drawing.Size(93, 38);
            this.btneditsupp.TabIndex = 11;
            this.btneditsupp.Values.Text = "Update";
            this.btneditsupp.Click += new System.EventHandler(this.btneditsupp_Click);
            // 
            // txtsup
            // 
            this.txtsup.Location = new System.Drawing.Point(92, 80);
            this.txtsup.Name = "txtsup";
            this.txtsup.Size = new System.Drawing.Size(170, 23);
            this.txtsup.TabIndex = 5;
            // 
            // lblsup
            // 
            this.lblsup.Location = new System.Drawing.Point(43, 80);
            this.lblsup.Name = "lblsup";
            this.lblsup.Size = new System.Drawing.Size(43, 20);
            this.lblsup.TabIndex = 4;
            this.lblsup.Values.Text = "Name";
            // 
            // btnsup
            // 
            this.btnsup.CornerRoundingRadius = -1F;
            this.btnsup.Location = new System.Drawing.Point(43, 25);
            this.btnsup.Name = "btnsup";
            this.btnsup.Palette = this.kryptonPalettebtn;
            this.btnsup.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnsup.Size = new System.Drawing.Size(93, 38);
            this.btnsup.TabIndex = 3;
            this.btnsup.Values.Text = "Add";
            this.btnsup.Click += new System.EventHandler(this.btnsup_Click);
            // 
            // kryptonDataGridViewsup
            // 
            this.kryptonDataGridViewsup.Location = new System.Drawing.Point(43, 109);
            this.kryptonDataGridViewsup.Name = "kryptonDataGridViewsup";
            this.kryptonDataGridViewsup.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewsup.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewsup.RowTemplate.Height = 25;
            this.kryptonDataGridViewsup.Size = new System.Drawing.Size(621, 240);
            this.kryptonDataGridViewsup.TabIndex = 1;
            // 
            // tabroleclaim
            // 
            this.tabroleclaim.Controls.Add(this.btneditroleclaim);
            this.tabroleclaim.Controls.Add(this.cbxroleinroleclaim);
            this.tabroleclaim.Controls.Add(this.txtclaimv);
            this.tabroleclaim.Controls.Add(this.kryptonLabel2);
            this.tabroleclaim.Controls.Add(this.kryptonLabel1);
            this.tabroleclaim.Controls.Add(this.txtclaimt);
            this.tabroleclaim.Controls.Add(this.lblroleclaim);
            this.tabroleclaim.Controls.Add(this.btnaddclaim);
            this.tabroleclaim.Controls.Add(this.kryptonDataGridViewroleclaim);
            this.tabroleclaim.Location = new System.Drawing.Point(4, 24);
            this.tabroleclaim.Name = "tabroleclaim";
            this.tabroleclaim.Padding = new System.Windows.Forms.Padding(3);
            this.tabroleclaim.Size = new System.Drawing.Size(789, 423);
            this.tabroleclaim.TabIndex = 9;
            this.tabroleclaim.Text = "RoleClaim";
            this.tabroleclaim.UseVisualStyleBackColor = true;
            // 
            // btneditroleclaim
            // 
            this.btneditroleclaim.CornerRoundingRadius = -1F;
            this.btneditroleclaim.Location = new System.Drawing.Point(160, 20);
            this.btneditroleclaim.Name = "btneditroleclaim";
            this.btneditroleclaim.Palette = this.kryptonPalettebtn;
            this.btneditroleclaim.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btneditroleclaim.Size = new System.Drawing.Size(93, 38);
            this.btneditroleclaim.TabIndex = 12;
            this.btneditroleclaim.Values.Text = "Update";
            this.btneditroleclaim.Click += new System.EventHandler(this.btneditroleclaim_Click);
            // 
            // cbxroleinroleclaim
            // 
            this.cbxroleinroleclaim.CornerRoundingRadius = -1F;
            this.cbxroleinroleclaim.DropDownWidth = 146;
            this.cbxroleinroleclaim.IntegralHeight = false;
            this.cbxroleinroleclaim.Location = new System.Drawing.Point(83, 72);
            this.cbxroleinroleclaim.Name = "cbxroleinroleclaim";
            this.cbxroleinroleclaim.Size = new System.Drawing.Size(146, 21);
            this.cbxroleinroleclaim.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxroleinroleclaim.TabIndex = 11;
            // 
            // txtclaimv
            // 
            this.txtclaimv.Location = new System.Drawing.Point(598, 68);
            this.txtclaimv.Name = "txtclaimv";
            this.txtclaimv.Size = new System.Drawing.Size(160, 23);
            this.txtclaimv.TabIndex = 10;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(500, 70);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Palette = this.kryptonPalettelbl;
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel2.Size = new System.Drawing.Size(92, 21);
            this.kryptonLabel2.TabIndex = 9;
            this.kryptonLabel2.Values.Text = "Claim value";
            // 
            // kryptonPalettelbl
            // 
            this.kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(33, 72);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Palette = this.kryptonPalettelbl;
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 21);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Role";
            // 
            // txtclaimt
            // 
            this.txtclaimt.Location = new System.Drawing.Point(320, 70);
            this.txtclaimt.Name = "txtclaimt";
            this.txtclaimt.Size = new System.Drawing.Size(160, 23);
            this.txtclaimt.TabIndex = 6;
            // 
            // lblroleclaim
            // 
            this.lblroleclaim.Location = new System.Drawing.Point(235, 70);
            this.lblroleclaim.Name = "lblroleclaim";
            this.lblroleclaim.Palette = this.kryptonPalettelbl;
            this.lblroleclaim.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblroleclaim.Size = new System.Drawing.Size(90, 21);
            this.lblroleclaim.TabIndex = 5;
            this.lblroleclaim.Values.Text = "Claim Type";
            // 
            // btnaddclaim
            // 
            this.btnaddclaim.CornerRoundingRadius = -1F;
            this.btnaddclaim.Location = new System.Drawing.Point(33, 20);
            this.btnaddclaim.Name = "btnaddclaim";
            this.btnaddclaim.Palette = this.kryptonPalettebtn;
            this.btnaddclaim.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnaddclaim.Size = new System.Drawing.Size(93, 38);
            this.btnaddclaim.TabIndex = 4;
            this.btnaddclaim.Values.Text = "Add";
            this.btnaddclaim.Click += new System.EventHandler(this.btnaddclaim_Click);
            // 
            // kryptonDataGridViewroleclaim
            // 
            this.kryptonDataGridViewroleclaim.Location = new System.Drawing.Point(33, 109);
            this.kryptonDataGridViewroleclaim.Name = "kryptonDataGridViewroleclaim";
            this.kryptonDataGridViewroleclaim.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridViewroleclaim.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridViewroleclaim.RowTemplate.Height = 25;
            this.kryptonDataGridViewroleclaim.Size = new System.Drawing.Size(659, 213);
            this.kryptonDataGridViewroleclaim.TabIndex = 0;
            // 
            // tabpagevid
            // 
            this.tabpagevid.Controls.Add(this.cbxvidmaploc);
            this.tabpagevid.Controls.Add(this.lblvipmaploc);
            this.tabpagevid.Controls.Add(this.btnidinsert);
            this.tabpagevid.Controls.Add(this.btniddrop);
            this.tabpagevid.Controls.Add(this.cbxvidmapitemid);
            this.tabpagevid.Controls.Add(this.lblvidmapitemid);
            this.tabpagevid.Controls.Add(this.lstbox);
            this.tabpagevid.Controls.Add(this.cbxvidmapvid);
            this.tabpagevid.Controls.Add(this.lblvid);
            this.tabpagevid.Location = new System.Drawing.Point(4, 24);
            this.tabpagevid.Name = "tabpagevid";
            this.tabpagevid.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagevid.Size = new System.Drawing.Size(789, 423);
            this.tabpagevid.TabIndex = 10;
            this.tabpagevid.Text = "Vid Mapping";
            this.tabpagevid.UseVisualStyleBackColor = true;
            // 
            // cbxvidmaploc
            // 
            this.cbxvidmaploc.CornerRoundingRadius = -1F;
            this.cbxvidmaploc.DropDownWidth = 146;
            this.cbxvidmaploc.IntegralHeight = false;
            this.cbxvidmaploc.Location = new System.Drawing.Point(646, 204);
            this.cbxvidmaploc.Name = "cbxvidmaploc";
            this.cbxvidmaploc.Size = new System.Drawing.Size(124, 21);
            this.cbxvidmaploc.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxvidmaploc.TabIndex = 27;
            this.cbxvidmaploc.Tag = "bi_prefer_loc_id";
            // 
            // lblvipmaploc
            // 
            this.lblvipmaploc.Location = new System.Drawing.Point(575, 204);
            this.lblvipmaploc.Name = "lblvipmaploc";
            this.lblvipmaploc.Palette = this.kryptonPalettelbl;
            this.lblvipmaploc.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblvipmaploc.Size = new System.Drawing.Size(70, 21);
            this.lblvipmaploc.TabIndex = 26;
            this.lblvipmaploc.Values.Text = "Location";
            // 
            // btnidinsert
            // 
            this.btnidinsert.Image = ((System.Drawing.Image)(resources.GetObject("btnidinsert.Image")));
            this.btnidinsert.Location = new System.Drawing.Point(586, 102);
            this.btnidinsert.Name = "btnidinsert";
            this.btnidinsert.Size = new System.Drawing.Size(71, 34);
            this.btnidinsert.TabIndex = 25;
            this.btnidinsert.UseVisualStyleBackColor = true;
            this.btnidinsert.Click += new System.EventHandler(this.btnidinsert_Click);
            // 
            // btniddrop
            // 
            this.btniddrop.Image = ((System.Drawing.Image)(resources.GetObject("btniddrop.Image")));
            this.btniddrop.Location = new System.Drawing.Point(586, 247);
            this.btniddrop.Name = "btniddrop";
            this.btniddrop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btniddrop.Size = new System.Drawing.Size(71, 34);
            this.btniddrop.TabIndex = 24;
            this.btniddrop.UseVisualStyleBackColor = true;
            this.btniddrop.Click += new System.EventHandler(this.btniddrop_Click);
            // 
            // cbxvidmapitemid
            // 
            this.cbxvidmapitemid.CornerRoundingRadius = -1F;
            this.cbxvidmapitemid.DropDownWidth = 146;
            this.cbxvidmapitemid.IntegralHeight = false;
            this.cbxvidmapitemid.Location = new System.Drawing.Point(646, 177);
            this.cbxvidmapitemid.Name = "cbxvidmapitemid";
            this.cbxvidmapitemid.Size = new System.Drawing.Size(124, 21);
            this.cbxvidmapitemid.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxvidmapitemid.TabIndex = 22;
            this.cbxvidmapitemid.Tag = "bi_item_id";
            // 
            // lblvidmapitemid
            // 
            this.lblvidmapitemid.Location = new System.Drawing.Point(586, 177);
            this.lblvidmapitemid.Name = "lblvidmapitemid";
            this.lblvidmapitemid.Palette = this.kryptonPalettelbl;
            this.lblvidmapitemid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblvidmapitemid.Size = new System.Drawing.Size(59, 21);
            this.lblvidmapitemid.TabIndex = 21;
            this.lblvidmapitemid.Values.Text = "Item Id";
            // 
            // lstbox
            // 
            this.lstbox.Location = new System.Drawing.Point(81, 55);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(488, 265);
            this.lstbox.TabIndex = 19;
            this.lstbox.Tag = "bi_item_id:bi_prefer_loc_id";
            // 
            // cbxvidmapvid
            // 
            this.cbxvidmapvid.CornerRoundingRadius = -1F;
            this.cbxvidmapvid.DropDownWidth = 146;
            this.cbxvidmapvid.IntegralHeight = false;
            this.cbxvidmapvid.Location = new System.Drawing.Point(81, 341);
            this.cbxvidmapvid.Name = "cbxvidmapvid";
            this.cbxvidmapvid.Size = new System.Drawing.Size(124, 21);
            this.cbxvidmapvid.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxvidmapvid.TabIndex = 18;
            this.cbxvidmapvid.Tag = "bi_item_vid";
            this.cbxvidmapvid.SelectedIndexChanged += new System.EventHandler(this.cbxvidmap_SelectedIndexChanged);
            // 
            // lblvid
            // 
            this.lblvid.Location = new System.Drawing.Point(7, 341);
            this.lblvid.Name = "lblvid";
            this.lblvid.Palette = this.kryptonPalettelbl;
            this.lblvid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblvid.Size = new System.Drawing.Size(68, 21);
            this.lblvid.TabIndex = 15;
            this.lblvid.Values.Text = "Item Vid";
            // 
            // tabPagecat
            // 
            this.tabPagecat.Controls.Add(this.kryptonTextBox1);
            this.tabPagecat.Controls.Add(this.kryptonLabel3);
            this.tabPagecat.Controls.Add(this.kryptonDataGridView1);
            this.tabPagecat.Controls.Add(this.btnaddcat);
            this.tabPagecat.Controls.Add(this.btneditcat);
            this.tabPagecat.Location = new System.Drawing.Point(4, 24);
            this.tabPagecat.Name = "tabPagecat";
            this.tabPagecat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagecat.Size = new System.Drawing.Size(789, 423);
            this.tabPagecat.TabIndex = 11;
            this.tabPagecat.Text = "Category";
            this.tabPagecat.UseVisualStyleBackColor = true;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(71, 99);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(170, 23);
            this.kryptonTextBox1.TabIndex = 17;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(22, 102);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel3.TabIndex = 16;
            this.kryptonLabel3.Values.Text = "Name";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Location = new System.Drawing.Point(22, 152);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Palette = this.kryptonPalettedatagridview;
            this.kryptonDataGridView1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridView1.RowTemplate.Height = 25;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(621, 240);
            this.kryptonDataGridView1.TabIndex = 15;
            // 
            // btnaddcat
            // 
            this.btnaddcat.CornerRoundingRadius = -1F;
            this.btnaddcat.Location = new System.Drawing.Point(22, 34);
            this.btnaddcat.Name = "btnaddcat";
            this.btnaddcat.Palette = this.kryptonPalettebtn;
            this.btnaddcat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnaddcat.Size = new System.Drawing.Size(93, 38);
            this.btnaddcat.TabIndex = 14;
            this.btnaddcat.Values.Text = "Add";
            this.btnaddcat.Click += new System.EventHandler(this.btnaddcat_Click);
            // 
            // btneditcat
            // 
            this.btneditcat.CornerRoundingRadius = -1F;
            this.btneditcat.Location = new System.Drawing.Point(148, 34);
            this.btneditcat.Name = "btneditcat";
            this.btneditcat.Palette = this.kryptonPalettebtn;
            this.btneditcat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btneditcat.Size = new System.Drawing.Size(93, 38);
            this.btneditcat.TabIndex = 13;
            this.btneditcat.Values.Text = "Update";
            this.btneditcat.Click += new System.EventHandler(this.btneditcat_Click);
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
            // btneditrole
            // 
            this.btneditrole.CornerRoundingRadius = -1F;
            this.btneditrole.Location = new System.Drawing.Point(190, 25);
            this.btneditrole.Name = "btneditrole";
            this.btneditrole.Palette = this.kryptonPalettebtn;
            this.btneditrole.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btneditrole.Size = new System.Drawing.Size(93, 35);
            this.btneditrole.TabIndex = 7;
            this.btneditrole.Values.Text = "Update";
            this.btneditrole.Click += new System.EventHandler(this.btneditrole_Click);
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 444);
            this.Controls.Add(this.multiDetailView);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.multiDetailView.ResumeLayout(false);
            this.tabPageRole.ResumeLayout(false);
            this.tabPageRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptodatagridrole)).EndInit();
            this.tabPageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewUser)).EndInit();
            this.tabPagedelisc.ResumeLayout(false);
            this.tabPagedelisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewdelisc)).EndInit();
            this.tabPagetpoatype.ResumeLayout(false);
            this.tabPagetpoatype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewpoa)).EndInit();
            this.tabPagetc.ResumeLayout(false);
            this.tabPagetc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewtc)).EndInit();
            this.tabPageuom.ResumeLayout(false);
            this.tabPageuom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewuom)).EndInit();
            this.tabPageloc.ResumeLayout(false);
            this.tabPageloc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewloc)).EndInit();
            this.tabPagepo.ResumeLayout(false);
            this.tabPagepo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewpo)).EndInit();
            this.tabPagesup.ResumeLayout(false);
            this.tabPagesup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewsup)).EndInit();
            this.tabroleclaim.ResumeLayout(false);
            this.tabroleclaim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxroleinroleclaim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewroleclaim)).EndInit();
            this.tabpagevid.ResumeLayout(false);
            this.tabpagevid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxvidmaploc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxvidmapitemid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxvidmapvid)).EndInit();
            this.tabPagecat.ResumeLayout(false);
            this.tabPagecat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private Krypton.Toolkit.KryptonPalette kryptonPaletteCsv;
        private Krypton.Toolkit.KryptonButton btnEditdelic;
        private Krypton.Toolkit.KryptonButton btneditpoatype;
        private Krypton.Toolkit.KryptonButton btnedittc;
        private Krypton.Toolkit.KryptonButton btnedituom;
        private Krypton.Toolkit.KryptonButton btneditloc;
        private Krypton.Toolkit.KryptonButton btneditpotype;
        private Krypton.Toolkit.KryptonButton btneditsupp;
        private Krypton.Toolkit.KryptonButton btneditroleclaim;
        private TabPage tabPagecat;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonButton btnaddcat;
        private Krypton.Toolkit.KryptonButton btneditcat;
        private Krypton.Toolkit.KryptonButton btneditrole;
    }
}