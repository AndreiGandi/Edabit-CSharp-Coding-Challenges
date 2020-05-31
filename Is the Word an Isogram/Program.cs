using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_the_Word_an_Isogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //IsIsogram("Algorism") ➞ true
            //IsIsogram("PasSword") ➞ false
            //// Not case sensitive.
            //IsIsogram("Consecutive") ➞ false
            Console.WriteLine(IsIsogram("PasSword"));
        }
        public static bool IsIsogram(string str)
        {
            str = str.ToLower();
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            for(int i = 0; i< chars.Length-1; i++)
            {

                if (chars[i] == chars[i + 1])
                    return false;
                
            }
            return true;

        }
    }
}
