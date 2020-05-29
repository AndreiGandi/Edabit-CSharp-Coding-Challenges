using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers_in_Descending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortDescending(123) ➞ 321
            //SortDescending(2619805) ➞ 9865210
            //SortDescending(73065) ➞ 76530
            Console.WriteLine(SortDescending(123));
        }
        public static int SortDescending(int num)
        {
            char[] nr = num.ToString().ToCharArray();
            Array.Sort(nr);
            Array.Reverse(nr);
            string result = "";
            foreach(var i in nr) { result += i; }
            return Convert.ToInt32(result);

        }
    }
}
