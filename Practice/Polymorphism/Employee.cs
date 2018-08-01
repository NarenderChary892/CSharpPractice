using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Polymorphism
{
    public class Employee
    {
        public  string FirstName = "FN";
        public  string LastName = "LN";
        
        public virtual void GetFistLastNames()
        {
           
            Console.WriteLine(FirstName+ " " +LastName);    
        }
       
        
    }
}
