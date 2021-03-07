using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Week_Later
{
    class Program
    {
        //Create a function which takes in a date as a string, and returns the date a week after.
            //WeekAfter("12/03/2020") ➞ "19/03/2020"
            //WeekAfter("21/12/1989") ➞ "28/12/1989"
            //WeekAfter("01/01/2000") ➞ "08/01/2000"
        static void Main(string[] args)
        {
            Console.WriteLine(WeekAfter("12/03/2020"));
        }
        public static string WeekAfter(string date)
        {
            DateTime d = new DateTime();
            d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            d = d.AddDays(7);

            return d.ToString("dd/MM/yyyy");
        }
    }
}
