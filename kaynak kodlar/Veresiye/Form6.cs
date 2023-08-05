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

namespace Veresiye
{
    public partial class Form6 : Form
    {
        public Form6()
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

        private void button1_Click(object sender, EventArgs e)
        {



            bağlantı.Open();

            int ilkborç = 0;

            SqlCommand komut = new SqlCommand("insert into Müşteri (Adsoyad,Telefon,Addres,Toplamborç) values (@Adsoyad,@Telefon,@Addres,@Toplamborç) ", bağlantı);
                         
            komut.Parameters.AddWithValue("@Adsoyad", Adsoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", Telefonno.Text);
            komut.Parameters.AddWithValue("@Addres", Addres.Text);
            komut.Parameters.AddWithValue("@Toplamborç", ilkborç);
            komut.ExecuteNonQuery();

            MessageBox.Show("Müşteri eklendi");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                    this.Close();

                }
            }
            bağlantı.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Telefonno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
