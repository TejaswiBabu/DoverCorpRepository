using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    abstract class Employee
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public Employee()
        { }
        public Employee(int Id, string EName)
        {
            this.Id = Id; this.EName = EName;
        }
        public abstract double CalculateBonus(int salary);
        public void GetDetails()
        {
            Console.WriteLine($"{Id} {EName} ");
        }
    }
    class PermnantEmployee : Employee
    {
        public PermnantEmployee()
        {
        }
        public PermnantEmployee(int Id, string EName) : base(Id, EName)
        { }
        public override double CalculateBonus(int salary)
        {
            return salary * 0.1;
        }
    }

    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {
        }
        public TemporaryEmployee(int Id, string EName) : base(Id, EName)
        { }
        public override double CalculateBonus(int salary) //extension and valid
        {
            return salary * 0.05;
        }
    }
    class ContractEmployee : Employee
    {
        public ContractEmployee()
        {
        }
        public ContractEmployee(int Id, string EName) : base(Id, EName)
        { }
        public override double CalculateBonus(int salary)
        {
            return salary * 0.09;
        }
    }
    class pROGRAM75
    {
        static void Main(string[] args)
        {
            Employee e1 = new PermnantEmployee(1001, "Meghana");
            Employee e2 = new TemporaryEmployee(1002, "Kiran");
            Employee e3 = new ContractEmployee(1003, "Rani");
            e1.CalculateBonus(25000); e2.CalculateBonus(20000); e3.CalculateBonus(15000);
            e1.GetDetails();
            e2.GetDetails();
            e3.GetDetails();
            Console.ReadKey();
        }

    }
}

/*
 Open Closed Principle(OCP)
In the project, software entities such as classes, modules, functions, etc., should be open for extension but closed for modification.
The new features should be implemented by adding classes, attributes and methods, instead of changing the existing one. 
 */