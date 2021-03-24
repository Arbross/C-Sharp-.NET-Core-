using System;

namespace Task_IEnumerator
{
    class Program
    {
        static void Main()
        {
            Fibonachi f = new Fibonachi();
            foreach (var item in f)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
