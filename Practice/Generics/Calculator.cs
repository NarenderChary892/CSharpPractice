using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Generics
{
    class Calculator<T>
    {
        public static bool AreEqual(T value1 , T value2)
        {
            return value1.Equals(value2);
        }
    }

    class Calculator2<T>
    {
        public static bool EqualOrNot(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
}
