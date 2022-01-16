using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3Tekrar
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
