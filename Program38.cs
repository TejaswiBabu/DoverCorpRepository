using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Student
    {
        private int id, fee;
        private string sname, course;
        public Student(int id=-1, string sname="Not Provided", string course=".NET", int fee=1000)
        {
            this.id = id;
            this.sname = sname;
            this.course = course;
            this.fee = fee;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{this.id} {this.sname} {this.course} {this.fee}");

        }
    }
    class Program38
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1001, "Tejaswi", ".NET", 50000);
            Student s2 = new Student(1002, "Babu", "Angular", 15000);
            Student s3 = new Student();
            s1.GetDetails();
            s2.GetDetails();
            s3.GetDetails();
        }
    }
}

/*
 * Parameterized constructor: Used to pass arguments whilc object creation
 Note:   Constructor method can be overloaded
        Constructor method can have default parameter
*/