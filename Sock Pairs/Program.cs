using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sock_Pairs
{
    class Program
    {

        //SockPairs("AA") ➞ 1
        //SockPairs("ABABC") ➞ 2
        //SockPairs("CABBACCC") ➞ 4
        static void Main(string[] args)
        {
            Console.WriteLine(SockPairs("CABBACCC"));
        }
        public static int SockPairs(string socks)
        {
            int pairs = 0;
            Dictionary<char, int> Socks = new Dictionary<char, int>();
            foreach(var sock in socks)
            {
                if (!Socks.ContainsKey(sock))
                    Socks.Add(sock, 1);
                else Socks[sock] += 1;
            }
            foreach(var item in Socks)
            {
                pairs += item.Value / 2;
            }
            return pairs;

        }
    }
}

