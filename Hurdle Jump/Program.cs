using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurdle_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hurdles = { 1, 2, 3, 4, 5 };
            Console.WriteLine(hurdleJump(hurdles, 5));
        }
        public static bool hurdleJump(int[] hurdles, int jumpHeight)
        {
            int maxHurdle = 0;
            if (hurdles.Length <= 0) return true;
            else if (hurdles.Length == 1)
            {
                maxHurdle = hurdles[0];
                if (maxHurdle > jumpHeight) return false;
                else return true ;
            }
            else
            {
                for (int i = 1; i < hurdles.Length; i++)
                {
                    if (hurdles[i] > maxHurdle)
                    {
                        maxHurdle = hurdles[i];
                    }
                }
                if (maxHurdle > jumpHeight)
                    return false;
                else return true;
            }
        }

    }
}
