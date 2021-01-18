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
    public partial class frmStokDetay : Form
    {
        public frmStokDetay()
        {
            InitializeComponent();
        }
        
        public string ad;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmStokDetay_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from tbl_urunler where urunAd='"+ad+"'",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
