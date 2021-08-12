using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program23
    {
        static void Display(int a, int b)
        {
            Console.WriteLine($"a={a},b={b}");
        }
        static void Square(ref int a, ref int b)
        {
            a *= a;   b *= b;
        }
        static void Main(string[] args)
        {
            int a = 100; int b = 200;
            Console.WriteLine("Before Square: ");
            Display(a, b);
            Square(ref a, ref b);
            Console.WriteLine("After Square: ");
            Display(a, b);

        }
    }
}

/* Method can be defines as
 * a) static : These methods will be called directly
 * b) regular : These methods will be called object
 * */
