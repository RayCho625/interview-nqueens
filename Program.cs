using System;
using System.Collections.Generic;

namespace NQueenQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n = 4;
            int resultCount = 1;
            NQueen nq = new NQueen();
            List<List<string>> result = nq.solveNQueens(n);
            
            foreach (List<string> re in result)
            {
                Console.WriteLine(string.Format("Solution {0} :", resultCount));
                Console.WriteLine("[");
                foreach (string r in re)
                {
                    Console.WriteLine(r.ToString());
                }
                Console.WriteLine("]");
                resultCount++;
            }
            
        }
    }
}
