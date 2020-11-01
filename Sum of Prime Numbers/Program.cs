using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Prime_Numbers
{
    class Program
    {
        //Create a function that takes a list of numbers and returns the sum of all prime numbers in the list.

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(SumPrimes(arr));
            //SumPrimes(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }) ➞ 17
            //SumPrimes(new int[] { 2, 3, 4, 11, 20, 50, 71 }) ➞ 87
            //SumPrimes(new int[] { }) ➞ 0
            //Console.WriteLine(isPrime(17));

        }
        public static int SumPrimes(int[] arr)
        {
            int Sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (isPrime(arr[i])) Sum += arr[i];
            }
            return Sum;
        }
        static bool isPrime(int nr)
        {
            if (nr == 1) return false;
            else if (nr % 2 == 0 && nr != 2) return false;
            else
            {
                for(int i=2; i<=nr/2; i++)
                {
                    if (nr % i == 0) return false;
                }
            }
            return true;
        }
    }
}
