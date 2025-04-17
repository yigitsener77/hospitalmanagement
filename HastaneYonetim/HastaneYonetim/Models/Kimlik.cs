using System;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.Models
{
    public abstract class Kimlik
    {
        public long TCKN { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KanGrubu { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public char? Cinsiyet { get; set; }

    }
}