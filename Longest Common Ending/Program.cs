using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Ending
{
    class Program
    {
        //LongestCommonEnding("multiplication", "ration") ➞ "ation"
        //LongestCommonEnding("potent", "tent") ➞ "tent"
        //LongestCommonEnding("skyscraper", "carnivore") ➞ ""
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonEnding("potent", "tent"));
        }
        public static string LongestCommonEnding(string str1, string str2)
        {
            string temp = "";
            for(int i = str1.Length-1, j = str2.Length - 1; ; i--, j--)
            {

                if (str1[i] == str2[j]) temp += str1[i];
                else break;
                if (i == 0 || j == 0) break;
            }
            char[] chars = temp.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
            
        }
    }
}
