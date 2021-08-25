using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Numbers
    {
        private int num1,num2;

        public void SetNumber(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void GetNumbers()
        {
            Console.WriteLine($"num1 = {this.num1}, num2 = {this.num2}");
           
        }
    }
    class Program35
    {
        static void Main(string[] args)
        {
            Numbers n1 = new Numbers();
            n1.SetNumber(100,2500);
            n1.GetNumbers();

        }
    }
}
