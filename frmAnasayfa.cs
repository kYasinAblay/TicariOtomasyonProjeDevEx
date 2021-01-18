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
using System.Xml;

namespace TicariOtomasyonProje
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        void Stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select urunad,sum(adet) as 'Adet' from tbl_urunler group by Urunad having sum(adet) <= 20 order by Sum(adet)", bgl.baglanti());
            da.Fill(dt);
            grdCntrlStoklar.DataSource = dt;

        }
        void Ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 8 tarih,saat,baslik from tbl_notlar order by Id desc", bgl.baglanti());
            da.Fill(dt);
            grdcntrlAjanda.DataSource = dt;

        }
        void FirmaHareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec Firmahareket2", bgl.baglanti());
            da.Fill(dt);
            grdcntrlsononHareket.DataSource = dt;

        }
        void Fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ad, telefon1 from tbl_firmalar", bgl.baglanti());
            da.Fill(dt);
            grdcntrlFihrist.DataSource = dt;
        }
        void Haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            //Stoklar   
            Stoklar();
            //Ajanda
            Ajanda();
            //Firma Hareketleri
            FirmaHareketleri();
            //Fihrist
            Fihrist();

            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            Haberler();
        }


    }
}
