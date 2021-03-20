using System;

namespace Enums
{
    class Program
    {
        enum Color : byte { Red = 1, Green, Blue, Orange}
        static void Main()
        {
            //Color color = Color.Green;
            //Console.WriteLine($"{color} : {(byte)color}");

            //Console.WriteLine("Input color(enum) : ");
            //if (Enum.TryParse<Color>(Console.ReadLine(), out color))
            //{
            //    Console.WriteLine($"OK parse : {color}");
            //    if (Enum.IsDefined(typeof(Color), color))
            //    {
            //        Console.WriteLine($"{color} exists");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{color} is not exist");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Bad parse");
            //}

            //string[] nameColor = Enum.GetNames(typeof(Color));
            //for (int i = 0; i < nameColor.Length; i++)
            //{
            //    Console.WriteLine($"\t\t{nameColor[i]}");
            //}
            //var colors = Enum.GetValues(typeof(Color));
            //foreach (Color c in colors)
            //{
            //    Console.WriteLine($"{c} ----- {(byte)c}");
            //}
            // Task : get all consts from std enum ConsoleColor (16 values), display and color line by it
            

            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("Hello world!");
                Console.ForegroundColor = colors[i];
                System.Threading.Thread.Sleep(50);
            }

            ConsoleColor[] new_colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("Hello world!");
                Console.BackgroundColor = colors[i];
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
