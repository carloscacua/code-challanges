using System;
using Cracking.Graph;
using System.Collections.Generic;
using System.Linq;

namespace Cracking.DemoTest3
{
    public class SelectionSort
    {
        public static List<int> Sort(List<int> l)
        {
            var result = new List<int>(l.Count);
            int min = int.MaxValue;

            while (l.Any()) 
            {
                min = int.MaxValue;
                for (int i = 0; i < l.Count; i++)
                    if (l[i] < min)
                        min = l[i];

                result.Add(min);
            }
            return result;
        }
    }
}
