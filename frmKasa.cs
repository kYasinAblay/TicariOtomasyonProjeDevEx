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
using DevExpress.Charts;

namespace TicariOtomasyonProje
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void musteriHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void firmaHareket()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute firmaHareketler", bgl.baglanti());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
        }
        public string ad;
        private void frmKasa_Load(object sender, EventArgs e)
        {
            lblAktifKullanici.Text = ad;
            musteriHareket();
            firmaHareket();

            //Toplam Tutarı hesaplama
            SqlCommand komut1 = new SqlCommand("select sum(tutar) from tbl_faturadetay", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamTutar.Text = dr1[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //son ayın faturaları
            SqlCommand komut2 = new SqlCommand("select (elektrik+su+dogalgaz+internet+ekstra) from TBL_GIDERLER order by Id asc", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblOdemeler.Text = dr2[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //son ayın personel maaşları
            SqlCommand komut3 = new SqlCommand("select Maaslar from tbl_giderler order by Id asc", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblPersonelMaaslari.Text = dr3[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //Müşteri sayısı
            SqlCommand komut4 = new SqlCommand("select count(*) from tbl_musteriler", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblMusteriSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Firma Sayısı
            SqlCommand komut5 = new SqlCommand("select count(*) from tbl_firmalar", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblFirmaSayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Firma Şehir Sayısı
            SqlCommand komut6 = new SqlCommand("select count(distinct(Il)) from tbl_firmalar", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblFirmaSehirSayisi.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam müşteri şehir sayısı
            SqlCommand komut7 = new SqlCommand("select count(distinct(Il)) from tbl_musteriler", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblMusteriSehirSayisi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Personel Sayısı
            SqlCommand komut8 = new SqlCommand("select count(*) from tbl_personeller", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblPersonelSayisi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Ürün stok Sayısı
            SqlCommand komut9 = new SqlCommand("select sum(adet) from TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                lblStokSayisi.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();

            //1. chart controle elektrik faturası son 4 ay listeleme
            SqlCommand komut10 = new SqlCommand("select top 4 ay,elektrik from tbl_giderler order by Id desc", bgl.baglanti());
            SqlDataReader dr10 = komut10.ExecuteReader();
            while (dr10.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
            }
            bgl.baglanti().Close();

            //2.chart controle su faturası son 4 ay listeleme
            SqlCommand komut11 = new SqlCommand("select top 4 ay, su from tbl_giderler order by Id desc", bgl.baglanti());
            SqlDataReader dr11 = komut11.ExecuteReader();
            while (dr11.Read())
            {
                chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
            }
            bgl.baglanti().Close();

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {
                //1.chart controle elektrik faturası son 4 ay listeleme
                SqlCommand komut10 = new SqlCommand("Select top 4 ay, elektrik from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            //su 
            if (sayac > 5 && sayac <= 10)
            {
                chartControl1.Series["Aylar"].Points.Clear();
                //2.chart controle su faturası son 4 ay listeleme
                SqlCommand komut11 = new SqlCommand("select top 4 ay, elektrik from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //doğalgaz
            if (sayac > 11 && sayac <= 15)
            {
                chartControl1.Series["Aylar"].Points.Clear();
                //2.chart controle doğal gaz faturası son 4 ay listeleme
                SqlCommand komut12 = new SqlCommand("select top 4 ay, Dogalgaz from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            //internet
            if (sayac > 16 && sayac <= 20)
            {
                chartControl1.Series["Aylar"].Points.Clear();
                //2.chart controle doğal gaz faturası son 4 ay listeleme
                SqlCommand komut13 = new SqlCommand("select top 4 ay, internet from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            //ekstra
            if (sayac > 20 && sayac <= 25)
            {
                chartControl1.Series["Aylar"].Points.Clear();
                //2.chart controle doğal gaz faturası son 4 ay listeleme
                SqlCommand komut14 = new SqlCommand("select top 4 ay, ekstra from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr14 = komut14.ExecuteReader();
                while (dr14.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));
                }
                bgl.baglanti().Close();
            }
        }

        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 > 0 && sayac2 <= 5)
            {
                //1.chart controle elektrik faturası son 4 ay listeleme
                SqlCommand komut10 = new SqlCommand("Select top 4 ay, elektrik from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            //su 
            if (sayac2 > 5 && sayac2 <= 10)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                //2.chart controle su faturası son 4 ay listeleme
                SqlCommand komut11 = new SqlCommand("select top 4 ay, su from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //doğalgaz
            if (sayac2 > 11 && sayac2 <= 15)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                //2.chart controle doğal gaz faturası son 4 ay listeleme
                SqlCommand komut12 = new SqlCommand("select top 4 ay, Dogalgaz from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            //internet
            if (sayac2 > 16 && sayac2 <= 20)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                //2.chart controle doğal gaz faturası son 4 ay listeleme
                SqlCommand komut13 = new SqlCommand("select top 4 ay, internet from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            //ekstra
            if (sayac2 > 20 && sayac2 <= 25)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                //2.chart controle doğal gaz faturası son 4 ay listeleme
                SqlCommand komut14 = new SqlCommand("select top 4 ay, ekstra from tbl_giderler order by Id desc", bgl.baglanti());
                SqlDataReader dr14 = komut14.ExecuteReader();
                while (dr14.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2==26)
            {
                sayac2 = 0;
            }
        }

    }
}
