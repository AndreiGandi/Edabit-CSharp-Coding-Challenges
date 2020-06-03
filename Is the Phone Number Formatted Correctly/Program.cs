using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Is_the_Phone_Number_Formatted_Correctly
{
    class Program
    {
        //IsValidPhoneNumber("(123) 456-7890") ➞ true
        //IsValidPhoneNumber("1111)555 2345") ➞ false
        //IsValidPhoneNumber("098) 123 4567") ➞ false
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidPhoneNumber("aaa(123) 456-7890"));
        }
        public static bool IsValidPhoneNumber(string str)
        {
            string format = @"^\(?\d{3}?\)\s\(?\d{3}?\)??-??\(?\d{4}?\)??-?$";
            Regex rgx = new Regex(format);
            if (rgx.IsMatch(str))
                return true;
            return false;

        }
    }
}
