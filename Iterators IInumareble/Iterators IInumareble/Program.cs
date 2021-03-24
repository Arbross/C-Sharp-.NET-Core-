using System;

namespace Iterators_IInumareble
{
    class Program
    {
        static void Main()
        {
            string str = "Hello IEnumerable!";
            foreach (var c in str)
            {
                Console.Write(c + " ");
            }
            CharEnumerator rn = str.GetEnumerator();
            while (rn.MoveNext())
            {
                Console.Write(rn.Current + "_");
            }
            rn.Reset();
            while (rn.MoveNext())
            {
                Console.Write(rn.Current + ".");
            }
        }
    }
}
