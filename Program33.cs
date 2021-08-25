using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program33
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Enter no's : ");
                int[] a = new int[5];
                for (int i = 0; i < 6; i++)
                    a[i] = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < a.Length; i++)
                    Console.WriteLine(a[i]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            //Console.ReadKey();
        }
    }
}
