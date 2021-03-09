using System;
using System.Collections.Generic;
using System.Text;

namespace NET_Core_Classes
{
    class Program
    {
        static void Main()
        {
            CarSalon salon = new CarSalon();
            salon.AddCar(new Car("Volkswagen", new Engine(1.8), 170, 160));
            salon.AddCar(new Car() { Brand = "Mercedes", Engine = new Engine(2.5), Speed = 120 });
            Console.WriteLine(salon);
            //List<int> li = new List<int>() { 10, 23, 44, 555 };
            //li.Add(100);
            //li.Insert(1, 444);
            //li.AddRange(new int[] { 5, 6, 7 });
            //li.InsertRange(2, new[] { 100, 121 });

            //foreach (var item in li)
            //{
            //    Console.WriteLine($"{item, 7}");
            //}
            //li.Remove(444);
            //li.RemoveAt(0);
            //Console.WriteLine($"After delete : \n{String.Join("\t", li)}");
            //li.RemoveRange(0, 2);
            //li.RemoveAll(x => x / 100 == 0 && x / 10 != 0);
            //Console.WriteLine($"After all delete : \n{String.Join("\t", li)}");

            //StringBuilder sb = new StringBuilder("Test line");

            //sb[0] = 't';
            //sb.Append(12.345);
            //sb.AppendJoin(',', 100, 'a', "text", 3.456);
            //Console.WriteLine(sb.ToString());
            //// sb.Insert(0, );
            //sb.Replace();

            Car car = new Car();
            Console.WriteLine(car.ToString());
            //Console.WriteLine(car.ToString());
            //Console.WriteLine(car.GetType().Name);

            Engine engine = new Engine(5.6);
            Console.WriteLine(engine.ToString());

            engine.Volume = 5;
            Console.WriteLine(engine.Volume);
        }
    }
}
