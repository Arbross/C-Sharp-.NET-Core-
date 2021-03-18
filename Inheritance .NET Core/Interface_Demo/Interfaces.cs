using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    interface IMove
    {
        static int demo = 100;
        void Move();
    }
    interface IFly : IMove
    {
        void Fly();
        ushort Height { get; set; }
    }
    interface ISwim
    {
        void Move();
    }

}
