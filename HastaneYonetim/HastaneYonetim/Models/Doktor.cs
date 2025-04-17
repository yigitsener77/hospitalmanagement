using System.Collections.Generic;

namespace HastaneYonetim.Models
{
    public class Doktor : Kimlik
    {
        public string Alan { get; set; }
        public string Poliklinik { get; set; }
        public bool MusaitMi { get; set; }
        public List<Randevu> Randevular { get; set; }
    }
  
    public class DoktorListeElemani
    {
        public long TCKN { get; set; }
        public string AdSoyad { get; set; }
        public string KanGrubu { get; set; }
        public string Telefon { get; set; }
        public string Alan { get; set; }
        public string Poliklinik { get; set; }
        public string Musait { get; set; }
    }
}