using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class BaseClass
    {
        private int dm1 = 100;
        protected int dm2 = 200;
        public int dm3 = 300;
        public void DisplayBase()
        {
            Console.WriteLine($"dm1={dm1},dm2={dm2},dm3={dm3}");
        }
    }

        class DerivedClass : BaseClass
        {
            public void DisplayDerived()
            {
                //dm1 is inaccessible sue to its protection level
                Console.WriteLine($"dm2={dm2},dm3={dm3}");

            }
        }
    
    class Program42
    {
        static void Main(string[] args)
        {
            DerivedClass o1 = new DerivedClass();
            o1.DisplayBase();
            o1.DisplayDerived();
            Console.WriteLine(o1.dm3);
        }
    }
}
