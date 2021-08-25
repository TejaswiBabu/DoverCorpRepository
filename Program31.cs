using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program31
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int? n = null;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input type not valid " + ex.Message);
                n = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                n = 0;
            }
            finally
            {
                Console.WriteLine($"Square of {n} is {n * n}");
            }
        }
    }
}
