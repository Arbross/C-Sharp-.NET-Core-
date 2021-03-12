using System;

namespace _02_Null_.Net_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable<ValueType>
            // int ? - скорочення nullable
            int? value = null; // null;
            if (value.HasValue)
            {
                value *= 2;
                Console.WriteLine($"Value {value}");
            }
            else
            {
                Console.WriteLine($"Value hasn't value(null)");
            }
            Console.WriteLine($"Default {value.GetValueOrDefault()}");
            Console.WriteLine($"Value or default {value.GetValueOrDefault(1111)}");

            int? value2 = 500;
            // int sum = (value + value2).GetValueOrDefault();
            int? sum = value + value2;
            Console.WriteLine($"Sum = {sum ?? 0}");
        }
    }
}
