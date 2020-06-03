using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize_the_Names
{
    class Program
    {


        //CapMe(["mavis", "senaida", "letty"]) ➞ ["Mavis", "Senaida", "Letty"]
        //CapMe(["samuel", "MABELLE", "letitia", "meridith"]) ➞ ["Samuel", "Mabelle", "Letitia", "Meridith"]
        //CapMe(["Slyvia", "Kristal", "Sharilyn", "Calista"]) ➞ ["Slyvia", "Kristal", "Sharilyn", "Calista"]
        static void Main(string[] args)
        {
            string[] arr = { "mavis", "senaida", "letty" };
            string[] names = CapMe(arr);
    }
        public static string[] CapMe(string[] arr)
        {
            List<string> names = new List<string>();
            foreach(string name in arr)
            {
                string nameStr = "";
                for(int i=0; i<name.Length; i++)
                {
                    if (i == 0) nameStr += name[i].ToString().ToUpper();
                    else nameStr += name[i].ToString().ToLower();
                }
                names.Add(nameStr);
            }
            return names.ToArray();
        }

        public static string[] CapMe_V2(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1, arr[i].Length - 1).ToLower();
            }
            return arr;
        }
    }
}
