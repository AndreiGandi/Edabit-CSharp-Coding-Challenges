using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Pirate_s_Tale
{
    class Program
    {
        //NumberOfDays([3, 5]) => 9 days
        //// Since: 3 days east + 2 days north (5 days passed) + 1 day of rest + 3 days north
        //NumberOfDays([-4, -1]) => 5 days
        // Since 4 days west + 1 day south
        static void Main(string[] args)
        {
            int[] coordinates = {10,10 };
            Console.WriteLine(NumberOfDays(coordinates));
        }
        public static int NumberOfDays(int[] coordinates)
        {
            int x = coordinates[0];
            int y = coordinates[1];
            int restday = 0;
            int days = Math.Abs(x) + Math.Abs(y);
            for(int i = 1; i<days; i++)
            {
                if (i % 5 == 0) ++restday;
            }
            return days + restday;
        }

    }
}
