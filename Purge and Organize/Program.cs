using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purge_and_Organize
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 4, 4, 4, 4, 4, 3, 2, 1, 2 };
            double[] newArr = UniqueSort(arr);
            for (int i = 0; i < newArr.Length; i++)
                Console.Write($"{newArr[i]} ");
        }
        //UniqueSort([1, 4, 4, 4, 4, 4, 3, 2, 1, 2]) ➞ [1, 2, 3, 4]
        public static double[] UniqueSort(double[] arr)
        {
            List<double> list = new List<double>();
            for(int i=0; i<arr.Length; i++)
            {
                if (!list.Contains(arr[i]))
                    list.Add(arr[i]);
            }
            double[] newArr = list.ToArray();
            Array.Sort(newArr);
            return newArr;

        }
        //using LINQ
        public static double[] UniqueSort_v2(double[] arr)
        {
            return arr.Distinct().OrderBy(n => n).ToArray();
        }
    }
}
