using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program66
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int> next = x => x + 1;
            Func<int, int> cube = x => x * x * x;

            Console.WriteLine(square(5));
            Console.WriteLine(next(7));
            Console.WriteLine(cube(7));

            Func<string, string> upper = x => x.ToUpper();
            Func<string, string> fname = x => x.Substring(0,x.IndexOf(" "));
            Func<string, string> lname = x => x.Substring(x.LastIndexOf(" ") + 1);

            Func<string, int> len = x => x.Length;

            Console.WriteLine(len("Kira Kumar"));
            Console.WriteLine(upper("Kiran Kumar"));
            Console.WriteLine(fname("Kiran Kumar"));
            Console.WriteLine(lname("Kiran Kumar"));

        }
    }
}
