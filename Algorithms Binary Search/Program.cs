using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Binary_Search
{
    //Create a function that finds a target number in a list of prime numbers.Implement a binary search algorithm in your function.
    //The target number will be from 2 through 97.
    //If the target is prime then return "yes" else return "no".

    //int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }
    //    IsPrime(primes, 3) ➞ "yes"
    //    IsPrime(primes, 4) ➞ "no"
    //    IsPrime(primes, 67) ➞ "yes"
    //    IsPrime(primes, 36) ➞ "no"


    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            Console.WriteLine(IsPrime(primes, 4));
        }
        public static string IsPrime(int[] primes, int num)
        {
            int leftIdx = 0;
            int rightIdx = primes.Length - 1; ;
            int middleidx = 0;
            while(leftIdx <= rightIdx)
            {
                middleidx = (leftIdx + rightIdx) / 2;
                if (num < primes[middleidx])
                {
                    rightIdx = middleidx - 1;
                }
                else if (num > primes[middleidx])
                {
                    leftIdx = middleidx + 1;
                }
                else return "yes";
            }
            return "no";
        }
    }
}
