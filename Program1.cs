using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter no1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a={a},b+{b}");
            Console.WriteLine($"Addition of {a} and {b} is {a + b}");
            Console.WriteLine($"Sub of {a} and {b} is {a - b}");
            Console.WriteLine($"Mul of {a} and {b} is {a * b}");
            Console.WriteLine($"Div of {a} and {b} is {a / b}");
        }
    }
}
