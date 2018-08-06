using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.List.Sorting
{
    class Numbers
    {
        public void GetNumbersSorting()
        {
            string str = string.Empty;
            List<int> numbers = new List<int> { 3, 2, 5, 6, 1, 7, 0, 4, 9, 8 };
            
            foreach (var item in numbers)
                str = str + item + ",";

            str = str.Remove(str.Length - 1);
            Console.WriteLine(str);

           
            numbers.Sort();
            string newStr = string.Empty;
            foreach (var item in numbers)
                newStr = newStr + item + ",";

            newStr = newStr.Remove(newStr.Length - 1);
            Console.WriteLine(newStr);

            numbers.Reverse();
            string revStr = string.Empty;
            foreach (var item in numbers)
                revStr = revStr + item + ",";

            revStr = revStr.Remove(revStr.Length - 1);
            Console.WriteLine(revStr);


        }
    }
}
