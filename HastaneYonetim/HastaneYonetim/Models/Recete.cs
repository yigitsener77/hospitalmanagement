using System.Collections.Generic;

namespace HastaneYonetim.Models
{
    public class Recete
    {
        public int ReceteNo { get; set; }
        public List<Ilac> Ilaclar { get; set; }
    }
}