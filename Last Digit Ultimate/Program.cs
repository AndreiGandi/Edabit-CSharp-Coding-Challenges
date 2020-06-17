using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Digit_Ultimate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(last_dig(25, 21, 125));
        }
        public static bool last_dig(int a, int b, int c)
        {
            return ((a * b) % 10 == c % 10) ? true : false;
        }
    }
}
