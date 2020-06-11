using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wurst_Is_Better
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WurstIsBetter("...n crackers— I couldn't get enough of the salty, spicy Wurst"));
        }
        public static string WurstIsBetter(string str)
        {
            string pattern = "(?i)(Kielbasa|Chorizo|Moronga|Salami|Sausage|Andouille|Naem|Merguez|Gurka|Snorkers|Pepperoni).";

            string newString = Regex.Replace(str, pattern, "Wurst");

            return newString;
        }
        //Withou REGEX
        public static string WurstIsBetter_v2(string str)
        {
            string[] sausages = new string[]
            {
        "Kielbasa", "Chorizo", "Moronga", "Salami", "Sausage", "Andouille",
        "Naem", "Merguez", "Gurka", "Snorkers", "Pepperoni"
            };
            foreach (string sausage in sausages)
            {
                str = str.Replace(sausage, "Wurst");
                str = str.Replace(sausage.ToLower(), "Wurst");
            }
            return str;
        }
    }
}
