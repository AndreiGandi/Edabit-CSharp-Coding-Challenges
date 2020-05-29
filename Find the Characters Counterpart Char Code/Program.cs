using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Characters_Counterpart_Char_Code
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int CounterpartCharCode(char symbol)
        {
            if (Char.IsLower(symbol))
                return (int)(Char.ToUpper(symbol));
            else return (int)(Char.ToLower(symbol));
        }
    }
}
