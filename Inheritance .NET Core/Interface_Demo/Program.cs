using System;

namespace Interface_Demo
{
    class Program
    {
        static void Main()
        {
            Duck duck = new Duck() { Height = 500 };
            duck.Fly();
            // duck.Move();
            IFly ifl = duck;
            ifl.Move();
            (duck as ISwim).Move();
            Duck md = new MandarinDuck() { Height = 10 };
            (md as MandarinDuck).Fly();
            IMove.demo++;
            Console.WriteLine(IMove.demo);
            // md.Fly();
        }
    }
}
