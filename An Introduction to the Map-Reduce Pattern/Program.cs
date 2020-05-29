using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace An_Introduction_to_the_Map_Reduce_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 6, 1, 8 };
            Console.WriteLine(Magnitude(arr));
        }
        //Formula: https://mathinsight.org/definition/magnitude_vector
        //Magnitude([3, 4]) ➞ 5
        //Magnitude([0, 0, -10]) ➞ 10
        //Magnitude([]) ➞ 0
        //Magnitude([2, 3, 6, 1, 8] ) ➞ 10.677078252031311
        public static double Magnitude(int[] arr)
        {
            double magnitude = 0;
            if (arr.Length == 0) return magnitude;
            else
            {
                double Sum = 0;
                for(int i = 0; i<arr.Length; i++)
                {
                    Sum += arr[i] * arr[i];
                }
                return Math.Sqrt(Sum);
            }
        }
    }
}
