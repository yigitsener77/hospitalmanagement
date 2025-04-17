namespace HastaneYonetim
{
    partial class MainForm
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
            this.btn_yeni_hasta_formu = new System.Windows.Forms.Button();
            this.btn_yeni_doktor_kayit = new System.Windows.Forms.Button();
            this.btn_yeni_ilac_kayit = new System.Windows.Forms.Button();
            this.btn_kayitli_doktor = new System.Windows.Forms.Button();
            this.btn_kayitli_hasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_yeni_hasta_formu
            // 
            this.btn_yeni_hasta_formu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni_hasta_formu.Location = new System.Drawing.Point(12, 12);
            this.btn_yeni_hasta_formu.Name = "btn_yeni_hasta_formu";
            this.btn_yeni_hasta_formu.Size = new System.Drawing.Size(167, 65);
            this.btn_yeni_hasta_formu.TabIndex = 0;
            this.btn_yeni_hasta_formu.Text = "Yeni Hasta Kayıt Formu";
            this.btn_yeni_hasta_formu.UseVisualStyleBackColor = true;
            this.btn_yeni_hasta_formu.Click += new System.EventHandler(this.btn_yeni_hasta_formu_Click);
            // 
            // btn_yeni_doktor_kayit
            // 
            this.btn_yeni_doktor_kayit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni_doktor_kayit.Location = new System.Drawing.Point(185, 12);
            this.btn_yeni_doktor_kayit.Name = "btn_yeni_doktor_kayit";
            this.btn_yeni_doktor_kayit.Size = new System.Drawing.Size(167, 65);
            this.btn_yeni_doktor_kayit.TabIndex = 1;
            this.btn_yeni_doktor_kayit.Text = "Yeni Doktor Kayıt Formu";
            this.btn_yeni_doktor_kayit.UseVisualStyleBackColor = true;
            this.btn_yeni_doktor_kayit.Click += new System.EventHandler(this.btn_yeni_doktor_kayit_Click);
            // 
            // btn_yeni_ilac_kayit
            // 
            this.btn_yeni_ilac_kayit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni_ilac_kayit.Location = new System.Drawing.Point(358, 12);
            this.btn_yeni_ilac_kayit.Name = "btn_yeni_ilac_kayit";
            this.btn_yeni_ilac_kayit.Size = new System.Drawing.Size(167, 65);
            this.btn_yeni_ilac_kayit.TabIndex = 2;
            this.btn_yeni_ilac_kayit.Text = "İlaç Düzenleme Formu";
            this.btn_yeni_ilac_kayit.UseVisualStyleBackColor = true;
            this.btn_yeni_ilac_kayit.Click += new System.EventHandler(this.btn_yeni_ilac_kayit_Click);
            // 
            // btn_kayitli_doktor
            // 
            this.btn_kayitli_doktor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitli_doktor.Location = new System.Drawing.Point(185, 83);
            this.btn_kayitli_doktor.Name = "btn_kayitli_doktor";
            this.btn_kayitli_doktor.Size = new System.Drawing.Size(167, 65);
            this.btn_kayitli_doktor.TabIndex = 5;
            this.btn_kayitli_doktor.Text = "Kayıtlı Doktor Listesi";
            this.btn_kayitli_doktor.UseVisualStyleBackColor = true;
            this.btn_kayitli_doktor.Click += new System.EventHandler(this.btn_kayitli_doktor_Click);
            // 
            // btn_kayitli_hasta
            // 
            this.btn_kayitli_hasta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitli_hasta.Location = new System.Drawing.Point(12, 83);
            this.btn_kayitli_hasta.Name = "btn_kayitli_hasta";
            this.btn_kayitli_hasta.Size = new System.Drawing.Size(167, 65);
            this.btn_kayitli_hasta.TabIndex = 6;
            this.btn_kayitli_hasta.Text = "Kayıtlı Hasta Listesi";
            this.btn_kayitli_hasta.UseVisualStyleBackColor = true;
            this.btn_kayitli_hasta.Click += new System.EventHandler(this.btn_kayitli_hasta_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.btn_kayitli_hasta);
            this.Controls.Add(this.btn_kayitli_doktor);
            this.Controls.Add(this.btn_yeni_ilac_kayit);
            this.Controls.Add(this.btn_yeni_doktor_kayit);
            this.Controls.Add(this.btn_yeni_hasta_formu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.Name = "MainForm";
            this.Text = "Hastane Yönetim Sistemi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yeni_hasta_formu;
        private System.Windows.Forms.Button btn_yeni_doktor_kayit;
        private System.Windows.Forms.Button btn_yeni_ilac_kayit;
        private System.Windows.Forms.Button btn_kayitli_doktor;
        private System.Windows.Forms.Button btn_kayitli_hasta;
    }
}

