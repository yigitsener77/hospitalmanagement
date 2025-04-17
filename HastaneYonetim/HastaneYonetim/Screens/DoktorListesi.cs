using HastaneYonetim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetim.Screens
{
    public partial class DoktorListesi : Form
    {
        public DoktorListesi()
        {
            InitializeComponent();
        }
        private List<DoktorListeElemani> doktorlar;
        private void DoktorListesi_Load(object sender, EventArgs e)
        {
            doktorlar = new List<DoktorListeElemani>
            {
                new DoktorListeElemani
                {
                    TCKN = 98765432112,
                    AdSoyad = "Derin Erson",
                    KanGrubu = "0 Rh-",
                    Musait = "Evet",
                    Telefon = "05559876541",
                    Alan = "Dahiliye",
                    Poliklinik = "Dahiliye"
                }
            };
            dgv_doktorlar.AutoGenerateColumns = false;
            dgv_doktorlar.DataSource = doktorlar;
        }

        
        private void menu_detay_Click(object sender, EventArgs e)
        {

        }
        
 
        private void menu_guncelle_Click(object sender, EventArgs e)
        {
            if(dgv_doktorlar.SelectedRows.Count > 0)
            {
                DialogResult cevap = MessageBox.Show("Seçilen Doktor kaydı güncellenecektir, emin misiniz?","Kayıt Güncelleme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(cevap != DialogResult.Yes)
                {
                    
                }
            }
        }


        private void menu_sil_Click(object sender, EventArgs e)
        {
            if(dgv_doktorlar.SelectedRows.Count > 0)
            {
                DialogResult cevap = MessageBox.Show("Seçilen Doktorun Kaydı silinecektir, emin misiniz?","Kayıt Silme",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap != DialogResult.Yes)
                {
                    long secilen_tckn = Convert.ToInt64(dgv_doktorlar.SelectedRows[0].Cells[0].Value);
                    dgv_doktorlar.Rows.RemoveAt(dgv_doktorlar.SelectedRows[0].Index);
                }
            }
        }
    }
}
