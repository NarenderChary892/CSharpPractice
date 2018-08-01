using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MethodOverrideHiding
{
    class OverrideClass : BaseClass
    {
        // This is overriding the base class
        public override void Print()
        {
            Console.WriteLine("This is Override Method(Printing the Children class/ Derivied class)");
        }
    }
}
