using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Check
{
    class Program
    {

        /*  
            In this challenge, you must verify the equality of two different values given the parameters a and b.
            Both the value and type of the parameters need to be equal. 
            The possible types of the given parameters are:
                Numbers
                Strings
                Booleans (false or true)
            */
        static void Main(string[] args)
        {
            Console.WriteLine(CheckEquality(0, "0"));
        }
        public static bool CheckEquality(object a, object b)
        {
            return Object.Equals(a, b);
        }
    }
}
