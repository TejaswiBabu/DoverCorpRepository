using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    interface IDal
    {
        void ConnectToDB();
        void AccessData();
    }
    class SqlDal : IDal
    {
        public void ConnectToDB()
        {
            Console.WriteLine("Connected to MS Sql Server");
        }
        public void AccessData()
        {
            Console.WriteLine("Customer data bougth fromSql server");
        }
    }
    class OraDal : IDal
    {
        public void ConnectToDB()
        {
            Console.WriteLine("Connected to Oracle DB Server");
        }
        public void AccessData()
        {
            Console.WriteLine("Customer data bougth from Oracle DB");
        }
    }

    class Customer
    {
        IDal dal;
        public Customer(IDal dal)
        {
            this.dal = dal;
        }
        public void GetData()
        {
            dal.ConnectToDB();
            dal.AccessData();
        }
    }
    class Program79
    {
        static void Main(string[] args)
        {
            Customer o1 = new Customer(new SqlDal());
            o1.GetData();
            Customer o2 = new Customer(new OraDal());
            o2.GetData();
        }
    }
}
