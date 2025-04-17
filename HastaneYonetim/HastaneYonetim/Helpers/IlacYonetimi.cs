using HastaneYonetim.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.Helpers
{

    public class IlacYonetimi : IYonetim<Ilac>
    {
        public void Guncelle(Ilac t)
        {
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                string sorgu = "UPDATE Ilac SET Ad=@ad, Kullanim=@kullanim WHERE IlacNo = @id";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@ad", t.Ad);
                    komut.Parameters.AddWithValue("@kullanim", t.Kullanim);
                    komut.Parameters.AddWithValue("@id", t.IlacNo);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
        }

        public List<Ilac> HepsiniOku()
        {
            List<Ilac> ilaclar = new List<Ilac>();
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                string sorgu = "SELECT * FROM Ilac";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    baglanti.Open();
                    using (SqlDataReader okuyucu = komut.ExecuteReader())
                    {
                        while (okuyucu.Read())
                        {
                            Ilac ilac = new Ilac
                            {
                                IlacNo = okuyucu.GetInt32(okuyucu.GetOrdinal("IlacNo")),
                                Ad = okuyucu.GetString(okuyucu.GetOrdinal("Ad")),
                                Kullanim = okuyucu.IsDBNull(okuyucu.GetOrdinal("Kullanim")) ? null : okuyucu.GetString(okuyucu.GetOrdinal("Kullanim"))
                            };
                            ilaclar.Add(ilac); 
                        }
                    }
                    baglanti.Close();
                }
            }
            return ilaclar;
        }


        public Ilac Oku(long id)
        {
            throw new NotImplementedException();
        }

        public void Sil(long id)
        {
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                string sorgu = "DELETE FROM Ilac WHERE IlacNo = @id";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@id", id);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close() ;
                }

            }
        }

        public void Ekle(Ilac t)
        {
            using (SqlConnection baglanti = Veritabani.Baglanti())
            {
                string sorgu = "INSERT INTO Ilac (Ad, Kullanim) VALUES (@ad, @kullanim)";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@ad", t.Ad);
                    //Kullanım boş olma ihtimali için DBNulleklendi.
                    komut.Parameters.AddWithValue("@kullanim", t.Kullanim ?? (object)DBNull.Value);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
        }

        void IYonetim<Ilac>.Ekle(Ilac t)
        {
            throw new NotImplementedException();
        }
    }
}
