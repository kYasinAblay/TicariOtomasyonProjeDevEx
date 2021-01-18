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
    public partial class frmBankalar : Form
    {
        public frmBankalar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtBankaAdi.Text = "";
            txtHesapno.Text = "";
            txtHesapno.Text = "";
            msktxtIban.Text = "";
            txtId.Text = "";
            txtSube.Text = "";
            txtYetkili.Text = "";
            msktxtTarih.Text = "";
            msktxtTelefon.Text = "";
            lkpFirma.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtHesapTuru.Text = "";

        }
        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD from tbl_firmalar",bgl.baglanti());
            da.Fill(dt);
            lkpFirma.Properties.ValueMember = "ID";
            lkpFirma.Properties.DisplayMember = "AD";
            lkpFirma.Properties.DataSource = dt;
        }
        private void frmBankalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();

            firmaListesi();
            temizle();
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select sehiradi from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_bankalar (Bankaadi,il,ilce,sube,iban,hesapno,Yetkili,telefon,tarih,hesapturu,firmaId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
            komut.Parameters.AddWithValue("@p2", cmbIl.Text);
            komut.Parameters.AddWithValue("@p3", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p4", txtSube.Text);
            komut.Parameters.AddWithValue("@p5", msktxtIban.Text);
            komut.Parameters.AddWithValue("@p6", txtHesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", msktxtTelefon.Text);
            komut.Parameters.AddWithValue("@p9", msktxtTarih.Text);
            komut.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", lkpFirma.EditValue);
                komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Sisteme Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            cmbIlce.Text = "";
            SqlCommand komut = new SqlCommand("select ilceadi from TBL_Ilceler where sehirid=@p1", bgl.baglanti());
            int plaka = int.Parse(cmbIl.SelectedIndex.ToString()) + 1;
            komut.Parameters.AddWithValue("@p1", plaka);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtId.Text = dr["ID"].ToString();
                txtBankaAdi.Text = dr["Bankaadi"].ToString();
                cmbIl.Text = dr["Il"].ToString();
                cmbIlce.Text = dr["ilce"].ToString();
                txtSube.Text = dr["sube"].ToString();
                msktxtIban.Text = dr["IBAN"].ToString();
                txtHesapno.Text = dr["hesapno"].ToString();
                txtYetkili.Text = dr["Yetkili"].ToString();
                msktxtTelefon.Text = dr["telefon"].ToString();
                msktxtTarih.Text = dr["tarih"].ToString();
                txtHesapTuru.Text = dr["hesapturu"].ToString();

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_bankalar where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            temizle();
            MessageBox.Show("Banka Bilgisi Sistemden Silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_bankalar set bankaadi=@p1,Il=@p2,ilce=@p3,sube=@p4,Iban=@p5,hesapno=@p6,yetkili=@p7,telefon=@p8,tarih=@p9,hesapturu=@p10,firmaid=@p11 where id=@p12", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
            komut.Parameters.AddWithValue("@p2", cmbIl.Text);
            komut.Parameters.AddWithValue("@p3", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p4", txtSube.Text);
            komut.Parameters.AddWithValue("@p5", msktxtIban.Text);
            komut.Parameters.AddWithValue("@p6", txtHesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", msktxtTelefon.Text);
            komut.Parameters.AddWithValue("@p9", msktxtTarih.Text);
            komut.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", lkpFirma.EditValue);
            komut.Parameters.AddWithValue("@p12", txtId.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);


        }
    }
}
