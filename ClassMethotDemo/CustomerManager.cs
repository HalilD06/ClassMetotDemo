using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added : \n" + customer.Id + "\t" + customer.Name + " " + customer.Surname + "  " + customer.Age);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("\nCustomer Deleted : \n" + customer.Id + "\t" + customer.Name + " " + customer.Surname);
        }
    }
}
