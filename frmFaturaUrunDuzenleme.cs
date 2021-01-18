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
    public partial class frmFaturaUrunDuzenleme : Form
    {
        public frmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtUrunId.Text = urunid;
            SqlCommand komut = new SqlCommand("select*from tbl_faturadetay where faturaUrunid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtFiyat.Text = dr[3].ToString();
                txtMiktar.Text = dr[2].ToString();
                txtTutar.Text = dr[4].ToString();
                txtUrunAd.Text = dr[1].ToString();
                //txtUrunId.Text = dr[0].ToString();

                bgl.baglanti().Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_faturadetay set urunad=@p1,miktar=@p2,fiyat=@p3,tutar=@p4 where faturaurunid=@p5", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMiktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p5", txtUrunId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişiklikler Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_faturadetay where faturaurunid=@p1",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",txtUrunId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Seçilen Kaydı Silmek İstediğinize Eminmisiniz","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }
    }
}
