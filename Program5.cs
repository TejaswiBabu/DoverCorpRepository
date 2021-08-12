using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter LMR: ");
            int lmr = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter PMR: ");
            int pmr = Convert.ToInt32(Console.ReadLine());

            int bu = (pmr - lmr);
            double ur = 0;
            if (bu < 150)
            {
                ur = 1.75;
            }
            else if (bu < 375)
            {
                ur = 3.25;
            }
            else if (bu < 500)
            {
                ur = 5;
            }
            else if (bu >= 500)
            {
                ur = 6.5;
            }

            Console.WriteLine($"UR is: {ur}");
            double amount = ur * bu;
            Console.WriteLine($"Amount is: {amount}");
        }
    }
}
/*
 Task: Genrate electricity bill
INPUT : lmr, pmr
Calculate: bu=pmr-lmr
claculate UR
BU       UR
<150    1.75
<375    3.25
<500    5
>=500   6.5
cALCULATE AMOUNT AND DISPLAY
*/

