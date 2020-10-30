using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_to_Repeat_a_String_n_Number_of_Times
{
    class Program
    {
        //Create a recursive function that takes two parameters and repeats the string n number of times.
        //The first parameter txt is the string to be repeated and the second parameter is the number of times the string is to be repeated.

        static void Main(string[] args)
        {
            Console.WriteLine(Repetition("kiwi", 3));
            //Repetition("ab", 3) ➞ "ababab"
            //Repetition("kiwi", 1) ➞ "kiwi"
            //Repetition("cherry", 2) ➞ "cherrycherry"
        }
        public static string Repetition(string txt, int n)
        {
            if (n == 0) return "";
            else return txt + Repetition(txt, --n);
        }
    }
}
