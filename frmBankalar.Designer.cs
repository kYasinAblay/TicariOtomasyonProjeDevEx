
namespace TicariOtomasyonProje
{
    partial class frmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankalar));
            this.txtHesapTuru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.msktxtIban = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lkpFirma = new DevExpress.XtraEditors.LookUpEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.msktxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Location = new System.Drawing.Point(116, 369);
            this.txtHesapTuru.Margin = new System.Windows.Forms.Padding(6);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.Size = new System.Drawing.Size(259, 22);
            this.txtHesapTuru.TabIndex = 10;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(8, 367);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(97, 22);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Hesap Türü:";
            // 
            // msktxtIban
            // 
            this.msktxtIban.Location = new System.Drawing.Point(117, 205);
            this.msktxtIban.Margin = new System.Windows.Forms.Padding(6);
            this.msktxtIban.Mask = "TR00000000000000000";
            this.msktxtIban.Name = "msktxtIban";
            this.msktxtIban.Size = new System.Drawing.Size(259, 23);
            this.msktxtIban.TabIndex = 5;
            this.msktxtIban.ValidatingType = typeof(int);
            // 
            // msktxtTelefon
            // 
            this.msktxtTelefon.Location = new System.Drawing.Point(116, 302);
            this.msktxtTelefon.Margin = new System.Windows.Forms.Padding(6);
            this.msktxtTelefon.Mask = "(999) 000-0000";
            this.msktxtTelefon.Name = "msktxtTelefon";
            this.msktxtTelefon.Size = new System.Drawing.Size(259, 23);
            this.msktxtTelefon.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lkpFirma);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.txtYetkili);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.cmbIlce);
            this.groupControl1.Controls.Add(this.cmbIl);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtHesapTuru);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.msktxtIban);
            this.groupControl1.Controls.Add(this.msktxtTarih);
            this.groupControl1.Controls.Add(this.msktxtTelefon);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtSube);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtHesapno);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtBankaAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1521, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(403, 753);
            this.groupControl1.TabIndex = 5;
            // 
            // lkpFirma
            // 
            this.lkpFirma.Location = new System.Drawing.Point(116, 399);
            this.lkpFirma.Name = "lkpFirma";
            this.lkpFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpFirma.Properties.NullText = "Bir Firma Seçin...";
            this.lkpFirma.Size = new System.Drawing.Size(259, 22);
            this.lkpFirma.TabIndex = 11;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(116, 600);
            this.btnTemizle.LookAndFeel.SkinName = "DevExpress Style";
            this.btnTemizle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnTemizle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(8);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(259, 43);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(116, 268);
            this.txtYetkili.Margin = new System.Windows.Forms.Padding(6);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(259, 22);
            this.txtYetkili.TabIndex = 7;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(52, 268);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(52, 22);
            this.labelControl12.TabIndex = 32;
            this.labelControl12.Text = "Yetkili:";
            // 
            // cmbIlce
            // 
            this.cmbIlce.Location = new System.Drawing.Point(117, 144);
            this.cmbIlce.Margin = new System.Windows.Forms.Padding(6);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlce.Size = new System.Drawing.Size(259, 22);
            this.cmbIlce.TabIndex = 3;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // cmbIl
            // 
            this.cmbIl.Location = new System.Drawing.Point(117, 115);
            this.cmbIl.Margin = new System.Windows.Forms.Padding(6);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIl.Size = new System.Drawing.Size(259, 22);
            this.cmbIl.TabIndex = 2;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(69, 142);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(34, 22);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "İlçe:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(84, 115);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(17, 22);
            this.labelControl8.TabIndex = 28;
            this.labelControl8.Text = "İl:";
            // 
            // msktxtTarih
            // 
            this.msktxtTarih.Location = new System.Drawing.Point(116, 337);
            this.msktxtTarih.Margin = new System.Windows.Forms.Padding(6);
            this.msktxtTarih.Mask = "00/00/0000";
            this.msktxtTarih.Name = "msktxtTarih";
            this.msktxtTarih.Size = new System.Drawing.Size(259, 23);
            this.msktxtTarih.TabIndex = 9;
            this.msktxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(116, 543);
            this.btnGuncelle.LookAndFeel.SkinName = "DevExpress Style";
            this.btnGuncelle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnGuncelle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(259, 43);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(116, 488);
            this.btnSil.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSil.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnSil.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSil.Margin = new System.Windows.Forms.Padding(6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(259, 43);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(116, 433);
            this.btnKaydet.LookAndFeel.SkinName = "DevExpress Style";
            this.btnKaydet.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnKaydet.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(259, 43);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(55, 397);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 22);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Firma:";
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(117, 174);
            this.txtSube.Margin = new System.Windows.Forms.Padding(6);
            this.txtSube.Name = "txtSube";
            this.txtSube.Size = new System.Drawing.Size(259, 22);
            this.txtSube.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(59, 172);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 22);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Şube:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(57, 203);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 22);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "IBAN:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 302);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 22);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Telefon:";
            // 
            // txtHesapno
            // 
            this.txtHesapno.Location = new System.Drawing.Point(116, 237);
            this.txtHesapno.Margin = new System.Windows.Forms.Padding(6);
            this.txtHesapno.Name = "txtHesapno";
            this.txtHesapno.Size = new System.Drawing.Size(259, 22);
            this.txtHesapno.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 237);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 22);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Hesap No:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(56, 336);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 22);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tarih:";
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(117, 86);
            this.txtBankaAdi.Margin = new System.Windows.Forms.Padding(6);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(259, 22);
            this.txtBankaAdi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 86);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Banka Adı:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(117, 54);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(259, 22);
            this.txtId.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(77, 54);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 1664;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(15);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(15);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1521, 753);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmBankalar
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTemizle;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmBankalar";
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.frmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtHesapTuru;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox msktxtIban;
        private System.Windows.Forms.MaskedTextBox msktxtTelefon;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSube;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBankaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIl;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.MaskedTextBox msktxtTarih;
        private DevExpress.XtraEditors.TextEdit txtHesapno;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.LookUpEdit lkpFirma;
    }
}