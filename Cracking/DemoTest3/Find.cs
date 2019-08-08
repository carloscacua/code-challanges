using System;
using Cracking.Graph;
using System.Collections.Generic;
using System.Linq;

namespace Cracking.DemoTest3
{
    public class Find
    {
        public static int Solve(List<int> l, int k)
        {
            if (l == null || k > l.Count)
                return -1;

            l.Sort();
            return l[l.Count - k - 1];
        }

        public static int SolveQuickSort(List<int> l, int k) 
        {
            if (l == null || k > l.Count)
                return -1;

            int mid = l.Count / 2;

            var result = Partition(l, l[mid]);

            if(result.Item2.Count > k)
            {
                return SolveQuickSort(result.Item2, k);
            }
            else if (result.Item2.Count == k) 
            {
                return result.Item2.Min();
            }
            else 
            {
                return SolveQuickSort(result.Item1, k - result.Item1.Count);
            }
        }

        private static (List<int>, List<int>) Partition(List<int> l, int pivot)
        {
            var left = new List<int>();
            var right = new List<int>();
            foreach (var x in l)
                if (x <= pivot) left.Add(x);
                else right.Add(x);

            return (left, right);
        }

    }
}
