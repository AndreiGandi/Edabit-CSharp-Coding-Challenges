using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_the_Average_of_All_Elements_a_Whole_Number
{
    class Program
    {

        //Create a function that takes an array as an argument and returns true or false depending on whether the average of all elements in the array is a whole number or not.
        //    IsAvgWhole([1, 3]) ➞ true
        //    IsAvgWhole([1, 2, 3, 4]) ➞ false
        //    IsAvgWhole([1, 5, 6]) ➞ true
        //    IsAvgWhole([1, 1, 1]) ➞ true
        //    IsAvgWhole([9, 2, 2, 5]) ➞ false


        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(IsAvgWhole(arr));
        }


        public static bool IsAvgWhole(int[] arr)
        {
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            avg /= arr.Length;

            if (avg - (int)avg == 0)
                return true;
            else return false;
        }
    }
}

