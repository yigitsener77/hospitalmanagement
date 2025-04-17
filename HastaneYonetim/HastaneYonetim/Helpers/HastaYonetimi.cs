using HastaneYonetim.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.Helpers
{
    public class HastaYonetimi : IYonetim<Hasta>
    {
        public void Ekle(Hasta t)
        {
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                string sorgu = "INSERT INTO Hasta(TCKN,Ad,Soyad,KanGrubu,DogumTarihi,Telefon,Cinsiyet,Notlar,Alerjiler,KronikHastaliklar,SigortaliMi,MedeniDurum,Sigara,Alkol) VALUES (@TCKN,@Ad,@Soyad,@KanGrubu,@DogumTarihi,@Telefon,@Cinsiyet,@Notlar,@Alerjiler,@KronikHastaliklar,@SigortaliMi,@MedeniDurum,@Sigara,@Alkol)";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    baglanti.Open();
                    komut.Parameters.AddWithValue("@TCKN", t.TCKN);                   
                    komut.Parameters.AddWithValue("@Ad", t.Ad);
                    komut.Parameters.AddWithValue("@Soyad", t.Soyad);
                    komut.Parameters.AddWithValue("KanGrubu", t.KanGrubu ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@DogumTarihi", t.DogumTarihi);
                    komut.Parameters.AddWithValue("@Telefon", t.Telefon ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Cinsiyet", t.Cinsiyet ?? 'B');
                    komut.Parameters.AddWithValue("@Notlar", t.Notlar ?? (object)DBNull.Value);
                    string alerjiler = string.Join(",", t.Alerjiler);
                    komut.Parameters.AddWithValue("@Alerjiler", alerjiler ?? (object)DBNull.Value);
                    string hastaliklar = string.Join(",", t.KronikHastaliklar);
                    komut.Parameters.AddWithValue("@KronikHastaliklar", hastaliklar ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@SigortaliMi", t.SigortaliMi);
                    komut.Parameters.AddWithValue("@MedeniDurum", t.MedeniDurum ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Sigara", t.Sigara ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Alkol", t.Alkol ?? (object)DBNull.Value);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
        }

        public void Guncelle(Hasta t)
        {
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                string sorgu = "UPDATE Hasta SET (TCKN,Ad,Soyad,KanGrubu,DogumTarihi,Telefon,Cinsiyet,Notlar,Alerjiler,KronikHastaliklar,SigortaliMi,MedeniDurum,Sigara,Alkol) VALUES(@TCKN,@Ad,@Soyad,@KanGrubu,@DogumTarihi,@Telefon,@Cinsiyet,@Notlar,@Alerjiler,@KronikHastaliklar,@SigortaliMi,@MedeniDurum,@Sigara,@Alkol)";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    baglanti.Open();
                    komut.Parameters.AddWithValue("@TCKN", t.TCKN);
                    komut.Parameters.AddWithValue("@Ad", t.Ad);
                    komut.Parameters.AddWithValue("@Soyad", t.Soyad);
                    komut.Parameters.AddWithValue("@KanGrubu", t.KanGrubu ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@DogumTarihi", t.DogumTarihi);
                    komut.Parameters.AddWithValue("@Telefon", t.Telefon ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Cinsiyet", t.Cinsiyet ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Notlar", t.Notlar ?? (object)DBNull.Value);
                    string alerjiler = string.Join(",", t.Alerjiler);
                    komut.Parameters.AddWithValue("@Alerjiler", alerjiler ?? (object)DBNull.Value);                 
                    string hastaliklar = string.Join(",", t.KronikHastaliklar);
                    komut.Parameters.AddWithValue("@KronikHastaliklar", hastaliklar ?? (object)DBNull.Value);                   
                    komut.Parameters.AddWithValue("@SigortaliMi", t.SigortaliMi);
                    komut.Parameters.AddWithValue("@MedeniDurum", t.MedeniDurum ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Sigara", t.Sigara ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Alkol", t.Alkol ?? (object)DBNull.Value);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
        }

        public List<Hasta> HepsiniOku()
        {
            List<Hasta> hastalar = new List<Hasta>();
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                string sorgu = "SELECT * FROM Hasta";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    baglanti.Open();
                    using (SqlDataReader okuyucu = komut.ExecuteReader())
                    {
                        while (okuyucu.Read())
                        {
                            Hasta hasta = new Hasta
                            {
                                TCKN = okuyucu.GetInt64(0),
                                Ad = okuyucu.GetString(1),
                                Soyad = okuyucu.GetString(2),
                                KanGrubu = okuyucu.IsDBNull(3) ? null : okuyucu.GetString(3),
                                DogumTarihi = okuyucu.GetDateTime(4),
                                Telefon = okuyucu.GetString(5),                                                             
                                Notlar = okuyucu.IsDBNull(7) ? null : okuyucu.GetString(7),
                                Alerjiler = okuyucu.IsDBNull(8) ? new List<string>() : okuyucu.GetString(8).Split(',').ToList(),
                                KronikHastaliklar = okuyucu.IsDBNull(9) ? new List<string>() : okuyucu.GetString(9).Split(',').ToList(),
                                SigortaliMi = okuyucu.GetBoolean(10),                              
                            };
                            if (!okuyucu.IsDBNull(6)) hasta.Cinsiyet = okuyucu.GetString(6)[0];                           
                            if (!okuyucu.IsDBNull(11)) hasta.MedeniDurum = okuyucu.GetBoolean(11);                           
                            if (!okuyucu.IsDBNull (12)) hasta.Sigara = okuyucu.GetBoolean(12);                          
                            if (!okuyucu.IsDBNull(13)) hasta.Alkol = okuyucu.GetBoolean(13);                     
                            hastalar.Add(hasta);
                        }
                    }
                    baglanti.Close();
                }
            }
            return hastalar;
        }

        public Hasta Oku(long id)
        {
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                string sorgu = "SELECT * FROM Hasta WHERE TCKN = @tckn";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("tckn", id);
                    baglanti.Open();
                    using (SqlDataReader okuyucu = komut.ExecuteReader())
                    {
                        //Sadece ilk veriyi okur, yoksa atlar.
                        if (okuyucu.Read())
                        {
                            Hasta hasta = new Hasta
                            {
                                TCKN = okuyucu.GetInt64(0),
                                Ad = okuyucu.GetString(1),
                                Soyad = okuyucu.GetString(2),
                                KanGrubu = okuyucu.IsDBNull(3) ? null : okuyucu.GetString(3),
                                DogumTarihi = okuyucu.GetDateTime(4),
                                Telefon = okuyucu.GetString(5),
                                Notlar = okuyucu.IsDBNull(7) ? null : okuyucu.GetString(7),
                                Alerjiler = okuyucu.IsDBNull(8) ? new List<string>() : okuyucu.GetString(8).Split(',').ToList(),
                                KronikHastaliklar = okuyucu.IsDBNull(9) ? new List<string>() : okuyucu.GetString(9).Split(',').ToList(),
                                SigortaliMi = okuyucu.GetBoolean(10),
                            };
                            if (!okuyucu.IsDBNull(6)) hasta.Cinsiyet = okuyucu.GetString(6)[0];
                            if (!okuyucu.IsDBNull(11)) hasta.MedeniDurum = okuyucu.GetBoolean(11);
                            if (!okuyucu.IsDBNull(12)) hasta.Sigara = okuyucu.GetBoolean(12);
                            if (!okuyucu.IsDBNull(13)) hasta.Alkol = okuyucu.GetBoolean(13);

                            return hasta;
                        }
                    }
                    baglanti.Close();
                }
            }
                return null;
        }

        public void Sil(long id)
        {
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                string sorgu = "DELETE FROM Hasta WHERE TCKN = @id";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@id", id);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

            }
        }
    }
}
