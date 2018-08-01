using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Polymorphism
{
    class EmployeeDetails
    {
        public void GetEmployeeDetails()
        {
            Employee[] emp = new Employee[4];
            emp[0] = new Employee();
            emp[1] = new FullTimeEmployee();
            emp[2] = new PartTimeEmployee();
            emp[3] = new TemparoryEmployee();

            Console.WriteLine('\n');
            foreach (Employee e in emp)
            {
                e.GetFistLastNames();
                
            }



        }
    }
}
