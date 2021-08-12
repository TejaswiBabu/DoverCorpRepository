using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program16
    {
        static void Main(string[] args)
        {

            //int[] items;
            //items = new int[5] { 100, 200, 300, 400, 500 }; //Array instantiation
            int[] items = new int[5];
            Console.WriteLine("Array input: ");
            int sum = 0;
            int count = items.Length;
            double avg = 0;
            int big = 0;  int small = 0;
            for(int i=0;i<items.Length;i++)
            {
                Console.Write($"Enter value for items[{i}]: ");
                items[i] = Convert.ToInt32(Console.ReadLine());

                sum += items[i];

                if (i == 0) big = small = items[0];
                else if (items[i] > big) big = items[i];
                else if (items[i] < small) small = items[i];

            }
            avg = (double)sum / count;
            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($"items[{i}]={items[i]} ");

            Console.WriteLine($"Count of elements: {count}");
            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine($"Avg of elements: {avg}");
            Console.WriteLine($"Biggest element: {big}\nSmallest element: {small}");

            /*items[0] = 1000;
            items[1] = 2000;
            items[2] = 3000;
            items[3] = 4000;
            items[4] = 5000;*/

            /*Console.WriteLine($"{items[0]}");
            Console.WriteLine($"{items[1]}");
            Console.WriteLine($"{items[2]}");
            Console.WriteLine($"{items[3]}");
            Console.WriteLine($"{items[4]}");*/

            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($"{items[i]}");

        }
    }
}

/*
 Array is a Programming feature, allow to store more than one value within a single indentification and

Application of an Array:
Days in a month,Hours in a day, Students in a classroom, Seats in bus, etc.,

Point to note:
Array is Abstract class in .NET Collection API
Array is declared at compiled time(stored in stack memory)
Arrays are index based collection, accessible using [ [ notation.
First element is accessible using 0 index, last element is accessible using length-1 as index
Dimensions are accessible using Rank property

Limitations:
    Array variable will store one type of data.
Array variable fixed( cannot enhance).
Insertion, deletion and sorting, searching of elements in array is big process
*/
