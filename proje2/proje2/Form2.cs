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
namespace proje2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection deneme = new SqlConnection("Data Source=SEHER-PC\\SQLEXPRESS;Initial Catalog=projedenem;Integrated Security=True;");
        public void veri(string randevu)
        {
            SqlDataAdapter da = new SqlDataAdapter(randevu, deneme);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_randevu.DataSource = ds.Tables[0];
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            deneme.Open();
            SqlCommand komut = new SqlCommand("select*from randevubos",deneme);
            SqlDataReader saat = komut.ExecuteReader();
            while(saat.Read())
            {
                comboBox2.Items.Add(saat[0].ToString());
            }
            deneme.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            deneme.Open();
            SqlCommand komut = new SqlCommand("insert into randevu(m_ad_soyad,p_ad_soyad,tarih,saat,islem) values(@adi,@per,@tarihi,@saati,@islemi)",deneme);
            komut.Parameters.AddWithValue("@adi", textBox1.Text);
            komut.Parameters.AddWithValue("@per", comboBox1.Text);
            komut.Parameters.AddWithValue("@tarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@saati",comboBox2.Text);
            komut.Parameters.AddWithValue("@islemi", textBox1.Text);
            komut.ExecuteNonQuery();
            deneme.Close();
            veri("select* from randevu");
            

        }

        private void dataGridView_randevu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
