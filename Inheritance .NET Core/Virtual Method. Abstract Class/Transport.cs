using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Method._Abstract_Class
{
    abstract class Transport
    {
        public string Brand { get; set; }
        public abstract void Move();
        public abstract byte Places { get; } // property
        public Transport(string Brand = "NoBrand")
        {
            this.Brand = Brand;
        }
        public void Repair()
        {
            Console.WriteLine($"Repair {Brand}....");
        }
        public override string ToString()
        {
            return $"Type : {GetType().Name}, Brand : {Brand}, Places : {Places}";
        }
    }
    class Car : Transport
    {
        public double Power { get; set; }
        public Car(string brand = "NoBrand", double power = 0.0f)
            : base(brand)
        {
            this.Power = power;
        }
        public override void Move()
        {
            Console.WriteLine($"Car '{Brand}' moves by road.");
        }
        public override byte Places => 4;
        public override string ToString()
        {
            return base.ToString() + $"\t Power : {Power}";
        }
        public new void Repair()
        {
            base.Repair();
            Console.WriteLine($"Car::Repair::");
        }
    }
    class Lorry : Car
    {
        public override byte Places => 2;
    }
}
