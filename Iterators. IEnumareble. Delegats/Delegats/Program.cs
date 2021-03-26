using System;

namespace Delegats
{
    // delegate
    // static drawTriangular(ConsoleColor c, int  height, char symbol)
    // drawSquare(ConsoleColor c, int height, char  symbol )
    // 1) to one method  2)  group  delegate, multicast, multiaddress
    public delegate void Message(ConsoleColor color, int height, char symbol);
    class Draw
    {
        public static void drawTriangular(ConsoleColor color, int height, char symbol)
        {
            Console.ForegroundColor = color;
            for (int i = 1; i <= height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j < 2 * i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void drawSquare(ConsoleColor color, int height, char symbol)
        {
            Console.ForegroundColor = color;
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Message deleg = new Message(Draw.drawTriangular);
            deleg(ConsoleColor.Red, 10, '*');
            deleg += Draw.drawSquare;
            deleg(ConsoleColor.Green, 5, '*');

            Console.WriteLine();
            foreach (var d in deleg.GetInvocationList())
            {
                Console.WriteLine(d.DynamicInvoke(ConsoleColor.Green, 5, '*'));
            }
        }
    }
}
