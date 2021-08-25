using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program60
    {
        static void Main(string[] args)
        {
            Action display = delegate ()
            {
                Console.WriteLine("Hello from display");
            };
            Action<string> wishes = delegate (string name)
             {
                 Console.WriteLine($"Hello {name}");
             };

            display();
            wishes("Kiran");
        }
    }

    /*Delegate:    A delegate is a typesafe funcition pointer
The object of delegate can be referred to a function or set of functions
.net provided 3 inbuilt delgates
Action    :    Refers to a function perform a task and without returning value
Func    :    Refers to a function  return a value
Predicate:    Refers to a function return boolean value*/
}
