using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcharoo
{

    //Create a function that takes a string and returns a new string with its first and last characters swapped, except under three conditions:

    //If the length of the string is less than two, return "Incompatible.".
    //If the argument is not a string, return "Incompatible.".
    //If the first and last characters are the same, return "Two's a pair.".


    //FlipEndChars("Cat, dog, and mouse.") ➞ ".at, dog, and mouseC"
    //FlipEndChars("ada") ➞ "Two's a pair."
    //FlipEndChars("Ada") ➞ "adA"
    //FlipEndChars("z") ➞ "Incompatible."
    //FlipEndChars([1, 2, 3]) ➞ "Incompatible."
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FlipEndChars("Ada"));
        }
        public static string FlipEndChars(object str)
        {
            string result = "";
            if (str.GetType().FullName != "System.String") result =  "Incompatible.";
            else if (str.ToString().Length < 2) result = "Incompatible.";
            else
            {
                string sString = str.ToString();
                if (sString[0] == sString[sString.Length - 1]) result = "Two's a pair.";
                else
                {
                    var first = sString[0]; var last = sString[sString.Length - 1];
                    StringBuilder sb = new StringBuilder(sString);
                    sb.Remove(0,1);
                    sb.Remove(sb.Length - 1, 1);
                    result = last + sb.ToString() + first;
                }
            }


            return result;
        }



    }
}
