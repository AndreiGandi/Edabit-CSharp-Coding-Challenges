using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clear_Brackets
{
    class Program
    {
        //Brackets("(a*(b-c)..... )") ➞ true
        //Brackets(")(a-b-45/7*(a-34))") ➞ false
        //Brackets("sin(90...)+.............cos1)") ➞ false

        //The string may not contain brackets, then return true.
        //String may contain spaces.
        //The string may be empty.
        static void Main(string[] args)
        {
            Console.WriteLine(Brackets("sin(90       )+      cos1)"));
        }
        public static bool Brackets(string str)
        {
            int bracketsIndicator = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                    bracketsIndicator++;
                if (str[i] == ')')
                    bracketsIndicator--;
            }
            if (bracketsIndicator == 0)
                return true;
            else return false;
        }

    }
}
