using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Only
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "R!=:~0o0./c&}9k`60=y";
            Console.WriteLine(LettersOnly(str));
        }
        //LettersOnly("R!=:~0o0./c&}9k`60=y") ➞ "Rocky"
        public static string LettersOnly(string str)
        {
            string filmName = "";
            for(int i=0; i<str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                    filmName += str[i].ToString();
            }
            return filmName;

        }
    }
}
