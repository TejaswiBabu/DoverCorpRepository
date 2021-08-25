using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01

{
    class UserModel
    {
        public string UName { get; set; }
        public string Pwd { get; set; }
    }
    class Program70
    {
        static void Main(string[] args)
        {
            UserModel u1 = new UserModel { UName = "Kiran", Pwd = "Kiran" };
            UserModel u2 = new UserModel { UName = "Raj", Pwd = "Ram" };

            Console.WriteLine($"{u1.UName} {u1.Pwd}");
            Console.WriteLine($"{u2.UName} {u2.Pwd}");



        }
    }
}

/*POCO Class: Plain Old CLR Objects
 * It is a class containing all public properties
 * These are used to have datasource copy
 * 
 * The object of this class can assign row in a database table
List of objects of this class can assign set of datatablerows
 * 
 * 
 * */
