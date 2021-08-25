using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp01
{
    class Program57
    {
        static void Main(string[] args)
        {
          //string[] items = new string[] { "flower", "plate", "fruit", "picture", "dish" };
          //List<string> items = new List<string> { "paper", "per", "eraser", "Sharpner" };
            //int[] items = new int[] {100,200, 300, 400, 500};

            List<int> items = new List<int> { 100, 200, 300, 400, 500 };
            var query = from item in items select item;

            foreach(var item in query)
            {
                Console.WriteLine(item);
            }

        }
    }
}

/*Linq: Language Integrated Query
 * Line enable us to interact with datasource  with a single syntax 
 Data sources like like array, collection, file, database, etc., 
In order to use linq feature we can use following ways
a) Sql like queries
b) Linq like queries
 */


