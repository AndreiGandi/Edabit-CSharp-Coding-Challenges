using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //gcd(32, 8) ➞ 8
            //gcd(8, 12) ➞ 4
            //gcd(17, 13) ➞ 1
            Console.WriteLine(gcd(8, 4));
        }
        //Euclide algorithm
        //public static int gcd(int a, int b)
        //{
        //    while (a != b)
        //    {
        //        if (a > b) a -= b;
        //        else b -= a;
        //    }
        //    return a;
        //}
        //
        public static int gcd(int a, int b)
        {

            while (b != 0) { int rest = a % b; a = b; b = rest; }


            return a;
        }
    }
}
