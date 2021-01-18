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

namespace TicariOtomasyonProje
{
    public partial class frmFaturalar : Form
    {
        public frmFaturalar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_faturabilgi", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            txtAlici.Text = "";
            txtId.Text = "";
            txtSeri.Text = "";
            txtSirano.Text = "";
            txtTeslimAlan.Text = "";
            txtTeslimEden.Text = "";
            txtVergiDaire.Text = "";
            msktxtSaat.Text = "";
            msktxtTarih.Text = "";
        }
        private void frmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            if (txtFaturaId.Text == "")
            {

                SqlCommand komut = new SqlCommand("insert into tbl_faturabilgi (seri,sirano,tarih,saat,vergidaire,alici,teslimeden,teslimalan) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtSeri.Text);
                komut.Parameters.AddWithValue("@p2", txtSirano.Text);
                komut.Parameters.AddWithValue("@p3", msktxtTarih.Text);
                komut.Parameters.AddWithValue("@p4", msktxtSaat.Text);
                komut.Parameters.AddWithValue("@p5", txtVergiDaire.Text);
                komut.Parameters.AddWithValue("@p6", txtAlici.Text);
                komut.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                komut.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            //firma carisi
            if (txtFaturaId.Text != "" && cmbCari.Text == "Firma")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into tbl_faturadetay (urunad,miktar,fiyat,tutar,faturaid) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p2", txtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", txtFaturaId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();


                //Hareket tablosuna veri girişi
                SqlCommand komut3 = new SqlCommand("insert into tbl_firmahareketler (urunid,adet,personel,firma,fiyat,toplam,faturaid,tarih) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", txtUrunId.Text);
                komut3.Parameters.AddWithValue("@h2", txtMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtFaturaId.Text);
                komut3.Parameters.AddWithValue("@h8", msktxtTarih.Text);

                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                if ((Application.OpenForms["frmHareketler"] as frmHareketler) != null)
                {
                    (Application.OpenForms["frmHareketler"] as frmHareketler).FirmaHareketleri();
                }
                

                //Stok Sayısını Azaltma
                SqlCommand komut4 = new SqlCommand("update tbl_urunler set adet=adet-@s1 where id=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", txtMiktar.Text);
                komut4.Parameters.AddWithValue("@s2", txtId.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Faturaya Ait Ürün Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();

            }

            //Müşteri Carisi
            if (txtFaturaId.Text != "" && cmbCari.Text == "Müşteri")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into tbl_faturadetay (urunad,miktar,fiyat,tutar,faturaid) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p2", txtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", txtFaturaId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();


                //Hareket tablosuna veri girişi
                SqlCommand komut3 = new SqlCommand("insert into tbl_musterihareketler (urunid,adet,personel,musteri,fiyat,toplam,faturaid,tarih) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", txtUrunId.Text);
                komut3.Parameters.AddWithValue("@h2", txtMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtFaturaId.Text);
                komut3.Parameters.AddWithValue("@h8", msktxtTarih.Text);

                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                if ((Application.OpenForms["frmHareketler"] as frmHareketler) != null)
                {
                    (Application.OpenForms["frmHareketler"] as frmHareketler).MusteriHareketleri();
                }



                //Stok Sayısını Azaltma
                SqlCommand komut4 = new SqlCommand("update tbl_urunler set adet=adet-@s1 where id=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", txtMiktar.Text);
                komut4.Parameters.AddWithValue("@s2", txtId.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Faturaya Ait Ürün Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["faturabilgiID"].ToString();
                txtSirano.Text = dr["sirano"].ToString();
                txtSeri.Text = dr["seri"].ToString();
                msktxtTarih.Text = dr["tarih"].ToString();
                msktxtSaat.Text = dr["saat"].ToString();
                txtAlici.Text = dr["alici"].ToString();
                txtTeslimEden.Text = dr["teslimeden"].ToString();
                txtTeslimAlan.Text = dr["teslimalan"].ToString();
                txtVergiDaire.Text = dr["vergidaire"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_faturabilgi set seri=@p1,sirano=@p2,tarih=@p3,saat=@p4,vergidaire=@p5,alici=@p6,teslimeden=@p7,teslimalan=@p8 where faturabilgiid=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtSeri.Text);
            komut.Parameters.AddWithValue("@p2", txtSirano.Text);
            komut.Parameters.AddWithValue("@p3", msktxtTarih.Text);
            komut.Parameters.AddWithValue("@p4", msktxtSaat.Text);
            komut.Parameters.AddWithValue("@p5", txtVergiDaire.Text);
            komut.Parameters.AddWithValue("@p6", txtAlici.Text);
            komut.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
            komut.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_faturabilgi where faturabilgiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunDetay fr = new frmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.id = dr["faturabilgiID"].ToString();
            }
            fr.Show();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select urunad,satisfiyat from tbl_urunler where Id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtUrunAd.Text = dr[0].ToString();
                    txtFiyat.Text = dr[1].ToString();
                }
            }
            else
            {
                MessageBox.Show("Gösterilecek Bir Kayıt Bulunamadı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
            bgl.baglanti().Close();
        }
    }
}
