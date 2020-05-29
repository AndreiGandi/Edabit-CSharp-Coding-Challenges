using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_Count_Negative_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] result = CountPosSumNeg(arr);
            Console.Write($"[{result[0]},{result[1]}]");
        }
        //CountPosSumNeg([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]) ➞ [10, -65]
        // There are a total of 10 positive numbers.
        // The sum of all negative numbers equals -65.

        public static int[] CountPosSumNeg(double[] arr)
        {
            int[] values = new int[] { };
            int count = 0, sum = 0;
            if (arr.Length == 0) return values;
            else
            {
                values = new int[2];
                for(int i = 0; i<arr.Length; i++)
                {
                    if (arr[i] > 0) count++;
                    else sum += Convert.ToInt32(arr[i]);
                }
                values[0] = count; values[1] = sum;
                return values;
            }
        }
    }
}
