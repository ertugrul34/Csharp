using System;
namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi :" +" "+ product.ProductName);
        }
    }
}
