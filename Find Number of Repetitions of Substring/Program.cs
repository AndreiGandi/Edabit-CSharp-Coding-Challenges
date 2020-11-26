using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Find_Number_of_Repetitions_of_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfRepeats("abcabcabcabc")); //  4

            //Console.WriteLine(NumberOfRepeats("bcbcbc")); // 3

            //Console.WriteLine(NumberOfRepeats("llbllbllbllbllbllb"));  // 6

            //Console.WriteLine(NumberOfRepeats("kc"));  // 1
        }
        public static int NumberOfRepeats(string str)
        {
            int counter = 0;
            string subString = "";
            for(int i = 0; i<str.Length; i++)
            {
                if(!subString.Contains(str[i]))
                {
                    subString += str[i];
                }
                else
                {
                    break;
                }
            }
            counter = Regex.Matches(str, subString).Count;

            return counter;
        }
    }
}
