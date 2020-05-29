using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_the_Middle_Character_s__of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetMiddle("test") ➞ "es"
            //GetMiddle("testing") ➞ "t"
            //GetMiddle("middle") ➞ "dd"
            //GetMiddle("A") ➞ "A"
            Console.WriteLine(GetMiddle("testing"));
        }
        public static string GetMiddle(string str)
        {
            string result = "";
            if(str.Length % 2 == 0)
            {
                result += $"{str[str.Length/2 -1]}{str[str.Length / 2]}";
            }
            else
            {
                result += $"{str[str.Length / 2]}";
            }
            return result;
        }
    }
}
