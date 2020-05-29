using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_Number_is_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //isPrime(31) ➞ true
            int nr = 46;
            if (isPrime(nr)) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
        }
        public static bool isPrime(int x)
        {
            if (x == 1) return false;
            else if (x != 2 && x % 2 == 0) return false;
            else
            {
                for(int i = 2; i<=x/2; i++)
                {
                    if (x % i == 0) return false;
                }
            }
            return true;
        }
    }
}
