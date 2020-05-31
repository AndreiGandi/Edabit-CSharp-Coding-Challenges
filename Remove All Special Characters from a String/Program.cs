using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Remove_All_Special_Characters_from_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //RemoveSpecialCharacters("The quick brown fox!") ➞ "The quick brown fox"
            //RemoveSpecialCharacters("%fd76$fd(-)6GvKlO.") ➞ "fd76fd-6GvKlO"
            //RemoveSpecialCharacters("D0n$c sed 0di0 du1") ➞ "D0nc sed 0di0 du1"
            Console.WriteLine(RemoveSpecialCharacters("The quick brown fox!"));
        }
        public static string RemoveSpecialCharacters(string str)
        {
            string newStr = "";
            for(int i=0; i<str.Length; i++)
            {
                if (Char.IsLetterOrDigit(str[i]) || str[i] == '_' || str[i] == '-' || str[i] == ' ')
                    newStr += str[i];
            }
            return newStr;

        }
        //using REGEX
        //public static string RemoveSpecialCharacters(string str)
        //{
        //    return Regex.Replace(str, "[^0-9A-Za-z _-]", "");
        //}


    }
}
