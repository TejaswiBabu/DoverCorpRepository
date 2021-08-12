using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program18
    {
        static void Main(string[] args)
        {
            int [,] items;
            items = new int[2, 2]
            { { 100, 200 }, {  200, 300 } }; //Array instantiation

            /*items[0, 0] = 100;
            items[0, 1] = 200;

            items[1, 0] = 300;
            items[1, 1] = 400;*/

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                    Console.Write($"{items[i, j]} ");
                Console.WriteLine();

            }

            /*Console.Write($"{items[0, 0]} ");
            Console.WriteLine($"{items[0, 1]} ");

            Console.Write($"{items[1, 0]} ");
            Console.WriteLine($"{items[1, 1]} ");*/

        }
    }
}
