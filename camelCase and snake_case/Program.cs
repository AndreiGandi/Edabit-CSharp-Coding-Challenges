using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace camelCase_and_snake_case
{
    class Program
    {
        //ToCamelCase("hello_edabit") ➞ "helloEdabit"
        //ToSnakeCase("helloEdabit") ➞ "hello_edabit"
        //ToCamelCase("is_modal_open") ➞ "isModalOpen"
        //ToSnakeCase("getColor") ➞ "get_color"

        static void Main(string[] args)
        {
           
        }
        public static string ToSnakeCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<str.Length; i++)
            {
                if(char.IsUpper(str[i]))
                {
                    sb.Append("_" + str[i].ToString().ToLower());
                }
                else sb.Append(str[i].ToString());
            }
            return sb.ToString();
        }
        public static string ToCamelCase(string str)
        {
            
            StringBuilder sb = new StringBuilder();
            for(int i=0; i< str.Length; i++)
            {
                if (str[i] == '_')
                {
                    i++;
                    sb.Append(str[i].ToString().ToUpper());
                }
                else sb.Append(str[i]);


            }
            return sb.ToString();

        }
    }
}
