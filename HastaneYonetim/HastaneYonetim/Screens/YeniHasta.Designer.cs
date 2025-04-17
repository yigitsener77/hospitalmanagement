namespace HastaneYonetim.Screens
{
    partial class YeniHasta
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tckn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.cb_kan_grubu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_dogum_tarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_sigorta_var = new System.Windows.Forms.RadioButton();
            this.rb_sigorta_yok = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_evli = new System.Windows.Forms.RadioButton();
            this.rb_bekar = new System.Windows.Forms.RadioButton();
            this.grp_sigorta = new System.Windows.Forms.GroupBox();
            this.grp_medeni = new System.Windows.Forms.GroupBox();
            this.cb_alkol = new System.Windows.Forms.CheckBox();
            this.cb_sigara = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_alerjiler = new System.Windows.Forms.TextBox();
            this.tb_kronik_hastaliklar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_notlar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_vazgec = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.grp_cinsiyet = new System.Windows.Forms.GroupBox();
            this.rb_belirtilmemis = new System.Windows.Forms.RadioButton();
            this.rb_kadin = new System.Windows.Forms.RadioButton();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.grp_sigorta.SuspendLayout();
            this.grp_medeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grp_cinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Hasta Kaydı Giriş Formu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C.Kimlik Numarası:";
            // 
            // tb_tckn
            // 
            this.tb_tckn.Location = new System.Drawing.Point(132, 33);
            this.tb_tckn.Name = "tb_tckn";
            this.tb_tckn.Size = new System.Drawing.Size(100, 20);
            this.tb_tckn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad:";
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(132, 60);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(100, 20);
            this.tb_ad.TabIndex = 4;
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(259, 60);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(100, 20);
            this.tb_soyad.TabIndex = 5;
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
            this.cb_kan_grubu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kan Grubu:";
            // 
            // dtp_dogum_tarihi
            // 
            this.dtp_dogum_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dogum_tarihi.Location = new System.Drawing.Point(132, 126);
            this.dtp_dogum_tarihi.Name = "dtp_dogum_tarihi";
            this.dtp_dogum_tarihi.Size = new System.Drawing.Size(100, 20);
            this.dtp_dogum_tarihi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sigorta Durumu:";
            // 
            // rb_sigorta_var
            // 
            this.rb_sigorta_var.AutoSize = true;
            this.rb_sigorta_var.Location = new System.Drawing.Point(4, 16);
            this.rb_sigorta_var.Name = "rb_sigorta_var";
            this.rb_sigorta_var.Size = new System.Drawing.Size(41, 17);
            this.rb_sigorta_var.TabIndex = 11;
            this.rb_sigorta_var.TabStop = true;
            this.rb_sigorta_var.Text = "Var";
            this.rb_sigorta_var.UseVisualStyleBackColor = true;
            // 
            // rb_sigorta_yok
            // 
            this.rb_sigorta_yok.AutoSize = true;
            this.rb_sigorta_yok.Checked = true;
            this.rb_sigorta_yok.Location = new System.Drawing.Point(53, 16);
            this.rb_sigorta_yok.Name = "rb_sigorta_yok";
            this.rb_sigorta_yok.Size = new System.Drawing.Size(44, 17);
            this.rb_sigorta_yok.TabIndex = 12;
            this.rb_sigorta_yok.TabStop = true;
            this.rb_sigorta_yok.Text = "Yok";
            this.rb_sigorta_yok.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Medeni Durumu:";
            // 
            // rb_evli
            // 
            this.rb_evli.AutoSize = true;
            this.rb_evli.Location = new System.Drawing.Point(6, 15);
            this.rb_evli.Name = "rb_evli";
            this.rb_evli.Size = new System.Drawing.Size(42, 17);
            this.rb_evli.TabIndex = 14;
            this.rb_evli.Text = "Evli";
            this.rb_evli.UseVisualStyleBackColor = true;
            // 
            // rb_bekar
            // 
            this.rb_bekar.AutoSize = true;
            this.rb_bekar.Checked = true;
            this.rb_bekar.Location = new System.Drawing.Point(73, 15);
            this.rb_bekar.Name = "rb_bekar";
            this.rb_bekar.Size = new System.Drawing.Size(53, 17);
            this.rb_bekar.TabIndex = 15;
            this.rb_bekar.TabStop = true;
            this.rb_bekar.Text = "Bekar";
            this.rb_bekar.UseVisualStyleBackColor = true;
            // 
            // grp_sigorta
            // 
            this.grp_sigorta.Controls.Add(this.rb_sigorta_var);
            this.grp_sigorta.Controls.Add(this.rb_sigorta_yok);
            this.grp_sigorta.Location = new System.Drawing.Point(132, 296);
            this.grp_sigorta.Name = "grp_sigorta";
            this.grp_sigorta.Size = new System.Drawing.Size(95, 39);
            this.grp_sigorta.TabIndex = 16;
            this.grp_sigorta.TabStop = false;
            // 
            // grp_medeni
            // 
            this.grp_medeni.Controls.Add(this.rb_evli);
            this.grp_medeni.Controls.Add(this.rb_bekar);
            this.grp_medeni.Location = new System.Drawing.Point(535, 24);
            this.grp_medeni.Name = "grp_medeni";
            this.grp_medeni.Size = new System.Drawing.Size(148, 38);
            this.grp_medeni.TabIndex = 17;
            this.grp_medeni.TabStop = false;
            // 
            // cb_alkol
            // 
            this.cb_alkol.AutoSize = true;
            this.cb_alkol.Location = new System.Drawing.Point(541, 77);
            this.cb_alkol.Name = "cb_alkol";
            this.cb_alkol.Size = new System.Drawing.Size(49, 17);
            this.cb_alkol.TabIndex = 18;
            this.cb_alkol.Text = "Alkol";
            this.cb_alkol.UseVisualStyleBackColor = true;
            // 
            // cb_sigara
            // 
            this.cb_sigara.AutoSize = true;
            this.cb_sigara.Location = new System.Drawing.Point(627, 77);
            this.cb_sigara.Name = "cb_sigara";
            this.cb_sigara.Size = new System.Drawing.Size(56, 17);
            this.cb_sigara.TabIndex = 19;
            this.cb_sigara.Text = "Sigara";
            this.cb_sigara.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Alerjiler:";
            // 
            // tb_alerjiler
            // 
            this.tb_alerjiler.Location = new System.Drawing.Point(541, 110);
            this.tb_alerjiler.Multiline = true;
            this.tb_alerjiler.Name = "tb_alerjiler";
            this.tb_alerjiler.Size = new System.Drawing.Size(120, 69);
            this.tb_alerjiler.TabIndex = 21;
            // 
            // tb_kronik_hastaliklar
            // 
            this.tb_kronik_hastaliklar.Location = new System.Drawing.Point(541, 200);
            this.tb_kronik_hastaliklar.Multiline = true;
            this.tb_kronik_hastaliklar.Name = "tb_kronik_hastaliklar";
            this.tb_kronik_hastaliklar.Size = new System.Drawing.Size(120, 69);
            this.tb_kronik_hastaliklar.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(446, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 49);
            this.label9.TabIndex = 22;
            this.label9.Text = "Kronik Hastalıklar:";
            // 
            // tb_notlar
            // 
            this.tb_notlar.Location = new System.Drawing.Point(541, 283);
            this.tb_notlar.Multiline = true;
            this.tb_notlar.Name = "tb_notlar";
            this.tb_notlar.Size = new System.Drawing.Size(120, 69);
            this.tb_notlar.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Notlar";
            // 
            // btn_vazgec
            // 
            this.btn_vazgec.Location = new System.Drawing.Point(571, 385);
            this.btn_vazgec.Name = "btn_vazgec";
            this.btn_vazgec.Size = new System.Drawing.Size(83, 20);
            this.btn_vazgec.TabIndex = 26;
            this.btn_vazgec.Text = "Vazgeç";
            this.btn_vazgec.UseVisualStyleBackColor = true;
            this.btn_vazgec.Click += new System.EventHandler(this.btn_vazgec_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(16, 385);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 27;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(132, 159);
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(100, 20);
            this.tb_telefon.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Telefon:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Cinsiyet:";
            // 
            // grp_cinsiyet
            // 
            this.grp_cinsiyet.Controls.Add(this.rb_belirtilmemis);
            this.grp_cinsiyet.Controls.Add(this.rb_kadin);
            this.grp_cinsiyet.Controls.Add(this.rb_erkek);
            this.grp_cinsiyet.Location = new System.Drawing.Point(132, 185);
            this.grp_cinsiyet.Name = "grp_cinsiyet";
            this.grp_cinsiyet.Size = new System.Drawing.Size(90, 94);
            this.grp_cinsiyet.TabIndex = 31;
            this.grp_cinsiyet.TabStop = false;
            // 
            // rb_belirtilmemis
            // 
            this.rb_belirtilmemis.AutoSize = true;
            this.rb_belirtilmemis.Location = new System.Drawing.Point(6, 64);
            this.rb_belirtilmemis.Name = "rb_belirtilmemis";
            this.rb_belirtilmemis.Size = new System.Drawing.Size(81, 17);
            this.rb_belirtilmemis.TabIndex = 2;
            this.rb_belirtilmemis.TabStop = true;
            this.rb_belirtilmemis.Text = "Belirtilmemiş";
            this.rb_belirtilmemis.UseVisualStyleBackColor = true;
            // 
            // rb_kadin
            // 
            this.rb_kadin.AutoSize = true;
            this.rb_kadin.Location = new System.Drawing.Point(6, 41);
            this.rb_kadin.Name = "rb_kadin";
            this.rb_kadin.Size = new System.Drawing.Size(52, 17);
            this.rb_kadin.TabIndex = 1;
            this.rb_kadin.TabStop = true;
            this.rb_kadin.Text = "Kadın";
            this.rb_kadin.UseVisualStyleBackColor = true;
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.Location = new System.Drawing.Point(6, 18);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(53, 17);
            this.rb_erkek.TabIndex = 0;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            // 
            // YeniHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 491);
            this.Controls.Add(this.grp_cinsiyet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_telefon);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_vazgec);
            this.Controls.Add(this.tb_notlar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_kronik_hastaliklar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_alerjiler);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_sigara);
            this.Controls.Add(this.cb_alkol);
            this.Controls.Add(this.grp_medeni);
            this.Controls.Add(this.grp_sigorta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_dogum_tarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_kan_grubu);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tckn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniHasta";
            this.Text = "YeniHasta";
            this.grp_sigorta.ResumeLayout(false);
            this.grp_sigorta.PerformLayout();
            this.grp_medeni.ResumeLayout(false);
            this.grp_medeni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grp_cinsiyet.ResumeLayout(false);
            this.grp_cinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tckn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.ComboBox cb_kan_grubu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dogum_tarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_sigorta_var;
        private System.Windows.Forms.RadioButton rb_sigorta_yok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_evli;
        private System.Windows.Forms.RadioButton rb_bekar;
        private System.Windows.Forms.GroupBox grp_sigorta;
        private System.Windows.Forms.GroupBox grp_medeni;
        private System.Windows.Forms.CheckBox cb_alkol;
        private System.Windows.Forms.CheckBox cb_sigara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_alerjiler;
        private System.Windows.Forms.TextBox tb_kronik_hastaliklar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_notlar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_vazgec;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grp_cinsiyet;
        private System.Windows.Forms.RadioButton rb_kadin;
        private System.Windows.Forms.RadioButton rb_erkek;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rb_belirtilmemis;
    }
}