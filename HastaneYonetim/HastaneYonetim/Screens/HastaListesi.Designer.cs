namespace HastaneYonetim.Screens
{
    partial class HastaListesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.tb_adSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tckn = new System.Windows.Forms.TextBox();
            this.dgv_hastalar = new System.Windows.Forms.DataGridView();
            this.TCKN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanGrubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_hasta_detay = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_hasta_duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_hasta_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastalar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.tb_adSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_tckn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Ara:";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(395, 18);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 4;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            // 
            // tb_adSoyad
            // 
            this.tb_adSoyad.Location = new System.Drawing.Point(273, 20);
            this.tb_adSoyad.Name = "tb_adSoyad";
            this.tb_adSoyad.Size = new System.Drawing.Size(100, 20);
            this.tb_adSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // tb_tckn
            // 
            this.tb_tckn.Location = new System.Drawing.Point(95, 20);
            this.tb_tckn.Name = "tb_tckn";
            this.tb_tckn.Size = new System.Drawing.Size(100, 20);
            this.tb_tckn.TabIndex = 0;
            // 
            // dgv_hastalar
            // 
            this.dgv_hastalar.AllowUserToAddRows = false;
            this.dgv_hastalar.AllowUserToDeleteRows = false;
            this.dgv_hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hastalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TCKN,
            this.AdSoyad,
            this.Telefon,
            this.KanGrubu,
            this.DogumTarihi,
            this.Sigorta});
            this.dgv_hastalar.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_hastalar.Location = new System.Drawing.Point(0, 75);
            this.dgv_hastalar.Name = "dgv_hastalar";
            this.dgv_hastalar.ReadOnly = true;
            this.dgv_hastalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hastalar.Size = new System.Drawing.Size(510, 285);
            this.dgv_hastalar.TabIndex = 5;
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
            this.KanGrubu.HeaderText = "KanGrubu";
            this.KanGrubu.Name = "KanGrubu";
            this.KanGrubu.ReadOnly = true;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "DogumTarihi";
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.ReadOnly = true;
            // 
            // Sigorta
            // 
            this.Sigorta.DataPropertyName = "Sigorta";
            this.Sigorta.HeaderText = "Sigorta";
            this.Sigorta.Name = "Sigorta";
            this.Sigorta.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_hasta_detay,
            this.menu_hasta_duzenle,
            this.menu_hasta_sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // menu_hasta_detay
            // 
            this.menu_hasta_detay.Name = "menu_hasta_detay";
            this.menu_hasta_detay.Size = new System.Drawing.Size(180, 22);
            this.menu_hasta_detay.Text = "Görüntüle";
            this.menu_hasta_detay.Click += new System.EventHandler(this.menu_hasta_detay_Click);
            // 
            // menu_hasta_duzenle
            // 
            this.menu_hasta_duzenle.Name = "menu_hasta_duzenle";
            this.menu_hasta_duzenle.Size = new System.Drawing.Size(180, 22);
            this.menu_hasta_duzenle.Text = "Düzenle";
            // 
            // menu_hasta_sil
            // 
            this.menu_hasta_sil.Name = "menu_hasta_sil";
            this.menu_hasta_sil.Size = new System.Drawing.Size(180, 22);
            this.menu_hasta_sil.Text = "Sil";
            // 
            // HastaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 361);
            this.Controls.Add(this.dgv_hastalar);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(520, 400);
            this.Name = "HastaListesi";
            this.Text = "HastaListesi";
            this.Load += new System.EventHandler(this.HastaListesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastalar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox tb_adSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tckn;
        private System.Windows.Forms.DataGridView dgv_hastalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCKN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanGrubu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigorta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_hasta_detay;
        private System.Windows.Forms.ToolStripMenuItem menu_hasta_duzenle;
        private System.Windows.Forms.ToolStripMenuItem menu_hasta_sil;
    }
}