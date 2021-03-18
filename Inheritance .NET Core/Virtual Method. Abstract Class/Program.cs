using System;
using System.Collections.Generic;

namespace Virtual_Method._Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car(brand : "Audi", power : 7.2);
            Console.WriteLine(car);
            car.Move();
            car.Repair();
            Car c = car as Car;
            if (c != null)
            {
                Console.WriteLine(c.Power++);
                c.Repair();
            }
            List<Transport> transports = new List<Transport>() { car, new Lorry() };
            foreach (var item in transports)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
