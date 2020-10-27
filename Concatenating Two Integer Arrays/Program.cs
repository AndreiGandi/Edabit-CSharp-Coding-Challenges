using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenating_Two_Integer_Arrays
{
    class Program
    {
        //Create a function to concatenate two integer arrays.
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6, 7, 8 };
            int[] result = ConcatArrays(arr1, arr2);
        }
        public static int[] ConcatArrays(int[] arr1, int[] arr2)
        {
            var newArr = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(newArr, 0);
            arr2.CopyTo(newArr, arr1.Length);
            return newArr;
        }
    }
}
