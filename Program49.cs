using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp01
{
    class Program49
    {
        static void Main(string[] args)
        {
            string fpath = @"c:\myfile1.txt";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fpath);
                string fileContent = sr.ReadToEnd();
                Console.WriteLine(fileContent);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine($"{fpath} not exist...");
            }
            sr.Close();
        }
    }
}

/*
StreamReader object, contains methods usedto read content from the existing file
 */