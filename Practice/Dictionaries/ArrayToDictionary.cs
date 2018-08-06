using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Dictionaries
{
    class ArrayToDictionary
    {
        public void ArrayToDict()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Aa",
                Salary = 25000
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Bb",
                Salary = 50000
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Cc",
                Salary = 30000
            };

            // Converting Array to Dictionaries
            // Array's doesn't grow automatically, but list's can grow  if you define Customer[2], then add more than 2 it will show error.
            Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;

            Dictionary<int, Customer> customerArrDict = customers.ToDictionary(cust => cust.Id, cust => cust);

            Console.WriteLine("\n");
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in customerArrDict)
            {
               
                Customer customerGet = customerKeyValuePair.Value;
                Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}", customerGet.Id, customerGet.Name, customerGet.Salary);
                Console.WriteLine("---------------------------------------");
            }


            // Converting List to Dictionaries
            // Array's doesn't grow automatically, but list's can grow
            List<Customer> customersList = new List<Customer>();
            customersList.Add(customer1);
            customersList.Add(customer2);
            customersList.Add(customer3);

            Dictionary<int, Customer> customerListDict = customersList.ToDictionary(cust => cust.Id, cust => cust);
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in customerListDict)
            {
                
                Customer customerGet = customerKeyValuePair.Value;
                Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}", customerGet.Id, customerGet.Name, customerGet.Salary);
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
