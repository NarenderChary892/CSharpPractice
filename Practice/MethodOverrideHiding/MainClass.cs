using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MethodOverrideHiding
{
    class MainClass
    {
        public void GetMethods()
        {
            // This is overriding the Base Class 
            BaseClass overrideMethod = new OverrideClass();
            overrideMethod.Print();

            // This is hiding the Base Class
            BaseClass hideMethod = new HidingClass();
            hideMethod.Print();

            // This is directly print the child class i.e., Hiding class method.
            HidingClass hiding = new HidingClass();
            hiding.Print();
            
        }
    }
}
