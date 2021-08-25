using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program56
    {
        static void Main(string[] args)
        {
            /*List<string> fruits = new List<string> { "Banana", "Cherry", "Mango", "Papaya", "Apple" };
                 foreach (string fruit in fruits)
                     Console.WriteLine(fruit);*/
            List<int> items = new List<int> { 10, 20, 30 };
            items.Insert(0, 5);
            items.Add(40);
            foreach (int item in items)
                Console.WriteLine(items);
        }
    }
}
