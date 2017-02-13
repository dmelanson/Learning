using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilitySample
{
    public interface IMaxTime
    {
        string Get(int A, int B, int C, int D);
    }

    public class MaxTime : IMaxTime
    {
        private int ExtractHighestPossible(List<int> list, int max)
        {
            foreach (int dig in list)
            {
                var matches = list.Where(x => x <= max).OrderBy(x => x);
                if (matches.Count() < 1) return -1;

                var maxDig = matches.Last();
                list.Remove(maxDig);
                return maxDig;
            }

            return -1;
        }

        public string Get(int A, int B, int C, int D)
        {
            var list = new List<int>(new [] { A, B, C, D });

            var endList = new List<int>();
            int max = 0;

            while (endList.Count() < 4)
            {
                switch (endList.Count())
                {
                    case 0:
                        max = ExtractHighestPossible(list, 2);
                        endList.Add(max);
                        break;
                    case 1:
                        var maxDig = endList[0] == 2 ? 3 : 9;
                        max = ExtractHighestPossible(list, maxDig);
                        endList.Add(max);
                        break;
                    case 2:
                        max = ExtractHighestPossible(list, 5);
                        endList.Add(max);
                        break;   
                    case 3:
                        max = ExtractHighestPossible(list, 9);
                        endList.Add(max);
                        break;

                }

                if (max < 0)
                    return "NOT POSSIBLE";
            }

            return string.Format("{0}:{1}", string.Join("", endList.Take(2)), string.Join("", endList.Skip(2).Take(2)));
        }
    }
}
