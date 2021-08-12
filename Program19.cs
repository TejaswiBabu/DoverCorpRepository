using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program19
    {
        static void Main(string[] args)
        {
            int[][] items; //Jagged array declaration
            items = new int[4][]; //instantiate with four rows

            items[0] = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };
            items[1] = new int[] { 2, 4 };
            items[2] = new int[] { 1, 2, 3, 4, 5, 6 };
            items[3] = new int[] { 2, 4, 5, 6 };

            for(int i=0;i<items.Length;i++)
            {
                for(int j=0;j<items[i].Length;j++)
                    Console.Write($"{items[i][j]} ");

            Console.WriteLine();
            }

        }
    }
}
