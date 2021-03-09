using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Product_Problem_Part_2
{
    class Program
    {
        //Create a function that takes an array arr and a number n and returns an array of two integers whose product is that of the number n.
        //TwoProduct(new int[] { 1, 2, 3, 4, 13, 5 }, 39) ➞  { 3, 13 }
        //TwoProduct(new int[] { 11, 2, 7, 3, 5, 0 }, 55) ➞ { 5, 11 }
        //TwoProduct(new int[] { 100, 12, 4, 1, 2 } 15) ➞ { }

                    //No duplicates.
                    //Sort the result.
                    //Try doing this with O(n) time complexity.
                    //The array can have multiple solutions, so return the first match you find.
                    //If there is no solution return an empty array (3rd example).
        static void Main(string[] args)
        {
            int[] test = TwoProduct(new int[] { 1, 2, -1, 4, 5 }, 20);
            Console.WriteLine();
        }
        public static int[] TwoProduct(int[] arr, int n)
        {
            List<int> pair = new List<int>();
            Array.Sort(arr);
            Array.Reverse(arr);
            for(int i = 0; i<arr.Length; i++)
            {
                if(n%arr[i] == 0 && arr[i] != 0 && arr[i] >1)
                {
                    n = n / arr[i];
                    pair.Add(arr[i]);
                }
                if (n == 1) break;
            }
            if (pair.Count != 0)
                pair.Sort();
            return pair.ToArray();
        }
    }
}
