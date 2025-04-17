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
    public partial class HastaListesi : Form
    {
        private readonly HastaYonetimi yonet;
        public HastaListesi()
        {
            InitializeComponent();
            yonet = new HastaYonetimi();
        }
        private List<HastaListeElemani> hastalar;
        private void HastaListesi_Load(object sender, EventArgs e)
        {
            List<Hasta> data = yonet.HepsiniOku();
            hastalar = new List<HastaListeElemani>();
            foreach (Hasta hasta in data)
            {
                hastalar.Add(new HastaListeElemani{
                    TCKN = hasta.TCKN,
                    AdSoyad = $"{hasta.Ad} {hasta.Soyad}",
                    DogumTarihi = hasta.DogumTarihi,
                    KanGrubu = hasta.KanGrubu,
                    Sigorta = hasta.SigortaliMi ? "Var" : "Yok",
                    Telefon = hasta.Telefon
                });
            }
            dgv_hastalar.AutoGenerateColumns = false;
            dgv_hastalar.DataSource = hastalar;
        }

        private void menu_hasta_detay_Click(object sender, EventArgs e)
        {
            if (dgv_hastalar.SelectedRows.Count > 0)
            {
                long tckn = (long)dgv_hastalar.SelectedRows[0].Cells[0].Value;
                HastaDetay detay = new HastaDetay(tckn);
                detay.ShowDialog();
            }
        }
    }
}
