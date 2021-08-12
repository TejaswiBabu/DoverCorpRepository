using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program21
    {
        static void Display()
        {
            Console.WriteLine("Hello from methods");
        }
        static void DrawLine()
        {
            for (int i = 0; i < 100; i++)
                Console.Write("=");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            DrawLine();
            Display();
            DrawLine();
        }
    }
}

/* A methos is a function inside a class
 * A method is a self contained block of statement to perform a task
 * A method can return a value to the caller
 * */