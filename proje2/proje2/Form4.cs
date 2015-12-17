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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection deneme = new SqlConnection("Data Source=SEHER-PC\\SQLEXPRESS;Initial Catalog=projedenem;Integrated Security=True;");
        public void veri(string randevu)
        {
            SqlDataAdapter da = new SqlDataAdapter(randevu,deneme);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_randevu.DataSource = ds.Tables[0];
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            veri("select*from Randevu2");
        }
    }
}
