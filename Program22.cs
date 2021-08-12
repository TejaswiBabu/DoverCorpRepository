using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program22
    {
        static void Wishes(string name)
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12) Console.WriteLine($"Hello {name}, Good Morning");
            else if (hour < 16) Console.WriteLine($"Hello {name}, Good Afternoon");
            else Console.WriteLine($"Hello {name}, Good Evening");
        }

        static void Main(string[] args)
        {

            Wishes("Tejuuuu");
        }
    }
}
