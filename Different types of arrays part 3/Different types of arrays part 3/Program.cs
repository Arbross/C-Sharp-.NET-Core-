using System;
using System.Linq;

namespace Different_types_of_arrays_part_3
{
    class Program
    {
        static double AvgArray(params int[] arr)
        {
            return arr.Average();
        }
        static void Main(string[] args)
        {
            int[] arr = new int []{ 5, 6, 5, 5, 74, 53, 1, 56 };
            Console.WriteLine($"{AvgArray(arr)}");
            Console.WriteLine($"{AvgArray(2, 100, 5)}");
        }
    }
}
