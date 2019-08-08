using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cracking.DemoTest2
{
    public static class LinkedListSum
    {
        public static List<int> SolveWithString(List<int> a, List<int> b)
        {
            int sum = getInt(a) + getInt(b);
            return sum.ToString().Select(c => (int)c).ToList();
        }

        private static int getInt(List<int> a) 
        {
            StringBuilder sb1 = new StringBuilder();
            foreach (int e in a)
                sb1.Append(e);
            return Int32.Parse(sb1.ToString());
        }

        public static List<int> SolveAsList(List<int> a, List<int> b)
        {
            List<int> sumList = new List<int>();
            int rest = 0, sum = 0;
            a.Reverse();
            b.Reverse();
            for(int i = 0; i < a.Count || i < b.Count; i++)
            {
                if (i >= a.Count) sum = b[i];
                else if (i >= b.Count) sum = a[i];
                else 
                {
                    sum = a[i] + b[i];
                }
                sum = sum + rest;

                rest = sum >= 10 ? 1 : 0;
                sum = sum % 10;
                sumList.Add(sum);
            }
            if (rest > 0) sumList.Add(rest);
            return sumList;
        }
    }
}
