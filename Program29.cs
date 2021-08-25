using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program29
    {
        static int Square(int n)
        {
            return n * n;
        }

        static int Factorial(int n)
        {
            int f = 1;
            for (int i = n; i >= 1; i++)
               f *= i;
            return f;
        }
        static int Reverse(int n)
        {
            int rev = 0;
            while(n>0)
            {
                int d = n % 10;
                rev = rev * 10 + d;
                n /= 10;
            }
            return rev;
        }
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static int Biggest(int a,int b)
        {
            return a > b? a : b;
        }
        static int Smallest(int a,int b)
        {
            return a < b ? a : b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Square(6));
            Console.WriteLine(Factorial(6));
            Console.WriteLine(Reverse(645));
            Console.WriteLine(Addition(10, 20));

            Console.WriteLine(Biggest(10, 20));
            Console.WriteLine(Smallest(10, 20));
        }
    }
}

/* 
 * Method returning values: Refers to a method contains a definition which takes argument
 * compute and return value to the caller
 * */
