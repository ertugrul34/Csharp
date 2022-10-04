using System;
namespace Metotlar
{
    public class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi);
        }
    }
}
