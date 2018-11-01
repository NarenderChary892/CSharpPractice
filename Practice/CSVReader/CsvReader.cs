using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSVReader
{
    class CsvReader
    {
        public void GetCSVDetails()
        {
            CsvValueProvider obj = new CsvValueProvider("data.csv");
            Console.WriteLine("CSV Reder");
            Console.WriteLine(obj.GetValueName(259, 3));
            Console.WriteLine(obj.GetValueName(156, 3));
            Console.WriteLine(obj.GetValueName(1, 7));
            Console.WriteLine(obj.GetValueName(156, 2));
        }
    }
}
