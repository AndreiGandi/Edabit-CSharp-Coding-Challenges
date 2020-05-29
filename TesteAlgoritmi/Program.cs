using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TesteAlgoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            //string txt = "AAPL dsadasda sadadsada dsadasda AAPL sadasdadsa";
            //Console.WriteLine(FindIndex(txt));

            Console.WriteLine(Relationship(9,9));

        }

        //Write an algorithm to find the second appearance of the word "AAPL" in a given String
        public static int FindIndex(string str)
        {
            int position = -1;
            int nrOfAppearances = 0;
            var regex = new Regex("AAPL?", RegexOptions.Compiled |
                RegexOptions.IgnoreCase);
            Match match = regex.Match(str);

            while (match.Success)
            {
                ++nrOfAppearances;
                position = match.Index;
                match = match.NextMatch();
                if (nrOfAppearances == 2)
                    break;
            }

            return position;
        }
        public static string Relationship(int a, int b)
        {
            string rel = "";

            if (a > b) rel = $"{a} > {b}";
            else if (a < b) rel = $"{a} < {b}";
            else rel = $"{a} = {b}";

            return rel;
        }
    }
}
