using System;
using System.Collections;

namespace _03_Equeals
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 123;
            object obj = value;
            int result = (int)obj;
            Console.WriteLine($"{obj} {result}");

            ArrayList arr = new ArrayList();
            arr.Add("Hello");
            arr.Add(12);

            int[] arrA = { 10, 2, 34 }; // ref1
            int[] arrB = { 10, 2, 34 }; // ref2
            int[] arrC = arrA; // ref1
            Console.WriteLine($"ref arrA == arrB {object.ReferenceEquals(arrA, arrB)}");
            Console.WriteLine($"ref arrA == arrC {object.ReferenceEquals(arrA, arrC)}");

            double? value1 = 23.45;
            double? value2 = 23.45;
            Console.WriteLine($"ref double value1 == value2 {object.ReferenceEquals(value1, value2)}");
            Console.WriteLine($"ref double value1 == value1 {object.ReferenceEquals(value1, value1)}");

            Console.WriteLine($"Equals double value1 == value2 {object.Equals(value1, value2)}");
            Console.WriteLine($"Equals double value1 == value1 {object.Equals(value1, value1)}");
            Console.WriteLine($"Equals double arrA == arrB {object.Equals(arrA, arrB)}"); // false for all classes

        }
    }
}
