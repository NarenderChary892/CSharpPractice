using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ToStringEqualMethods
{
    /// <summary>
    /// Convert ToString() Method Example
    /// </summary>
    class GetStudent
    {
        public void StudentDetails()
        {
            Student stu = new Student();
            stu.FirstName = "Narender";
            stu.LastName = "Chary";

            Console.WriteLine(stu.ToString());
        }
    }
}
