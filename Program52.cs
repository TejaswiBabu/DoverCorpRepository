using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp01
{
    class Program52
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            items.Add(100);
            items.Add(20);
            items.Add(80);
            items.Add(60);
            items.Add(30);

            items.Sort();
            items.Reverse();

            for (int i = 0; i < items.Count; i++)
                Console.WriteLine($"items are (i)");
        }
    }
}
