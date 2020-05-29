using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle_the_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Donald Trump";
            Console.WriteLine(NameShuffle(name));
        }
        public static string NameShuffle(string str)
        {
            string[] str1 = str.Split(' ');
            string reversedName = str1[1] + " " + str1[0];
            return reversedName;
            
  
        }
    }
}
