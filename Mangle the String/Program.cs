using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangle_the_String
{
    //Create a function that takes a string and replaces every letter with the letter following it in the alphabet("c" becomes "d", "z" becomes "a", "b" becomes "c", etc).
    //Then capitalize every vowel(a, e, i, o, u) and return the new modified string.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mangle("Fun times!"));  // "GvO Ujnft!"
            Console.WriteLine(Mangle("The quick brown fox."));  // "UIf rvjdl cspxO gpy."
            Console.WriteLine(Mangle("Omega"));  // "Pnfhb"
        }
        public static string Mangle(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in str)
            {

                if (char.IsLetter(ch))
                {
                    if ((int)ch == 90)
                        sb.Append((char)65);
                    else if((int)ch == 122)
                        sb.Append((char)97);

                    else sb.Append(Convert.ToChar((int)ch + 1).ToString());
                }
                else if (char.IsWhiteSpace(ch)) sb.Append(" ");
                else sb.Append(ch);
               
            }
            return sb.ToString().Replace("a","A").Replace("e", "E").Replace("i", "I").Replace("o", "O").Replace("u", "U");
        }
    }
}
