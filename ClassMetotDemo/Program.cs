using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = "1111111";
            customer1.Ad = "Ethem";
            customer1.Soyad = "ANIL";

            Customer customer2 = new Customer();
            customer2.Id = "2222222";
            customer2.Ad = "Pogi";
            customer2.Soyad = "ANIL";

            Customer customer3 = new Customer();
            customer3.Id = "3333333";
            customer3.Ad = "Garip";
            customer3.Soyad = "ANIL";

            Customer[] customerAdd = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();
            foreach (var customer in customerAdd)
            {
                customerManager.Add(customer);
            }
            Console.WriteLine("Customer Added.");

            Customer[] customerList = new Customer[] { customer1, customer2, customer3 };
            foreach (var customer in customerAdd)
            {
                customerManager.List(customer);
            }
            Console.WriteLine("Customer Listed.");

            Customer[] customerDelete = new Customer[] { customer1, customer2, customer3 };
            foreach (var customer in customerAdd)
            {
                customerManager.Delete(customer);
            }
            Console.WriteLine("Customer Deleted.");
        }
    }
}
