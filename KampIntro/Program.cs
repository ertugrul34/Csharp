using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - kendini tekrarlama

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azazlış Görseli");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Görseli");
            }
            else
            {
                Console.WriteLine("Sabit Görseli");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
                

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
