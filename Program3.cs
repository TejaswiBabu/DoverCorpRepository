using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program3
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a letter: ");
                char ch = Convert.ToChar(Console.ReadLine());

                Console.WriteLine($"Given letter is: {ch}");
                if (ch >= 65 && ch <= 90)
                    Console.WriteLine($"{ch} is capital letter alphabet");
                else if (ch >= 97 && ch <= 122)
                    Console.WriteLine($"{ch} is small letter alphabet");
                else if (ch >= 48 && ch <= 57)
                    Console.WriteLine($"{ch} is digit");
                else
                    Console.WriteLine($"{ch} is spl letter");
            }
        }
    }

    /*
     character refers to any letter including alphabet, digit, special letters
      ASCII value for every letter
    A - Z   are 65 to 90
    a - z are 97 to 122
    0 - 9  are 48 to 57 
     */
