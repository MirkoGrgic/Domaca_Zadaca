using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ZadacaEDukos
{
    public abstract class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int OIB { get; }
        private decimal Balance { get; set; }

        public string Address { get; }
        public string City { get; }
        public string Region { get; }
        public string PostalCode { get; }
        public string Country { get; }

        protected Person(string firstName, string lastName, int oib, decimal balance, string address, string city, string region, string postalCode, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            OIB = oib;
            Balance = balance;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
        }


        public decimal GetBalance()
        {
            return Balance;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Region: {Region}");
            Console.WriteLine($"Postal Code: {PostalCode}");
            Console.WriteLine($"Country: {Country}");
        }

    }
}
