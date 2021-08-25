using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp01
{
   
    class Program30
    {
        static void Main(string[] args)
        {
            int? a = null;
            if (a is null)
                Console.WriteLine("No value into the variable");
            else
                Console.WriteLine($"Value is {a}");

            string name = string.Empty;
            if (string.IsNullOrEmpty(name))
                Console.WriteLine("name is empty");
            else
                Console.WriteLine($"{name} is the value");
        }
    }
}
   
