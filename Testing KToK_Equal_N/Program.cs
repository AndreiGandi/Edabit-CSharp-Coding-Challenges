using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Testing_KToK_Equal_N
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool KToK(string n, int k)
        {
            
            BigInteger nr = new BigInteger(double.Parse(n));
            if (nr == (BigInteger)Math.Pow(k, k))
                return true;
            return false;
        }
    }
}
