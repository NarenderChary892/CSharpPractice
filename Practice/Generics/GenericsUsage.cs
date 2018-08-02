using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Generics
{
    class GenericsUsage
    {
        public static void GetGenerics()
        {
            bool stringEqual = Calculator<string>.AreEqual("A", "A");
            if (stringEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


            bool IntEqual = Calculator2<int>.EqualOrNot(1, 1);
            if (IntEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
