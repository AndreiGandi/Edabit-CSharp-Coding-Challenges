using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_the_13th
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasFriday13th(3, 2020)); // true
            Console.WriteLine(HasFriday13th(10, 2017)); // true
            Console.WriteLine(HasFriday13th(1, 1985)); // false

        }
        public static bool HasFriday13th(int month, int year)
        {
            DateTime date = new DateTime(year, month, 13);
            if (date.DayOfWeek == DayOfWeek.Friday)
                return true;
            return false;
        }
    }
}
