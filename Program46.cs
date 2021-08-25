using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    partial class MyClass
    {
        public void Display1()
        {
            Console.WriteLine("Hello from display1");
        }
    }
    partial class MyClass
    {
        public void Display2()
        {
            Console.WriteLine("Hello from display2");
        }
    }
    class Program46
    {
        static void Main(string[] args)
        {
            MyClass o1 = new MyClass();
            o1.Display1();
            o1.Display2();
        }
    }
}
