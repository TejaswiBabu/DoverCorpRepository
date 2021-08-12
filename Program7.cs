using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program7
    {
        static void Main(string[] args)
        {
            var v1 = 100;
            Console.WriteLine($"v1={v1}, data type is {v1.GetType()}");

            var v2 = 45.34;
            Console.WriteLine($"v2={v2}, data type is {v2.GetType()}");

            var v3 = 'a';
            Console.WriteLine($"v3={v3}, data type is {v3.GetType()}");

            var v4 = true;
            Console.WriteLine($"v4={v4}, data type is {v4.GetType()}");

            var v5 = "Teju";
            Console.WriteLine($"v5={v5}, data type is {v5.GetType()}");


        }
    }
}
