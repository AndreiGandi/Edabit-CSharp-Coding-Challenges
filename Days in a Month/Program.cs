using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Days_in_a_Month
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        static bool isLeap(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                return true;
            return false;
        }
        public static int Days(int month, int year)
        {
            int days = 0;
            switch(month)
            {
                case 1: days = 31; break;
                case 2:
                    {
                        if (isLeap(year)) days = 29;
                        else days = 28;
                        break;
                    }
                case 3: days = 31; break;
                case 4: days = 30; break;
                case 5: days = 31; break;
                case 6: days = 30; break;
                case 7: days = 31; break;
                case 8: days = 31; break;
                case 9: days = 30; break;
                case 10: days = 31; break;
                case 11: days = 30; break;
                case 12: days = 31; break;
            }
            return days;
        }

    }
}
