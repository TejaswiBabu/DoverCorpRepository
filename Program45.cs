using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    interface IEmail
    {
        void Compose();
        void Inbox();
    }
    class GEmail: IEmail
    {
        public void Compose()
        {
            Console.WriteLine("Code to send email");
            Console.WriteLine("This feature helps to write emails");
        }
        public void Inbox()
        {
            Console.WriteLine("Code to have inbox");
            Console.WriteLine("This feature help to read received email");
        }
    }
    class Program45
    {
        static void Main(string[] args)
        {
            IEmail email;
            email = new GEmail();
            email.Compose();
            email.Inbox();
        }
    }
}
