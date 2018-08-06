using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.List.NewEx
{
   public class NewCustomer : IComparable<NewCustomer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

        // Based on the Salary it is sorting.
        public int CompareTo(NewCustomer other)
        {
            return this.Salary.CompareTo(other.Salary);
            //return this.Name.CompareTo(other.Name);
        }
    }
        // Sorting by Name using IComparer method.
        public class SortByName : IComparer<NewCustomer>
        {
            public int Compare(NewCustomer x, NewCustomer y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
}
