using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_the_Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 };
            Console.WriteLine(Mean(arr));
        }
        //Mean([1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3]) ➞ 2.55
        public static double Mean(int[] arr)
        {
            double S = 0, avg = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                S += arr[i];
            }
            avg = System.Math.Round(S / arr.Length, 2);

            return avg;

        }
    }
}
