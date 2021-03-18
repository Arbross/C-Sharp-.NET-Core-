using System;
using Inheritance_NET_Core;

namespace Use_Vehicle
{
    class Program
    {
        class Car : Vehicle
        {
            public void Print()
            {
                Console.WriteLine("Car with speed : ", Speed);
            }
        }
        static void Main()
        {
            Vehicle vehicle = new Vehicle() { Brand = "Loli" };
            vehicle.ToString();
        }
    }
}
