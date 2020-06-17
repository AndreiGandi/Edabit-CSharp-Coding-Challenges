using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_vs_24_Hours
{
    class Program
    {
        //Create a function that converts 12-hour time to 24-hour time or vice versa.Return the output as a string.
        //ConvertTime("12:00 am") ➞ "0:00"
        //ConvertTime("6:20 pm") ➞ "18:20"
        //ConvertTime("21:00") ➞ "9:00 pm"
        //ConvertTime("5:05") ➞ "5:05 am"
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertTime("12:00 am"));
        }
        public static string ConvertTime(string time)
        {
            string convertedTime = "";
            if(time.Length>5)
            {
                //12h to 24h Format
                convertedTime = To24hFormat(time).ToLower();
                //if the value is 12:00 am will return 00:00 and the value must be 0:00
                if(convertedTime[0] == '0')
                {
                    convertedTime = convertedTime.Remove(0, 1);
                }
                
            }
            else
            {
                //24h to 12h Format
                string[] arr = time.Split(' ');
                convertedTime = To12hFormat(arr[0]);
            }
            return convertedTime.ToLower();
        }
        public static string To24hFormat(string date)
        {
            DateTime d =  DateTime.Parse(date);
            return d.ToString("HH:mm");
        }
        public static string To12hFormat(string date)
        {
            DateTime d = DateTime.Parse(date);
            return d.ToString("h:mm tt");
        }


        //An elegant solution
        //public static string ConvertTime(string time)
        //{
        //    if (time.Contains("am") || time.Contains("pm"))
        //    {
        //        return DateTime.Parse(time).ToString("H:mm");
        //    }

        //    return DateTime.Parse(time).ToString("h:mm tt").ToLower();
        //}

    }
}
