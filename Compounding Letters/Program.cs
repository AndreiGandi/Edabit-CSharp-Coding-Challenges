using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compounding_Letters
{
    class Program
    {
        //Accum("abcd") ➞ "A-Bb-Ccc-Dddd"
        //Accum("RqaEzty") ➞ "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
        //Accum("cwAt") ➞ "C-Ww-Aaa-Tttt"
        static void Main(string[] args)
        {
            Console.WriteLine(Accum("RqaEzty"));
        }
        public static string Accum(string str)
        {
            string result = "";
            for(int i=0; i<str.Length; i++)
            {
                for(int j=0; j<i+1; j++)
                {
                    if (i + j == i)
                        result += str[i].ToString().ToUpper();
                    else result += str[i].ToString().ToLower();
                }
                result += "-";
            }
            return result.Remove(result.Length-1);
        }
    }
}
