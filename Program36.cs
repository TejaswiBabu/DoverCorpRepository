using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Person
    {
        private string pname, gender;
        private int age;
        public void SetDetails(string pname, string gender, int age)
        {
            this.pname = pname; this.gender = gender; this.age = age;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{this.pname} {this.gender} {this.age}");

        }
    }
    class Program36
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            p1.SetDetails("Kiran", "Male", 35);
            p2.SetDetails("Rani", "Female", 4);

            p1.GetDetails();
            p2.GetDetails();
        }
    }
}

/*Define person class with pname, gender and age as data members
 * Implement SetDetails() and GetDetails method
 * Declare 2 object access
 */