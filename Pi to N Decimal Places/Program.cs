using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi_to_N_Decimal_Places
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPi(15));
            
        }
        public static decimal MyPi(int n)
        {
            const decimal myPi = 3.1415926535897931M;
            return (decimal)Math.Round(myPi, n);

        }
    }
}
