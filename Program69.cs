using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp01
{
    class Program69
    {
        static void Main(string[] args)
        {


            List<string> names = new List<string> { "Sai", "Om", "Kiran", "Ashok", "Ganesh", "Raju", "Mahesh", "Suresh" };

            //var query = from name in names select name;
            //var query = from name in names orderby name select name;
            //var query = from name in names orderby name descending select name;
            //var query = from name in names orderby name.Length select name;
            //var query = from name in names orderby name.Length descending select name;
            //var query = from name in names where name.Length==5 select name;

            //var query = names.Where(x => x.Length == 5);

            var query = names.Take(3).Where(x => x.Length < 5);

            foreach (string item in query)
                Console.WriteLine(item); ;

        }
    }
}
