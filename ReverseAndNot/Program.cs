using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndNot
{
    class Program
    {
        //ReverseAndNot(123) ➞ "321123"
        //ReverseAndNot(152) ➞ "251152"
        //ReverseAndNot(123456789) ➞ "987654321123456789"
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseAndNot(123));
        }
        public static string ReverseAndNot(int i)
        {
            string number = "";
            int reversedNr = 0;
            int temp = i;
            while(temp != 0)
            {
                reversedNr = reversedNr * 10 + temp % 10;
                temp /= 10;
            }
            number = reversedNr.ToString() + i.ToString();
            return number;
        }
    }
}
