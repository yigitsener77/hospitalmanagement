namespace HastaneYonetim.Screens
{
    partial class DoktorListesi
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
            this.dgv_doktorlar = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_adSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tckn = new System.Windows.Forms.TextBox();
            this.TCKN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanGrubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poliklinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_detay = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sil = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktorlar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_doktorlar
            // 
            this.dgv_doktorlar.AllowUserToAddRows = false;
            this.dgv_doktorlar.AllowUserToDeleteRows = false;
            this.dgv_doktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doktorlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TCKN,
            this.AdSoyad,
            this.Telefon,
            this.KanGrubu,
            this.Poliklinik,
            this.Alan});
            this.dgv_doktorlar.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_doktorlar.Location = new System.Drawing.Point(-1, 106);
            this.dgv_doktorlar.MultiSelect = false;
            this.dgv_doktorlar.Name = "dgv_doktorlar";
            this.dgv_doktorlar.ReadOnly = true;
            this.dgv_doktorlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doktorlar.Size = new System.Drawing.Size(541, 249);
            this.dgv_doktorlar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_adSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_tckn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Ara:";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(453, 38);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 2;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad:";
            // 
            // tb_adSoyad
            // 
            this.tb_adSoyad.Location = new System.Drawing.Point(329, 40);
            this.tb_adSoyad.Name = "tb_adSoyad";
            this.tb_adSoyad.Size = new System.Drawing.Size(100, 20);
            this.tb_adSoyad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // tb_tckn
            // 
            this.tb_tckn.Location = new System.Drawing.Point(89, 40);
            this.tb_tckn.Name = "tb_tckn";
            this.tb_tckn.Size = new System.Drawing.Size(100, 20);
            this.tb_tckn.TabIndex = 3;
            // 
            // TCKN
            // 
            this.TCKN.DataPropertyName = "TCKN";
            this.TCKN.HeaderText = "T.C. Kimlik No";
            this.TCKN.Name = "TCKN";
            this.TCKN.ReadOnly = true;
            // 
            // AdSoyad
            // 
            this.AdSoyad.DataPropertyName = "AdSoyad";
            this.AdSoyad.HeaderText = "Ad Soyad";
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // KanGrubu
            // 
            this.KanGrubu.DataPropertyName = "KanGrubu";
            this.KanGrubu.HeaderText = "Kan Grubu";
            this.KanGrubu.Name = "KanGrubu";
            this.KanGrubu.ReadOnly = true;
            // 
            // Poliklinik
            // 
            this.Poliklinik.DataPropertyName = "Poliklinik";
            this.Poliklinik.HeaderText = "Poliklinik";
            this.Poliklinik.Name = "Poliklinik";
            this.Poliklinik.ReadOnly = true;
            // 
            // Alan
            // 
            this.Alan.DataPropertyName = "Alan";
            this.Alan.HeaderText = "Alan";
            this.Alan.Name = "Alan";
            this.Alan.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_detay,
            this.menu_guncelle,
            this.menu_sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
            // 
            // menu_detay
            // 
            this.menu_detay.Name = "menu_detay";
            this.menu_detay.Size = new System.Drawing.Size(180, 22);
            this.menu_detay.Text = "Detay";
            this.menu_detay.Click += new System.EventHandler(this.menu_detay_Click);
            // 
            // menu_guncelle
            // 
            this.menu_guncelle.Name = "menu_guncelle";
            this.menu_guncelle.Size = new System.Drawing.Size(180, 22);
            this.menu_guncelle.Text = "Güncelle";
            this.menu_guncelle.Click += new System.EventHandler(this.menu_guncelle_Click);
            // 
            // menu_sil
            // 
            this.menu_sil.Name = "menu_sil";
            this.menu_sil.Size = new System.Drawing.Size(180, 22);
            this.menu_sil.Text = "Sil";
            this.menu_sil.Click += new System.EventHandler(this.menu_sil_Click);
            // 
            // DoktorListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_doktorlar);
            this.Name = "DoktorListesi";
            this.Text = "DoktorListesi";
            this.Load += new System.EventHandler(this.DoktorListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktorlar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_doktorlar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_adSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tckn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCKN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanGrubu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poliklinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_detay;
        private System.Windows.Forms.ToolStripMenuItem menu_guncelle;
        private System.Windows.Forms.ToolStripMenuItem menu_sil;
    }
}