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
            Console.WriteLine(WurstIsBetter("I like chorizos, but not sausages"));
        }
        public static string WurstIsBetter(string str)
        {
            string format = "^(Kielbasa|Chorizo|Moronga|Salami|Sausage|Andouille|Naem|Merguez|Gurka|Snorkers|Pepperoni)$";
            

            return Regex.Replace(str, format, "Wurst");
        }
    }
}
