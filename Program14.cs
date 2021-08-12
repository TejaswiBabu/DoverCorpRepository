//Generate Fibonacci series

using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program14
    {
        //Generate fibbonacci series
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            int c = 0;

            Console.Write($"{a} {b} ");
            int i = 2;
            while (i < 10)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
                i++;
            }
        }
    }
}

