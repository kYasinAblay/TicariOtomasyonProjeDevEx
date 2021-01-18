using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyonProje
{
    public partial class frmAnaModul : Form
    {
        public frmAnaModul()
        {
            InitializeComponent();
        }

        
        frmUrunler frUrun;
        private void brbtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frUrun== null || frUrun.IsDisposed)
            {
                frUrun = new frmUrunler();
                frUrun.MdiParent = this;
                frUrun.Show();
            }
            
            
        }
        frmMusteriler frmMusteri;
        private void brbtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteri== null || frmMusteri.IsDisposed)
            {
                frmMusteri = new frmMusteriler();
                frmMusteri.MdiParent = this;
                frmMusteri.Show();

            }
        }
        frmFirmalar fr3;
        private void brbtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3== null || fr3.IsDisposed)
            {
                fr3 = new frmFirmalar();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        frmPersonel fr4;
        private void brbtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4== null || fr4.IsDisposed)
            {
                fr4 = new frmPersonel();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        frmRehber fr5;
        private void brbtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5== null || fr5.IsDisposed)
            {
                fr5 = new frmRehber();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        frmGiderler fr6;
        private void brbtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6== null || fr6.IsDisposed)
            {
                fr6 = new frmGiderler();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        frmBankalar fr7;
        private void brbtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7== null || fr7.IsDisposed)
            {
                fr7 = new frmBankalar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        frmFaturalar fr8;
        private void brbtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8== null || fr8.IsDisposed)
            {
                fr8 = new frmFaturalar();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }
        frmNotlar fr9;
        private void brbtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9== null || fr9.IsDisposed)
            {
                fr9 = new frmNotlar();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }
        frmHareketler fr10;
        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10== null || fr10.IsDisposed)
            {
                fr10 = new frmHareketler();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }
        frmRaporlar fr11;
        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11== null || fr11.IsDisposed)
            {
                fr11 = new frmRaporlar();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }
        frmStoklar fr12;
        private void brbtnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12== null || fr12.IsDisposed)
            {
                fr12 = new frmStoklar();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }
        frmAyarlar fr13;
        private void brbtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13== null || fr13.IsDisposed)
            {
                fr13 = new frmAyarlar();
              
                fr13.Show();
            }
        }
        frmKasa fr14;
        private void brbtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14== null || fr14.IsDisposed)
            {
                fr14 = new frmKasa();
                fr14.ad = kullanici;
                fr14.MdiParent = this;
                fr14.Show();
            }
          
        }
        public string kullanici;
        private void frmAnaModul_Load(object sender, EventArgs e)
        {

        }
        frmAnasayfa fr15;
        private void brbtnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15==null ||fr15.IsDisposed)
            {
                fr15 = new frmAnasayfa();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }
    }
}
