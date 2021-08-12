using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program4
    {
        //Read 3sub marks into m,p,c variables and display tot, avg, result and grade
        static void Main(string[] args)
        {
            Console.Write("Enter math marks: ");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter phy marks: ");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter chem marks: ");
            int chem = Convert.ToInt32(Console.ReadLine());

            int tot = math + phy + chem;
            double avg = (double)tot / 3;


            Console.WriteLine($"Total marks: {tot} ");
            Console.WriteLine($"Average marks: {avg}");

            string result = string.Empty;
            if (math >= 35 && phy >= 35 && chem >= 35)
            {
                result = "PASS";

            }
            else
            {
                result = "FAIL";
            }
            Console.WriteLine($"Result is: {result}");
        }
    }
}

/* 
 Control structure: Used to control statement execution
 if: used as branching
 case: used for constant expression in the condition
loop: to iterate statements

relational operators: >,>=,<,<=,==,!=
logical operators: && (and), || (or),  !(not)
*/

