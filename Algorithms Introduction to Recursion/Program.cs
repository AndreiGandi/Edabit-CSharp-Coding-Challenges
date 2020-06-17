using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Introduction_to_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
        }
        public static int factorial(int num)
        {
            if (num <= 1)
                return 1;
            else return num * factorial(num - 1);
        }
    }
}
