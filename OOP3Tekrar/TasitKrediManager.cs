using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3Tekrar
{
    class TasitKrediManager : IKrediManager  //interface de bu olaya implementasyon denir
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
