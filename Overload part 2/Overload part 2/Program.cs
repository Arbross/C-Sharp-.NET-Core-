using _04_Overload;
using System;
using System.Collections.Generic;
namespace Overload_part_2
{
    class Program
    {
        static void Main()
        {
            _04_Overload.Fraction fr3 = new Fraction(15, 2);
            double d = (double)fr3;
            Console.WriteLine($"We convert(implicitly to double) {d}");

            Console.WriteLine($"{fr3}");
        }
    }
}
