namespace HastaneYonetim.Screens
{
    partial class YeniIlac
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
            this.tb_kullanim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.num_ilacNo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_ilaclar = new System.Windows.Forms.ListBox();
            this.btn_vazgec = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_ilacNo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_kullanim
            // 
            this.tb_kullanim.Location = new System.Drawing.Point(66, 90);
            this.tb_kullanim.Multiline = true;
            this.tb_kullanim.Name = "tb_kullanim";
            this.tb_kullanim.Size = new System.Drawing.Size(137, 82);
            this.tb_kullanim.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kullanım:";
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(63, 38);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(140, 20);
            this.tb_ad.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "İlaç No:";
            // 
            // num_ilacNo
            // 
            this.num_ilacNo.Location = new System.Drawing.Point(62, 7);
            this.num_ilacNo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_ilacNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_ilacNo.Name = "num_ilacNo";
            this.num_ilacNo.Size = new System.Drawing.Size(51, 20);
            this.num_ilacNo.TabIndex = 18;
            this.num_ilacNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kayıtlı İlaç Listesi:";
            // 
            // lst_ilaclar
            // 
            this.lst_ilaclar.FormattingEnabled = true;
            this.lst_ilaclar.Location = new System.Drawing.Point(213, 38);
            this.lst_ilaclar.Name = "lst_ilaclar";
            this.lst_ilaclar.Size = new System.Drawing.Size(231, 134);
            this.lst_ilaclar.TabIndex = 20;
            this.lst_ilaclar.SelectedIndexChanged += new System.EventHandler(this.lst_ilaclar_SelectedIndexChanged);
            // 
            // btn_vazgec
            // 
            this.btn_vazgec.Location = new System.Drawing.Point(15, 249);
            this.btn_vazgec.Name = "btn_vazgec";
            this.btn_vazgec.Size = new System.Drawing.Size(75, 23);
            this.btn_vazgec.TabIndex = 21;
            this.btn_vazgec.Text = "Vazgeç";
            this.btn_vazgec.UseVisualStyleBackColor = true;
            this.btn_vazgec.Click += new System.EventHandler(this.btn_vazgec_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(369, 249);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 22;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(207, 249);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 23;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(288, 249);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 24;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // YeniIlac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_vazgec);
            this.Controls.Add(this.lst_ilaclar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_ilacNo);
            this.Controls.Add(this.tb_kullanim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "YeniIlac";
            this.Text = "YeniIlac";
            this.Load += new System.EventHandler(this.YeniIlac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_ilacNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_kullanim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown num_ilacNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_ilaclar;
        private System.Windows.Forms.Button btn_vazgec;
        private System.Windows.Forms.Button btn_ekle;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
    }
}