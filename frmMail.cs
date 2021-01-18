using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyonProje
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void frmMail_Load(object sender, EventArgs e)
        {

            txtMailAdresi.Text = mail;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("kamilyasinablay@hotmail.com", "25591544a");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(txtMailAdresi.Text);
            mesajim.From = new MailAddress("kamilyasinablay@hotmail.com");
            mesajim.Subject = txtKonu.Text;
            mesajim.Body = rchtxtMesaj.Text;
            //istemci.Send(mesajim);
            MessageBox.Show("Mesajınız gönderilmiştir", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            try
            {
                istemci.SendAsync(mesajim, (object)mesajim);
            }
            catch (SmtpException ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
        }
    }
}
