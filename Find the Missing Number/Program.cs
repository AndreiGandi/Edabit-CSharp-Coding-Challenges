using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Missing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 2, 3, 6, 5, 9, 1, 4, 8 };
            Console.WriteLine(MissingNum(arr));
        }
        public static int MissingNum(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            return GaussSum()-sum;
        }
        public static int GaussSum()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return (arr.Length * (arr.Length + 1) / 2);
        }
    }
}
