using System;
using System.Collections.Generic;
using System.Linq;

using System.Collections;
using System.IO;

namespace ConsoleApp01
{
    class Program64
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int> { 20, 15, 23, 54, 67, 43, 98, 79, 100, 92 };

            Console.WriteLine(items.First());
            Console.WriteLine(items.Last());
            Console.WriteLine(items.ElementAt(2));

            Console.WriteLine(items.Count());
            Console.WriteLine(items.Max());
            Console.WriteLine(items.Min());
            Console.WriteLine(items.Min());
            Console.WriteLine(items.Average());

            //foreach(int item in items)
            //foreach(int item in items.Take(5))
            //foreach(int item in items.Skip(3))

            foreach(int item in items.Take(2).Skip(2).Take(3))
                Console.WriteLine(item);
        }
    }
}
