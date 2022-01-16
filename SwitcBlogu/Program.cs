using System;

namespace SwitcBlogu
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 101;


            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                default:
                    Console.WriteLine("number is not 10 or 20");
                    break;
            }




            string adi = "Ahmet";

            switch (adi)
            {
                case "Ahmet":
                    Console.WriteLine("İsim dogru");
                    break;
                default:
                    Console.WriteLine("İsim yalnis");
                    break;
            }
        }
    }
}
