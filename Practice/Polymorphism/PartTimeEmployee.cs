﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Polymorphism
{
    class PartTimeEmployee : Employee
    {
        public override void GetFistLastNames()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Part Time");
        }
    }
}
