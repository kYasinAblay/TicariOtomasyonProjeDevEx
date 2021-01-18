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
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSetGiderler.TBL_GIDERLER' table. You can move, or remove it, as needed.
            this.TBL_GIDERLERTableAdapter.Fill(this.DboTicariOtomasyonDataSetGiderler.TBL_GIDERLER);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSetPersoneller.TBL_PERSONELLER' table. You can move, or remove it, as needed.
            this.TBL_PERSONELLERTableAdapter.Fill(this.DboTicariOtomasyonDataSetPersoneller.TBL_PERSONELLER);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSetMusteriler.TBL_MUSTERILER' table. You can move, or remove it, as needed.
            this.TBL_MUSTERILERTableAdapter.Fill(this.DboTicariOtomasyonDataSetMusteriler.TBL_MUSTERILER);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSet.TBL_FIRMALAR' table. You can move, or remove it, as needed.
            this.TBL_FIRMALARTableAdapter.Fill(this.DboTicariOtomasyonDataSet.TBL_FIRMALAR);

            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();


            this.reportViewer4.RefreshReport();

            this.reportViewer5.RefreshReport();
        }
    }
}
