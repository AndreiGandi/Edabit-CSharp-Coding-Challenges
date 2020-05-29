using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smaller_String_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(smallerNum("1600","16"));
        }
        public static string smallerNum(string n1, string n2)
        {
            int N1 = int.Parse(n1);
            int N2 = int.Parse(n2);
            if (N1 < N2) return N1.ToString();
            else return N2.ToString();
        }

    }
}
