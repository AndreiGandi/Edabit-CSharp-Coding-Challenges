using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifying_the_Last_Character
{


        //Create a function which makes the last character of a string repeat n number of times.

        //ModifyLast("Hello", 3) ➞ "Hellooo"
        //ModifyLast("hey", 6) ➞ "heyyyyyy"
        //ModifyLast("excuse me what?", 5) ➞ "excuse me what?????"

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ModifyLast("Hello", 3));
        }

        public static string ModifyLast(string str, int n)
        {
            char lastChar = str[str.Length - 1];
            StringBuilder sb = new StringBuilder(str.Substring(0, str.Length-1));
            for(int i=0; i<n; i++)
            {
                sb.Append(lastChar);
            }

            return sb.ToString();

    }
    }
}
