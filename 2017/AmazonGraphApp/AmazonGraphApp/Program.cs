using System;

namespace AmazonGraphApp
{
    class Program
    {

        public static void visit(int[][] ar, bool[,] v, int i, int j)
        {
            int size = ar.Length;
            if (ar[i][j] == 1)
            {
                v[i,j] = true;
                if (j > 0 && i < size - 1)
                {
                    visit(ar, v, i + 1, j - 1); // SouthWest
                }
                if (i < size - 1)
                {
                    visit(ar, v, i + 1, j); // South
                    if (j < size - 1)
                        visit(ar, v, i + 1, j + 1); // SouthEast
                }
                if (j < size - 1)
                    visit(ar, v, i, j + 1); // East
            }
        }

        static void Main(string[] args)
        {
            int count = 0;
            var ar = new int[][] {  new int[]{1, 1, 0, 0, 0},
                                    new int[]{0, 0, 0, 0, 1},
                                    new int[]{1, 0, 0, 1, 1},
                                    new int[]{1, 1, 1, 0, 1},
                                    new int[]{1, 0, 1, 0, 1} };

            var n = ar.Length;
            var v = new bool[5,5];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    v[i,j] = false;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ar[i][j] == 1 && !v[i,j])
                    {
                        count++;
                        visit(ar, v, i, j);
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
