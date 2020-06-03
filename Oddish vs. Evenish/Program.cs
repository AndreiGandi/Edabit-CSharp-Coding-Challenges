using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oddish_vs.Evenish
{
    class Program
    {
        //Create a function that determines whether a number is Oddish or Evenish.
        //A number is Oddish if the sum of all of its digits is odd, and a number is Evenish if the sum of all of its digits is even.
        //If a number is Oddish, return "Oddish". Otherwise, return "Evenish".
        //OddishOrEvenish(43) ➞ "Oddish"
        //OddishOrEvenish(373) ➞ "Oddish"
        //OddishOrEvenish(4433) ➞ "Evenish"
        static void Main(string[] args)
        {
            Console.WriteLine(OddishOrEvenish(43));
        }
        public static string OddishOrEvenish(int num)
        {
            int Sum = 0;
            while (num != 0) {
                Sum += num % 10;
                num /= 10;
            }
            if (Sum % 2 == 0) return "Evenish";
            else return "Oddish";

        }
    }
}
