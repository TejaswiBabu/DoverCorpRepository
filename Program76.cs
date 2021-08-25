using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Singleton
    {
        private static Singleton instance = null;
        public static Singleton Instanitate()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
        public void GetDetails(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program76
    {
        static void Main(string[] args)
        {
            Singleton o1 = Singleton.Instanitate();
            o1.GetDetails("From Training");

            Singleton o2 = Singleton.Instanitate();
            o2.GetDetails("From Developement");
        }
    }
}
