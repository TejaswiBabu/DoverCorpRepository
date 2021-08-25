using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program68
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Add = (a, b) => a + b;
            Func<int, int, int> Big = (a, b) => a > b ? a : b;
            Func<Func<int, int, int>, int, int, int> Calculate = (cb, a, b) => cb(a, b);

            Console.WriteLine(Calculate(Add, 10, 20));
            Console.WriteLine(Calculate(Big, 10, 20));

            Console.WriteLine(Calculate((a, b) => a - b, 10, 20));
             Console.WriteLine(Calculate((a, b) => a < b ? a : b, 10, 20));
        }
    }
}
