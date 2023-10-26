using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_38
{
    class Customer
    {
        public int ID { get; set; }

        private string _firstName;
        public string FirstName 
        { 
            get { return "Mrs." + _firstName; } 
            set { _firstName = value; } 
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
