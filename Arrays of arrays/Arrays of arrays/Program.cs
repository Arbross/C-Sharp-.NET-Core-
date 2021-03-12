using System;
using System.Linq;

// Jugged arrays
namespace Arrays_of_arrays
{
    class Program
    {
        static int[][] CreateJugged(params int[] cols)
        {
            int[][] m = new int[cols.Length][];

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[cols[i]];
            }

            return m;
        }
        static void FillRand(ref int[][] matrix, int left, int right)
        {
            Random rand = new Random();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rand.Next(left, right + 1);
                }
            }
        }

        static void PrintJugged(int[][] matrix)
        {
            for (int i = 0; i < matrix[i].Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j], 10}\t");
                }
                Console.WriteLine();
            }
        }
        static int SumJugged(int[][] matrix)
        {
            int sum = 0;

            foreach (int[] line in matrix)
            {
                foreach (int elem in line)
                {
                    sum += elem;
                }
            }

            return sum;
        }
        static void Main()
        {
            int[][] matrix = CreateJugged(0, 0, 0, 0);
            FillRand(ref matrix, 0, 10);
            
            PrintJugged(matrix);
        }
    }
}