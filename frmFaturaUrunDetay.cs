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
    public partial class frmFaturaUrunDetay : Form
    {
        public frmFaturaUrunDetay()
        {
            InitializeComponent();
        }
        public string id;
        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select*from tbl_faturadetay where faturaid='" + id + "'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            
        }
        private void frmFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunDuzenleme fr = new frmFaturaUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr!=null)
            {
                fr.urunid = dr["faturaurunid"].ToString();
            }
            fr.Show();
        }
    }
}
