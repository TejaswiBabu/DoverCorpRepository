using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    //Display wishes based on time
    class Program11
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12) Console.WriteLine("Good Morning!");
            else if (hour < 16) Console.WriteLine("Good Afternoon");
            else Console.WriteLine("Good evening!");

            string day = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower();
            if (day == "sat" || day == "sun")
                Console.WriteLine("Today is weekend and busy with family");
            else
                Console.WriteLine("Today is weekday and enjoying the office works");

        }
    }
}
