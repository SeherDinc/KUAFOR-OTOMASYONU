using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 musteri = new Form1();
           musteri.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 randevu = new Form2();
            randevu.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ilayda" && textBox2.Text == "deniz")
            {
                button1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                MessageBox.Show("Hatalı giriş yaptınız.");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
        }
    }
}
