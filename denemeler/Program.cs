using System;

namespace denemeler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool medeniHal = true;

            string mesaj = medeniHal == true ? "evlilere kampanya" : "bekarlara kampanya";
            Console.WriteLine(mesaj);





            Console.Write("[1-10] arasında sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = "";
            cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
            Console.WriteLine(cevap);


        }
    }
}
