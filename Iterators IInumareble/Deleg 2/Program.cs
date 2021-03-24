using System;

namespace Deleg_2
{
        delegate bool MyPredicate(int number);
    static class ArrayExtention
    {
        public static int CountElements(this int[] arr, MyPredicate predicate)
        {
            int counter = 0;
            foreach (var i in arr)
            {
                if (predicate(i))
                {
                    ++counter;
                }
            }
            return counter;
        }
    }
    class Program
    {
        
        static bool IsNegitive(int number)
        {
            return number < 0;
        }
        static bool IsPositive(int number)
        {
            return number > 0;
        }
        
        static void Main()
        {
            int[] arr = { 10, -2, -3, 22, 33, 44 };
            // Console.WriteLine(CountElements(arr, IsNegitive));
            // Console.WriteLine(CountElements(arr, x => x % 2 == 0));

            Console.WriteLine(arr.CountElements(x => x % 5 == 0));
        }
    }
}
