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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.SqlClient;
namespace Veresiye
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        bağlantısınıfı bağlantısınıfı = new bağlantısınıfı();
        SqlConnection bağlantı = new SqlConnection(bağlantısınıfı.Sqlbağlantısı);
        DataSet daset = new DataSet();


        private void Form5_Load(object sender, EventArgs e)
        {

            bağlantı.Open();
            SqlDataAdapter adrt = new SqlDataAdapter("select * from  Müşteri", bağlantı);
            adrt.Fill(daset, "Müşteri");
            dataGridView1.DataSource = daset.Tables["Müşteri"];
            bağlantı.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            bağlantı.Open();
            DataTable tablo = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Müşteri where Adsoyad like '%" + Arama.Text + "%'", bağlantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("delete from Müşteri where ID =@p1", bağlantı);
            komut.Parameters.AddWithValue("@p1", ID.Text);
            komut.ExecuteNonQuery();

            bağlantı.Close();
            MessageBox.Show("Kayıt silindi");
            daset.Tables["Müşteri"].Clear();
            bağlantı.Open();
            SqlDataAdapter adrt = new SqlDataAdapter("select * from  Müşteri", bağlantı);
            adrt.Fill(daset, "Müşteri");
            dataGridView1.DataSource = daset.Tables["Müşteri"];
            bağlantı.Close();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("update Müşteri set Adsoyad=@Adsoyad,Telefon=@Telefon,Addres=@Addres where ID=@ID ", bağlantı);
            komut.Parameters.AddWithValue("@ID", ID.Text);
            komut.Parameters.AddWithValue("@Adsoyad", Adsoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", Telefon.Text);
            komut.Parameters.AddWithValue("@Addres", Addres.Text);
            komut.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("Müşteri Güncellendi");
            daset.Tables["Müşteri"].Clear();

            bağlantı.Open();
            SqlDataAdapter adrt = new SqlDataAdapter("select * from  Müşteri", bağlantı);
            adrt.Fill(daset, "Müşteri");
            dataGridView1.DataSource = daset.Tables["Müşteri"];
            bağlantı.Close();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";


                }
            }
            bağlantı.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
              

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            Adsoyad.Text = dataGridView1.CurrentRow.Cells["Adsoyad"].Value.ToString();
            Telefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            Addres.Text = dataGridView1.CurrentRow.Cells["Addres"].Value.ToString();
        }
    }
}
