using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_for_Anagrams
{
    class Program
    {
        //IsAnagram("cristian", "Cristina") ➞ true
        //IsAnagram("Dave Barry", "Ray Adverb") ➞ true
        //IsAnagram("Nope", "Note") ➞ false
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("cristian", "Cristina"));
        }
        public static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            char[] s1 = str1.ToLower().ToCharArray();
            char[] s2 = str2.ToLower().ToCharArray();
            Array.Sort(s1);
            Array.Sort(s2);

            if (new string(s1) == new string(s2))
                return true;
            return false;
        }
    }
}
