using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp01
{
    class Program48
    {
        static void Main(string[] args)
        {
            string fileName = @"e:\myfile1.txt";

            //Total File Path
            Console.WriteLine("Path= " + Path.GetDirectoryName(fileName));
            //File path with FileName
            Console.WriteLine("Path= " + Path.GetFullPath(fileName));
            //Returns Extension of Path File
            Console.WriteLine("Extension of Path= " + Path.GetExtension(fileName));
            //Returns FileName of Path
            Console.WriteLine("FilaName of Path= " + Path.GetFileName(fileName));

        }
    }
}
