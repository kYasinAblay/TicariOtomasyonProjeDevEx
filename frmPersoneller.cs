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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void personelListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from tbl_personeller", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
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
        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtGorev.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            msktxtTc.Text = "";
            msktxtTelefon1.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            rchAdres.Text = "";
        }
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            personelListe();
            sehirListesi();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_personeller (ad,soyad,telefon,tc,mail,il,ilce,adres,gorev) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktxtTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", msktxtTc.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", cmbIl.Text);
            komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", rchAdres.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgileri Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListe();

        }

       

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["Soyad"].ToString();
                msktxtTelefon1.Text = dr["Telefon"].ToString();
                msktxtTc.Text = dr["TC"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                cmbIl.Text = dr["Il"].ToString();
                cmbIlce.Text = dr["Ilce"].ToString();
                rchAdres.Text = dr["Adres"].ToString();
                txtGorev.Text = dr["gorev"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("delete from tbl_personeller where Id=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", txtId.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Listeden Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.None);
            personelListe();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_personeller set ad=@p1,soyad=@p2,telefon=@p3,tc=@p4,mail=@p5,il=@p6,ilce=@p7,adres=@p8,gorev=@p9 where Id=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktxtTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", msktxtTc.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", cmbIl.Text);
            komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", rchAdres.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.Parameters.AddWithValue("@p10", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personelListe();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            cmbIlce.Text = "";
            SqlCommand komut = new SqlCommand("select ilceadi from TBL_Ilceler where sehirid=@p1", bgl.baglanti());
            int plaka = int.Parse(cmbIl.SelectedIndex.ToString()) + 1;
            komut.Parameters.AddWithValue("@p1", plaka);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

       
    }
}
