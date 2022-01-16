using System;

namespace VoidKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();



            productManager.Topla2(3, 6);


            int toplamSonucu = productManager.Topla(3, 6);         //return de yapılan işlemi burada çağırdık
                                                                   //tekrar kullanabilmek için toplamaSonucu olarak bir
            Console.WriteLine(toplamSonucu);                       //değişkende kaydettik

            Console.WriteLine(toplamSonucu * 2);
        }
    }
}
