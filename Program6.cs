using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter no: ");
            int d = Convert.ToInt32(Console.ReadLine());

            switch (d)
            {
                case 1:
                    Console.WriteLine("North");
                    break;
                case 2:
                    Console.WriteLine("East");
                    break;
                case 3:
                    Console.WriteLine("East");
                    break;
                case 4:
                    Console.WriteLine("East");
                    break;
                default:
                    Console.WriteLine("Invalid choice...");
                    break;
            }

        }
    }
}
