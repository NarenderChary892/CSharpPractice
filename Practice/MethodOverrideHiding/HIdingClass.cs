using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MethodOverrideHiding
{
    class HidingClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("This is directly calling Derived class using Derived class instance/object");
        }
    }
}
