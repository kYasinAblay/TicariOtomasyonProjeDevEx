using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyonProje
{
    public partial class frmFirmalar : Form
    {
        public frmFirmalar()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void firmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select*from Tbl_Firmalar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select sehiradi from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();


        }
        void temizle()
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtMail.Text = "";
            txtSektor.Text = "";
            txtVergidaire.Text = "";
            txtYetkili.Text = "";
            txtYGorev.Text = "";
            msktxtFax.Text = "";
            msktxtTelefon1.Text = "";
            msktxtTelefon2.Text = "";
            msktxtTelefon3.Text = "";
            msktxtTc.Text = "";
            txtKod1.Text = "";
            rchAdres.Text = "";
            CmbIl.Text = "";
            cmbIlce.Text = "";
            rchtxtKod1.Text = "";
            rchtxtKod2.Text = "";
            rchtxtKod3.Text = "";
            txtAd.Focus();

        }
        void carikodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("select firmakod1 from tbl_kodlar  ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rchtxtKod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            temizle();
            firmaListesi();
           
            sehirListesi();
            carikodaciklamalar();
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_Firmalar (Ad,Yetkilistatu,yetkiliadsoyad,Yetkilitc,sektor,telefon1,telefon2,telefon3,Mail,Fax,Il,Ilce,VERGiDAIRE,Adres,OzelKod1,Ozelkod2,OzelKod3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYGorev.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", msktxtTc.Text);
            komut.Parameters.AddWithValue("@p5", txtSektor.Text);
            komut.Parameters.AddWithValue("@p6", msktxtTelefon1.Text);
            komut.Parameters.AddWithValue("@p7", msktxtTelefon2.Text);
            komut.Parameters.AddWithValue("@p8", msktxtTelefon3.Text);
            komut.Parameters.AddWithValue("@p9", txtMail.Text);
            komut.Parameters.AddWithValue("@p10", msktxtFax.Text);
            komut.Parameters.AddWithValue("@p11", CmbIl.Text);
            komut.Parameters.AddWithValue("@p12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p13", txtVergidaire.Text);
            komut.Parameters.AddWithValue("@p14", rchAdres.Text);
            komut.Parameters.AddWithValue("@p15", txtKod1.Text);
            komut.Parameters.AddWithValue("@p16", txtKod2.Text);
            komut.Parameters.AddWithValue("@p17", txtKod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListesi();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_Firmalar set Ad=@p1,Yetkilistatu=@p2,yetkiliadsoyad=@p3,Yetkilitc=@p4,sektor=@p5,telefon1=@p6,telefon2=@p7,telefon3=@p8,Mail=@p9,Il=@p10,Ilce=@p11,fax=@p12,vergidaire=@p13,Adres=@p14,OzelKod1=@p15,Ozelkod2=@p16,OzelKod3=@p17 where Id=@p18", bgl.baglanti());

           
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYGorev.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", msktxtTc.Text);
            komut.Parameters.AddWithValue("@p5", txtSektor.Text);
            komut.Parameters.AddWithValue("@p6", msktxtTelefon1.Text);
            komut.Parameters.AddWithValue("@p7", msktxtTelefon2.Text);
            komut.Parameters.AddWithValue("@p8", msktxtTelefon3.Text);
            komut.Parameters.AddWithValue("@p9", txtMail.Text);
            komut.Parameters.AddWithValue("@p10", CmbIl.Text);
            komut.Parameters.AddWithValue("@p11", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p12", msktxtFax.Text);
            komut.Parameters.AddWithValue("@p13", txtVergidaire.Text);
            komut.Parameters.AddWithValue("@p14", rchAdres.Text);
            komut.Parameters.AddWithValue("@p15", txtKod1.Text);
            komut.Parameters.AddWithValue("@p16", txtKod2.Text);
            komut.Parameters.AddWithValue("@p17", txtKod3.Text);
            komut.Parameters.AddWithValue("@p18", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListesi();
            temizle();
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            cmbIlce.Text = "";
            SqlCommand komut = new SqlCommand("select ilceadi from TBL_Ilceler where sehirid=@p1", bgl.baglanti());
            int plaka = int.Parse(CmbIl.SelectedIndex.ToString()) + 1;
            komut.Parameters.AddWithValue("@p1", plaka);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_Firmalar where Id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


            firmaListesi();
            MessageBox.Show("Firma Listeden Silindi.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtYGorev.Text = dr["YETKILISTATU"].ToString();
                txtYetkili.Text = dr["YETKILIADSOYAD"].ToString();

                msktxtTc.Text = dr["YETKILITC"].ToString();
                txtSektor.Text = dr["Sektor"].ToString();

                msktxtTelefon1.Text = dr["TELEFON1"].ToString();
                msktxtTelefon2.Text = dr["TELEFON2"].ToString();
                msktxtTelefon3.Text = dr["TELEFON3"].ToString();

                txtMail.Text = dr["Mail"].ToString();
                msktxtFax.Text = dr["Fax"].ToString();
                CmbIl.Text = dr["Il"].ToString();
                cmbIlce.Text = dr["Ilce"].ToString();

                txtVergidaire.Text = dr["VERGiDAIRE"].ToString();
                rchAdres.Text = dr["Adres"].ToString();
                txtKod1.Text = dr["Ozelkod1"].ToString();
                txtKod2.Text = dr["Ozelkod2"].ToString();
                txtKod3.Text = dr["Ozelkod3"].ToString();

            }
        }
    }
}
