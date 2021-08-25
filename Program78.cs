using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    interface IItem
    {
        string Cook();
    }
    class NonVeg : IItem
    {
        private string dish;
        public NonVeg(string dish)
        {
            this.dish = dish;
        }
        public string Cook()
        {
            return "Non Veg " + dish + " cooked, ready and start eating";
        }
    }
    class Veg : IItem
    {
        private string dish;
        public Veg(string dish)
        {
            this.dish = dish;
        }
        public string Cook()
        {
            return "Veg " + dish + " cooked, ready and start eating";
        }
    }
    class ExpertCook
    {
        IItem item;
        public ExpertCook(IItem item)
        {
            this.item = item;
        }
        public void StartEating()
        {
            if (this.item == null)
                Console.WriteLine("Dish not available, sorry");
            else
                Console.WriteLine(item.Cook());
        }
    }


    class Program78
    {
        static void Main(string[] args)
        {
            ExpertCook ck1 = new ExpertCook(new NonVeg("Chilli Chicken"));
            ExpertCook ck2 = new ExpertCook(new Veg("French fries"));
            ck1.StartEating();
            ck2.StartEating();
        }
    }
}
