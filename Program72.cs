using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp01
{
    class Program72
    {
        static void Main(string[] args)
        {
            EmployeeBO context = new EmployeeBO();
            List<EmpModel> employees;

            employees = context.GetAllEmployees().Where(x => x.Job == "Developer").ToList();

            foreach (EmpModel e in employees)
                Console.WriteLine($"{e.Id} {e.EName} {e.Job}");
        }
    }
}
