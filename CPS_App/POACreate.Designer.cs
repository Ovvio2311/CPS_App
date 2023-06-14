using Krypton.Toolkit;

namespace CPS_App
{
    partial class POACreate
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
            lbltype = new KryptonLabel();
            kryptonPalettelbl = new KryptonPalette(components);
            lblloc = new KryptonLabel();
            lblsup = new KryptonLabel();
            lblcur = new KryptonLabel();
            lbltc = new KryptonLabel();
            lbldelisc = new KryptonLabel();
            lblecf = new KryptonLabel();
            lblcont = new KryptonLabel();
            txtcont = new KryptonTextBox();
            pn1 = new KryptonPanel();
            cbxcur = new KryptonComboBox();
            btncancel = new KryptonButton();
            kryptonPalettebtn = new KryptonPalette(components);
            btnclear1 = new KryptonButton();
            btnnext = new KryptonButton();
            kryptonDateTimePickerec = new KryptonDateTimePicker();
            lblpoacreate = new KryptonWrapLabel();
            kryptonPaletteheader = new KryptonPalette(components);
            cbxselisc = new KryptonComboBox();
            cbxtc = new KryptonComboBox();
            cbxsup = new KryptonComboBox();
            cbxloc = new KryptonComboBox();
            cbxtype = new KryptonComboBox();
            kryptonPalettepanel = new KryptonPalette(components);
            btnclear = new KryptonButton();
            pn2 = new KryptonPanel();
            cbxuom = new KryptonComboBox();
            btnback = new KryptonButton();
            lblitemcr = new KryptonWrapLabel();
            txtquot = new KryptonTextBox();
            txtref = new KryptonTextBox();
            txtam = new KryptonTextBox();
            lblquot = new KryptonLabel();
            lblref = new KryptonLabel();
            lblam = new KryptonLabel();
            txtpri = new KryptonTextBox();
            txtminqty = new KryptonTextBox();
            txtproqty = new KryptonTextBox();
            txtsupitid = new KryptonTextBox();
            cbxitid = new KryptonComboBox();
            lblpri = new KryptonLabel();
            lblminqty = new KryptonLabel();
            lbluom = new KryptonLabel();
            lblproqty = new KryptonLabel();
            lblsupid = new KryptonLabel();
            lblitid = new KryptonLabel();
            btnAdd = new KryptonButton();
            btnsubmit = new KryptonButton();
            kryptonPalettereadonly = new KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)pn1).BeginInit();
            pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxcur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxselisc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxtc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxsup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxloc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxtype).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pn2).BeginInit();
            pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbxuom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbxitid).BeginInit();
            SuspendLayout();
            // 
            // lbltype
            // 
            lbltype.ForeColor = Color.FromArgb(177, 192, 214);
            lbltype.LabelStyle = LabelStyle.NormalControl;
            lbltype.Location = new Point(130, 110);
            lbltype.Name = "lbltype";
            lbltype.Palette = kryptonPalettelbl;
            lbltype.PaletteMode = PaletteMode.Custom;
            lbltype.Size = new Size(46, 21);
            lbltype.TabIndex = 1;
            lbltype.Tag = "vc_poa_type_desc";
            lbltype.Values.Text = "Type";
            // 
            // kryptonPalettelbl
            // 
            kryptonPalettelbl.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonPalettelbl.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // lblloc
            // 
            lblloc.ForeColor = Color.FromArgb(177, 192, 214);
            lblloc.Location = new Point(46, 160);
            lblloc.Name = "lblloc";
            lblloc.Palette = kryptonPalettelbl;
            lblloc.PaletteMode = PaletteMode.Custom;
            lblloc.Size = new Size(130, 21);
            lblloc.TabIndex = 2;
            lblloc.Tag = "vc_location_desc";
            lblloc.Values.Text = "Delivery Location";
            // 
            // lblsup
            // 
            lblsup.ForeColor = Color.FromArgb(177, 192, 214);
            lblsup.Location = new Point(108, 213);
            lblsup.Name = "lblsup";
            lblsup.Palette = kryptonPalettelbl;
            lblsup.PaletteMode = PaletteMode.Custom;
            lblsup.Size = new Size(68, 21);
            lblsup.TabIndex = 3;
            lblsup.Tag = "vc_supp_desc";
            lblsup.Values.Text = "Supplier";
            // 
            // lblcur
            // 
            lblcur.ForeColor = Color.FromArgb(177, 192, 214);
            lblcur.Location = new Point(102, 270);
            lblcur.Name = "lblcur";
            lblcur.Palette = kryptonPalettelbl;
            lblcur.PaletteMode = PaletteMode.Custom;
            lblcur.Size = new Size(74, 21);
            lblcur.TabIndex = 4;
            lblcur.Tag = "vc_cur_desc";
            lblcur.Values.Text = "Currency";
            // 
            // lbltc
            // 
            lbltc.ForeColor = Color.FromArgb(177, 192, 214);
            lbltc.Location = new Point(356, 213);
            lbltc.Name = "lbltc";
            lbltc.Palette = kryptonPalettelbl;
            lbltc.PaletteMode = PaletteMode.Custom;
            lbltc.Size = new Size(162, 21);
            lbltc.TabIndex = 4;
            lbltc.Tag = "vc_tc_desc";
            lbltc.Values.Text = "Terms and Conditions";
            // 
            // lbldelisc
            // 
            lbldelisc.ForeColor = Color.FromArgb(177, 192, 214);
            lbldelisc.Location = new Point(376, 270);
            lbldelisc.Name = "lbldelisc";
            lbldelisc.Palette = kryptonPalettelbl;
            lbldelisc.PaletteMode = PaletteMode.Custom;
            lbldelisc.Size = new Size(136, 21);
            lbldelisc.TabIndex = 5;
            lbldelisc.Tag = "vc_deli_sched_desc";
            lbldelisc.Values.Text = "Delivery Schedule";
            // 
            // lblecf
            // 
            lblecf.ForeColor = Color.FromArgb(177, 192, 214);
            lblecf.Location = new Point(404, 110);
            lblecf.Name = "lblecf";
            lblecf.Palette = kryptonPalettelbl;
            lblecf.PaletteMode = PaletteMode.Custom;
            lblecf.Size = new Size(108, 21);
            lblecf.TabIndex = 5;
            lblecf.Tag = "dt_effect_date";
            lblecf.Values.Text = "Effective Date";
            // 
            // lblcont
            // 
            lblcont.ForeColor = Color.FromArgb(177, 192, 214);
            lblcont.Location = new Point(404, 160);
            lblcont.Name = "lblcont";
            lblcont.Palette = kryptonPalettelbl;
            lblcont.PaletteMode = PaletteMode.Custom;
            lblcont.Size = new Size(98, 21);
            lblcont.TabIndex = 7;
            lblcont.Tag = "bi_contract_no";
            lblcont.Values.Text = "Contract No.";
            // 
            // txtcont
            // 
            txtcont.Location = new Point(518, 160);
            txtcont.Name = "txtcont";
            txtcont.Size = new Size(160, 23);
            txtcont.TabIndex = 6;
            txtcont.Tag = "bi_contract_no";
            // 
            // pn1
            // 
            pn1.Controls.Add(cbxcur);
            pn1.Controls.Add(btncancel);
            pn1.Controls.Add(btnclear1);
            pn1.Controls.Add(btnnext);
            pn1.Controls.Add(txtcont);
            pn1.Controls.Add(kryptonDateTimePickerec);
            pn1.Controls.Add(lblpoacreate);
            pn1.Controls.Add(cbxselisc);
            pn1.Controls.Add(cbxtc);
            pn1.Controls.Add(cbxsup);
            pn1.Controls.Add(cbxloc);
            pn1.Controls.Add(cbxtype);
            pn1.Controls.Add(lbltc);
            pn1.Controls.Add(lbldelisc);
            pn1.Controls.Add(lblcont);
            pn1.Controls.Add(lblecf);
            pn1.Controls.Add(lbltype);
            pn1.Controls.Add(lblloc);
            pn1.Controls.Add(lblsup);
            pn1.Controls.Add(lblcur);
            pn1.Location = new Point(3, 3);
            pn1.Name = "pn1";
            pn1.Palette = kryptonPalettepanel;
            pn1.PaletteMode = PaletteMode.Custom;
            pn1.Size = new Size(817, 436);
            pn1.TabIndex = 18;
            // 
            // cbxcur
            // 
            cbxcur.CornerRoundingRadius = -1F;
            cbxcur.DropDownWidth = 121;
            cbxcur.IntegralHeight = false;
            cbxcur.Location = new Point(182, 270);
            cbxcur.Name = "cbxcur";
            cbxcur.Size = new Size(160, 21);
            cbxcur.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cbxcur.TabIndex = 4;
            cbxcur.Tag = "i_cur_id:vc_cur_desc";
            // 
            // btncancel
            // 
            btncancel.CornerRoundingRadius = -1F;
            btncancel.Location = new Point(397, 333);
            btncancel.Name = "btncancel";
            btncancel.Palette = kryptonPalettebtn;
            btncancel.PaletteMode = PaletteMode.Custom;
            btncancel.Size = new Size(115, 38);
            btncancel.TabIndex = 10;
            btncancel.Values.Text = "Cancel";
            btncancel.Click += btncancel_Click;
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
            // btnclear1
            // 
            btnclear1.CornerRoundingRadius = -1F;
            btnclear1.Location = new Point(228, 333);
            btnclear1.Name = "btnclear1";
            btnclear1.Palette = kryptonPalettebtn;
            btnclear1.PaletteMode = PaletteMode.Custom;
            btnclear1.Size = new Size(114, 38);
            btnclear1.TabIndex = 9;
            btnclear1.Values.Text = "Clear";
            btnclear1.Click += btnclear_Click;
            // 
            // btnnext
            // 
            btnnext.CornerRoundingRadius = -1F;
            btnnext.Location = new Point(563, 333);
            btnnext.Name = "btnnext";
            btnnext.Palette = kryptonPalettebtn;
            btnnext.PaletteMode = PaletteMode.Custom;
            btnnext.Size = new Size(115, 38);
            btnnext.TabIndex = 11;
            btnnext.Values.Text = "Next";
            btnnext.Click += btnnext_Click;
            // 
            // kryptonDateTimePickerec
            // 
            kryptonDateTimePickerec.CalendarTodayDate = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            kryptonDateTimePickerec.CornerRoundingRadius = -1F;
            kryptonDateTimePickerec.Location = new Point(518, 110);
            kryptonDateTimePickerec.Name = "kryptonDateTimePickerec";
            kryptonDateTimePickerec.Size = new Size(160, 21);
            kryptonDateTimePickerec.TabIndex = 5;
            kryptonDateTimePickerec.Tag = "dt_effect_date";
            // 
            // lblpoacreate
            // 
            lblpoacreate.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblpoacreate.ForeColor = Color.DarkCyan;
            lblpoacreate.LabelStyle = LabelStyle.BoldControl;
            lblpoacreate.Location = new Point(46, 46);
            lblpoacreate.Name = "lblpoacreate";
            lblpoacreate.Palette = kryptonPaletteheader;
            lblpoacreate.PaletteMode = PaletteMode.Custom;
            lblpoacreate.Size = new Size(124, 27);
            lblpoacreate.StateCommon.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblpoacreate.Text = "POA Create";
            // 
            // kryptonPaletteheader
            // 
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = Color.DarkCyan;
            kryptonPaletteheader.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // cbxselisc
            // 
            cbxselisc.CornerRoundingRadius = -1F;
            cbxselisc.DropDownWidth = 121;
            cbxselisc.IntegralHeight = false;
            cbxselisc.Location = new Point(518, 270);
            cbxselisc.Name = "cbxselisc";
            cbxselisc.Size = new Size(160, 21);
            cbxselisc.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cbxselisc.TabIndex = 8;
            cbxselisc.Tag = "ti_deli_sched_id:vc_deli_sched_desc";
            // 
            // cbxtc
            // 
            cbxtc.CornerRoundingRadius = -1F;
            cbxtc.DropDownWidth = 121;
            cbxtc.IntegralHeight = false;
            cbxtc.Location = new Point(518, 213);
            cbxtc.Name = "cbxtc";
            cbxtc.Size = new Size(160, 21);
            cbxtc.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cbxtc.TabIndex = 7;
            cbxtc.Tag = "ti_tc_id:vc_tc_desc";
            // 
            // cbxsup
            // 
            cbxsup.CornerRoundingRadius = -1F;
            cbxsup.DropDownWidth = 121;
            cbxsup.IntegralHeight = false;
            cbxsup.Location = new Point(182, 213);
            cbxsup.Name = "cbxsup";
            cbxsup.Size = new Size(160, 21);
            cbxsup.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cbxsup.TabIndex = 3;
            cbxsup.Tag = "bi_supp_id:vc_supp_desc";
            // 
            // cbxloc
            // 
            cbxloc.CornerRoundingRadius = -1F;
            cbxloc.DropDownWidth = 121;
            cbxloc.IntegralHeight = false;
            cbxloc.Location = new Point(182, 160);
            cbxloc.Name = "cbxloc";
            cbxloc.Size = new Size(160, 21);
            cbxloc.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cbxloc.TabIndex = 2;
            cbxloc.Tag = "bi_deli_loc_id:vc_location_desc";
            // 
            // cbxtype
            // 
            cbxtype.CornerRoundingRadius = -1F;
            cbxtype.DropDownWidth = 121;
            cbxtype.IntegralHeight = false;
            cbxtype.Location = new Point(182, 110);
            cbxtype.Name = "cbxtype";
            cbxtype.Size = new Size(160, 21);
            cbxtype.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cbxtype.TabIndex = 1;
            cbxtype.Tag = "ti_poa_type_id:vc_poa_type_desc";
            cbxtype.SelectedIndexChanged += cbxtype_SelectedIndexChanged;
            // 
            // kryptonPalettepanel
            // 
            kryptonPalettepanel.Common.StateCommon.Back.Color1 = Color.Transparent;
            kryptonPalettepanel.Common.StateCommon.Back.Color2 = Color.Transparent;
            // 
            // btnclear
            // 
            btnclear.CornerRoundingRadius = -1F;
            btnclear.Location = new Point(80, 377);
            btnclear.Name = "btnclear";
            btnclear.Palette = kryptonPalettebtn;
            btnclear.PaletteMode = PaletteMode.Custom;
            btnclear.Size = new Size(114, 38);
            btnclear.TabIndex = 21;
            btnclear.Values.Text = "Clear";
            btnclear.Click += btnclear_Click;
            // 
            // pn2
            // 
            pn2.Controls.Add(cbxuom);
            pn2.Controls.Add(btnback);
            pn2.Controls.Add(lblitemcr);
            pn2.Controls.Add(txtquot);
            pn2.Controls.Add(txtref);
            pn2.Controls.Add(txtam);
            pn2.Controls.Add(lblquot);
            pn2.Controls.Add(lblref);
            pn2.Controls.Add(lblam);
            pn2.Controls.Add(txtpri);
            pn2.Controls.Add(txtminqty);
            pn2.Controls.Add(txtproqty);
            pn2.Controls.Add(txtsupitid);
            pn2.Controls.Add(cbxitid);
            pn2.Controls.Add(lblpri);
            pn2.Controls.Add(lblminqty);
            pn2.Controls.Add(lbluom);
            pn2.Controls.Add(lblproqty);
            pn2.Controls.Add(lblsupid);
            pn2.Controls.Add(lblitid);
            pn2.Controls.Add(btnAdd);
            pn2.Controls.Add(btnsubmit);
            pn2.Controls.Add(btnclear);
            pn2.Location = new Point(3, 3);
            pn2.Name = "pn2";
            pn2.Palette = kryptonPalettepanel;
            pn2.PaletteMode = PaletteMode.Custom;
            pn2.Size = new Size(899, 454);
            pn2.TabIndex = 19;
            // 
            // cbxuom
            // 
            cbxuom.CornerRoundingRadius = -1F;
            cbxuom.DropDownWidth = 121;
            cbxuom.Enabled = false;
            cbxuom.IntegralHeight = false;
            cbxuom.Location = new Point(228, 290);
            cbxuom.Name = "cbxuom";
            cbxuom.Size = new Size(160, 21);
            cbxuom.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cbxuom.TabIndex = 50;
            cbxuom.Tag = "i_uom_id:vc_uom_desc";
            // 
            // btnback
            // 
            btnback.CornerRoundingRadius = -1F;
            btnback.Location = new Point(218, 377);
            btnback.Name = "btnback";
            btnback.Palette = kryptonPalettebtn;
            btnback.PaletteMode = PaletteMode.Custom;
            btnback.Size = new Size(115, 38);
            btnback.TabIndex = 22;
            btnback.Values.Text = "Back";
            btnback.Click += btnback_Click;
            // 
            // lblitemcr
            // 
            lblitemcr.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblitemcr.ForeColor = Color.DarkCyan;
            lblitemcr.LabelStyle = LabelStyle.BoldControl;
            lblitemcr.Location = new Point(28, 46);
            lblitemcr.Name = "lblitemcr";
            lblitemcr.Palette = kryptonPaletteheader;
            lblitemcr.PaletteMode = PaletteMode.Custom;
            lblitemcr.Size = new Size(104, 27);
            lblitemcr.StateCommon.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblitemcr.Text = "Item Add";
            // 
            // txtquot
            // 
            txtquot.Location = new Point(540, 244);
            txtquot.Name = "txtquot";
            txtquot.Size = new Size(160, 23);
            txtquot.TabIndex = 20;
            txtquot.Tag = "bi_quot_no";
            // 
            // txtref
            // 
            txtref.Location = new Point(540, 194);
            txtref.Name = "txtref";
            txtref.Size = new Size(160, 23);
            txtref.TabIndex = 19;
            txtref.Tag = "vc_reference";
            // 
            // txtam
            // 
            txtam.Enabled = false;
            txtam.Location = new Point(228, 244);
            txtam.Name = "txtam";
            txtam.Size = new Size(160, 23);
            txtam.TabIndex = 15;
            txtam.Tag = "dc_amount";
            // 
            // lblquot
            // 
            lblquot.Location = new Point(427, 244);
            lblquot.Name = "lblquot";
            lblquot.Palette = kryptonPalettelbl;
            lblquot.PaletteMode = PaletteMode.Custom;
            lblquot.Size = new Size(107, 21);
            lblquot.TabIndex = 47;
            lblquot.Tag = "bi_quot_no";
            lblquot.Values.Text = "Quotation No.";
            // 
            // lblref
            // 
            lblref.Location = new Point(444, 196);
            lblref.Name = "lblref";
            lblref.Palette = kryptonPalettelbl;
            lblref.PaletteMode = PaletteMode.Custom;
            lblref.Size = new Size(83, 21);
            lblref.TabIndex = 46;
            lblref.Tag = "vc_reference";
            lblref.Values.Text = "Reference";
            // 
            // lblam
            // 
            lblam.Location = new Point(157, 243);
            lblam.Name = "lblam";
            lblam.Palette = kryptonPalettelbl;
            lblam.PaletteMode = PaletteMode.Custom;
            lblam.Size = new Size(65, 21);
            lblam.TabIndex = 45;
            lblam.Tag = "dc_amount";
            lblam.Values.Text = "Amount";
            // 
            // txtpri
            // 
            txtpri.Location = new Point(540, 141);
            txtpri.Name = "txtpri";
            txtpri.Size = new Size(160, 23);
            txtpri.TabIndex = 18;
            txtpri.Tag = "dc_price";
            // 
            // txtminqty
            // 
            txtminqty.Location = new Point(540, 95);
            txtminqty.Name = "txtminqty";
            txtminqty.Size = new Size(160, 23);
            txtminqty.TabIndex = 17;
            txtminqty.Tag = "dc_min_qty";
            // 
            // txtproqty
            // 
            txtproqty.Location = new Point(228, 194);
            txtproqty.Name = "txtproqty";
            txtproqty.Size = new Size(160, 23);
            txtproqty.TabIndex = 14;
            txtproqty.Tag = "dc_promise_qty";
            // 
            // txtsupitid
            // 
            txtsupitid.Location = new Point(228, 141);
            txtsupitid.Name = "txtsupitid";
            txtsupitid.Size = new Size(160, 23);
            txtsupitid.TabIndex = 13;
            txtsupitid.Tag = "bi_supp_item_id";
            // 
            // cbxitid
            // 
            cbxitid.CornerRoundingRadius = -1F;
            cbxitid.DropDownWidth = 121;
            cbxitid.IntegralHeight = false;
            cbxitid.Location = new Point(228, 95);
            cbxitid.Name = "cbxitid";
            cbxitid.Size = new Size(160, 21);
            cbxitid.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cbxitid.TabIndex = 12;
            cbxitid.Tag = "bi_item_id:vc_item_desc";
            // 
            // lblpri
            // 
            lblpri.Location = new Point(474, 141);
            lblpri.Name = "lblpri";
            lblpri.Palette = kryptonPalettelbl;
            lblpri.PaletteMode = PaletteMode.Custom;
            lblpri.Size = new Size(47, 21);
            lblpri.TabIndex = 38;
            lblpri.Tag = "dc_price";
            lblpri.Values.Text = "Price";
            // 
            // lblminqty
            // 
            lblminqty.Location = new Point(462, 97);
            lblminqty.Name = "lblminqty";
            lblminqty.Palette = kryptonPalettelbl;
            lblminqty.PaletteMode = PaletteMode.Custom;
            lblminqty.Size = new Size(65, 21);
            lblminqty.TabIndex = 37;
            lblminqty.Tag = "dc_min_qty";
            lblminqty.Values.Text = "Min Qty";
            // 
            // lbluom
            // 
            lbluom.Location = new Point(67, 290);
            lbluom.Name = "lbluom";
            lbluom.Palette = kryptonPalettelbl;
            lbluom.PaletteMode = PaletteMode.Custom;
            lbluom.Size = new Size(155, 21);
            lbluom.TabIndex = 36;
            lbluom.Tag = "vc_uom_desc";
            lbluom.Values.Text = "Unit of Measurement";
            // 
            // lblproqty
            // 
            lblproqty.Location = new Point(126, 194);
            lblproqty.Name = "lblproqty";
            lblproqty.Palette = kryptonPalettelbl;
            lblproqty.PaletteMode = PaletteMode.Custom;
            lblproqty.Size = new Size(96, 21);
            lblproqty.TabIndex = 35;
            lblproqty.Tag = "dc_promise_qty";
            lblproqty.Values.Text = "Promise Qty";
            // 
            // lblsupid
            // 
            lblsupid.Location = new Point(103, 141);
            lblsupid.Name = "lblsupid";
            lblsupid.Palette = kryptonPalettelbl;
            lblsupid.PaletteMode = PaletteMode.Custom;
            lblsupid.Size = new Size(119, 21);
            lblsupid.TabIndex = 34;
            lblsupid.Tag = "bi_supp_item_id";
            lblsupid.Values.Text = "Supplier Item Id";
            // 
            // lblitid
            // 
            lblitid.Location = new Point(163, 95);
            lblitid.Name = "lblitid";
            lblitid.Palette = kryptonPalettelbl;
            lblitid.PaletteMode = PaletteMode.Custom;
            lblitid.Size = new Size(59, 21);
            lblitid.TabIndex = 33;
            lblitid.Tag = "vc_item_desc";
            lblitid.Values.Text = "Item Id";
            // 
            // btnAdd
            // 
            btnAdd.CornerRoundingRadius = -1F;
            btnAdd.Location = new Point(356, 377);
            btnAdd.Name = "btnAdd";
            btnAdd.Palette = kryptonPalettebtn;
            btnAdd.PaletteMode = PaletteMode.Custom;
            btnAdd.Size = new Size(115, 38);
            btnAdd.TabIndex = 23;
            btnAdd.Values.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnsubmit
            // 
            btnsubmit.CornerRoundingRadius = -1F;
            btnsubmit.Location = new Point(490, 377);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Palette = kryptonPalettebtn;
            btnsubmit.PaletteMode = PaletteMode.Custom;
            btnsubmit.Size = new Size(112, 38);
            btnsubmit.TabIndex = 24;
            btnsubmit.Values.Text = "Submit";
            btnsubmit.Click += btnsubmit_Click;
            // 
            // kryptonPalettereadonly
            // 
            kryptonPalettereadonly.Common.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonPalettereadonly.Common.StateCommon.Back.Color2 = SystemColors.Control;
            // 
            // POACreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 606);
            Controls.Add(pn2);
            Controls.Add(pn1);
            Name = "POACreate";
            Text = "POACreate";
            Load += POACreate_Load;
            ((System.ComponentModel.ISupportInitialize)pn1).EndInit();
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxcur).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxselisc).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxtc).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxsup).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxloc).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxtype).EndInit();
            ((System.ComponentModel.ISupportInitialize)pn2).EndInit();
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbxuom).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbxitid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KryptonLabel lbltype;
        private KryptonLabel lblloc;
        private KryptonLabel lblsup;
        private KryptonLabel lblcur;
        private KryptonLabel lbltc;
        private KryptonLabel lbldelisc;
        private KryptonLabel lblecf;
        private KryptonLabel lblcont;
        private KryptonTextBox txtcur;
        private KryptonTextBox txtcont;
        private KryptonPanel pn1;
        private KryptonWrapLabel lblpoacreate;
        private KryptonComboBox cbxselisc;
        private KryptonComboBox cbxtc;
        private KryptonComboBox cbxsup;
        private KryptonComboBox cbxloc;
        private KryptonComboBox cbxtype;
        private KryptonDateTimePicker kryptonDateTimePickerec;
        private KryptonPanel pn2;
        private KryptonTextBox txtquot;
        private KryptonTextBox txtref;
        private KryptonTextBox txtam;
        private KryptonLabel lblquot;
        private KryptonLabel lblref;
        private KryptonLabel lblam;
        private KryptonTextBox txtpri;
        private KryptonTextBox txtminqty;
        private KryptonTextBox txtproqty;
        private KryptonTextBox txtsupitid;
        private KryptonComboBox cbxitid;
        private KryptonLabel lblpri;
        private KryptonLabel lblminqty;
        private KryptonLabel lbluom;
        private KryptonLabel lblproqty;
        private KryptonLabel lblsupid;
        private KryptonLabel lblitid;
        private KryptonButton btnclear;

        private KryptonWrapLabel lblitemcr;
        private KryptonPalette kryptonPalettelbl;
        private KryptonPalette kryptonPaletteheader;
        private KryptonPalette kryptonPalettereadonly;
        private KryptonPalette kryptonPalettepanel;
        private KryptonPalette kryptonPalettebtn;
        private KryptonButton btnAdd;
        private KryptonButton btnsubmit;
        private KryptonButton btnnext;
        private KryptonButton btnback;
        private KryptonButton btnclear1;
        private KryptonButton btncancel;
        private KryptonComboBox cbxuom;
        private KryptonComboBox cbxcur;
    }
}