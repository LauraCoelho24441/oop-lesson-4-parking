using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson4_parking.modules
{
    public class CarPark
    {
        private List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the CarPark()");
        }

        public override string ToString()
        {
            return "I am the CarPark()";
        }

        public void AddCustomer(Customer newCustomer)
        {
            listOfCustomers.Add(newCustomer);
        }

        public void CalculateCharges()
        {
            foreach(Customer customer in listOfCustomers)
            {
                int calculatedCharge = carParkCharge.CalculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer: cost is {calculatedCharge} euro for registration {customer.Registration} ");
            }
        }
    }
}
