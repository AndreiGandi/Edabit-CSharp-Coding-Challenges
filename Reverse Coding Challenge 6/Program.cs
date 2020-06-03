using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Coding_Challenge_6
{
    class Program
    {
        //MysteryFunc(152) ➞ 10
        //MysteryFunc(832) ➞ 48
        //MysteryFunc(19) ➞ 9
        //MysteryFunc(133) ➞ 9
        static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc(0));
        }
        public static int MysteryFunc(int num)
        {
            if (num == 0) return 0;
            int prod = 1;
            while(num != 0)
            {
                prod *= num % 10;
                num /= 10;
            }
            return prod;
        }
    }
}
