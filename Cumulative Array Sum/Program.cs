using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cumulative_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 2, 3 };
            double[] arr2 = CumulativeSum(arr);
            foreach(var i in arr2)
            {
                Console.Write($"{ i } ");
            }
        }
        //CumulativeSum([1, 2, 3]) ➞ [1, 3, 6]
        public static double[] CumulativeSum(double[] arr)
        {
            double[] newArr = new double[] { };
            if (arr.Length == 0)
            {
                return newArr;
            }
            else
            {
                newArr = new double[arr.Length];
                for (int i = 0; i < newArr.Length; i++)
                {
                    double Sum = 0;
                    for (int j = 0; j <= i; j++)
                    {
                        Sum += arr[j];
                    }
                    newArr[i] = Sum;
                }
                return newArr;
            }
        }

        public static double[] CumulativeSum_v2(double[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i] + arr[i - 1];
            }

            return arr;
        }
    }
}
