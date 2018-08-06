using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.List.NewEx
{
    class NewCustomerInfo
    {
        public void GetCustomerInfo()
        {
            NewCustomer customer1 = new NewCustomer()
            {
                Id = 101,
                Name = "Narender",
                Salary = 25000,
                Type = "Retail"
            };
            NewCustomer customer2 = new NewCustomer()
            {
                Id = 102,
                Name = "Chary",
                Salary = 50000,
                Type = "Retail"
            };
            NewCustomer customer3 = new NewCustomer()
            {
                Id = 103,
                Name = "Uppala",
                Salary = 30000,
                Type = "Retail"
            };
            NewCustomer customer4 = new NewCustomer()
            {
                Id = 103,
                Name = "Naren",
                Salary = 10000,
                Type = "Corporate"
            };
            NewCustomer customer5 = new NewCustomer()
            {
                Id = 103,
                Name = "Alice",
                Salary = 20000,
                Type = "Corporate"
            };

            List<NewCustomer> retailCustomers = new List<NewCustomer>();
            retailCustomers.Add(customer1);
            retailCustomers.Add(customer2);
            retailCustomers.Add(customer3);

            List<NewCustomer> corporateCustomers = new List<NewCustomer>();
            corporateCustomers.Add(customer4);
            corporateCustomers.Add(customer5);


            // AddRange Method
            retailCustomers.AddRange(corporateCustomers);
            retailCustomers.Sort();
            foreach(NewCustomer cust in retailCustomers)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}, Type: {3}", cust.Id, cust.Name, cust.Salary, cust.Type);
            }

            // SortByName 

            SortByName sortByName = new SortByName();
            retailCustomers.Sort(sortByName);
            Console.WriteLine("After Sorting By Name:");
            foreach (NewCustomer cust in retailCustomers)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}, Type: {3}", cust.Id, cust.Name, cust.Salary, cust.Type);
            }

        }
    }
}
