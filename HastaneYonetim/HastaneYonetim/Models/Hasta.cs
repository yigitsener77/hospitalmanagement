using System;
using System.Collections.Generic;

namespace HastaneYonetim.Models
{
    public class Hasta : Kimlik
    {
        public List<Randevu> Randevular { get; set; }
        public string Notlar { get; set; }
        public List<string> KronikHastaliklar { get; set; }
        public List<string> Alerjiler { get; set; }
        public bool SigortaliMi { get; set; }
        public bool? MedeniDurum { get; set; }
        public bool? Sigara { get; set; }
        public bool? Alkol { get; set; }
        public List<Ilac> KullanilanIlaclar { get; set; }
    }
   
    public class HastaListeElemani
    {
        public long TCKN {  get; set; }
        public string AdSoyad { get; set; }
        public string KanGrubu {  get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi {  get; set; }
        public string Sigorta {  get; set; }
    }
}