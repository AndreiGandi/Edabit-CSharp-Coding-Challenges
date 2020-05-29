using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_the_Highest_and_Lowest_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //HighLow("1 2 -3 4 5") ➞ "5 -3"
            //HighLow("13") ➞ "13 13"
            string str = "1 2 -3 4 5";
            Console.WriteLine(HighLow(str));
        }
        public static string HighLow(string str)
        {
            string result = "";
            string[] nr = str.Split(' ');
            List<int> list = new List<int>();
            for(int i=0; i<nr.Length; i++)
            {
                list.Add(Convert.ToInt32(nr[i]));
            }
            list.Sort();
            result = $"{list[nr.Length-1]} {list[0]}";




            return result;

        }
    }
}
