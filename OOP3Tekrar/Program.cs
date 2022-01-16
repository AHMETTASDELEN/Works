using System;
using System.Collections.Generic;

namespace OOP3Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager(); //bunlara new lemekdiyoruz veya
            IKrediManager tasitKrediManager = new TasitKrediManager();     //instıns oluştrumak
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();


            List<ILoggerService> loggerServices = new List<ILoggerService>()
            {
                dataBaseLoggerService, smsLoggerService
            };


            basvuruManager.BasvuruYap(esnafKrediManager,loggerServices);

            
            //ihtiyacKrediManager.Hesapla();



            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager,tasitKrediManager,konutKrediManager
            };


            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
