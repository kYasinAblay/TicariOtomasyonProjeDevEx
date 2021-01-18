
namespace TicariOtomasyonProje
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(50, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(213, 102);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(192, 22);
            this.txtKullanici.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(213, 145);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.PasswordChar = '*';
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(192, 22);
            this.txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(126, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(142, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ticari Otomasyon - 2020";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGirisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.Appearance.Options.UseBackColor = true;
            this.btnGirisYap.Appearance.Options.UseFont = true;
            this.btnGirisYap.Location = new System.Drawing.Point(213, 187);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(192, 38);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            this.btnGirisYap.MouseLeave += new System.EventHandler(this.btnGirisYap_MouseLeave);
            this.btnGirisYap.MouseHover += new System.EventHandler(this.btnGirisYap_MouseHover);
            // 
            // frmAdmin
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 304);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdmin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
    }
}