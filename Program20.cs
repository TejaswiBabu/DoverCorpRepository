using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program20
    {
        static void Main(string[] args)
        {
            string[][] batches;
            batches = new string[4][]; //instantiate with four rows

            batches[0] = new string[] { "anil", "ashok", "arun" };
            batches[1] = new string[] { "bhanu", "bharath", "bhaskar", "bhagvan" };
            batches[2] = new string[] { "chandu", "charan"};
            batches[3] = new string[] { "daniel", "david", "danny", "devender","Diana"};

            for(int i=0;i<batches.Length;i++)//refers to toal rows
            {
                for (int j = 0; j < batches[i].Length; j++)//refers to colums in each row
                Console.Write($"{batches[i][j]} ");
                Console.WriteLine();
            }
        }
    }
}
