using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.ID = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                ID = 2,
                City = "İstanbul",
                FirstName = "Derin",
                LastName = "Demiroğ"
            };
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
}
