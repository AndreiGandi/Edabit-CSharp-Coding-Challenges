using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_the_Index_of_All_Capital_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //IndexOfCapitals("eQuINoX") ➞ [1, 3, 4, 6]
            string str = "eQuINoX";

        }
        public static int[] IndexOfCapitals(string str)
        {
            int[] arr = new int[] { };
            List<int> list = new List<int>();
            for(int i=0; i<str.Length; i++)
            {
                if(Char.IsUpper(str[i]))
                {
                    list.Add(i);
                }
            }
            arr = list.ToArray();
            return arr;
        }
    }
}
