using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlTeRnAtInG_cApS
{
    class Program
    {
        //AlternatingCaps("Hello") ➞ "HeLlO"
        //AlternatingCaps("How are you?") ➞ "HoW aRe YoU?"
        //AlternatingCaps("OMG this website is awesome!") ➞ "OmG tHiS wEbSiTe Is AwEsOmE!"
        //The first letter should always be UPPERCASE.
        //Ignore spaces.
        static void Main(string[] args)
        {
            Console.WriteLine(AlternatingCaps("How are you?"));
        }
        public static string AlternatingCaps(string str)
        {

            StringBuilder sb = new StringBuilder();
            bool uppercase = true;
            //foreach(char c in str)
            for(int i = 0; i<str.Length; i++)
            {
                if (str[i] == ' ') { sb.Append(' '); continue; }
                if (uppercase) sb.Append(Char.ToUpper(str[i]));
                else sb.Append(Char.ToLower(str[i]));
                uppercase = !uppercase;
            }
            return sb.ToString();
        }
    }
}
