using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson4_parking.modules
{
    public class Customer
    {
        public int hoursParked { get; set; }

        public string Registration { get; set; }
        public Customer(string registration,int _hoursParked)
        {
            Console.WriteLine("I am the Customer()");
            Registration = registration;
            hoursParked = _hoursParked;
        }

        public override string ToString()
        {
            return "I am the Customer()";
        }
    }
}
