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
            SqlCommand komut = new SqlCommand("Insert into tbl_ogretmenler (OgrtAd, OgrtSoyad, OgrtTC, OgrtTel, OgrtIl, OgrtIlce, OgrtBrans, OgrtMail, OgrtAdres ) values(@p1,@p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_adi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyadi.Text);
            komut.Parameters.AddWithValue("@p3", msk_tckimlikno.Text);
            komut.Parameters.AddWithValue("@p4", msk_telefon.Text);   
            komut.Parameters.AddWithValue("@p5", cmb_il.Text);
            komut.Parameters.AddWithValue("@p6", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@p7", cmb_brans.Text);
            komut.Parameters.AddWithValue("@p8", txt_mail.Text);
            komut.Parameters.AddWithValue("@p9", rch_adres.Text);
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
            }
        }
    }
}
