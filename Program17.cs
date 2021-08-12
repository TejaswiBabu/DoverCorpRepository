using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program17
    {
        //Display 5 names in array
        static void Main(string[] args)
        {
            String[] names = { "raj", "ram", "ganesh", "ashok", "kiran" };
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);
        }
    }
}
