using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Remove_Every_Vowel_from_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //RemoveVowels("Happy Thanksgiving to all--even the haters and losers!")
            //➞ "Hppy Thnksgvng t ll--vn th htrs nd lsrs!"
            Console.WriteLine(RemoveVowels("Happy Thanksgiving to all--even the haters and losers!"));
        }
        public static string RemoveVowels(string str)
        {
            string newStr = "";
            for(int i=0; i<str.Length; i++)
            {
                if (isVowel(str[i].ToString()))
                    newStr += "";
                else newStr += str[i];
            }
            return newStr;
        }
        public static bool isVowel(string ch)
        {
            if (ch.ToLower() == "a" ||
                 ch.ToLower() == "e" ||
                 ch.ToLower() == "i" ||
                 ch.ToLower() == "o" ||
                 ch.ToLower() == "u")
                return true;
            return false;
        }

        //Using REGEX
        

        public static string RemoveVowels_v2(string str)
        {
            return new Regex(@"[aeiouAEIOU]").Replace(str, "");
        }

}
}
