using HastaneYonetim.Helpers;
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

    public partial class HastaDetay : Form
    {
        private readonly long tckn;
        private readonly HastaYonetimi yonet;

        public HastaDetay(long tckn)
        {
            InitializeComponent();
            this.tckn = tckn;
            yonet = new HastaYonetimi();
        }

        private void HastaDetay_Load(object sender, EventArgs e)
        {
            lbl_tckn.Text = tckn.ToString();
            Hasta hasta = yonet.Oku(tckn);
            lbl_adsoyad.Text = $"{hasta.Ad} {hasta.Soyad}";
            lbl_dogum_tarihi.Text = hasta.DogumTarihi.ToString("dd/MM/yyyy");
            lbl_alerjiler.Text = string.Join(", ", hasta.Alerjiler);
            lbl_kronik_hastaliklar.Text = string.Join(", ", hasta.KronikHastaliklar);
            lbl_kan_grubu.Text = hasta.KanGrubu;
            lbl_sigortali_mi.Text = hasta.SigortaliMi ? "Var" : "Yok";
            lbl_medeni_durum.Text = hasta.MedeniDurum ? "Evli" : "Bekar";
            lbl_sigara.Text = hasta.Sigara ? "Kullanıyor" : "Kullanmıyor";
            lbl_alkol.Text = hasta.Alkol ? "Kullanıyor" : "Kullanmıyor";
            lbl_telefon.Text = hasta.Telefon;
        }
    }
}
