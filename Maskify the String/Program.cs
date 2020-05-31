using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maskify_the_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify(""));
        }
        //Maskify("4556364607935616") ➞ "############5616"
        //Maskify("64607935616") ➞ "#######5616"
        //Maskify("1") ➞ "1"
        //Maskify("") ➞ ""


        public static string Maskify(string str)
        {

            string maskify = "";

            if (str.Length < 5)
            {
                maskify = str;
            }
            else
            {
                for (int i = 0; i < str.Length - 4; i++)
                {
                    maskify += "#";
                }
                for (int i = str.Length - 4; i < str.Length; i++)
                {
                    maskify += str[i];
                }
            }

            return maskify;
        }
    }
}
