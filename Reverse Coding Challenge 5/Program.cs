using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Coding_Challenge_5
{
    class Program
    {
        //832 ➞ 594
        //51 ➞ 36
        //7977 ➞ 198
        //1 ➞ 0
        //665 ➞ 99
        //149 ➞ 0
        static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc(149));
        }
        public static int MysteryFunc(int num)
        {
            char[] digits = num.ToString().ToCharArray();
            Array.Sort(digits);
            Array.Reverse(digits);
            int formattedNr = 0;
            for (int i = 0, j = 1; i < digits.Length; i++, j *= 10)
            {
                formattedNr += Convert.ToInt32(digits[i].ToString()) * j;
            }
            return num - formattedNr;
        }

        //a better implementation
        //public static int MysteryFunc(int num)
        //{
        //    char[] ca = num.ToString().ToCharArray();
        //    Array.Sort(ca);
        //    return num - Int32.Parse(new string(ca));
        //}
    }
}
