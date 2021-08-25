using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program65
    {
        static void Main(string[] args)
        {
            Action display = () => Console.WriteLine("Hello, Good Morning!");
            display();

            Action<string> wishes = x => Console.WriteLine($"Hello {x}, welcome");
            wishes("Kiran");
            wishes("Harsha");
        }
    }
}

/* 
 * Lambda expression: It is a simple and short function definition
 * which can be provided definition as an argument
 * Advantages: Instant implementation
 * 
 * Will us inbuilt delegates (Action, Func, Predicate) for demo purpose
 * These lamda expression calles as arrow functions in javascript
 * */
