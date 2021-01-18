
namespace TicariOtomasyonProje
{
    partial class frmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMail));
            this.lblMailKisi = new System.Windows.Forms.Label();
            this.txtMailAdresi = new DevExpress.XtraEditors.TextEdit();
            this.txtKonu = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.rchtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMailKisi
            // 
            this.lblMailKisi.AutoSize = true;
            this.lblMailKisi.Location = new System.Drawing.Point(14, 188);
            this.lblMailKisi.Name = "lblMailKisi";
            this.lblMailKisi.Size = new System.Drawing.Size(144, 29);
            this.lblMailKisi.TabIndex = 0;
            this.lblMailKisi.Text = "Mail Adresi :";
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Location = new System.Drawing.Point(165, 191);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(271, 22);
            this.txtMailAdresi.TabIndex = 1;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(165, 219);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(271, 22);
            this.txtKonu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konu :";
            // 
            // rchtxtMesaj
            // 
            this.rchtxtMesaj.Location = new System.Drawing.Point(165, 250);
            this.rchtxtMesaj.Name = "rchtxtMesaj";
            this.rchtxtMesaj.Size = new System.Drawing.Size(271, 157);
            this.rchtxtMesaj.TabIndex = 4;
            this.rchtxtMesaj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mesaj :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 164);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(123, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "MAIL GÖNDERME PANELİ";
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.Location = new System.Drawing.Point(165, 413);
            this.btnGonder.LookAndFeel.SkinName = "DevExpress Style";
            this.btnGonder.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnGonder.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(271, 40);
            this.btnGonder.TabIndex = 7;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(521, 484);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchtxtMesaj);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMailAdresi);
            this.Controls.Add(this.lblMailKisi);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönderme Formu";
            this.Load += new System.EventHandler(this.frmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMailKisi;
        private DevExpress.XtraEditors.TextEdit txtMailAdresi;
        private DevExpress.XtraEditors.TextEdit txtKonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchtxtMesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private System.Windows.Forms.Label label3;
    }
}