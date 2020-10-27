using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Collatz_Conjecture
{
    class Program
    {

        //Consider the following operation on an arbitrary positive integer:
        //If n is even -> n / 2
        //If n is odd -> n* 3 + 1

        //Create a function to repeatedly evaluate these operations, until reaching 1. Return the number of steps it took.

        //See the following example, using 10 as the input, with 6 steps:
        //10 is even - 10 / 2 = 5
        //5 is odd - 5 * 3 + 1 = 16
        //16 is even - 16 / 2 = 8
        //8 is even - 8 / 2 = 4
        //4 is even - 4 / 2 = 2
        //2 is even - 2 / 2 = 1 -> Reached 1, so return 6


        static void Main(string[] args)
        {
            Console.WriteLine(collatz(10));
        }

        public static int collatz(int num)
        {
            int steps = 0;
            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2; steps++;
                }
                else
                {
                    num = num * 3 + 1; steps++;
                }
            }
            return steps;
        }
    }
}
