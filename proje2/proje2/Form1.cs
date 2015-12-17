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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection deneme = new SqlConnection("Data Source=SEHER-PC\\SQLEXPRESS;Initial Catalog=projedenem;Integrated Security=True;");
        public void verigoster(String veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,deneme);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void button_kaydet_Click(object sender, EventArgs e)
        {

        }

        private void textBox_dogum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_gör_Click(object sender, EventArgs e)
        {
            deneme.Open();
            verigoster("select* from musterim");
            deneme.Close();
        }

        private void button_kaydet_Click_1(object sender, EventArgs e)
        {
            deneme.Open();
            SqlCommand komut = new SqlCommand("insert into musterim(m_ad_soyad,yas,d_tarihi,telefon,mail) values (@adi,@yasi,@d_tarihi,@teli,@maili)",deneme);
            komut.Parameters.AddWithValue("@adi", textBox_ad.Text);
            komut.Parameters.AddWithValue("@yasi", textBox_yas.Text);
            komut.Parameters.AddWithValue("@d_tarihi", textBox_dogum.Text);
            komut.Parameters.AddWithValue("@teli", textBox_tel.Text);
            komut.Parameters.AddWithValue("@maili", textBox_mail.Text);
            komut.ExecuteNonQuery();
            verigoster("select* from musterim");
            deneme.Close();
            textBox_ad.Clear();
            textBox_yas.Clear();
            textBox_dogum.Clear();
            textBox_tel.Clear();
            textBox_mail.Clear();
        }

        
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            string m_ad_soyad = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            string yas=dataGridView1.Rows[secili].Cells[1].Value.ToString();
            string d_tarihi=dataGridView1.Rows[secili].Cells[2].Value.ToString();
            string telefon=dataGridView1.Rows[secili].Cells[3].Value.ToString();
            string mail = dataGridView1.Rows[secili].Cells[4].Value.ToString();

            textBox_ad.Text = m_ad_soyad;
            textBox_yas.Text = yas;
            textBox_dogum.Text = d_tarihi;
            textBox_tel.Text = telefon;
            textBox_mail.Text = mail;
        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            deneme.Open();
            SqlCommand komut = new SqlCommand("update musterim set m_ad_soyad='"+textBox_ad.Text+"',yas='" + textBox_yas.Text + "',d_tarihi='" + textBox_dogum.Text + "',telefon='" + textBox_tel.Text + "',mail='" + textBox_mail.Text + "'where m_ad_soyad='" + textBox_ad.Text + "'", deneme);
            komut.ExecuteNonQuery();
            verigoster("select*from musterim");
            deneme.Close();
        }

    }
}