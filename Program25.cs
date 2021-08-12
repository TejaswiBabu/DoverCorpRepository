

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program25
    {

        static void GetRole(string qualification, out string eligibleRole)
        {
            switch(qualification)
            {
                case "B.Tech":
                    eligibleRole = "Programmer";
                    break;
                case "MBA":
                    eligibleRole = "HR";
                    break;
                case "MCA":
                    eligibleRole = "Trainer";
                    break;
                default:
                    eligibleRole = "Assistant";
                    break;
            }
        }
        static void Main(string[] args)
        {
            string qualification = "B.Tech";
            string eligibleRole;
            GetRole(qualification, out eligibleRole);
            Console.WriteLine($"For qualification {qualification}, eligible role is: {eligibleRole}");

        }
    }
}


























/*
 * using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program25
    {
        static void Initialize(out int a)
        {
            a = 0;
        }
        static void Main(string[] args)
        {
            int a;
            Initialize(out a);
            Console.WriteLine(a);

        }
    }
}
*/
/*
 * Out parameter used to have variable without initialization and changes will be effect to the original
 * commonly used in the case of initialization at definition
 * */
