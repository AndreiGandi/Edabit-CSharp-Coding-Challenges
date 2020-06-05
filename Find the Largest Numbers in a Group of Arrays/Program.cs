using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Largest_Numbers_in_a_Group_of_Arrays
{
    class Program
    {
        //FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]) ➞ [7, 90, 2]
        //FindLargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]) ➞ [-34, -2, 7]
        //FindLargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]) ➞ [0.7634, 9.32, 9]
        static void Main(string[] args)
        {
            double[][] values = {
                new double[] { 4, 2, 7, 1},
                new double[] { 20, 70, 40, 90 },
                new double[] { 1, 2, 0 }
            };
            double[] MaxValues = FindLargest(values);
        }
        public static double[] FindLargest(double[][] values)
        {
            double[] maxArr = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                double max = values[i][0];
                for (int j = 0; j < values[i].Length; j++)
                {
                    if (values[i][j] > max) 
                        max = values[i][j];
                }
                maxArr[i] = max;
            }
            return maxArr;
        }
    }
}
