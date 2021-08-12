using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program24
    {
        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int a = 100;  int b = 200;
            Console.WriteLine($"Before swap: a={a},b={b}");
            Swap(ref a, ref b);

            Console.WriteLine($"After swap: a={a},b= {b}");
        }
    }
}
