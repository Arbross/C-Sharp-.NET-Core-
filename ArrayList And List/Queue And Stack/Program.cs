using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue_And_Stack
{
    class Program
    {
        static void Main()
        {
            Stack st = new Stack(new object[] { "one", 2, "three" });
            st.Push("four");
            while (st != null) // (st.Count > 0)
            {

                Console.WriteLine($" Was removed : {st.Pop()}");
            }
            Print(st);

            Stack<string> stack = new Stack<string>(new string[] { "car", "bike", "plane" }) { };
            stack.Push("Hello World!");
            string[] str = new string[stack.Count];
            stack.CopyTo(str, 0);
            Print(stack);

            Queue queue = new Queue(new object[] { "line", "word", 100, 12 });
            Print(queue);
            queue.Enqueue("back");
            while (queue.Count > 0)
            {
                // queue.Peek();
                Console.WriteLine(queue.Dequeue());
            }
        }
        static void Print(IEnumerable list)
        {
            Console.WriteLine(nameof(list));
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
