using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
            int[] arr = ArrayOfMultiples(7, 5);
        }
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] arr = new int[length];
            for(int i=0; i<length; i++)
            {
                arr[i] = (i + 1) * num;
            }
            return arr;

        }
    }
}
