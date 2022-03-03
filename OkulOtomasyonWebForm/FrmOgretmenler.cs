using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace OkulOtomasyonWebForm
{
    public partial class FrmOgretmenler : Form
    {
        public FrmOgretmenler()
        {
            InitializeComponent();
        }

        //Bağlantı sınıfını burada newliyoruz. 
        SqlBaglantisi baglan = new SqlBaglantisi();

        //Kayıtları datagridde listeleme
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Ogretmenler", baglan.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }

        //İl adlarını ilgili İl Combosuna ekleme işlemi
        void IlEkle()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Iller", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_il.Properties.Items.Add(dr[1]);
            }
            baglan.baglanti().Close();

        }

        //Branşları ilgili comboya çekme işlemi
        void BransGetir()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Branslar", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_brans.Properties.Items.Add(dr[1]);
            }
            baglan.baglanti().Close();
        }
      
        void Temizle()
        {
            txt_id.Text = "";
            txt_adi.Text = "";
            txt_soyadi.Text = "";
            msk_tckimlikno.Text = "";
            msk_telefon.Text = "";
            cmb_il.Text = "";
            cmb_ilce.Text = "";
            cmb_brans.Text = "";
            txt_mail.Text = "";
            rch_adres.Text = "";
            pic_ogretmenresim.ImageLocation = "";
        }


        //Form Ana Load metodu
        private void FrmOgretmenler_Load(object sender, EventArgs e)
        {
            Listele();
            IlEkle();
            BransGetir();
        }

        //İl alanından ili seçince ilçe bilgilerini ilgili ilçe combosuna getiriyoruz
        private void cmb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ilce.Properties.Items.Clear();
            cmb_ilce.Text = "";

            SqlCommand komut = new SqlCommand("select * from TBL_ILCELER where sehirid=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", cmb_il.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_ilce.Properties.Items.Add(dr[1]);
            }
            baglan.baglanti().Close();
        }

        //Kaydetme işlemi
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into tbl_ogretmenler (OgrtAd, OgrtSoyad, OgrtTC, OgrtTel, OgrtIl, OgrtIlce, OgrtBrans, OgrtMail, OgrtAdres, OgrtFoto ) values(@p1,@p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_adi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyadi.Text);
            komut.Parameters.AddWithValue("@p3", msk_tckimlikno.Text);
            komut.Parameters.AddWithValue("@p4", msk_telefon.Text);   
            komut.Parameters.AddWithValue("@p5", cmb_il.Text);
            komut.Parameters.AddWithValue("@p6", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@p7", cmb_brans.Text);
            komut.Parameters.AddWithValue("@p8", txt_mail.Text);
            komut.Parameters.AddWithValue("@p9", rch_adres.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Öğretmen eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            

        }

        //Datagridde kayda tıklayınca kayıtları güncellemek için textboxlara aktarma işlemi --> method adı : FocusedRowObjectChanged
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txt_id.Text = dr["ogrtId"].ToString();
                txt_adi.Text = dr["ogrtAd"].ToString();
                txt_soyadi.Text = dr["ogrtSoyad"].ToString();
                msk_tckimlikno.Text = dr["ogrtTc"].ToString();
                msk_telefon.Text = dr["ogrtTel"].ToString();
                cmb_il.Text = dr["ogrtIl"].ToString();
                cmb_ilce.Text = dr["ogrtIlce"].ToString();
                cmb_brans.Text = dr["ogrtBrans"].ToString();
                txt_mail.Text = dr["ogrtMail"].ToString();
                rch_adres.Text = dr["ogrtAdres"].ToString();
                yeniyol = "C:\\Users\\Memduh\\source\\repos\\OkulOtomasyon\\OkulOtomasyonWebForm" + "\\resimler\\" + dr["ogrtFoto"].ToString();
                pic_ogretmenresim.ImageLocation = yeniyol;
            }
        }

        public string yeniyol;
        


        //Resim Kaydet butonuna tıklama işlemi 
        private void Btn_resimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası | *.jpg; *.png; *.bmp | Tüm dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\Memduh\\source\\repos\\OkulOtomasyon\\OkulOtomasyonWebForm" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pic_ogretmenresim.ImageLocation = yeniyol;



        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Ogretmenler set OgrtAd=@P1, OgrtSoyad=@P2, OgrtTC=@P3, OgrtTel=@P4, OgrtIl=@P5, OgrtIlce=@P6, OgrtBrans=@P7, OgrtMail=@P8, OgrtAdres=@P9, OgrtFoto=@P10 WHERE OgrtId=@p11",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_adi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyadi.Text);
            komut.Parameters.AddWithValue("@p3", msk_tckimlikno.Text);
            komut.Parameters.AddWithValue("@p4", msk_telefon.Text);
            komut.Parameters.AddWithValue("@p5", cmb_il.Text);
            komut.Parameters.AddWithValue("@p6", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@p7", cmb_brans.Text);
            komut.Parameters.AddWithValue("@p8", txt_mail.Text);
            komut.Parameters.AddWithValue("@p9", rch_adres.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p11", txt_id.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Öğretmen güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_ogretmenler where ogrtId=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_id.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Öğretmen silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
