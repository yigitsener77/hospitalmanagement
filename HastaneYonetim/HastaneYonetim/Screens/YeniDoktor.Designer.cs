namespace HastaneYonetim.Screens
{
    partial class YeniDoktor
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_vazgec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_dogum_tarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_kan_grubu = new System.Windows.Forms.ComboBox();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_tckn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_poliklinik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_alan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_musait_mi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(245, 237);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 39;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_vazgec
            // 
            this.btn_vazgec.Location = new System.Drawing.Point(19, 237);
            this.btn_vazgec.Name = "btn_vazgec";
            this.btn_vazgec.Size = new System.Drawing.Size(75, 23);
            this.btn_vazgec.TabIndex = 22;
            this.btn_vazgec.Text = "Vazgeç";
            this.btn_vazgec.UseVisualStyleBackColor = true;
            this.btn_vazgec.Click += new System.EventHandler(this.btn_vazgec_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // dtp_dogum_tarihi
            // 
            this.dtp_dogum_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dogum_tarihi.Location = new System.Drawing.Point(132, 126);
            this.dtp_dogum_tarihi.Name = "dtp_dogum_tarihi";
            this.dtp_dogum_tarihi.Size = new System.Drawing.Size(100, 20);
            this.dtp_dogum_tarihi.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Kan Grubu:";
            // 
            // cb_kan_grubu
            // 
            this.cb_kan_grubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kan_grubu.FormattingEnabled = true;
            this.cb_kan_grubu.Items.AddRange(new object[] {
            "A Rh(+)",
            "A Rh(-)",
            "B Rh(+)",
            "B Rh(-)",
            "AB Rh(+)",
            "AB Rh(-)",
            "0 Rh(+)",
            "0 Rh(-)"});
            this.cb_kan_grubu.Location = new System.Drawing.Point(132, 98);
            this.cb_kan_grubu.Name = "cb_kan_grubu";
            this.cb_kan_grubu.Size = new System.Drawing.Size(121, 21);
            this.cb_kan_grubu.TabIndex = 35;
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(259, 60);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(100, 20);
            this.tb_soyad.TabIndex = 34;
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(132, 60);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(100, 20);
            this.tb_ad.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Ad Soyad:";
            // 
            // tb_tckn
            // 
            this.tb_tckn.Location = new System.Drawing.Point(132, 33);
            this.tb_tckn.Name = "tb_tckn";
            this.tb_tckn.Size = new System.Drawing.Size(100, 20);
            this.tb_tckn.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "T.C.Kimlik Numarası:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "Yeni Doktor Kaydı Giriş Formu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Müsait Mi?:";
            // 
            // cb_poliklinik
            // 
            this.cb_poliklinik.FormattingEnabled = true;
            this.cb_poliklinik.Items.AddRange(new object[] {
            "Aile Hekimliği Polikliniği",
            "Çocuk Sağlığı ve Hastalıkları Polikliniği",
            "Diş Hekimliği Polikliniği",
            "Kadın Hastalıkları ve Doğum Polikliniği",
            "Dahiliye Polikliniği",
            "Genel Cerrahi Polikliniği",
            "Psikiyatri Polikliniği",
            "Nöroloji Polikliniği",
            "Dermatoloji Polikliniği",
            "Enfeksiyon Hastalıkları Polikliniği",
            "Kardiyoloji Polikliniği",
            "Göz Hastalıkları Polikliniği",
            "Kulak Burun Boğaz (KBB) Polikliniği",
            "Ortopedi ve Travmatoloji Polikliniği",
            "Üroloji Polikliniği",
            "Anesteziyoloji Polikliniği",
            "Radyoloji Polikliniği",
            "Patoloji Polikliniği",
            "Fiziksel Tıp ve Rehabilitasyon Polikliniği",
            "Onkoloji Polikliniği",
            "Endokrinoloji Polikliniği",
            "Gastroenteroloji Polikliniği",
            "Hematoloji Polikliniği",
            "Kardiyovasküler Cerrahi Polikliniği",
            "Plastik Rekonstrüktif ve Estetik Cerrahi Polikliniği",
            "Çocuk Cerrahisi Polikliniği",
            "Acil Tıp Polikliniği",
            "Geriatri Polikliniği",
            "Spor Hekimliği Polikliniği",
            "Halk Sağlığı Polikliniği"});
            this.cb_poliklinik.Location = new System.Drawing.Point(73, 196);
            this.cb_poliklinik.Name = "cb_poliklinik";
            this.cb_poliklinik.Size = new System.Drawing.Size(121, 21);
            this.cb_poliklinik.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Poliklinik:";
            // 
            // cb_alan
            // 
            this.cb_alan.FormattingEnabled = true;
            this.cb_alan.Items.AddRange(new object[] {
            "Aile Hekimliği",
            "Çocuk Sağlığı ve Hastalıkları",
            "Diş Hekimliği",
            "Kadın Hastalıkları ve Doğum",
            "Dahiliye (İç Hastalıkları)",
            "Genel Cerrahi",
            "Psikiyatri",
            "Nöroloji",
            "Dermatoloji",
            "Enfeksiyon Hastalıkları",
            "Kardiyoloji",
            "Göz Hastalıkları",
            "Kulak Burun Boğaz (KBB)",
            "Ortopedi ve Travmatoloji",
            "Üroloji",
            "Anesteziyoloji ve Reanimasyon",
            "Radyoloji",
            "Patoloji",
            "Fiziksel Tıp ve Rehabilitasyon",
            "Onkoloji",
            "Endokrinoloji",
            "Gastroenteroloji",
            "Hematoloji",
            "Kardiyovasküler Cerrahi",
            "Plastik Rekonstrüktif ve Estetik Cerrahi",
            "Çocuk Cerrahisi",
            "Acil Tıp",
            "Geriatri",
            "Spor Hekimliği",
            "Halk Sağlığı"});
            this.cb_alan.Location = new System.Drawing.Point(55, 160);
            this.cb_alan.Name = "cb_alan";
            this.cb_alan.Size = new System.Drawing.Size(121, 21);
            this.cb_alan.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Alan:";
            // 
            // cb_musait_mi
            // 
            this.cb_musait_mi.AutoSize = true;
            this.cb_musait_mi.Location = new System.Drawing.Point(238, 203);
            this.cb_musait_mi.Name = "cb_musait_mi";
            this.cb_musait_mi.Size = new System.Drawing.Size(15, 14);
            this.cb_musait_mi.TabIndex = 40;
            this.cb_musait_mi.UseVisualStyleBackColor = true;
            // 
            // YeniDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 339);
            this.Controls.Add(this.cb_musait_mi);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_vazgec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_dogum_tarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_kan_grubu);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_tckn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_poliklinik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_alan);
            this.Controls.Add(this.label2);
            this.Name = "YeniDoktor";
            this.Text = "YeniDoktor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_vazgec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_dogum_tarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_kan_grubu;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_tckn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_poliklinik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_alan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_musait_mi;
    }
}