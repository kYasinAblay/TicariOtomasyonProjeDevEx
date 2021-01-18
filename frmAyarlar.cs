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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_admin", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (btnIslem.Text=="Kaydet")
            {
                SqlCommand komut = new SqlCommand("insert into tbl_admin values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Admin Sisteme Kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();

            }
            if (btnIslem.Text=="Güncelle")
            {
                SqlCommand komut1 = new SqlCommand("update tbl_admin set sifre=@p2 where kullaniciad=@p1");
                komut1.Parameters.AddWithValue("@p1",txtKullaniciAdi.Text);
                komut1.Parameters.AddWithValue("@p2",txtSifre.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtKullaniciAdi.Text = dr["kullaniciad"].ToString();
                txtSifre.Text = dr["sifre"].ToString();

            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text!="")
            {
                btnIslem.Text = "Güncelle";
                btnIslem.BackColor = Color.GreenYellow;
            }
            else
            {
                btnIslem.Text = "Kaydet";
                btnIslem.BackColor = Color.MediumTurquoise;
            }
        }
    }
}
