using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_s_Addition
{
    class Program
    {
        //Create a function that adds all the numbers together from 1 to n or, if two numbers are given: n to m.The input can be in any order.
        static void Main(string[] args)
        { 
            Console.WriteLine(Gauss(new long[] { 1975, 165 }));
        }
        public static long Gauss(long[] arr)
        {
            long Sum = 0;
            if (arr.Length == 1) Sum = arr[0] * (arr[0] + 1) / 2;
            else
            {
                if (arr[0] > arr[1])
                    Sum = (arr[1] + arr[0]) * (arr[0] - arr[1]+1)/2;
                else
                    Sum = (arr[1] + arr[0]) * (arr[1] - arr[0]+1) / 2;
            }
            return Sum;
        }
    }
}
