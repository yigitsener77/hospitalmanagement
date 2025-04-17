using System;

namespace HastaneYonetim.Models
{
    public class Randevu
    {
        public string Barkod { get; set; }
        public long HastaTCKN { get; set; }
        public long DoktorTCKN { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Notlar { get; set; }
        public bool Durum { get; set; }
        public int ReceteNo {  get; set; }
    }
}