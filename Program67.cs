using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program67
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Add = (a, b) => a + b;
            Func<int, int, int> Sub = (a, b) => a - b;

            Func<int, int, int> Big = (a, b) => a > b ? a : b;
            Func<int, int, int> Small = (a, b) => a < b ? a : b;

            Console.WriteLine(Add(25, 5));
            Console.WriteLine(Sub(25, 5));
            Console.WriteLine(Big(25, 5));
            Console.WriteLine(Small(25, 5));
        }
    }
}
