using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_NET_Core
{
    public class Vehicle
    {
        public string Brand { get; set; }
        internal uint Year { get; set; }
        protected internal uint Speed { get; set; }
        private protected string Upgrade { get; set; }

    }
    class Motocycle : Vehicle
    {
        public void Print()
        {
            Console.WriteLine("Upgrade : ", Upgrade);
        }
    }
}
