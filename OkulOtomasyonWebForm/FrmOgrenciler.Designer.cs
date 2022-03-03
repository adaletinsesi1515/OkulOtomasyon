
namespace OkulOtomasyonWebForm
{
    partial class FrmOgrenciler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView_ogrenciler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pic_ogrenciresim = new System.Windows.Forms.PictureBox();
            this.cmb_ilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_il = new DevExpress.XtraEditors.ComboBoxEdit();
            this.msk_tckimlikno = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyadi = new DevExpress.XtraEditors.TextEdit();
            this.txt_adi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.rch_adres = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_resimsec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ogrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ogrenciresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView_ogrenciler;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1096, 768);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ogrenciler});
            // 
            // gridView_ogrenciler
            // 
            this.gridView_ogrenciler.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView_ogrenciler.Appearance.Row.BackColor2 = System.Drawing.Color.Yellow;
            this.gridView_ogrenciler.Appearance.Row.Options.UseBackColor = true;
            this.gridView_ogrenciler.GridControl = this.gridControl1;
            this.gridView_ogrenciler.Name = "gridView_ogrenciler";
            this.gridView_ogrenciler.OptionsView.ShowGroupPanel = false;
            this.gridView_ogrenciler.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView_ogrenciler_FocusedRowObjectChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_temizle);
            this.groupControl1.Controls.Add(this.btn_guncelle);
            this.groupControl1.Controls.Add(this.btn_sil);
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.Btn_resimsec);
            this.groupControl1.Controls.Add(this.rch_adres);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.cmb_ilce);
            this.groupControl1.Controls.Add(this.cmb_il);
            this.groupControl1.Controls.Add(this.msk_tckimlikno);
            this.groupControl1.Controls.Add(this.txt_soyadi);
            this.groupControl1.Controls.Add(this.txt_adi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.pic_ogrenciresim);
            this.groupControl1.Controls.Add(this.txt_id);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1114, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(776, 768);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(158, 198);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(305, 28);
            this.txt_id.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(113, 201);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "ID : ";
            // 
            // pic_ogrenciresim
            // 
            this.pic_ogrenciresim.Image = ((System.Drawing.Image)(resources.GetObject("pic_ogrenciresim.Image")));
            this.pic_ogrenciresim.Location = new System.Drawing.Point(448, 9);
            this.pic_ogrenciresim.Margin = new System.Windows.Forms.Padding(4);
            this.pic_ogrenciresim.Name = "pic_ogrenciresim";
            this.pic_ogrenciresim.Size = new System.Drawing.Size(203, 181);
            this.pic_ogrenciresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ogrenciresim.TabIndex = 18;
            this.pic_ogrenciresim.TabStop = false;
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.Location = new System.Drawing.Point(157, 422);
            this.cmb_ilce.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmb_ilce.Properties.Appearance.Options.UseFont = true;
            this.cmb_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ilce.Size = new System.Drawing.Size(304, 28);
            this.cmb_ilce.TabIndex = 30;
            // 
            // cmb_il
            // 
            this.cmb_il.Location = new System.Drawing.Point(157, 377);
            this.cmb_il.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_il.Name = "cmb_il";
            this.cmb_il.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmb_il.Properties.Appearance.Options.UseFont = true;
            this.cmb_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_il.Size = new System.Drawing.Size(304, 28);
            this.cmb_il.TabIndex = 29;
            this.cmb_il.SelectedIndexChanged += new System.EventHandler(this.cmb_il_SelectedIndexChanged);
            // 
            // msk_tckimlikno
            // 
            this.msk_tckimlikno.Font = new System.Drawing.Font("Tahoma", 11F);
            this.msk_tckimlikno.Location = new System.Drawing.Point(158, 328);
            this.msk_tckimlikno.Margin = new System.Windows.Forms.Padding(4);
            this.msk_tckimlikno.Mask = "00000000000";
            this.msk_tckimlikno.Name = "msk_tckimlikno";
            this.msk_tckimlikno.Size = new System.Drawing.Size(303, 30);
            this.msk_tckimlikno.TabIndex = 27;
            this.msk_tckimlikno.ValidatingType = typeof(int);
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(158, 283);
            this.txt_soyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_soyadi.Properties.Appearance.Options.UseFont = true;
            this.txt_soyadi.Size = new System.Drawing.Size(305, 28);
            this.txt_soyadi.TabIndex = 26;
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(158, 246);
            this.txt_adi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_adi.Size = new System.Drawing.Size(305, 28);
            this.txt_adi.TabIndex = 25;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(103, 425);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 22);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "İlçe :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(123, 381);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 22);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "İl :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 332);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 22);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "T.C.Kimlik No :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(81, 290);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 22);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Soyadı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(112, 245);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 22);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Adı :";
            // 
            // rch_adres
            // 
            this.rch_adres.Location = new System.Drawing.Point(158, 468);
            this.rch_adres.Margin = new System.Windows.Forms.Padding(4);
            this.rch_adres.Name = "rch_adres";
            this.rch_adres.Size = new System.Drawing.Size(304, 117);
            this.rch_adres.TabIndex = 32;
            this.rch_adres.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(87, 465);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 22);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Adres :";
            // 
            // btn_temizle
            // 
            this.btn_temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.ImageOptions.Image")));
            this.btn_temizle.Location = new System.Drawing.Point(498, 436);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(132, 62);
            this.btn_temizle.TabIndex = 37;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.ImageOptions.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(498, 367);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(132, 62);
            this.btn_guncelle.TabIndex = 36;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.ImageOptions.Image")));
            this.btn_sil.Location = new System.Drawing.Point(498, 298);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(132, 62);
            this.btn_sil.TabIndex = 35;
            this.btn_sil.Text = "Sil";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.ImageOptions.Image")));
            this.btn_kaydet.Location = new System.Drawing.Point(498, 227);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(132, 62);
            this.btn_kaydet.TabIndex = 34;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // Btn_resimsec
            // 
            this.Btn_resimsec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_resimsec.ImageOptions.Image")));
            this.Btn_resimsec.Location = new System.Drawing.Point(157, 593);
            this.Btn_resimsec.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_resimsec.Name = "Btn_resimsec";
            this.Btn_resimsec.Size = new System.Drawing.Size(132, 62);
            this.Btn_resimsec.TabIndex = 33;
            this.Btn_resimsec.Text = "Resim Seç";
            this.Btn_resimsec.Click += new System.EventHandler(this.Btn_resimsec_Click);
            // 
            // FrmOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmOgrenciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Bilgileri";
            this.Load += new System.EventHandler(this.FrmOgrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ogrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ogrenciresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ogrenciler;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pic_ogrenciresim;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_il;
        private System.Windows.Forms.MaskedTextBox msk_tckimlikno;
        private DevExpress.XtraEditors.TextEdit txt_soyadi;
        private DevExpress.XtraEditors.TextEdit txt_adi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox rch_adres;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.SimpleButton Btn_resimsec;
    }
}