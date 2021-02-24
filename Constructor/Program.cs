using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Ethem", LastName = "Anil", City = "Ankara" };

            Customer customer2 = new Customer ( 2, "Anil", "Sandalci", "Ankara" );
            Console.WriteLine(customer2.FirstName);

            Customer customer3 = new Customer();
            customer3.Id = 3;

        }
        
    }

    class Customer
    {
        public Customer(int id, string firstname, string lastname, string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }
        
        //Default constructor (Parametresi olmayan Constructor'a denir.)
        
        public Customer()
        {
            
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
