using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListAndList
{
    class Program
    {
        class ComparerArrayList : IComparer
        { 
            public int Compare(object x, object y)
            {
                if (x.GetType() == y.GetType())
                {
                    if (x is int)
                    {
                        return ((int)x).CompareTo(y);
                    }
                    else if (x is double)
                    {
                        return ((double)x).CompareTo(y);
                    }
                    else if (x is string)
                    {
                        return ((string)x).CompareTo(y);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            // generic - 'template'
            // C++ sorted set, map, multiset<>, multimap<> 
            // nongeneric - неузагальнені колекції(object) ArrayList, SortedList(pair(object key, object value), )
            // generic List<>, SortedList<TKey, Value>, Dictionary<TKey, Tvalue>, SortedDictionary<TKey, TValue>, HashSet<>

            Tuple<int, string, double> d = new Tuple<int, string, double>(0, "", 0); // immuteble
            // ValueTuple<>


            ArrayList arrayList = new ArrayList(10) { 10, 12, "hello", "two", 4.5 };
            ArrayList arrayList1 = new ArrayList(10) { 11, 654, "hello", "two", 4.5 };
            arrayList = arrayList1;
            arrayList.Add("one");
            arrayList.AddRange(new int[] { 100, -200 });
            arrayList.Insert(1, "New");
            arrayList.InsertRange(1, new[] { "apple", "berry" });
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(arrayList.Capacity);
            arrayList.Remove("apple");
            arrayList.RemoveAt(0);
            arrayList.RemoveRange(1, 2);
            Console.WriteLine("\nAfter remove : ");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(arrayList.Capacity);
            arrayList.Sort(new ComparerArrayList());
            arrayList.Clear();

            List<int> list = new List<int>() { 10, 23, 11, 20 };
            list.RemoveAll(x => x % 2 == 0);
            Console.WriteLine("\nAfter remove % 2 == 0 : ");
            Print(list);
        }
        static void Print(IEnumerable list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
