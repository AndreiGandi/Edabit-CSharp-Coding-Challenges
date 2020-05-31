using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fact(1) ➞ 1
            //Fact(3) ➞ 6
            //Fact(6) ➞ 720
            Console.WriteLine(Fact(6));
        }
        public static long Fact(int n)
        {
            long fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            return fact;
        }
    }
}
