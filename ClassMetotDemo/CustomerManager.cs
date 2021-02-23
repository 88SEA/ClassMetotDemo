using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added :"+customer.Id+" - "+customer.Ad+" "+customer.Soyad);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Customer Listed :" + customer.Id + " - " + customer.Ad + " " + customer.Soyad);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Delete :" + customer.Id + " - " + customer.Ad + " " + customer.Soyad);
        }
    }
}
