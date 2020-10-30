using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveStringsLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "apple";
            Console.WriteLine(RecursiveStringLength(s));

        }
        static int StringLength(string s)
        {
            int count = 0;
            for(int i=0; i<s.Length; i++)
            {
                count++;
            }
            return count;
        }
        static int RecursiveStringLength(string s)
        {

            if (s.Equals("")) return 0;
            else return RecursiveStringLength(s.Substring(1)) + 1;
        }

    }
}
