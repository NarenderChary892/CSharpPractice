using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Dictionaries
{
    class CustomerInfo
    {
        public void GetCustomerInfo()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Narender",
                Salary = 25000
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Chary",
                Salary = 50000
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Uppala",
                Salary = 30000
            };

            Dictionary<int, Customer> customerDict = new Dictionary<int, Customer>();
            customerDict.Add(customer1.Id, customer1);
            customerDict.Add(customer2.Id, customer2);
            customerDict.Add(customer3.Id, customer3);

            //Getting Particular Customer Info
            Customer customer103 = customerDict[103];

            Console.WriteLine("\n\n");
            Console.WriteLine("Dictionaries");
            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", customer103.Id,customer103.Name,customer103.Salary);

            // Getting all the Customer details using foreach loop
               // foreach (var customerKeyValuePair in customerDict)
            foreach (KeyValuePair<int, Customer>  customerKeyValuePair in customerDict)
            {
               // Console.WriteLine("key: {0}", customerKeyValuePair.Key);
                Customer customerGet = customerKeyValuePair.Value;
                Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}", customerGet.Id, customerGet.Name, customerGet.Salary);
                Console.WriteLine("---------------------------------------");
            }



            // Only getting the keys
            Console.WriteLine("Only Keys:");
            foreach (int key in customerDict.Keys)
            {
                Console.WriteLine(key);
            }

            // Only getting the values
            Console.WriteLine("Only Values:");
            foreach (Customer cust in customerDict.Values)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}", cust.Id, cust.Name, cust.Salary);
            }

            // Checking Key Exist or not
            if (customerDict.ContainsKey(135))
            {
                Console.WriteLine("Key exist");
            }
            else
            {
                Console.WriteLine("Key Not Exist");
            }

            // Using TryGetValue 
            Customer cus;
            if(customerDict.TryGetValue(101,out cus))
            {
                Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}", cus.Id, cus.Name, cus.Salary);
            }
            else
            {
                Console.WriteLine("Key Not Exist");
            }

            // Count the number of items 
            Console.WriteLine("No.of items: {0}",customerDict.Count());

            // Count the customer whose salary is greater than 25000
            Console.WriteLine("Salary > 25000 Customers: {0}", customerDict.Count(kvp => kvp.Value.Salary > 25000) );
        }
    }
}
