using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize_the_First_Letter_of_Each_Word
{
    class Program
    {
        //MakeTitle("This is a title") ➞ "This Is A Title"
        //MakeTitle("capitalize every word") ➞ "Capitalize Every Word"
        //MakeTitle("I Like Pizza") ➞ "I Like Pizza"
        //MakeTitle("PIZZA PIZZA PIZZA") ➞ "PIZZA PIZZA PIZZA"
        static void Main(string[] args)
        {
            Console.WriteLine(MakeTitle("capitalize every word"));
        }
        public static string MakeTitle(string str)
        {
            string newStr = str[0].ToString().ToUpper();
            for(int i=1; i<str.Length; i++)
            {
                if (str[i - 1] == ' ')
                    newStr += str[i].ToString().ToUpper();
                else newStr += str[i].ToString();

            }
            return newStr;


        }
    }
}
