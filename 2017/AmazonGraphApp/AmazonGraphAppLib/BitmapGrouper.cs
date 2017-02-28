using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazonGraphAppLib
{


    public class BitmapGrouper
    {
        private HashSet<Tuple<int, int>> Visited = new HashSet<Tuple<int, int>>();
        int count;


        public void CheckBit(int[][] ar, int x, int y, bool newGroup)
        {
            if (Visited.Contains(new Tuple<int, int>(x, y)))
                return;

            Visited.Add(new Tuple<int, int>(x, y));

            if (ar[x][y] == 0)
                return;

            if (newGroup)
                count++;

            var neighbors = AdjacentElements<int>(ar, x, y).ToArray();

            foreach(var neighbor in neighbors)
            {
                CheckBit(ar, neighbor.Item1, neighbor.Item2, false);
            }
        }

        public static IEnumerable<Tuple<int, int>> AdjacentElements<T>(T[][] arr, int row, int column)
        {
            int rows = arr.Length;
            int columns = arr[0].Length;

            for (int j = row - 1; j <= row + 1; j++)
                for (int i = column - 1; i <= column + 1; i++)
                    if (i >= 0 && j >= 0 && i < columns && j < rows && !(j == row && i == column))
                        yield return new Tuple<int, int> (j, i);
        }


        public int GetGroupCountFromBitmap(int[][] ar)
        {
            var n = ar.Length;

            for (int i = 0; i < n; i++)
            {
                var width = ar[i].Length;
                for (int j = 0; j < width; j++)
                {
                    CheckBit(ar, i,j, true);
                }
            }
            return count;
        }
    }
}
