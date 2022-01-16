using System;

namespace CokluSartlarlaCalısmak
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1011;

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greather than 200");
            }


            Console.WriteLine(" ");


            //iç içe if kullanımı 

            if (number > 100)
            {
                if (number < 150)
                {
                    Console.WriteLine("101-149 arasında");
                }
                if (number >= 150 && number < 250)
                {
                    if (number >= 150 && number < 200)
                    {
                        Console.WriteLine("150-199 arasında");
                    }
                    if (number >= 200 && number < 250)
                    {
                        Console.WriteLine("200-249 arasında");
                    }
                }
            }
        }
    }
}
