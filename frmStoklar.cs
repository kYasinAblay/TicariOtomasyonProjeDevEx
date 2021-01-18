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
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmStoklar_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("Istanbul", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Izmir", 8);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Adana", 5);

            SqlDataAdapter da = new SqlDataAdapter("select urunad as 'Ürün Adı',sum(adet) as 'Miktar' from tbl_urunler group by urunad", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


            //Charta stok miktarı listeleme 
            SqlCommand komut = new SqlCommand("select urunad as 'Ürün Adı',sum(adet) as 'Miktar' from tbl_urunler group by urunad", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();

            //Charta firma-şehir sayısı çekme
            SqlCommand komut2 = new SqlCommand("select il,count(*) from tbl_firmalar group by Il", bgl.baglanti());

            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmStokDetay fr = new frmStokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.ad = dr["Ürün Adı"].ToString();
            }
            fr.Show();
        }
    }
}
