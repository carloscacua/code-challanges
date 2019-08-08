using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class FirstMissingInteger
    {
        public static int firstMissingPositive(List<int> A)
        {
            var stack = new HashSet<int>();
            foreach (int i in A)
                if (!stack.Contains(i))
                    stack.Add(i);
            for (int i = 1; i <= A.Count; i++)
                if (!stack.Contains(i))
                    return i;

            return A.Count + 1;

        }
    }
}
