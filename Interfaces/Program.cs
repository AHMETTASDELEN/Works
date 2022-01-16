using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();


            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
                
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }







        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer();
            customer.ID = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";
            customer.Address = "Ankara";


            Student student = new Student();
            student.ID = 2;
            student.FirstName = "Derin";
            student.LastName = "Demiroğ";
            student.Department = "Computer Science";


            PersonManager manager = new PersonManager();
            manager.Add(customer);
            manager.Add(student);
        }
    }
}
