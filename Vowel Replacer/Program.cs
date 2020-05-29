using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(ReplaceVowels("the aardvark", "#"));
        }
		public static string ReplaceVowels(string str, string ch)
		{
			string newstr = "";
			for (int i = 0; i < str.Length; i++)
			{
				if (isVowel(str[i].ToString()))
				{
					newstr += ch;
				}
				else { newstr += str[i].ToString(); }
			}
			return newstr;
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
	}
}
