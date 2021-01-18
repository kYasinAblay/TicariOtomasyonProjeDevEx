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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from tbl_notlar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            txtBaslik.Text = "";
            txtHitap.Text = "";
            txtId.Text = "";
            rchDetay.Text = "";
            msktxtSaat.Text = "";
            msktxtTarih.Text = "";
        }
        private void frmNotlar_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_notlar (tarih,saat,baslik,detay,olusturan,hitap) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", msktxtTarih.Text);
            komut.Parameters.AddWithValue("@p2", msktxtSaat.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", rchDetay.Text);
            komut.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", txtHitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Bilgisi Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtBaslik.Text = dr["Baslik"].ToString();
                rchDetay.Text = dr["Detay"].ToString();
                txtOlusturan.Text = dr["Olusturan"].ToString();
                txtHitap.Text = dr["Hitap"].ToString();
                msktxtTarih.Text = dr["Tarih"].ToString();
                msktxtSaat.Text = dr["Saat"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_notlar where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Sistemden Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_notlar set tarih=@p1,saat=@p2,baslik=@p3,detay=@p4,olusturan=@p5,hitap=@p6 where id=@p7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktxtTarih.Text);
            komut.Parameters.AddWithValue("@p2", msktxtSaat.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", rchDetay.Text);
            komut.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", txtHitap.Text);
            komut.Parameters.AddWithValue("@p7", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Bilgisi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmNotDetay fr = new frmNotDetay();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.metin = dr["Detay"].ToString();
            }
            fr.Show();
        }
    }
}
