using System;
using Cracking.Graph;
using System.Collections.Generic;
using System.Linq;

namespace Cracking.DemoTest3
{
    public class MergeSort
    {
        public static List<int> Sort(List<int> l)
        {
            if (l == null || l.Count <= 1) return l;

            var mid = l.Count / 2;

            var left = l.Take(mid).ToList();
            var right = l.Skip(mid).ToList();

            return Merge(Sort(left), Sort(right));
        }

        public static List<int> Merge(List<int> l, List<int> r) 
        {
            var result = new List<int>(l.Count + r.Count);
            int i = 0, j = 0;

            while(i < l.Count || j < r.Count)
            {
                if (i == l.Count)
                    result.Add(r[j++]);
                else if (j == r.Count)
                    result.Add(l[i++]);
                else
                    result.Add(l[i] < r[j] ? l[i++] : r[j++]);
            }
            return result;
        }
    }
}
