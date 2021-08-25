using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program34
    {
        static void Main(string[] args)
        {
            string[] names= { "Anshul", "Rajesh", "Dev", "Ganesh" };
            foreach (string name in names)
                Console.WriteLine(name);

            int[] items = { 100, 200, 300, 400, 500 };
            foreach (int item in items)
                Console.WriteLine(items);
        }
    }
}
