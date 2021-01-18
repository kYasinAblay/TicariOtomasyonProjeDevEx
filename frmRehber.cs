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
    public partial class frmRehber : Form
    {
        public frmRehber()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmRehber_Load(object sender, EventArgs e)
        {

            //Müşteri Bilgileri
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,Telefon,telefon2,mail from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //Firma Bilgileri
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select Ad,YETKILIADSOYAD,Telefon1,telefon2,telefon3,mail,fax from TBL_FIRMALAR", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmMail frmMail = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView2.FocusedRowHandle);

            if (dr!=null)
            {
                frmMail.mail = dr["Mail"].ToString();
               
            }
            frmMail.Show();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmMail frmMail = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frmMail.mail = dr["Mail"].ToString();
            }
            frmMail.Show();
        }
    }
}
