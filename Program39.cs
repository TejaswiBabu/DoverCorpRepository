using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    enum VehicleType
    {
        TwoWheeler, FourWheeler
    }


    class Parking
    {
        private VehicleType type;
        private int capacity, count, amount, price;
        public Parking(VehicleType type, int count)
        {

            if (type == VehicleType.TwoWheeler)
            {
                capacity = count > 150 ? 150 : count;
                this.count = count > 150 ? 150 : count;
                price = 20;
            }
            else if (type == VehicleType.FourWheeler)
            { capacity = 40; ; price = 40; }
            this.type = type;
            
            this.amount = this.count * this.price;
        }

        public void AddCount(int count)
        {
            int availableCount = this.capacity - this.count;
            if (count > availableCount)
                Console.WriteLine($"You cannot add more than {availableCount}");
            else
            {
                this.count += count;
                Console.WriteLine($"{count}Vehicles added successfully...");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"Type is: {this.type.ToString()} , Capacity:{this.capacity}, " +
            $"Count is: {this.count} Price: {this.price}, Amount: {this.amount}");
        }
    }

    class Program39
    {
        static void Main(string[] args)
        {
                Parking tw = new Parking(VehicleType.TwoWheeler, 200);
            Parking fw = new Parking(VehicleType.FourWheeler, 12);

            tw.GetDetails();
            fw.GetDetails();

                tw.AddCount(2);
        }
    }
}
