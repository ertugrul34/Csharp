using System;
namespace OOP1
{
    public class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi :" +" "+ product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi :" + " " + product.ProductName);
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);

        }
    }
}
