using System;

namespace ProductListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 28;
            product1.ProductName = "Tablet";
            product1.UnitPrice = 99.9;
            product1.UnitsInStock = 210;

            Product product2 = new Product();
            product2.Id = 36;
            product2.ProductName = "Klavye";
            product2.UnitPrice = 78.60;
            product2.UnitsInStock = 130;

            Product product3 = new Product();
            product3.Id = 45;
            product3.ProductName = "Fare";
            product3.UnitPrice = 55;
            product3.UnitsInStock = 230;

            Product[] products = new Product[] { product1,product2,product3};
            foreach (Product product in products)
            {
                Console.WriteLine(" ");
                Console.WriteLine(product.Id + ":" + product.ProductName + ":" + product.UnitPrice + ":" + product.UnitsInStock);
                Console.WriteLine(" ");
                Console.WriteLine(product.ProductName + " Eklendi");
                Console.WriteLine(" ");
            }

            for (int i = 0; i < products.Length; i=i+1)
            {
                Console.WriteLine(products[i]);
            }






           


        }
    }
}
