using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MethodOverrideHiding
{
    class BaseClass
    {
        // This is Base class method.
        public virtual void Print()
        {
            Console.WriteLine("This is Hiding (Hiding the Base Class Method)");
        }
    }
}
