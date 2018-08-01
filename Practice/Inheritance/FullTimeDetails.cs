using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Inheritance {
  class FullTimeDetails {

    public void getFullTimeEmployeeDetails() {
      FullTimeEmployee FTE = new FullTimeEmployee {
        Name = "Narender Chary",
        experience = 1,
        age = 22,
        fSalary = 50000
      };
      Console.WriteLine( "\n\n Name: {0}\n Age: {1}\n Experience: {2} yrs\n Salary: {3}", FTE.Name, FTE.age, FTE.experience, FTE.fSalary );
    }
  }
}
