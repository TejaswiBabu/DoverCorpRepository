using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program61
    {
        static void Main(String[] args)
        {
            Func<int, int> square = delegate (int n)
            {
                return n * n;
            };
            Func<int, int> Next = delegate (int n)
            {
                return n + 1;
            };

            Console.WriteLine(square(5));
            Console.WriteLine(Next(8));
        }
    }
}
