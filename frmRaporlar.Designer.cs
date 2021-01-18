
namespace TicariOtomasyonProje
{
    partial class frmRaporlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlar));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TBL_FIRMALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DboTicariOtomasyonDataSet = new TicariOtomasyonProje.DboTicariOtomasyonDataSet();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.TBL_FIRMALARTableAdapter = new TicariOtomasyonProje.DboTicariOtomasyonDataSetTableAdapters.TBL_FIRMALARTableAdapter();
            this.DboTicariOtomasyonDataSetFirmalar = new TicariOtomasyonProje.DboTicariOtomasyonDataSetFirmalar();
            this.DboTicariOtomasyonDataSetMusteriler = new TicariOtomasyonProje.DboTicariOtomasyonDataSetMusteriler();
            this.TBL_MUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_MUSTERILERTableAdapter = new TicariOtomasyonProje.DboTicariOtomasyonDataSetMusterilerTableAdapters.TBL_MUSTERILERTableAdapter();
            this.DboTicariOtomasyonDataSetPersoneller = new TicariOtomasyonProje.DboTicariOtomasyonDataSetPersoneller();
            this.TBL_PERSONELLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_PERSONELLERTableAdapter = new TicariOtomasyonProje.DboTicariOtomasyonDataSetPersonellerTableAdapters.TBL_PERSONELLERTableAdapter();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DboTicariOtomasyonDataSetPersonel = new TicariOtomasyonProje.DboTicariOtomasyonDataSetPersonel();
            this.DboTicariOtomasyonDataSetGiderler = new TicariOtomasyonProje.DboTicariOtomasyonDataSetGiderler();
            this.TBL_GIDERLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_GIDERLERTableAdapter = new TicariOtomasyonProje.DboTicariOtomasyonDataSetGiderlerTableAdapters.TBL_GIDERLERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FIRMALARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetFirmalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_MUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_PERSONELLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetGiderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GIDERLERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TBL_FIRMALARBindingSource
            // 
            this.TBL_FIRMALARBindingSource.DataMember = "TBL_FIRMALAR";
            this.TBL_FIRMALARBindingSource.DataSource = this.DboTicariOtomasyonDataSet;
            // 
            // DboTicariOtomasyonDataSet
            // 
            this.DboTicariOtomasyonDataSet.DataSetName = "DboTicariOtomasyonDataSet";
            this.DboTicariOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer2);
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(795, 396);
            this.xtraTabPage2.Text = "Firma Raporları";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "datasetFirmalar";
            reportDataSource1.Value = this.TBL_FIRMALARBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TicariOtomasyonProje.reportfirmalar.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(795, 396);
            this.reportViewer2.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage1.ImageOptions.SvgImage")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(795, 396);
            this.xtraTabPage1.Text = "Müşteri Raporları";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetMusteriler";
            reportDataSource2.Value = this.TBL_MUSTERILERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TicariOtomasyonProje.reportMusteriler.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(795, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1240, 562);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.reportViewer3);
            this.xtraTabPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage3.ImageOptions.SvgImage")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(795, 396);
            this.xtraTabPage3.Text = "Kasa Raporları";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(795, 396);
            this.reportViewer3.TabIndex = 1;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.reportViewer4);
            this.xtraTabPage4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage4.ImageOptions.SvgImage")));
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1238, 508);
            this.xtraTabPage4.Text = "Gider Raporları";
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetGiderler";
            reportDataSource3.Value = this.TBL_GIDERLERBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "TicariOtomasyonProje.reportGiderler.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1238, 508);
            this.reportViewer4.TabIndex = 1;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.reportViewer5);
            this.xtraTabPage5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage5.ImageOptions.SvgImage")));
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1238, 508);
            this.xtraTabPage5.Text = "Personel Raporları";
            // 
            // TBL_FIRMALARTableAdapter
            // 
            this.TBL_FIRMALARTableAdapter.ClearBeforeFill = true;
            // 
            // DboTicariOtomasyonDataSetFirmalar
            // 
            this.DboTicariOtomasyonDataSetFirmalar.DataSetName = "DboTicariOtomasyonDataSetFirmalar";
            this.DboTicariOtomasyonDataSetFirmalar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DboTicariOtomasyonDataSetMusteriler
            // 
            this.DboTicariOtomasyonDataSetMusteriler.DataSetName = "DboTicariOtomasyonDataSetMusteriler";
            this.DboTicariOtomasyonDataSetMusteriler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_MUSTERILERBindingSource
            // 
            this.TBL_MUSTERILERBindingSource.DataMember = "TBL_MUSTERILER";
            this.TBL_MUSTERILERBindingSource.DataSource = this.DboTicariOtomasyonDataSetMusteriler;
            // 
            // TBL_MUSTERILERTableAdapter
            // 
            this.TBL_MUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // DboTicariOtomasyonDataSetPersoneller
            // 
            this.DboTicariOtomasyonDataSetPersoneller.DataSetName = "DboTicariOtomasyonDataSetPersoneller";
            this.DboTicariOtomasyonDataSetPersoneller.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_PERSONELLERBindingSource
            // 
            this.TBL_PERSONELLERBindingSource.DataMember = "TBL_PERSONELLER";
            this.TBL_PERSONELLERBindingSource.DataSource = this.DboTicariOtomasyonDataSetPersoneller;
            // 
            // TBL_PERSONELLERTableAdapter
            // 
            this.TBL_PERSONELLERTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSetPersoneller";
            reportDataSource4.Value = this.TBL_PERSONELLERBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "TicariOtomasyonProje.reportPersoneller.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 0);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(1238, 508);
            this.reportViewer5.TabIndex = 2;
            // 
            // DboTicariOtomasyonDataSetPersonel
            // 
            this.DboTicariOtomasyonDataSetPersonel.DataSetName = "DboTicariOtomasyonDataSetPersonel";
            this.DboTicariOtomasyonDataSetPersonel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DboTicariOtomasyonDataSetGiderler
            // 
            this.DboTicariOtomasyonDataSetGiderler.DataSetName = "DboTicariOtomasyonDataSetGiderler";
            this.DboTicariOtomasyonDataSetGiderler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_GIDERLERBindingSource
            // 
            this.TBL_GIDERLERBindingSource.DataMember = "TBL_GIDERLER";
            this.TBL_GIDERLERBindingSource.DataSource = this.DboTicariOtomasyonDataSetGiderler;
            // 
            // TBL_GIDERLERTableAdapter
            // 
            this.TBL_GIDERLERTableAdapter.ClearBeforeFill = true;
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 562);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmRaporlar";
            this.Text = "RAPORLAR";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FIRMALARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetFirmalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_MUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_PERSONELLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSetGiderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GIDERLERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource TBL_FIRMALARBindingSource;
        private DboTicariOtomasyonDataSet DboTicariOtomasyonDataSet;
        private DboTicariOtomasyonDataSetTableAdapters.TBL_FIRMALARTableAdapter TBL_FIRMALARTableAdapter;
        private DboTicariOtomasyonDataSetFirmalar DboTicariOtomasyonDataSetFirmalar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource TBL_MUSTERILERBindingSource;
        private DboTicariOtomasyonDataSetMusteriler DboTicariOtomasyonDataSetMusteriler;
        private DboTicariOtomasyonDataSetMusterilerTableAdapters.TBL_MUSTERILERTableAdapter TBL_MUSTERILERTableAdapter;
        private System.Windows.Forms.BindingSource TBL_PERSONELLERBindingSource;
        private DboTicariOtomasyonDataSetPersoneller DboTicariOtomasyonDataSetPersoneller;
        private DboTicariOtomasyonDataSetPersonellerTableAdapters.TBL_PERSONELLERTableAdapter TBL_PERSONELLERTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private DboTicariOtomasyonDataSetPersonel DboTicariOtomasyonDataSetPersonel;
        private System.Windows.Forms.BindingSource TBL_GIDERLERBindingSource;
        private DboTicariOtomasyonDataSetGiderler DboTicariOtomasyonDataSetGiderler;
        private DboTicariOtomasyonDataSetGiderlerTableAdapters.TBL_GIDERLERTableAdapter TBL_GIDERLERTableAdapter;
    }
}