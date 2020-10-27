using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = Reverse(arr);
        }
        public static int[] Reverse(int[] arr)
        {
            int[] newArr =new int[arr.Length];
            for(int i = arr.Length-1, j = 0; i>=0; i--, j++)
            {
                newArr[j] = arr[i];
            }
            return newArr;
        }

        //public static int[] Reverse(int[] arr)
        //{
        //    return Array.Reverse(arr).;
        //}
    }
}
