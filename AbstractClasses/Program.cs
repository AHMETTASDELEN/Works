using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Kaydet();
            aMevzuat.Degerlendir();
        }
    }

 
    abstract class MevzuatBase
    {
        public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi");
        }
    }


    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatına göre değerlendirildi");
        }
    }


    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatına göre değerlendirildi");
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added");
        }
        public void Delete()
        {
            Console.WriteLine("Customer deleted");
        }


    class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
