using System;

namespace Different_types_of_matrix
{
    class Program
    {
        static void FillRand(ref int[,] m, int left = 0, int right = 100)
        {
            Random rand = new Random();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rand.Next(left, right + 1);
                }
            }
        }
        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.WriteLine($"{m[i, j]}\t");
                }
            }
        }

        static int maxInMatrix(int[,] m)
        {
            int max = m[0, 0];
            foreach (var elem in m)
            {
                if (max < elem)
                {
                    max = elem;
                }
            }

            return max;
        }
        static int minInMatrix(int[,] m)
        {
            int min = m[0, 0];
            foreach (var elem in m)
            {
                if (min > elem)
                {
                    min = elem;
                }
            }

            return min;
        }

        static void Main(string[] args)
        {
            const int rows = 2, cols = 3;
            int[,] matrix = new int[rows, cols] { { 1, 2, 3 }, { 1, 2, 4 } };

            FillRand(ref matrix, 0, 100);
            PrintMatrix(matrix);

            Console.WriteLine($"Max : {maxInMatrix(matrix)}, Min : {minInMatrix(matrix)}");

            //int sum = 0;
            //foreach (var elem in matrix)
            //{
            //    if (elem > 0)
            //    {
            //        sum += elem;
            //    }
            //}
        }
    }
}
