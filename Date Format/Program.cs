using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Format
{
    //Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.
    class Program
    {
        static void Main(string[] args)
        {
            //FormatDate("11/12/2019") ➞ "20191211"
            //FormatDate("12/31/2019") ➞ "20193112"
            //FormatDate("01/15/2019") ➞ "20191501"
            Console.WriteLine(FormatDate("11/12/2019"));
        }
        public static string FormatDate(string date)
        {
            string[] elements = date.Split('/');
            return elements[2] + elements[1] + elements[0];
        }
    }
}
