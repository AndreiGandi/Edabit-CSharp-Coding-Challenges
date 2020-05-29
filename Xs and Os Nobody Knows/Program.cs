using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xs_and_Os_Nobody_Knows
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //XO("ooxx") ➞ true
        //XO("xooxx") ➞ false
        //XO("ooxXm") ➞ true
        //// Case insensitive.
        //XO("zpzpzpp") ➞ true
        //// Returns true if no x and o.
        //XO("zzoo") ➞ false
        public static bool XO(string str)
        {
            if (Count('x', str) == Count('o', str))
                return true;
            return false;

        }
        public static int Count(char ch, string str)
        {
            int count = 0;
            for(int i = 0; i<str.Length; i++)
            {
                if (str[i].ToString().ToLower() == ch.ToString())
                    count++;
            }
            return count;
        }
    }
}
