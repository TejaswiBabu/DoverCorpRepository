using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp01
{
    class Program63
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "Banana", "Apple", "Grapes", "Pine Apple", "Jack fruit", "Cherry", "Papaya", "Mango" };

            //foreach(string fruit in fruits.Take(4))
            //foreach (string fruit in fruits.Skip(2))

            foreach(string fruit in fruits.Skip(2).Take(3))
                Console.WriteLine(fruit);

            //Console.WriteLine(fruits.First());
            //Console.WriteLine(fruits.Last());
            //Console.WriteLine(fruits.ElementAt(2));
            //Console.WriteLine(fruits.Count());
        }

    }
}
