using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_and_Capitalize
{

    //Create a function that takes a string of lowercase characters and returns that string reversed and in upper case.
    class Program
    {

        static void Main(string[] args)
        {
            //ReverseCapitalize("abc") ➞ "CBA"
            //ReverseCapitalize("hellothere") ➞ "EREHTOLLEH"
            //ReverseCapitalize("input") ➞ "TUPNI"

            Console.WriteLine(ReverseCapitalize("abc"));

        }
        public static string ReverseCapitalize(string str)
        {
            char[] chArray = str.ToCharArray();
            Array.Reverse(chArray);
            string result = new string(chArray);
            return result.ToUpper();
        }
    }
}
