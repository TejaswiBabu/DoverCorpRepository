
//Display numbers in particular order

using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program13
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{i} {11- i}");
                Thread.Sleep(1000);
                i++;
            }
        }
    }
}
