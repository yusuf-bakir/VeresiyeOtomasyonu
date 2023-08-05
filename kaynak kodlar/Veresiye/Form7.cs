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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Veresiye
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        bağlantısınıfı bağlantısınıfı = new bağlantısınıfı();
        SqlConnection bağlantı = new SqlConnection(bağlantısınıfı.Sqlbağlantısı);
        DataSet DataSet = new DataSet();
       
        private void Form7_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = DataSet;
            bağlantı.Open();
            SqlDataAdapter adrt = new SqlDataAdapter("select Adsoyad,Toplamborç,VerilenborçTarihi,AlınacakborçTarihi,Telefon from  Müşteri ", bağlantı);
            adrt.Fill(DataSet, "Müşteri");
            dataGridView1.DataSource = DataSet.Tables["Müşteri"];
            bağlantı.Close();

           


           




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
           
         


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void Tltutar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

           
            adsoyad.Text = dataGridView1.CurrentRow.Cells["Adsoyad"].Value.ToString();
             Telefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            Toplamborç.Text = dataGridView1.CurrentRow.Cells["Toplamborç"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            string sql = "SELECT *  FROM Müşteri Where AlınacakborçTarihi BETWEEN @tar1 and @tar2 ";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, bağlantı);
            adp.SelectCommand.Parameters.AddWithValue("@tar1", dateTimePicker1.Value);
            adp.SelectCommand.Parameters.AddWithValue("@tar2", dateTimePicker2.Value);
           
            adp.Fill(dt);
            bağlantı.Close();
            dataGridView1.DataSource = dt;


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

    

