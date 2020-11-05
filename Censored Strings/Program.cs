using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censored_Strings
{
    class Program
    {
        //Given a censored string and a string of the censored vowels, return the original uncensored string.
        //uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo") ➞ "Where did my vowels go?"
        //uncensor("abcd", "") ➞ "abcd"
        //uncensor("*PP*RC*S*", "UEAE") ➞ "UPPERCASE"

        //Notes
        //The vowels are given in the correct order.
        //The number of vowels will match the number of* characters in the censored string.


        static void Main(string[] args)
        {
            Console.WriteLine(Uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo"));
        }
        public static string Uncensor(string txt, string vowels)
        {
            int vowelsIndex = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var c in txt)
            {
                if (c == '*')
                {
                    sb.Append(vowels[vowelsIndex]);
                    vowelsIndex++;
                }
                else sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
