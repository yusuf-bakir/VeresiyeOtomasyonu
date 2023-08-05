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

namespace Veresiye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bağlantısınıfı bağlantısınıfı = new bağlantısınıfı();
        SqlConnection bağlantı = new SqlConnection(bağlantısınıfı.Sqlbağlantısı);
        DataSet daset = new DataSet();
        
        
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 şifreHatırlatma = new Form2();
            şifreHatırlatma.ShowDialog();





        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 kayıt = new Form3();
            kayıt.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            bağlantı.Open();
            string kullanıcıadı = textBox1.Text;
            string şifre1 = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select * From Table_1 where kullanıcı = '" + kullanıcıadı.ToString() + "'and şifre ='" + şifre1.ToString() + "'", bağlantı);
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Giriş başarılı ");
                Form4 anasayfa= new Form4();
                anasayfa.ShowDialog();
                this.Close();   


            }
            else
            {
                MessageBox.Show("Hatalı kulanıcı adı veya şifre...");
            }
            bağlantı.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanıcı adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

            }
        }
    }
}
