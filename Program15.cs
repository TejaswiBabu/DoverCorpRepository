using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter no: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
                i++;
            }

        }
    }
}

//Genrate multiplication table

