using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_the_Sum_of_the_Two_Smallest_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 9, 6, -1 };
            Console.WriteLine($"Sum: {SumSmallest(arr)}");
        }
        //Create a function that takes an array of numbers and returns the sum of the two lowest positive numbers.
        //SumSmallest([, 9, 6, -1]) ➞ 8
        public static int SumSmallest(int[] values)
        {
            int sum = 0;
            List<int> positiveNr = new List<int>();
            for(int i = 0; i<values.Length; i++)
            {
                if (values[i] > 0)
                    positiveNr.Add(values[i]);
            }
            positiveNr.Sort();
            sum = positiveNr[0] + positiveNr[1];




            return sum;
        }
    }
}
