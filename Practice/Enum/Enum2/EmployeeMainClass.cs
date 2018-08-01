using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Enum.Enum2
{
     public class EmployeeMainClass
    {

        public void GetEmployee()
        {
            Employee[] emp = new Employee[3];

            emp[0] = new Employee
            {
                Name = "Narender",
                Gender = Gender.Male
            };

            emp[1] = new Employee
            {
                Name = "Bhagya",
                Gender = Gender.Female
            };
            emp[2] = new Employee
            {
                Name = "Chary",
                Gender = Gender.Male
            };

            foreach (Employee e in emp)
            {
                Console.WriteLine("Name: {0}  Gender: {1}", e.Name, e.Gender);
            }
        }

    }
    
}
