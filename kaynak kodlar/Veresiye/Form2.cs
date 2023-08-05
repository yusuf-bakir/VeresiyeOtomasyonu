using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace Veresiye
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bağlantısınıfı bağlantısınıfı = new bağlantısınıfı();
        SqlConnection bağlantı = new SqlConnection(bağlantısınıfı.Sqlbağlantısı);

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bağlantı.Open();
            string kullanıcıadı = textBox1.Text;
            string mail1 = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select * From Table_1 where kullanıcı = '" + kullanıcıadı.ToString() + "'and Mail ='" + mail1.ToString() + "'", bağlantı);
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                MailMessage Mail = new MailMessage();
                SmtpClient smtpserver = new SmtpClient();
                string tarih = DateTime.Now.ToLongDateString();
                string mailadresim = ("veresiyeotomasyonu3234@gmail.com");
                string şifre1 = "nvjjpnwbiilquken";
                string konu = ("şifre hatırlatma");
                string kime = (oku["Mail"].ToString());
                string yaz = ("Sayın :" + oku["kullanıcı"].ToString() + "\n" + "Bizden " + tarih + " Tarihinde Şifre hatırlatma talebinde bulundunuz." + "\n" + "Parolanız : " + oku["şifre"].ToString() + "\n" + "İyi Günler");
                smtpserver.Credentials = new NetworkCredential(mailadresim, şifre1);
                smtpserver.Port = 587;
                smtpserver.EnableSsl = true;
                smtpserver.Host = "smtp.gmail.com";
                Mail.From = new MailAddress(mail1);
                Mail.To.Add(kime);
                Mail.Subject = konu; Mail.Body = yaz;
                smtpserver.Send(Mail);
                MessageBox.Show("E-posta adresinizi kontror ediniz şifreniz gönderilmiştir.");
                this.Close();
            }

            else
            {
                MessageBox.Show("Hatalı kulanıcı adı veya E-posta...");
            }
            bağlantı.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "E-posta")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "kullanıcı adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }
    }
}
