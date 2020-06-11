using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almost_Palindrome
{
    class Program
    {
        //AlmostPalindrome("abcdcbg") ➞ true
        //// Transformed to "abcdcba" by changing "g" to "a".
        //AlmostPalindrome("abccia") ➞ true
        //// Transformed to "abccba" by changing "i" to "b".
        //AlmostPalindrome("abcdaaa") ➞ false
        //// Can't be transformed to a palindrome in exactly 1 turn.
        //AlmostPalindrome("1234312") ➞ false
        static void Main(string[] args)
        {
            Console.WriteLine(AlmostPalindrome("abcdcbg"));
        }
        public static bool AlmostPalindrome(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            int nrOfDifferences = 0;
            string reversedStr = new string(chars);
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] != reversedStr[i])
                    nrOfDifferences++;
            }
            // abcdcbg with gbcdcba => 2 diffenreces a-g and g-a
            if (nrOfDifferences == 2) return true;
            return false;
        }
    }
}
