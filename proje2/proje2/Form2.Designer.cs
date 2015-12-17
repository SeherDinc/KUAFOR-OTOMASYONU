namespace proje2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_saat = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxmusteri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_islem = new System.Windows.Forms.ComboBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.buttongor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Randevu Tarihi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Randevu  Saati :";
            // 
            // comboBox_saat
            // 
            this.comboBox_saat.FormattingEnabled = true;
            this.comboBox_saat.Location = new System.Drawing.Point(209, 129);
            this.comboBox_saat.Name = "comboBox_saat";
            this.comboBox_saat.Size = new System.Drawing.Size(184, 27);
            this.comboBox_saat.TabIndex = 9;
            this.comboBox_saat.SelectedIndexChanged += new System.EventHandler(this.comboBox_saat_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBoxmusteri
            // 
            this.textBoxmusteri.Location = new System.Drawing.Point(209, 15);
            this.textBoxmusteri.Name = "textBoxmusteri";
            this.textBoxmusteri.Size = new System.Drawing.Size(121, 27);
            this.textBoxmusteri.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yapılacak İşlem:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox_islem
            // 
            this.comboBox_islem.FormattingEnabled = true;
            this.comboBox_islem.Items.AddRange(new object[] {
            "Solaryum",
            "Cilt Bakımı",
            "Saç Bakımı"});
            this.comboBox_islem.Location = new System.Drawing.Point(209, 174);
            this.comboBox_islem.Name = "comboBox_islem";
            this.comboBox_islem.Size = new System.Drawing.Size(121, 27);
            this.comboBox_islem.TabIndex = 10;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(58, 235);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(159, 45);
            this.button_kaydet.TabIndex = 6;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(416, 111);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(130, 45);
            this.button_sil.TabIndex = 7;
            this.button_sil.Text = "Sil ";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // buttongor
            // 
            this.buttongor.Location = new System.Drawing.Point(338, 269);
            this.buttongor.Name = "buttongor";
            this.buttongor.Size = new System.Drawing.Size(208, 45);
            this.buttongor.TabIndex = 8;
            this.buttongor.Text = "Randevuları Görüntüle";
            this.buttongor.UseVisualStyleBackColor = true;
            this.buttongor.Click += new System.EventHandler(this.buttongor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Müşteri Adı Soyadı:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(416, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 27);
            this.textBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Personel Adı Soyadı:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1-DenizSAVUMLU",
            "2-BurcuSAVUMLU",
            "3-HavvaYALAVEŞ",
            "4-SedaTEPE"});
            this.comboBox1.Location = new System.Drawing.Point(209, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 326);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttongor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxmusteri);
            this.Controls.Add(this.comboBox_islem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_saat);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Randevu İşlemleri";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_saat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxmusteri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_islem;
        private System.Windows.Forms.Button buttongor;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}