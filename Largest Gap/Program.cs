using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Gap
{
    class Program
    {
        //Given an array of integers, return the largest gap between elements of the sorted version of that array.
            //LargestGap(new int[] { 9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5 }) ➞ 11
            // After sorting get { 0, 0, 4, 5, 5, 6, 9, 20, 25, 26, 26 }
            // Largest gap of 11 between 9 and 20
        static void Main(string[] args)
        {
            Console.WriteLine(LargestGap(new int[] { 9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5 }));
        }
        public static int LargestGap(int[] arr)
        {
            Array.Sort(arr);
            int largestGap = 0;
            for(int i = 0; i<arr.Length-1; i++)
            {
                if ((arr[i + 1] - arr[i]) > largestGap)
                    largestGap = (arr[i + 1] - arr[i]);
            }
            return largestGap;
        }
    }
}
