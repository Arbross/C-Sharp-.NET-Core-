using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    class Duck : IFly, ISwim
    {
        public const ushort MaxHeight = 700;
        private ushort height;
        public ushort Height 
        {
            get => height;
            set => height = value > MaxHeight ? MaxHeight : value; 
        }

        public void Fly()
        {
            Console.WriteLine($"Duck is flying on height {height}.");
        }
        //virtual public void Fly()
        //{
        //    Console.WriteLine($"Duck is flying on height {height}.");
        //}
        // cant be public (true realisation(yavna))
        public void Move()
        {
            Console.WriteLine("Duck moves on land and on air.");
        }
        void ISwim.Move()
        {
            Console.WriteLine("Duck moves on land and on air and swim.");
        }
        void IMove.Move()
        {
            Console.WriteLine("Duck moves on land and on air! and swim.");
        }
    }
}
