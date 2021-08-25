using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program27

    {
        //Define a method and name it Addition which take any number of integer values and display their sum
        static void Addition(params int[] items)
        {
            int sum = 0;
            for (int i = 0; i < items.Length; i++)
                sum += items[i];
            Console.WriteLine($"Addition of elements: {sum}");
        }
        static void Main(string[] args)
        {
            Addition(10, 20, 30, 400);
            Addition(500, 600);
        }
    }
}

/*
 * params type: Allow to have differemt number of arguments to a function
 * Can have only one params type as argument
 * can have another variable before to params also
 * */