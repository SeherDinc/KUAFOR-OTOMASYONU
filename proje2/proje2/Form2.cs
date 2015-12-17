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
        private void Form2_Load(object sender, EventArgs e)
        {
            deneme.Open();
            SqlCommand komut = new SqlCommand("select*from randevuol",deneme);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                comboBox_saat.Items.Add(oku[0].ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            //deneme.Open();
            //SqlCommand komut = new SqlCommand("insert into (m_ad_soyad,p_ad_soyad,tarih,saat)values('"+textBoxmusteri.Text+"','"+textBoxcalısan.Text+"','"+dateTimePicker1.Text+"','"+comboBox_saat.Text+"'");
            //komut.ExecuteNonQuery();
            //komut.CommandText="insert into randevudolu(personal_adı,saat)values('"+comboBox_saat+"')'";
            //komut.CommandText="delete from randevuol "
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_sil_Click(object sender, EventArgs e)
        {

        }

        private void buttongor_Click(object sender, EventArgs e)
        {
            Form4 randevu=new Form4();
            randevu.Show();

        }

     
       
    }
}
