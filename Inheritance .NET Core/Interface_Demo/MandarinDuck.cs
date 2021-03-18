using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    class MandarinDuck : Duck
    {
        public new void Fly()
        {
            Console.WriteLine($"Mandarin duck isn't flying bird.");
        }
        //public override void Fly()
        //{
        //    Console.WriteLine($"Mandarin duck isn't flying bird.");
        //}

    }
}
