using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_the_Order_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Str Reverse: {Reverse("texting")}");
        }
        public static string Reverse(string str)
        {
            string reverseStr = "";
            for(int i = str.Length-1; i >= 0 ; i--)
            {
                reverseStr += str[i];
            }
            return reverseStr;
        }
    }
}
