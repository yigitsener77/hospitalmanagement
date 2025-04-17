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
    public partial class YeniHasta: Form
    {
        private readonly HastaYonetimi yonet;
        private readonly Dictionary<string, string> kan_gruplari;
        public YeniHasta()
        {
            InitializeComponent();         
            yonet = new HastaYonetimi();
            kan_gruplari = new Dictionary<string, string>
            {
              { "A+", "A Rh +" },
              { "B+", "B Rh +" },
              { "AB+", "AB Rh +" },
              { "0+", "0 Rh +" },
              { "A-", "A Rh -" },
              { "B", "B Rh -" },
              { "AB-", "AB Rh -" },
              { "0-", "0 Rh -" }
            };
            cb_kan_grubu.DataSource = new BindingSource(kan_gruplari, null);
            cb_kan_grubu.DisplayMember = "Value";
            cb_kan_grubu.ValueMember = "Key";
            cb_kan_grubu.SelectedIndex = -1;

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tb_tckn.Text.Trim().Length > 0 &&
                tb_ad.Text.Trim().Length > 0 &&
                tb_soyad.Text.Trim().Length > 0)
            {
                KontrolCevap cevap = Utils.TCKNKontrol(tb_tckn.Text.Trim());
                if (cevap.Durum)
                {
                    long tckn = Convert.ToInt64(tb_tckn.Text.Trim());
                    if (yonet.Oku(tckn) == null)
                    {
                        Hasta hasta = new Hasta
                        {
                            TCKN = tckn,
                            Ad = tb_ad.Text.Trim(),
                            Soyad = tb_soyad.Text.Trim(),
                            DogumTarihi = dtp_dogum_tarihi.Value,
                            Alerjiler = tb_alerjiler.Text.Trim().Split(',').ToList(),
                            KronikHastaliklar = tb_kronik_hastaliklar.Text.Trim().Split(',').ToList(),
                            //Trim: Stringlerde baştaki ve sondaki boşlukları kaldırır
                            Notlar = tb_notlar.Text.Trim() == string.Empty ? null : tb_notlar.Text.Trim(),
                            KanGrubu = cb_kan_grubu.SelectedValue?.ToString(),
                            SigortaliMi = rb_sigorta_var.Checked,
                            MedeniDurum = rb_evli.Checked,
                            Sigara = cb_sigara.Checked,
                            Alkol = cb_alkol.Checked,
                            Telefon = tb_telefon.Text.Trim()
                        };
                        if (rb_erkek.Checked) hasta.Cinsiyet = 'E';
                        else if (rb_kadin.Checked) hasta.Cinsiyet = 'K';

                        yonet.Ekle(hasta);
                        //Yeni kayıt ekleme mantığı burada çalışacak.
                        MessageBox.Show("Kayıt başarıyla gerçekleşti!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Bu T.C. Kimlik Numarası ile bir hasta kaydı zaten mevcut!");
                    }
                }
                else
                {
                    MessageBox.Show(cevap.Mesaj);

                }
            }
            else
            {
                //Kayıt eklenemiyor uyarısı verecek.
                MessageBox.Show("İstenilen bilgiler eksik!");
            }
        }

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
