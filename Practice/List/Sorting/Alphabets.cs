using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.List.Sorting
{
    class Alphabets
    {
        public void GetAlphabetsSorting()
        {
            string str = string.Empty;
            List<string> alphabets = new List<string> { "C", "E", "A", "D", "B" };

            foreach(var letters in alphabets)
            
                str = str + letters + ",";

                str = str.Remove(str.Length - 1);
                Console.WriteLine(str);

            alphabets.Sort();

            string newStr = string.Empty;
            foreach (var item in alphabets)
                newStr = newStr + item + ",";

            newStr = newStr.Remove(newStr.Length - 1);
            Console.WriteLine(newStr);

            alphabets.Reverse();

            string revStr = string.Empty;
            foreach (var item in alphabets)
                revStr = revStr + item + ",";

            revStr = revStr.Remove(revStr.Length - 1);
            Console.WriteLine(revStr);
        }
    }
}
