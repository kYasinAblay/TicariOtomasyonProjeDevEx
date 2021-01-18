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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtMail.Text = "";
            txtSoyad.Text = "";
            txtVergidaire.Text = "";
            msktxtTc.Text = "";
            msktxtTelefon1.Text = "";
            msktxtTelefon2.Text = "";
            rchAdres.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
           
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select sehiradi from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }
        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListesi();
            temizle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            cmbIlce.Text = "";
            SqlCommand komut = new SqlCommand("select ilceadi from TBL_ILCELER where sehirid=@p1", bgl.baglanti());
            int plaka = int.Parse(cmbIl.SelectedIndex.ToString()) + 1;
            komut.Parameters.AddWithValue("@p1", plaka);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERiLER (AD,Soyad,telefon,telefon2,tc,mail,il,ilce,adres,vergidaire) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktxtTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", msktxtTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", msktxtTc.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", cmbIl.Text);
            komut.Parameters.AddWithValue("@p8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", rchAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtVergidaire.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }




        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_MUSTERiLER where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERiLER set Ad=@p1,Soyad=@p2,telefon=@p3,Telefon2=@p4,Tc=@p5,Mail=@p5,Il=@p7,Ilce=@p8,VergiDaire=@p9,Adres=@p10 where Id=@p11", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktxtTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", msktxtTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", msktxtTc.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", cmbIl.Text);
            komut.Parameters.AddWithValue("@p8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", txtVergidaire.Text);
            komut.Parameters.AddWithValue("@p10", rchAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            temizle();

        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["Soyad"].ToString();
                msktxtTelefon1.Text = dr["Telefon"].ToString();
                msktxtTelefon2.Text = dr["Telefon2"].ToString();
                msktxtTc.Text = dr["TC"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                cmbIl.Text = dr["Il"].ToString();
                cmbIlce.Text = dr["Ilce"].ToString();
                txtVergidaire.Text = dr["VergiDaire"].ToString();
                rchAdres.Text = dr["Adres"].ToString();

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}