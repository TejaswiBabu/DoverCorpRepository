using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program26
    {
        static void DisplayNames(string batchcode, params string []names)
        {
            Console.Write($"Batch Code : {batchcode}:  ");
            for (int i = 0; i < names.Length; i++)
                Console.Write($"{names[i]} ");

            Console.WriteLine("\n==========================");

        }
        static void Main(string[] args)
        {
            DisplayNames("ABCD001", "Ashok", "Anil", "Arvind");
            DisplayNames("MSE009", "Bhanu", "Bhavya");
            
        }
    }
}

/*
 * params type: Allow to have differemt number of arguments to a function
 * Can have only one params type as argument
 * can have another variable before to params also
 * */
