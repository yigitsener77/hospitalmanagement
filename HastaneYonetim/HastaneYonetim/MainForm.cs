using HastaneYonetim.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetim
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_yeni_hasta_formu_Click(object sender, EventArgs e)
        {
            YeniHasta yeniHasta = new YeniHasta();
            yeniHasta.ShowDialog();
        }

        private void btn_yeni_doktor_kayit_Click(object sender, EventArgs e)
        {
            YeniDoktor yeniDoktor = new YeniDoktor();
            yeniDoktor.ShowDialog();
        }

        private void btn_yeni_ilac_kayit_Click(object sender, EventArgs e)
        {
            YeniIlac yeniIlac = new YeniIlac();
            yeniIlac.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi = new HastaListesi();
            hastaListesi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorListesi doktorListesi = new DoktorListesi();
            doktorListesi.ShowDialog();
        }

        private void btn_kayitli_doktor_Click(object sender, EventArgs e)
        {
            DoktorListesi doktorListesi = new DoktorListesi();
            doktorListesi.ShowDialog();
        }

        private void btn_kayitli_hasta_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi = new HastaListesi();
            hastaListesi.ShowDialog();
        }
    }
}
