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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Veresiye
{
    public partial class Form4 : Form
    {
        Form7 borçişlemleri;   
        public Form4()
        {
            InitializeComponent();
        }

        bağlantısınıfı bağlantısınıfı = new bağlantısınıfı();
        SqlConnection bağlantı = new SqlConnection(bağlantısınıfı.Sqlbağlantısı);
        DataSet DataSet = new DataSet();


        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= DataSet;
            bağlantı.Open();
            SqlDataAdapter adrt = new SqlDataAdapter("select * from  Müşteri", bağlantı);
            adrt.Fill(DataSet, "Müşteri");
            dataGridView1.DataSource = DataSet.Tables["Müşteri"];
            bağlantı.Close();

            DataSet.Tables["Müşteri"].Clear();

            bağlantı.Open();
            SqlDataAdapter güncelle = new SqlDataAdapter("select * from  Müşteri", bağlantı);
            adrt.Fill(DataSet, "Müşteri");
            dataGridView1.DataSource = DataSet.Tables["Müşteri"];
            bağlantı.Close();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";




                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tltutar.Text!="")
            {


                if (radioButton1.Checked == true)

                {

                    int borçekle = 0;

                    borçekle = Convert.ToInt32(Tltutar.Text);



                    bağlantı.Open();
                    SqlCommand komut = new SqlCommand("update Müşteri set Toplamborç=Toplamborç+@borçekle,VerilenborçTarihi=@Tarih ,AlınacakborçTarihi=@Atarih,Açıklama=@Açıklama where ID=@ID ", bağlantı);
                         
                    komut.Parameters.AddWithValue("@ID", ID.Text);
                    komut.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@borçekle", borçekle);
                    komut.Parameters.AddWithValue("@Atarih", dateTimePicker2.Value);
                    komut.Parameters.AddWithValue("@Açıklama", Açıklama.Text);
                    komut.ExecuteNonQuery();
                    bağlantı.Close();
                    MessageBox.Show("borç eklendi");
                    Tltutar.Text = "";
                    Toplamborç.Text = "";


                }
                else if (radioButton2.Checked == true)
                {

                    int borçcıkar = 0;

                    borçcıkar = Convert.ToInt32(Tltutar.Text);
                   


                        bağlantı.Open();
                        SqlCommand komut = new SqlCommand("update Müşteri set Toplamborç=Toplamborç-@borçcıkar,VerilenborçTarihi=@Tarih,AlınacakborçTarihi=@Atarih,Açıklama=@Açıklama  where ID=@ID ", bağlantı);
                        komut.Parameters.AddWithValue("@ID", ID.Text);
                        komut.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
                        komut.Parameters.AddWithValue("@borçcıkar", borçcıkar);
                        komut.Parameters.AddWithValue("@Atarih", dateTimePicker2.Value);
                        komut.Parameters.AddWithValue("@Açıklama", Açıklama.Text);
                        komut.ExecuteNonQuery();
                        bağlantı.Close();
                        MessageBox.Show("borç çıkarıldı ");
                        Tltutar.Text = "";
                     Toplamborç.Text = "";


                }
                else
                {
                    MessageBox.Show("Borç işleminizi belirtiniz ");
                }
                DataSet.Tables["Müşteri"].Clear();

                bağlantı.Open();
                SqlDataAdapter adrt = new SqlDataAdapter("select * from  Müşteri", bağlantı);
                adrt.Fill(DataSet, "Müşteri");
                dataGridView1.DataSource = DataSet.Tables["Müşteri"];
                bağlantı.Close();

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";


                    }
                }
            }
            else
            {
                MessageBox.Show("BORÇ İŞLEMİ İÇİN ÜCRET GİRİNİZ ");
            }
            bağlantı.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tltutar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form5 müşterilisteme=new Form5();
            müşterilisteme.ShowDialog();    

            bağlantı.Open();
            SqlDataAdapter adrt = new SqlDataAdapter("select * from  Müşteri", bağlantı);
            adrt.Fill(DataSet, "Müşteri");
            dataGridView1.DataSource = DataSet.Tables["Müşteri"];
            bağlantı.Close();

            DataSet.Tables["Müşteri"].Clear();

            bağlantı.Open();
            SqlDataAdapter güncelle = new SqlDataAdapter("select * from  Müşteri", bağlantı);
            adrt.Fill(DataSet, "Müşteri");
            dataGridView1.DataSource = DataSet.Tables["Müşteri"];
            bağlantı.Close();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";


                }
            }
        }

        private void Tltutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            bağlantı.Open();
            DataTable tablo = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Müşteri where Adsoyad like '%" + textBox1.Text + "%'", bağlantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlantı.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 müşteriekle=new Form6();  
            müşteriekle.ShowDialog();
            DataSet.Tables["Müşteri"].Clear();

            bağlantı.Open();
            SqlDataAdapter adrt = new SqlDataAdapter("select * from  Müşteri", bağlantı);
            adrt.Fill(DataSet, "Müşteri");
            dataGridView1.DataSource = DataSet.Tables["Müşteri"];
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

      

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            ID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            Adsoyad.Text = dataGridView1.CurrentRow.Cells["Adsoyad"].Value.ToString();
            Telefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            Addres.Text = dataGridView1.CurrentRow.Cells["Addres"].Value.ToString();
            Toplamborç.Text = dataGridView1.CurrentRow.Cells["Toplamborç"].Value.ToString();
            Açıklama.Text = dataGridView1.CurrentRow.Cells["Açıklama"].Value.ToString();

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();

            form7.ShowDialog();

        }
    }
}
