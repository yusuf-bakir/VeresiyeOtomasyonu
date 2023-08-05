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
using System.Data;

namespace Veresiye
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        bağlantısınıfı bağlantısınıfı = new bağlantısınıfı();
        SqlConnection bağlantı = new SqlConnection(bağlantısınıfı.Sqlbağlantısı);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "kullanıcı adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "E-posta")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "Şifre")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand cmd = new SqlCommand("select * From Table_1 where kullanıcı = '" + textBox1.ToString() + "'and Mail ='" + textBox2.ToString() + "'", bağlantı);

            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("bu kullanıcı zaten kayıtlı...");


            }
            else
            {

                oku.Close();
                int borçekle = 0;

                SqlCommand ekle = new SqlCommand("insert into Table_1(kullanıcı,şifre,Mail) values (@kullanıcı,@şifre,@Mail)", bağlantı);

                ekle.Parameters.AddWithValue("@kullanıcı", textBox1.Text);
                ekle.Parameters.AddWithValue("@şifre",textBox3.Text);
                ekle.Parameters.AddWithValue("@Mail", textBox2.Text);
                


                ekle.ExecuteNonQuery();
                MessageBox.Show("kayıt işlemi gerçekleşmiştir");
                this.Close();



            }






            bağlantı.Close();


        }
    }
}
