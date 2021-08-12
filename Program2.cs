using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string fullName = Console.ReadLine();
            string firstName = fullName.Substring(0, fullName.IndexOf(" "));
            string lastName = fullName.Substring(fullName.LastIndexOf(" ")+1);

            Console.WriteLine($"Hello {fullName}");
            Console.WriteLine($"First name is: {firstName}");
            Console.WriteLine($"Last Name is {lastName}");
        }
    }
}
/*
 Naming Convention: while writing programmable code, we have to follow naming convention to identify the code 
ClassName, MethodName or any TypeName should be in PascalCase(1st letter should be capital

keywords will be in lowercase
Contsants will be in UPPERCASE

variable names will be camelCaseNotation
*/

