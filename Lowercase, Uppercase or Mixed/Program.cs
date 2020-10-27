using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowercase__Uppercase_or_Mixed
{
    class Program
    {
        //Create a function which returns "upper" if all the letters in a word are uppercase, "lower" if lowercase and "mixed" for any mix of the two.
        static void Main(string[] args)
        {
            Console.WriteLine(GetCase("Indoor Voice")); // "lower"
        }
        public static string GetCase(string str)
        {
            var countUpper = 0;
            var countLower = 0;
            foreach(var item in str)
            {
                if (char.IsPunctuation(item) || char.IsWhiteSpace(item))
                    continue;
                else if (char.IsLetter(item) && char.IsUpper(item))
                    countUpper++;
                else countLower++;
            }
            if (countUpper != 0 && countLower == 0)
                return "upper";
            else if (countUpper == 0 && countLower != 0)
                return "lower";
            else return "mixed";
        }

        //public static string GetCase(string str)
        //{
        //    if (str == str.ToUpper())
        //        return "upper";
        //    else if (str == str.ToLower())
        //        return "lower";
        //    else
        //        return "mixed";
        //}
    }
}
