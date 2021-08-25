using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class EmpModel
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }
    class Program71
    {
        static void Main(string[] args)
        {
            List<EmpModel> employees = new List<EmpModel>();
            {
                new EmpModel { Id = 1001, EName = "Bhardwaj", Job = "Trainer", Salary = 30000 };
                new EmpModel { Id = 1002, EName = "Bhaskar", Job = "Developer", Salary = 32000 };
                new EmpModel { Id = 1003, EName = "Poornima", Job = "Programmer", Salary = 35000 };
                new EmpModel { Id = 1004, EName = "Kiran", Job = "Trainer", Salary = 30000 };
                new EmpModel { Id = 1005, EName = "Nishit", Job = "Developer", Salary = 25000 };
            };
            // List <EmpModel> employees = new List<EmpModel>();
            //employees.Add(e1);
            //employees.Add(e2);
            //employees.Add(e3);
            //employees.Add(e4);
            //employees.Add(e5);

            foreach (EmpModel e in employees)
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");

          /*  Console.WriteLine($"{e1.Id} {e1.EName} {e1.Job} {e1.Salary}");
            Console.WriteLine($"{e2.Id} {e2.EName} {e2.Job} {e2.Salary}");
            Console.WriteLine($"{e3.Id} {e3.EName} {e3.Job} {e3.Salary}");
            Console.WriteLine($"{e4.Id} {e4.EName} {e4.Job} {e4.Salary}");
            Console.WriteLine($"{e5.Id} {e5.EName} {e5.Job} {e5.Salary}");*/


        }
    }
}
