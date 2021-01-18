
namespace TicariOtomasyonProje
{
    partial class frmNotDetay
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
            this.rchNotDetay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchNotDetay
            // 
            this.rchNotDetay.BackColor = System.Drawing.SystemColors.Info;
            this.rchNotDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchNotDetay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchNotDetay.Location = new System.Drawing.Point(0, 0);
            this.rchNotDetay.Name = "rchNotDetay";
            this.rchNotDetay.ReadOnly = true;
            this.rchNotDetay.Size = new System.Drawing.Size(800, 306);
            this.rchNotDetay.TabIndex = 0;
            this.rchNotDetay.Text = "";
            // 
            // frmNotDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.rchNotDetay);
            this.Name = "frmNotDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOT DETAY";
            this.Load += new System.EventHandler(this.frmNotDetay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchNotDetay;
    }
}