using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonWebForm
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            Listele();
            IlEkle();
        }

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_OGRENCILER",baglan.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

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

        void Temizle()
        {
            txt_id.Text = "";
            txt_adi.Text = "";
            txt_soyadi.Text = "";
            msk_tckimlikno.Text = "";            
            cmb_il.Text = "";
            cmb_ilce.Text = "";
            rch_adres.Text = "";
            pic_ogrenciresim.ImageLocation = "";
        }

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

        public string yeniyol;
        private void Btn_resimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası | *.jpg; *.png; *.bmp | Tüm dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\Memduh\\source\\repos\\OkulOtomasyon\\OkulOtomasyonWebForm" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pic_ogrenciresim.ImageLocation = yeniyol;
        }

        private void gridView_ogrenciler_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView_ogrenciler.GetDataRow(gridView_ogrenciler.FocusedRowHandle);
            if (dr != null)
            {
                txt_id.Text = dr["ogrId"].ToString();
                txt_adi.Text = dr["ogrAdi"].ToString();
                txt_soyadi.Text = dr["ogrSoyad"].ToString();
                msk_tckimlikno.Text = dr["ogrTc"].ToString();                
                cmb_il.Text = dr["ogrIl"].ToString();
                cmb_ilce.Text = dr["ogrIlce"].ToString();
                rch_adres.Text = dr["ogrAdres"].ToString();
                yeniyol = "C:\\Users\\Memduh\\source\\repos\\OkulOtomasyon\\OkulOtomasyonWebForm" + "\\resimler\\" + dr["ogrFoto"].ToString();
                pic_ogrenciresim.ImageLocation = yeniyol;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_OGRENCILER (OgrAdi, OgrSoyad, OgrTC, OgrIl, OgrIlce, OgrAdres, OgrFoto ) values(@p1,@p2, @p3, @p4, @p5, @p6, @p7)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_adi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyadi.Text);
            komut.Parameters.AddWithValue("@p3", msk_tckimlikno.Text);            
            komut.Parameters.AddWithValue("@p4", cmb_il.Text);
            komut.Parameters.AddWithValue("@p5", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@p6", rch_adres.Text);
            komut.Parameters.AddWithValue("@p7", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Öğrenci eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_OGRENCILER where ogrId=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_id.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Öğrenci silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_OGRENCILER set OgrAdi=@P1, OgrSoyad=@P2, OgrTC=@P3, OgrIl=@P4, OgrIlce=@P5, OgrAdres=@P6, OgrFoto=@P7 WHERE OgrId=@p8", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_adi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyadi.Text);
            komut.Parameters.AddWithValue("@p3", msk_tckimlikno.Text);            
            komut.Parameters.AddWithValue("@p4", cmb_il.Text);
            komut.Parameters.AddWithValue("@p5", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@p6", rch_adres.Text);
            komut.Parameters.AddWithValue("@p7", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p8", txt_id.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Öğrenci güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
    }
}
