using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format_Number_with_Comma_s__Separating_Thousands
{
    class Program
    {
        static void Main(string[] args)
        {
            //FormatNum(1000) ➞ "1,000"
            //FormatNum(100000) ➞ "100,000"
            //FormatNum(20) ➞ "20"
            Console.WriteLine(FormatNum(20));
        }
        public static string FormatNum(int num)
        {
            return String.Format("{0:n0}", num);
        }
    }
}
