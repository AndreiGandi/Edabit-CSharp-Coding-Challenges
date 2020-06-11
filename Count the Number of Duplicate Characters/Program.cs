using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Number_of_Duplicate_Characters
{
    class Program
    {
        //DuplicateCount("abcde") ➞ 0
        //DuplicateCount("aabbcde") ➞ 2
        //DuplicateCount("Indivisibilities") ➞ 2
        //DuplicateCount("Aa") ➞ 0
        // Case sensitive
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("abcde"));
        }
        public static int DuplicateCount(string str)
        {
            int count = 0;
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(var c in arr)
            {
                if (!dict.ContainsKey(c))
                    dict.Add(c, 1);
                else dict[c] += 1;
            }
            foreach(var key in dict.Keys)
            {
                if(dict[key] > 1) count++;
            }


            return count;
        }
    }
}
