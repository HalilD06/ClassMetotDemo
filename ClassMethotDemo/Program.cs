using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n\n");

            Customer customer1 = new Customer { Id = 213456, Name = "Akif", Surname = "Esad", Age = 30 };
            Customer customer2 = new Customer { Id = 45689, Name = "Emre", Surname = "Ucar", Age = 25 };
            Customer customer3 = new Customer { Id = 231456, Name = "Ali", Surname = "Kofte", Age = 45 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer3);


        }
    }
}
