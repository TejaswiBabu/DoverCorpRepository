using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp01
{
    class Program55
    {
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable();
            employees.Add("emp1", "eashwar");
            employees.Add("emp2", "eman");
            employees.Add("emp3", "eashwar");
            employees.Add("Programmer1", "Pavan");
            employees.Add("hr1", "Harish");
            employees.Add("hr2", "hemanth");

            foreach (DictionaryEntry e in employees)
                Console.WriteLine($"key = {e.Key}, Value = {e.Value}");
        }
    }
}
