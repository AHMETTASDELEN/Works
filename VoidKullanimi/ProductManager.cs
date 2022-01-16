using System;
using System.Collections.Generic;
using System.Text;

namespace VoidKullanimi
{
    class ProductManager
    {
        public int Topla(int sayı1, int sayı2)           //return, işlemi yapar ve tekrar kullanabilmemizi sağlar 
        {
            return sayı1 + sayı2;
        }

        public void Topla2(int sayı1, int sayı2)         //void, işlemi yapar ve bitirir
        {
            Console.WriteLine(sayı1 + sayı2);
        }   


    }
}
