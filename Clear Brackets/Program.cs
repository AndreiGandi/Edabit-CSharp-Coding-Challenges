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
            bool open = false;
            bool pairs = false;
            bool isCorrectFormatted = true;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == ')' && open == false && pairs == false)
                    return false;
                else if(str[i] == '(')
                {
                    open = true;
                    for(int j = str.Length-1; j>i;j--)
                    {
                        isCorrectFormatted = false;
                        if (str[j] == ')')
                        {
                            open = false;
                            pairs = true;
                            isCorrectFormatted = true;
                            break;
                        }
                    }
                }
            }
            return isCorrectFormatted;
        }

    }
}
