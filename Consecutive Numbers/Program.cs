using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecutive_Numbers
{
    class Program
    {
        //Create a function that determines whether elements in an array can be re-arranged to form a consecutive list of numbers where each number appears exactly once.
            //Cons([5, 1, 4, 3, 2]) ➞ true
            //// Can be re-arranged to form [1, 2, 3, 4, 5]
            //Cons([5, 1, 4, 3, 2, 8]) ➞ false
            //Cons([5, 6, 7, 8, 9, 9]) ➞ false
            // 9 appears twice
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 4, 3, 2 };
            Console.WriteLine(Cons(arr));
        }
        public static bool Cons(int[] arr)
        {
            Array.Sort(arr);
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i + 1] - arr[i] != 1)
                    return false;
            }
            return true;
        }
    }
}
