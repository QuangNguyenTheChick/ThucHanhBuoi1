using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            IPHostEntry iplc = Dns.Resolve(hostName);
            foreach (IPAddress i in iplc.AddressList)
            {
                Console.WriteLine(i);
            }

        }
    }
}
