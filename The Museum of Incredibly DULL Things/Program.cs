using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Museum_of_Incredibly_DULL_Things
{
    class Program
    {
        //RemoveSmallest([1, 2, 3, 4, 5] ) ➞ [2, 3, 4, 5]
        //RemoveSmallest([5, 3, 2, 1, 4]) ➞ [5, 3, 2, 4]
        //RemoveSmallest([2, 2, 1, 2, 1]) ➞ [2, 2, 2, 1]

        //Don't change the order of the left over items.
        //If you get an empty array, return an empty array: [] ➞ [].
        //If there are multiple items with the same value, remove item with lower index(3rd example).

        static void Main(string[] args)
        {
            int[] arr = { 2, 2, 1, 2, 1 };
            int[] result = RemoveSmallest(arr);
        }
        public static int[] RemoveSmallest(int[] values)
        {
            List<int> list = new List<int>();
            if (values.Length != 0)
            {
                int min = values[0];

                for (int i = 1; i < values.Length; i++)
                {
                    if (min > values[i])
                        min = values[i];
                }
                bool removed = false;
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] == min && removed == false)
                    {
                        removed = true;
                    }
                    else list.Add(values[i]);
                }
                return list.ToArray();
            }
            else return list.ToArray();

        }
    }
}
