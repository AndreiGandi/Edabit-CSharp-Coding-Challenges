using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMinValue
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 34, 15, 88, 2 };
            Console.WriteLine(FindSmallestNum(arr));
        }
        public static double FindSmallestNum(double[] arr)
        {
            double min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            return min;
        }
    }
}
