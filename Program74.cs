using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    interface IPrintScanTasks
    {
        void PrintContent(string content);
        void ScanContent(string content);
        void PhotoCopyContent(string content);
    }
    interface IFaxTasks
    {
        void FaxContent(string content);
    }
    interface IDuplexTaskx
    {
        void PrintDuplexContent(string content);
    }
    class HpPrinter : IPrintScanTasks, IFaxTasks
    {
        public void FaxContent(string content)
        {
            Console.WriteLine("Can Send fax to the destination");
        }
        public void PhotoCopyContent(string content)
        {
            Console.WriteLine("Can take xerox copy");
        }
        public void PrintContent(string content)
        {
            Console.WriteLine("Can take a printout");
        }
        public void ScanContent(string content)
        {
            Console.WriteLine("Can scan content to system");
        }
    }
    class CanonPrinter : IPrintScanTasks, IDuplexTaskx
    {
        public void PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }
        public void PrintContent(string content)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplexContent(string content)
        {
            throw new NotImplementedException();
        }
        public void ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
    class Program74
    {

    }
}
/*
 Interface Segregation Principle(ISP)
No Client should be forced to dependent methods if does not use itno
This principle states that any client should not be forced to use an interface which is irrelevant to it.
*/