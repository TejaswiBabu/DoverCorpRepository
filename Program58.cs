using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    static class IntegerExtensionMethods
    {
       public static int Square(this int n)
        {
            return n * n;
        }
        public static int Next(this int n)
        {
            return n + 1;
        }
    }
    class Program58
    {
        static void Main(string[] args)
        {
            int n = 9;
            Console.WriteLine(n);
            Console.WriteLine(n.Next());
            Console.WriteLine(n.Next().Next());
            Console.WriteLine(n.Square());
            Console.WriteLine(n.Next().Square());
        }
    }
}
