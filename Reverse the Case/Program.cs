using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_the_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
            string str = "Happy Birthday";
            Console.WriteLine($"{ReverseCase(str)}");
        }
        public static string ReverseCase(string str)
        {
            string newStr = "";
            for(int i = 0; i<str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    newStr += Char.ToLower(str[i]);
                else newStr += Char.ToUpper(str[i]);
            }
            return newStr;
        }

    }
}
