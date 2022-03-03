
namespace OkulOtomasyonWebForm
{
    partial class FrmOgretmenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pic_ogretmenresim = new System.Windows.Forms.PictureBox();
            this.cmb_brans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_ilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_il = new DevExpress.XtraEditors.ComboBoxEdit();
            this.msk_telefon = new System.Windows.Forms.MaskedTextBox();
            this.msk_tckimlikno = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyadi = new DevExpress.XtraEditors.TextEdit();
            this.txt_adi = new DevExpress.XtraEditors.TextEdit();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_resimsec = new DevExpress.XtraEditors.SimpleButton();
            this.rch_adres = new System.Windows.Forms.RichTextBox();
            this.txt_mail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ogretmenresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_brans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(3, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1200, 674);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1211, 1);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(844, 674);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(842, 628);
            this.xtraTabPage1.Text = "Öğretmen Bilgi-1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pic_ogretmenresim);
            this.groupControl2.Controls.Add(this.cmb_brans);
            this.groupControl2.Controls.Add(this.cmb_ilce);
            this.groupControl2.Controls.Add(this.cmb_il);
            this.groupControl2.Controls.Add(this.msk_telefon);
            this.groupControl2.Controls.Add(this.msk_tckimlikno);
            this.groupControl2.Controls.Add(this.txt_soyadi);
            this.groupControl2.Controls.Add(this.txt_adi);
            this.groupControl2.Controls.Add(this.txt_id);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(9, 4);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(675, 613);
            this.groupControl2.TabIndex = 1;
            // 
            // pic_ogretmenresim
            // 
            this.pic_ogretmenresim.Image = ((System.Drawing.Image)(resources.GetObject("pic_ogretmenresim.Image")));
            this.pic_ogretmenresim.Location = new System.Drawing.Point(293, 17);
            this.pic_ogretmenresim.Margin = new System.Windows.Forms.Padding(4);
            this.pic_ogretmenresim.Name = "pic_ogretmenresim";
            this.pic_ogretmenresim.Size = new System.Drawing.Size(172, 161);
            this.pic_ogretmenresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ogretmenresim.TabIndex = 17;
            this.pic_ogretmenresim.TabStop = false;
            // 
            // cmb_brans
            // 
            this.cmb_brans.Location = new System.Drawing.Point(163, 479);
            this.cmb_brans.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmb_brans.Properties.Appearance.Options.UseFont = true;
            this.cmb_brans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_brans.Size = new System.Drawing.Size(304, 28);
            this.cmb_brans.TabIndex = 16;
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.Location = new System.Drawing.Point(163, 436);
            this.cmb_ilce.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmb_ilce.Properties.Appearance.Options.UseFont = true;
            this.cmb_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ilce.Size = new System.Drawing.Size(304, 28);
            this.cmb_ilce.TabIndex = 15;
            // 
            // cmb_il
            // 
            this.cmb_il.Location = new System.Drawing.Point(163, 391);
            this.cmb_il.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_il.Name = "cmb_il";
            this.cmb_il.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmb_il.Properties.Appearance.Options.UseFont = true;
            this.cmb_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_il.Size = new System.Drawing.Size(304, 28);
            this.cmb_il.TabIndex = 14;
            this.cmb_il.SelectedIndexChanged += new System.EventHandler(this.cmb_il_SelectedIndexChanged);
            // 
            // msk_telefon
            // 
            this.msk_telefon.Font = new System.Drawing.Font("Tahoma", 11F);
            this.msk_telefon.Location = new System.Drawing.Point(163, 347);
            this.msk_telefon.Margin = new System.Windows.Forms.Padding(4);
            this.msk_telefon.Mask = "(999) 000-0000";
            this.msk_telefon.Name = "msk_telefon";
            this.msk_telefon.Size = new System.Drawing.Size(303, 30);
            this.msk_telefon.TabIndex = 13;
            // 
            // msk_tckimlikno
            // 
            this.msk_tckimlikno.Font = new System.Drawing.Font("Tahoma", 11F);
            this.msk_tckimlikno.Location = new System.Drawing.Point(161, 305);
            this.msk_tckimlikno.Margin = new System.Windows.Forms.Padding(4);
            this.msk_tckimlikno.Mask = "00000000000";
            this.msk_tckimlikno.Name = "msk_tckimlikno";
            this.msk_tckimlikno.Size = new System.Drawing.Size(303, 30);
            this.msk_tckimlikno.TabIndex = 12;
            this.msk_tckimlikno.ValidatingType = typeof(int);
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(161, 260);
            this.txt_soyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_soyadi.Properties.Appearance.Options.UseFont = true;
            this.txt_soyadi.Size = new System.Drawing.Size(305, 28);
            this.txt_soyadi.TabIndex = 10;
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(161, 223);
            this.txt_adi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_adi.Size = new System.Drawing.Size(305, 28);
            this.txt_adi.TabIndex = 9;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(161, 186);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(305, 28);
            this.txt_id.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(84, 486);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(62, 22);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Branş : ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(109, 439);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 22);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "İlçe :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(129, 395);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 22);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "İl :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(75, 351);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 22);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Telefon :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 309);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 22);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "T.C.Kimlik No :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(84, 267);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 22);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Soyadı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(115, 222);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(112, 185);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(842, 628);
            this.xtraTabPage2.Text = "Öğretmen Bilgi-2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_temizle);
            this.groupControl1.Controls.Add(this.btn_guncelle);
            this.groupControl1.Controls.Add(this.btn_sil);
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.Btn_resimsec);
            this.groupControl1.Controls.Add(this.rch_adres);
            this.groupControl1.Controls.Add(this.txt_mail);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(4, 4);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(682, 613);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btn_temizle
            // 
            this.btn_temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.ImageOptions.Image")));
            this.btn_temizle.Location = new System.Drawing.Point(305, 497);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(132, 62);
            this.btn_temizle.TabIndex = 18;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.ImageOptions.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(305, 428);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(132, 62);
            this.btn_guncelle.TabIndex = 17;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.ImageOptions.Image")));
            this.btn_sil.Location = new System.Drawing.Point(305, 359);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(132, 62);
            this.btn_sil.TabIndex = 16;
            this.btn_sil.Text = "Sil";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.ImageOptions.Image")));
            this.btn_kaydet.Location = new System.Drawing.Point(305, 288);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(132, 62);
            this.btn_kaydet.TabIndex = 15;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // Btn_resimsec
            // 
            this.Btn_resimsec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_resimsec.ImageOptions.Image")));
            this.Btn_resimsec.Location = new System.Drawing.Point(305, 219);
            this.Btn_resimsec.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_resimsec.Name = "Btn_resimsec";
            this.Btn_resimsec.Size = new System.Drawing.Size(132, 62);
            this.Btn_resimsec.TabIndex = 14;
            this.Btn_resimsec.Text = "Resim Seç";
            this.Btn_resimsec.Click += new System.EventHandler(this.Btn_resimsec_Click);
            // 
            // rch_adres
            // 
            this.rch_adres.Location = new System.Drawing.Point(132, 68);
            this.rch_adres.Margin = new System.Windows.Forms.Padding(4);
            this.rch_adres.Name = "rch_adres";
            this.rch_adres.Size = new System.Drawing.Size(304, 117);
            this.rch_adres.TabIndex = 13;
            this.rch_adres.Text = "";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(132, 30);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_mail.Properties.Appearance.Options.UseFont = true;
            this.txt_mail.Size = new System.Drawing.Size(305, 28);
            this.txt_mail.TabIndex = 12;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(61, 65);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 22);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Adres :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(59, 28);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 22);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Mail : ";
            // 
            // FrmOgretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgretmenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Bilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOgretmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ogretmenresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_brans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.SimpleButton Btn_resimsec;
        private System.Windows.Forms.RichTextBox rch_adres;
        private DevExpress.XtraEditors.TextEdit txt_mail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.PictureBox pic_ogretmenresim;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_brans;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_il;
        private System.Windows.Forms.MaskedTextBox msk_telefon;
        private System.Windows.Forms.MaskedTextBox msk_tckimlikno;
        private DevExpress.XtraEditors.TextEdit txt_soyadi;
        private DevExpress.XtraEditors.TextEdit txt_adi;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}