using System;

namespace Arrays_.NET_main
{
    class Program
    {
        static void FillRand(int[] arr, int left = 0, int right = 100)
        {
            Random rand = new Random(); // srand(base)

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(left, right);
            }
        }

        static void PrintArray(int[] arr, string prompt = "")
        {
            Console.WriteLine(prompt);
            // Only to read (its really man)
            foreach (var elem in arr) // var = auto C++
            {
                Console.Write(elem + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = null;
            Console.Write("Enter array size : ");
            int size = int.Parse(Console.ReadLine());

            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Wrong size! Try again!");
            }

            arr = new int[size];
            int []arr2 = new int[arr.Length * 2];
            FillRand(arr);
            PrintArray(arr, "Array : ");

            Array.Clear(arr, 0, arr.Length / 2);
            PrintArray(arr, "Array (auto clear) : ");
            arr.CopyTo(arr2, 2);
            PrintArray(arr2, "Array 2 : ");

            Array.Copy(arr, 1, arr2, 4, 5);
            PrintArray(arr2, "Array (Array.Copy(...);) : ");

            Console.WriteLine("Enter value for search : ");
            int value = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(arr, value);

            if (index != -1)
            {
                Console.WriteLine($"Value {value} found in index {index}");
            }
            else {
                Console.WriteLine($"Value {value} not found");
            }

            int limit = 20;
            Array.Fill(arr, 5, 0, 5);
            index = Array.FindIndex(arr, (int e) => { return e > limit; });
            Console.WriteLine($"Index of first positive number int arr : {index}");

            index = Array.FindIndex(arr, e => e % 5 == 0);
            Console.WriteLine($"Index of first number dividable int arr : {index}");

            Array.Resize(ref arr, arr.Length + 1);
            arr = new int[11];
            
            Array.Sort(arr);
            Array.Sort(arr, (x, y) => -x.CompareTo(y));

            //string[] products = { "apple", "milk", "jujubes" };
            //double[] prices = { 20, 22.4, 28.9, 15.5 };
            //Array.Sort(prices, products);

            //for (int i = 0; i < prices.Length; i++)
            //{
            //    Console.WriteLine($"Names : {products[i], 10}, Prices : {prices[i], 10}");
            //}

            //PrintArray(arr, "Sorted : ");

        }
    }
}
