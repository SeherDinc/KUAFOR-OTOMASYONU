namespace proje2
{
    partial class Form1
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
            this.labelad = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_yas = new System.Windows.Forms.TextBox();
            this.textBox_dogum = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.button_gör = new System.Windows.Forms.Button();
            this.button_güncelle = new System.Windows.Forms.Button();
            this.labelmail = new System.Windows.Forms.Label();
            this.labeltel = new System.Windows.Forms.Label();
            this.labelyas = new System.Windows.Forms.Label();
            this.labeld_tar = new System.Windows.Forms.Label();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_güncel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelad.Location = new System.Drawing.Point(12, 12);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(80, 19);
            this.labelad.TabIndex = 0;
            this.labelad.Text = "Adı Soyadı:";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(150, 139);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(111, 20);
            this.textBox_mail.TabIndex = 13;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(150, 75);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(111, 20);
            this.textBox_tel.TabIndex = 12;
            // 
            // textBox_yas
            // 
            this.textBox_yas.Location = new System.Drawing.Point(150, 106);
            this.textBox_yas.Name = "textBox_yas";
            this.textBox_yas.Size = new System.Drawing.Size(111, 20);
            this.textBox_yas.TabIndex = 11;
            // 
            // textBox_dogum
            // 
            this.textBox_dogum.Location = new System.Drawing.Point(150, 41);
            this.textBox_dogum.Name = "textBox_dogum";
            this.textBox_dogum.Size = new System.Drawing.Size(111, 20);
            this.textBox_dogum.TabIndex = 10;
            this.textBox_dogum.TextChanged += new System.EventHandler(this.textBox_dogum_TextChanged);
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(150, 11);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(111, 20);
            this.textBox_ad.TabIndex = 9;
            // 
            // button_gör
            // 
            this.button_gör.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_gör.Location = new System.Drawing.Point(384, 107);
            this.button_gör.Name = "button_gör";
            this.button_gör.Size = new System.Drawing.Size(166, 34);
            this.button_gör.TabIndex = 8;
            this.button_gör.Text = "Görüntüle";
            this.button_gör.UseVisualStyleBackColor = true;
            this.button_gör.Click += new System.EventHandler(this.button_gör_Click);
            // 
            // button_güncelle
            // 
            this.button_güncelle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_güncelle.Location = new System.Drawing.Point(384, 59);
            this.button_güncelle.Name = "button_güncelle";
            this.button_güncelle.Size = new System.Drawing.Size(166, 34);
            this.button_güncelle.TabIndex = 7;
            this.button_güncelle.Text = "Güncelle";
            this.button_güncelle.UseVisualStyleBackColor = true;
            this.button_güncelle.Click += new System.EventHandler(this.button_güncelle_Click);
            // 
            // labelmail
            // 
            this.labelmail.AutoSize = true;
            this.labelmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelmail.Location = new System.Drawing.Point(12, 138);
            this.labelmail.Name = "labelmail";
            this.labelmail.Size = new System.Drawing.Size(87, 19);
            this.labelmail.TabIndex = 4;
            this.labelmail.Text = "Mail Adresi:";
            // 
            // labeltel
            // 
            this.labeltel.AutoSize = true;
            this.labeltel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltel.Location = new System.Drawing.Point(12, 74);
            this.labeltel.Name = "labeltel";
            this.labeltel.Size = new System.Drawing.Size(131, 19);
            this.labeltel.TabIndex = 3;
            this.labeltel.Text = "Telefon Numarası:";
            // 
            // labelyas
            // 
            this.labelyas.AutoSize = true;
            this.labelyas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyas.Location = new System.Drawing.Point(12, 107);
            this.labelyas.Name = "labelyas";
            this.labelyas.Size = new System.Drawing.Size(34, 19);
            this.labelyas.TabIndex = 2;
            this.labelyas.Text = "Yaş:";
            // 
            // labeld_tar
            // 
            this.labeld_tar.AutoSize = true;
            this.labeld_tar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeld_tar.Location = new System.Drawing.Point(12, 40);
            this.labeld_tar.Name = "labeld_tar";
            this.labeld_tar.Size = new System.Drawing.Size(96, 19);
            this.labeld_tar.TabIndex = 1;
            this.labeld_tar.Text = "Doğum Tarihi";
            // 
            // button_kaydet
            // 
            this.button_kaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Location = new System.Drawing.Point(384, 147);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(166, 34);
            this.button_kaydet.TabIndex = 14;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 177);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(363, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = " İsim:";
            // 
            // textBox_güncel
            // 
            this.textBox_güncel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_güncel.Location = new System.Drawing.Point(448, 23);
            this.textBox_güncel.Name = "textBox_güncel";
            this.textBox_güncel.Size = new System.Drawing.Size(130, 27);
            this.textBox_güncel.TabIndex = 20;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(722, 374);
            this.Controls.Add(this.textBox_güncel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.button_gör);
            this.Controls.Add(this.labeld_tar);
            this.Controls.Add(this.button_güncelle);
            this.Controls.Add(this.labelad);
            this.Controls.Add(this.labelmail);
            this.Controls.Add(this.labeltel);
            this.Controls.Add(this.labelyas);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.textBox_dogum);
            this.Controls.Add(this.textBox_yas);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_tel);
            this.Name = "Form1";
            this.Text = "Müşteri Kaydı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelad;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_yas;
        private System.Windows.Forms.TextBox textBox_dogum;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Button button_gör;
        private System.Windows.Forms.Button button_güncelle;
        private System.Windows.Forms.Label labelmail;
        private System.Windows.Forms.Label labeltel;
        private System.Windows.Forms.Label labelyas;
        private System.Windows.Forms.Label labeld_tar;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_güncel;
    }
}

