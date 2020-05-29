using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_out_Strings_from_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //FilterArray([1, "a", "b", 0, 15]) ➞ [1, 0, 15]
            object[] haystack_1 = new object[] { "$%^", 567, "&&&" };
            int[] nr = FilterArray(haystack_1);
            for(int i=0; i<nr.Length; i++)
            {
                Console.Write($"{nr[i]} ");
            }

        }
        public static int[] FilterArray(object[] arr)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList(arr.Length);
            for(int i=0; i<arr.Length; i++)
            {
                list.Add(arr[i]);
            }
            IEnumerable<int> query1 = list.OfType<int>();
            return query1.ToArray();
        }
        

        //public static int[] FilterArray(object[] arr)
        //{
        //    List<int> list = new List<int>();
        //    for(int i=0; i<arr.Length; i++)
        //    {
        //        int result;
        //        if (int.TryParse(arr[i].ToString(), out result))
        //        {
        //            list.Add(result);
        //        }
        //    }
        //    int[] nr = list.ToArray();
        //    return nr;
        //}
    }
}
