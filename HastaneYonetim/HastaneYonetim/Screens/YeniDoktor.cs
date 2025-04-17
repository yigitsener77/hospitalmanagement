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
    public partial class YeniDoktor : Form
    {
        public YeniDoktor()
        {
            InitializeComponent();
            dtp_dogum_tarihi.MaxDate = DateTime.Now.AddYears(-21);
        }

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tb_tckn.Text.Length > 0 &&
               tb_ad.Text.Length > 0 &&
               tb_soyad.Text.Length > 0 &&
               cb_kan_grubu.Text.Length > 0 &&
               dtp_dogum_tarihi.Value < DateTime.Now.AddYears(-21) &&
               cb_alan.Text.Length > 0 &&
               cb_poliklinik.Text.Length > 0)    
            {
                KontrolCevap cevap = Utils.TCKNKontrol(tb_tckn.Text);
                if (cevap.Durum)
                {
                    MessageBox.Show("İstenilen Bilgiler Tamam!");
                }
                else
                {
                    MessageBox.Show(cevap.Mesaj);
                }
            }
            else
            {
                MessageBox.Show("İstenilen bilgiler eksik.");
            }
        }
    }
}
