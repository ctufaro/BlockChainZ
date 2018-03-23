﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace BlockChainZ.Console.Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCoinBlockchain = new Blockchain();
            myCoinBlockchain.Difficulty = 4;

            // Received a block from the P2P network.
            // Validate 300 coins transfer.
            System.Console.WriteLine("Mining a block...");
            myCoinBlockchain.AddBlock(new Block(1, "03/12/2017", "300"));

            // this line below will cause the chain to be invalid.
            //myCoinBlockchain.GetLatestBlock().PreviousHash = "";

            // Validate the chain
            myCoinBlockchain.ValidateChain();


            System.Console.WriteLine("Done");
            System.Console.ReadKey();
        }
    }
}
