using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_the_Century
{
    class Program
    {

        //        Century(1756) ➞ "18th century"
        //Century(1555) ➞ "16th century"
        //Century(1000) ➞ "10th century"
        //Century(1001) ➞ "11th century"
        //Century(2005) ➞ "21st century"

        //    All years will be between 1000 and 2010
        //    The 11th century is between 1001 and 1100
        //    The 18th century is between 1701-1800
        static void Main(string[] args)
        {
            Console.WriteLine(Century(2005));
        }
        public static string Century(int year)
        {
            string century = "";
            if (year == 1000) century = "10th century";
            if (year >= 1001 && year <= 1100) century = "11th century";
            if (year >= 1101 && year <= 1200) century = "12th century";
            if (year >= 1201 && year <= 1300) century = "13th century";
            if (year >= 1301 && year <= 1400) century = "14th century";
            if (year >= 1401 && year <= 1500) century = "15th century";
            if (year >= 1501 && year <= 1600) century = "16th century";
            if (year >= 1601 && year <= 1700) century = "17th century";
            if (year >= 1701 && year <= 1800) century = "18th century";
            if (year >= 1801 && year <= 1900) century = "19th century";
            if (year >= 1901 && year <= 2000) century = "20th century";
            if (year >= 2001 && year <= 2100) century = "21st century";
            return century;
        }
    }
}
