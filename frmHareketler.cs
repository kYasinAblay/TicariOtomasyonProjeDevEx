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
    public partial class frmHareketler : Form
    {
        public frmHareketler()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        public void FirmaHareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec Firmahareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        public void MusteriHareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmHareketler_Load(object sender, EventArgs e)
        {
            FirmaHareketleri();
            MusteriHareketleri();
        }
    }
}
