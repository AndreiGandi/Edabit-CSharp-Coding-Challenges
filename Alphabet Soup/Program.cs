using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet_Soup
{
    class Program
    {
        static void Main(string[] args)
        {
            //AlphabetSoup("hello") ➞ "ehllo"
            string str = "hello kitty";
            Console.WriteLine(AlphabetSoup(str));
        }
        public static string AlphabetSoup(string str)
        {
            char[] elements = new char[str.Length];
            for(int i = 0; i<str.Length; i++)
            {
                elements[i] = str[i];
            }
            Array.Sort(elements);
            string result = "";
            for(int i = 0; i<elements.Length; i++)
            {
                result += elements[i];
            }
            return result;
        }
        //Using List
        public static string AlphabetSoup_V2(string str)
        {
            List<char> strList = new List<char>();
            foreach (char c in str)
            {
                strList.Add(c);
            }
            strList.Sort();

            string returnStr = "";
            foreach (char c in strList)
            {
                returnStr += c;
            }

            return returnStr;
        }
        //Using ToCharArray
        public static string AlphabetSoup_V3(string str)
        {
            var strArr = str.ToCharArray();
            Array.Sort(strArr);

            return new string(strArr);
        }
    }
}
