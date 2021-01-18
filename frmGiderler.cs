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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void giderListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from tbl_giderler",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtDogalgaz.Text = "";
            txtEkstra.Text = "";
            txtElektrik.Text = "";
            txtId.Text = "";
            txtInternet.Text = "";
            txtMaaslar.Text = "";
            txtSu.Text = "";
            cmbAylar.Text = "";
            cmbYil.Text = "";
            rchNotlar.Text = "";


        }
        private void frmGiderler_Load(object sender, EventArgs e)
        {
            giderListesi();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_giderler (ay,yil,elektrik,su,dogalgaz,internet,maaslar,ekstra,notlar) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAylar.Text);
            komut.Parameters.AddWithValue("@p2",cmbYil.Text);
            komut.Parameters.AddWithValue("@p3",decimal.Parse(txtElektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            komut.Parameters.AddWithValue("@p9", rchNotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider tabloya eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            giderListesi();
         
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtId.Text = dr["Id"].ToString();
                cmbAylar.Text = dr["AY"].ToString();
                cmbYil.Text = dr["Yil"].ToString();
                txtElektrik.Text = dr["Elektrik"].ToString();
                txtSu.Text = dr["Su"].ToString();
                txtDogalgaz.Text = dr["Dogalgaz"].ToString();
                txtInternet.Text = dr["internet"].ToString();
                txtMaaslar.Text = dr["maaslar"].ToString();
                txtEkstra.Text = dr["ekstra"].ToString();
                rchNotlar.Text = dr["notlar"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete from tbl_giderler where id=@p1",bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", txtId.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderListesi();
            MessageBox.Show("Gider Listeden Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("update tbl_giderler set Ay=@p1,yil=@p2,elektrik=@p3,su=@p4,dogalgaz=@p5,internet=@p6,maaslar=@p7,ekstra=@P8,notlar=@p9 where id=@p10" ,bgl.baglanti());

            komutGuncelle.Parameters.AddWithValue("@p1", cmbAylar.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", cmbYil.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrik.Text));
            komutGuncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
            komutGuncelle.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
            komutGuncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            komutGuncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
            komutGuncelle.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            komutGuncelle.Parameters.AddWithValue("@p9", rchNotlar.Text);
            komutGuncelle.Parameters.AddWithValue("@p10", txtId.Text);
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider tabloya eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            temizle();
        }
    }
}
