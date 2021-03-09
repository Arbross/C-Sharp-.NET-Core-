using System;
using System.Collections.Generic;
using System.Text;

namespace NET_Core_Classes
{
    // Internal = видно у межах збiрка
    // public is for all view
    class Engine
    {
        
        double volume;
        public Engine(double volume)
        {
            this.volume = volume;
        }
        public double Volume // full property
        { 
            get { return volume; } 
            /*protected*/ set 
            {
                if (value > 0)
                {
                    volume = value;
                }
            } 
        }
        //public override string ToString()
        //{
        //    return $"Engine with volume : {volume}";
        //}
        // arrow syntax
        public override string ToString() => $"Engine with volume : {volume}";
    }
    /*internal*/ class Car
    {
        private string brand;
        public string Brand
        {
            get => brand; // \t ' ' \n
            set => brand = String.IsNullOrWhiteSpace(value) ? "NoBrand" : value;
        }
        uint speed;
        // public const uint MAX_SPEED = 360; // static
        public readonly uint MaxSpeed = 360;
        public readonly uint ID;
        private static uint counter = 0;
        static Car()
        {
            counter = (uint)new Random().Next(1000, 2000);
        }
        public Car(string brand, Engine engine, uint speed = 0, uint maxSpeed = 360)
        {
            MaxSpeed = maxSpeed;
            Brand = brand;
            Speed = speed;
            this.Engine = engine;
            ID = ++counter;
        }
        public Car() : this("NoBrand", default(Engine), 0, 360) { }
        public uint Speed
        {
            get => speed;
            set => speed = value > MaxSpeed ? MaxSpeed : value;
        }
        public Engine Engine { get; /*protected*/ set; }
        public override string ToString() => $"ID : {ID}\t Brand : {Brand}\t Speed: {Speed}\t Engine : {Engine?.ToString()}";
    }
}
