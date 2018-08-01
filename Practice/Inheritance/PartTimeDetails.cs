using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Inheritance {
  class PartTimeDetails {
    public void getPartTimeEmployeeDetails() {
      PartTimeEmployee PTE = new PartTimeEmployee {
        Name = "Uppala",
        experience = 2,
        age = 25,
        pSalary = 25000
      };
      Console.WriteLine( "\n\n Name: {0}\n Age: {1}\n Experience: {2} yrs\n Salary: {3}", PTE.Name, PTE.age, PTE.experience, PTE.pSalary );
    }
  }
}
