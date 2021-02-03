using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.TcNo = "12345678910";
            

            //Kodlama.io

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID(Yazılım geliştirme prensipleri) --> 'L'

            //Base class,base classtan inherit alan diğer classların referanslarını da tutabilir.
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
