using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] haystack_3 = new object[] { "javascript", "python", "python", "ruby", "javascript", "c", "ruby" };
            object[] noDuplica = RemoveDups(haystack_3);
            for(int i = 0; i<noDuplica.Length; i++)
            {
                Console.Write($"{noDuplica[i]} ");
            }

        }
        //RemoveDups(["The", "big", "cat"]) ➞ ["The", "big", "cat"]
        //Using IEnumerable
        public static object[] RemoveDups(object[] str)
        {
            IEnumerable<object> distinctAges = str.Distinct();
            return distinctAges.ToArray();
        }

    }
}
