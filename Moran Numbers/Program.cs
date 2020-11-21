using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moran_Numbers
{
    //A Harshad number is a number which is divisible by the sum of its digits.For example, 132 is divisible by 6 (1+3+2).
    //A subset of the Harshad numbers are the Moran numbers.Moran numbers yield a prime when divided by the sum of their digits.
    //For example, 133 divided by 7 (1+3+3) yields 19, a prime.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Moran(134));

        }
        public static string Moran(int n)
        {
            if (n % digitsSum(n) == 0)
            {
                if (isPrime(n / digitsSum(n)))
                    return "M";
                else return "H";
            }
            else return "Neither";
        }
        public static bool isPrime(int nr)
        {
            if (nr == 1) return false;
            if (nr != 2 && nr % 2 == 0) return false;
            else
            {
                for (int i = 3; i <= nr / 2; i++)
                    if (nr % i == 0) return false;
            }
            return true;
        }
        public static int digitsSum(int nr)
        {
            int sum = 0;
            while(nr != 0)
            {
                sum += nr % 10;
                nr /= 10;
            }
            return sum;
        }
    }
}
