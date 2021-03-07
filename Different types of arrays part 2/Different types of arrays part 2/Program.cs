using System;
using System.Linq;

// Jugged arrays
namespace Different_types_of_arrays_part_2
{
    class Program
    {
        static int[] SumByRows(int[][] m)
        {
            int[] arr = null;
            int i = 0;

            foreach (var elem in m)
            {
                arr[i] = elem.Sum();
                    ++i;
            }

            return arr;
        }

        static void PasteRow(int[][] m, int[] arr, int index)
        {
            Array.Resize(ref m, (m.Length + 1));
            //int[][] ma = new int[m.Length][];

            //int ind = 0;
            //for (int i = 0; i < m.Length; i++)
            //{
            //    if (ind == index)
            //    {
            //        ma[i] = arr;
            //    }
            //    else
            //    {
            //        ma[i] = m[ind];
            //        ++ind;
            //    }
            //}

            //for (int i = 0; i < m.Length; i++)
            //{
            //    m[i] = ma[i];
            //}

            for (int i = 0; i < m.Length; i++)
            {
                if (i == index)
                {
                    
                }
            }
        }
        static void ReversByRows(int[][] m)
        {
            for (int i = 0, j = m.Length - 1; i < j; i++, j--)
            {
                var tmp = m[i];
                m[i] = m[j];
                m[j] = tmp;
            }
        }

        static int[][] CreateJugged(params int[] cols)
        {
            int[][] m = new int[cols.Length][];

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[cols[i]];
            }

            return m;
        }

        static void PrintJugged(int[][] matrix)
        {
            for (int i = 0; i < matrix[i].Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j],10}\t");
                }
                Console.WriteLine();
            }
        }

        static void FillRand(int[][] matrix)
        {
            Random rand = new Random();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; ; j++)
                {

                }
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
            const int rows = 3;
            int[][] m = new int[rows][] 
            {
                new int [4] { 1, 2, 3, 4 },
                new[] { 10, 20, 30 },
                new[] { 100, 200 }
            };

            int[][] matrix = CreateJugged(1, 2, 3, 4, 5, 6);

            ReversByRows(matrix);
            PrintJugged(matrix);
        }
    }
}
