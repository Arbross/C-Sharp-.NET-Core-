using System;

/*-------------Одновимірні масиви C #---------------------------------------------
7. Перерозташувати елементи у масиві( відємні, потім невідємні) у порядку їх  слідування. 
Для масиву : 2  1 -4  -55  -7 100 10
Повинні отримати змінений масив: -4  -55  -7  2 1 100 10
Використати FindAll(), CopyTo().

8. Вводиться число. Масив заповнити випадковими числами. Знайти кількість входжень у масив введеного числа.
Скористатися Count() з System.Linq

9. Визначити суму елементів, розміщених між максимальним та мінімальним елементом масиву.
Користуватися методами (Max, Min, IndexOf)

-----10. Створити 2 паралельних масиви: назви та ціни  тoварів. Впорядкувати масиви по зростанню ціни(Sort(keys, values)).*/

namespace Array_task__and_funcs_
{
    class Program
    {
        // Print array
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
        // Task 7
        public static void ChangePlaceOn(int[] arr)
        {
            int[] new_arr_minus = Array.FindAll(arr, e => e < 0);
            new_arr_minus.CopyTo(arr, 0);

            int[] new_arr_plus = Array.FindAll(arr, e => e > 0);
            new_arr_plus.CopyTo(arr, new_arr_minus.Length);
        }
        // Task 8
        public static void CountOfComeIn(int[] arr)
        {
            Random rand = new Random(); // srand(base)

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, -4, -55, -7, 100, 10 };


            PrintArray(arr, "Array : ");
            ChangePlaceOn(arr);
            PrintArray(arr, "Changed array : ");
        }
    }
}
