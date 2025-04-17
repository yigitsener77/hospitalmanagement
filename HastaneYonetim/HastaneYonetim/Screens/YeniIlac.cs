using HastaneYonetim.Helpers;
using HastaneYonetim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetim.Screens
{
    public partial class YeniIlac : Form
    {
        private List<Ilac> ilaclar;
        private IlacYonetimi yonet;
        public YeniIlac()
        {
            InitializeComponent();
            yonet = new IlacYonetimi();
            ListeyiDoldur();
          
        }

        private void ListeyiDoldur()
        {
            tb_ad.Text = string.Empty;
            tb_kullanim.Clear();
            ilaclar = yonet.HepsiniOku();
            lst_ilaclar.DataSource = ilaclar;
            lst_ilaclar.DisplayMember = "Ad";
            lst_ilaclar.ValueMember = "IlacNo";
            lst_ilaclar.SelectedIndex = -1;
            btn_sil.Visible = false;
            btn_guncelle.Visible = false;
            btn_ekle.Visible = true;
        }

        private void YeniIlac_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(tb_ad.Text.Length > 0)
            {
                Ilac yeni_ilac = new Ilac
                {
                    Ad = tb_ad.Text,
                    Kullanim = tb_kullanim.Text
                };

                yonet.Ekle(yeni_ilac);
                ListeyiDoldur();

            }
            else
            {
                MessageBox.Show("İstenen bilgiler eksik!!!");
            }
        }

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lst_ilaclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listelerde hiç bir şey seçilmediyse bu index -1 gelecektir.
            if(lst_ilaclar.SelectedIndex > -1)
            {
                //listelerde seçilen elementin kendisini verir(as Alias Kısatılmışı.)
                Ilac secilen = lst_ilaclar.SelectedItem as Ilac;
                btn_ekle.Visible = false;
                btn_sil.Visible = true;
                btn_guncelle.Visible = true;
                num_ilacNo.Enabled = false;

                num_ilacNo.Value = secilen.IlacNo;
                tb_ad.Text = secilen.Ad;
                tb_kullanim.Text = secilen.Kullanim;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (tb_ad.Text.Length > 0)
            {
                Ilac secilen = lst_ilaclar.SelectedItem as Ilac;
                secilen.Ad = tb_ad.Text;
                secilen.Kullanim = tb_kullanim.Text;
                yonet.Guncelle(secilen);
                ListeyiDoldur();               
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Ilac secilen = lst_ilaclar.SelectedItem as Ilac;
            int ilacNo = secilen.IlacNo;
            DialogResult cevap = MessageBox.Show("Seçilen ilaç kaydı silinecektir, Emin misiniz?", "İlaç Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                yonet.Sil(ilacNo);
                ListeyiDoldur();
            }
        }
    }
}
