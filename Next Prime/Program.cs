using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_Prime
{
    class Program
    {
        //NextPrime(12) ➞ 13
        //NextPrime(24) ➞ 29
        //NextPrime(11) ➞ 11
        // 11 is a prime, so we return the number itself.
        static void Main(string[] args)
        {
            Console.WriteLine(NextPrime(12));
        }
        public static int NextPrime(int num)
        {
            int nr = 0;
            for(int i=num; ; i++)
            {
                if(isPrime(i))
                {
                    nr = i; break;
                }
            }
            return nr;
        }
        public static bool isPrime(int x)
        {
            if (x == 1) return false;
            else if (x != 2 && x % 2 == 0) return false;
            else
            {
                for (int i = 2; i <= x / 2; i++)
                {
                    if (x % i == 0) return false;
                }
            }
            return true;
        }
    }
}
