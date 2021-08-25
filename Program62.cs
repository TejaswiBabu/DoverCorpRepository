using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program62
    {
        static void Main(string[] args)
        {

            Predicate<int> IsZero = delegate (int n)
            {
                if (n == 0)
                    return true;
                else
                    return false;
            };
            Predicate<int> IsPositive = delegate (int n)
            {
                if (n > 0)
                    return true;
                else
                    return false;

            };
            int n = 6;
            if (IsZero(n))
                Console.WriteLine("Input is zero");
            else if (IsPositive(n))
                Console.WriteLine($"{n} is positive");
            else
                Console.WriteLine($"{n} is negative");
        }
    }
}
