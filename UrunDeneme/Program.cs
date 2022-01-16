using System;

namespace UrunDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Buji";
            product1.UnitPrice = 300;
            product1.UnitsInStock = 210;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Akü";
            product2.UnitPrice = 500;
            product2.UnitsInStock = 55;

            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "Far";
            product3.UnitPrice = 480;
            product3.UnitsInStock = 22;

            Product product4 = new Product();
            product4.Id = 4;
            product4.ProductName = "Silecek";
            product4.UnitPrice = 80;
            product4.UnitsInStock = 38;

            ProductManager productManager = new ProductManager();
            productManager.Ekle(product1);
            productManager.Güncelle(product2);
            productManager.Sil(product3);
            Console.WriteLine(" ");

            Product[] products = new Product[]
            {
                product1,
                product2,
                product3,
                product4
            };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine("----------");
            }



        }
    }
}
