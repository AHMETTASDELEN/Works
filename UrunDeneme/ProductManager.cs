using System;
using System.Collections.Generic;
using System.Text;

namespace UrunDeneme
{
    class ProductManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine(product.ProductName + " : " +"Eklendi");
        }

        public void Sil(Product product)
        {
            Console.WriteLine(product.ProductName + " : " + "Silindi");
        }

        public void Güncelle(Product product)
        {
            Console.WriteLine(product.ProductName + " : " + "Güncellendi");
        }
    }
}