using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture
{
    class Program
    {
        //Create a function that, when given two positive integers a b, returns the string "a" 
        //if integer a took fewer steps to reach 1 than b when passed through the Collatz sequence, or "b" if integer b took fewer steps to reach 1 than a.

        //Collatz(10, 15) ➞ "a"
        //// Because 10.0 - 5.0 - 16.0 - 8.0 - 4.0 - 2.0 - 1.0: 6 steps
        //// 15.0 - 46.0 - 23.0 - 70.0 - 35.0 - 106.0 - 53.0 - 160.0 - 80.0 - 40.0 - 20.0 - 10.0 - 5.0 - 16.0 - 8.0 - 4.0 - 2.0 - 1.0: 17 steps
        //Collatz(13, 16) ➞ "b"
        //Collatz(53782, 72534) ➞ "b"

        static void Main(string[] args)
        {
            Console.WriteLine(Collatz(13, 16));
        }
        public static string Collatz(Int64 a, Int64 b)
        {
            if (CountStepsCollatz(a) > CountStepsCollatz(b)) return "b";
            else return "a";
        }
        static int CountStepsCollatz(long nr)
        {
            int count = 0;
            while(nr != 1)
            {
                if (nr % 2 == 0)  nr /= 2;
                else nr = 3 * nr + 1;
                count++;
            }
            return count;
        }
    }
}
