using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Index__Part_2_
{
    class Program
    {
        // Create a function that searches for the index of a given item in an array using recursion. 
        // If the item is present, it should return the index, otherwise, it should return -1.
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(Search(arr, 3)); // 2

        }
        public static int Search(int[] arr, int item)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == item) return i;
            return -1;
        }
    }
}
