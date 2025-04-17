using System.Collections.Generic;

namespace HastaneYonetim.Helpers
{
    //T: Strong Type: Baskın tip, T ile belirtilen alana bir veri tipi yazıldığında interface veya sınıf o veri tipi için kullanılabilir olur.
    public interface IYonetim<T>
    {
        void Ekle(T t);
        T Oku(long id);
        List<T> HepsiniOku();
        void Guncelle(T t);
        void Sil(long id);
    }
}
