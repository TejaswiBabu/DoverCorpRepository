using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program28
    {
        static void Display()
        {
            Console.WriteLine("Hello Good Morning");

        }
        static void Display(string name)
        {
            Console.WriteLine($"Hello {name} Good Morning!");
        }

        static void Main(string[] args)
        {
                Display();
                Display("Teju");

        }
    }
}

/* 
 * Method overloading: Refers to define more than one method with same name
 * */
