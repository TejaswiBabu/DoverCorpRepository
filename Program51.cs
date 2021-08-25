using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp01
{
    class Program51
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            items.Add("Kiran");
            items.Add(100);
            items.Add('a');
            items.Add(true);
            items.Add(45.56);

            foreach (var item in items)
                Console.WriteLine($"item is {item}, data type is {items.GetType()}");

        }
    }
}
