using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp01
{
    class Program53
    {
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable();
            employees.Add("emp1", "eashwar");
            employees.Add("Programmer1", "Pavan");
            employees.Add("hr1", "Harish");

            if (employees.Contains("hr1"))
                Console.WriteLine(employees["hr1"].ToString());

            Console.WriteLine();
        }
    }
}
