using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainZ.Console.Node
{
    class Program
    {
        static void Main(string[] args)
        {
            var chain = new BlockChain();
            var server = new WebServer(chain, args[0]);
            System.Console.Read();
        }
    }
}
