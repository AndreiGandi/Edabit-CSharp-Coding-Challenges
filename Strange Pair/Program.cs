using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strange_Pair
{
    class Program
    {
        static void Main(string[] args)
        {
            //IsStrangePair("ratio", "orator") ➞ true
            //// "ratio" ends with "o" and "orator" starts with "o".
            //// "ratio" starts with "r" and "orator" ends with "r".

            //IsStrangePair("sparkling", "groups") ➞ true

            //IsStrangePair("bush", "hubris") ➞ false

            //IsStrangePair("", "") ➞ true
            Console.WriteLine(IsStrangePair("ratio", "orator"));
        }
        public static bool IsStrangePair(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) && String.IsNullOrEmpty(str2)) return true;
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2)) return false;
            if (str1[0] == str2[str2.Length - 1] && str2[0] == str1[str1.Length - 1])
                return true;
            return false;
        }
    }
}
