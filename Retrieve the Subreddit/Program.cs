using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrieve_the_Subreddit
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = "https://www.reddit.com/r/funny/";
            Console.WriteLine(SubReddit(link));
        }
        //SubReddit("https://www.reddit.com/r/funny/") ➞ "funny"
        public static string SubReddit(string link)
        {
            string str = "";
            //string[] elems = link.Split('/');
            str = link.Split('/')[4];





            return str;
        }

    }
}
