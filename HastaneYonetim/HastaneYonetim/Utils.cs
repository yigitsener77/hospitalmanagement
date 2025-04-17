using HastaneYonetim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim
{
    public static class Utils
    {
        public static KontrolCevap TCKNKontrol(string tckn)
        {
            KontrolCevap cevap = new KontrolCevap();
            if (long.TryParse(tckn, out long kimlik))
            {
                if (kimlik.ToString().Length == 11)
                {
                    long ilk9 = kimlik / 100;
                    long son2 = kimlik % 100;
                    long tekler = 0, ciftler = 0;
                    for (int i = 1; i < 10; i++)
                    {
                        long b = ilk9 % 10;
                        ilk9 /= 10;
                        if (i % 2 == 0)
                        {
                            ciftler += b;
                        }
                        else
                        {
                            tekler += b;
                        }
                    }

                    long b10 = (tekler * 7 - ciftler) % 10;
                    long b11 = (tekler + ciftler + b10) % 10;

                    if (son2 == b10 * 10 + b11)
                    {
                        cevap.Mesaj = "Kimlik numarası tutarlıdır.";
                        cevap.Durum = true;
                    }
                    else
                    {
                        cevap.Mesaj = "Kimlik numarası tutarsızdır.";
                    }
                }
                else
                {
                    cevap.Mesaj = "Kimlik numarası 11 basamaklı olmalıdır!";
                }
            }
            else
            {
                cevap.Mesaj = "Kimlik numarası rakamlardan oluşmalıdır!";
            }

            return cevap;
        }
    }
}

