using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Letters_and_Digits
{
    class Program
    {
        //Write a function that takes a string and calculates the number of letters and digits within it.Return the result as anonymous type in string format.

        //    count_all("Hello World") ➞ " { LETTERS =  10,  DIGITS =  0 }"
        //    count_all("H3ll0 Wor1d") ➞ " { LETTERS =  7,  DIGITS =  3 }"
        //    count_all("149990") ➞  "{ LETTERS =  0, DIGITS = 6 }"

        //    Notes
        //        Tests contain only alphanumeric characters.
        //        Spaces are not letters.
        //        All tests contain valid strings.
        //        Return the result as anonymous type.



        static void Main(string[] args)
        {
            Console.WriteLine(count_all("Hello World"));
        }

        public static string count_all(string txt)
        {
            string text = txt.Replace(" ", "");
            int digits = 0;
            int letters = 0;
            foreach(var c in text)
            {
                if (char.IsDigit(c))
                    digits++;
                else if (char.IsLetter(c))
                    letters++;
            }
            string result = string.Format(" LETTERS =  {0}, DIGITS = {1} ", letters, digits);
            return "{"+result+"}";
        }
    }
}
