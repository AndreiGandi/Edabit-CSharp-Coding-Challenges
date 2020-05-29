using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_the_Number_a_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //IsPrime(5) ➞ true
            //IsPrime(1) ➞ false
            //IsPrime(23) ➞ true
            //IsPrime(24) ➞ false
            Console.WriteLine(IsPrime(-5));
        }
        public static bool IsPrime(int value)
        {

            if (value <= 1) return false;
            else if (value != 2 && value % 2 == 0) return false;
            else
            {
                for (int i = 2; i <= value / 2; i++)
                {
                    if (value % i == 0) return false;
                }
            }
            return true;
        }
    }
}
