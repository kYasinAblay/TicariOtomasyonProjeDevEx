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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void btnGirisYap_MouseHover(object sender, EventArgs e)
        {
           btnGirisYap.BackColor = Color.Yellow;
        }

        private void btnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.LightSeaGreen;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from TBL_ADMIN where kullaniciad=@p1 and sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullanici.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmAnaModul fr = new frmAnaModul();
                frmKasa frm = new frmKasa();
                frm.ad=txtKullanici.Text;
                frm.lblAktifKullanici.Text = txtKullanici.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
