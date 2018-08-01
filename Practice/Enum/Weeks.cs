using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Enum
{
    public class Weeks
    {
        public void GetEnums()
        {
            Console.WriteLine('\n');
            Console.WriteLine(Weeks.WeekDays.Friday);
            Console.WriteLine((int)Weeks.WeekDays.Friday);
            Console.WriteLine(Weeks.Weekdays.Friday);
            Console.WriteLine(Weeks.weekdays.Monday);
            Console.WriteLine((int)Weeks.weekdays.Friday);
        }
        public enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }

        public enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public enum weekdays
        {
            Monday = 10,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

    }


}




