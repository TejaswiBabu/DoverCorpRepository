using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program32
    {
        static void Main(string[] args)
        {
            int? a = null; int? b = null;  int?c =null;
            try
            {
                Console.Write("Enter value for a: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter value for b: ");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Number cannot divisible by zero");
                Console.WriteLine("b value changed to 1");
                c = a / 1;
            }
            finally
            {
                Console.WriteLine($"Division is {c}");
            }
             
        }
    }
}
