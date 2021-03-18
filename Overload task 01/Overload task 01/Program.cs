using System;

namespace Overload_task_01
{
    // + Class : поле Jugged array  int [][] matrix
    // + к-р приймає кількість колонок у кожному рядку як params int []
    // + властивості для читання Rows  get
    // + метод Columns(int row) ???
    // + двовимірний індексатор indexator
    // + заповнення вип числами
    // + ToString()

    class JuggedArray
    {
        private int[][] m = null;
        public JuggedArray(params int[] cols)
        {
            m = new int[cols.Length][];

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[cols[i]];
            }
        }

        public override string ToString()
        {
            string s = null;
            for (int i = 0; i < m.Length; i++)
            {
                s += String.Join("   ", m[i]);
            }
            return s;
        }

        public int[] Columns(int row)
        {
            int[] result = new int[m[row].Length];
            for (int i = 0; i < m[row].Length; i++)
            {
                result[i] = m[row][i];
            }
            return result;
        }
        public int Rows()
        {
            // !!!
            return m?.Length ?? 0;
        }
        public void FillRand(int left, int right)
        {
            Random rand = new Random();

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    m[i][j] = rand.Next(left, right + 1);
                }
            }
        }
        private bool IsValid(int row, int col) => row < 0 || row >= m.Length && col < 0 || col >= m[row].Length;
        public int this[int row, int col]
        {
            get
            {
                if (IsValid(row, col))
                {
                    throw new Exception("Inccorect row");
                }
                return m[row][col];
            }
            set
            {
                if (IsValid(row, col))
                {
                    throw new Exception("Inccorect row");
                }
                m[row][col] = value;
            }
        }

        public void PrintJugged()
        {
            for (int i = 0; i < m[i].Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    Console.Write($"{m[i][j], 10}\t");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main()
        {
            JuggedArray jd = new JuggedArray(5, 6, 5, 4);
            jd.FillRand(0, 10);
            jd[0, 0] = 5;
            Console.WriteLine(jd.ToString());
        }
    }
}
