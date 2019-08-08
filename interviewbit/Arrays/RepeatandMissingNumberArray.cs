using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class RepeatandMissingNumberArray
    {
        public static List<int> repeatedNumber(List<int> A)
        {
            var set = new HashSet<int>(A);
            int a = -1, b = -1;

            foreach (int e in A)
            {
                if (set.Contains(e))
                    a = e;
                else
                    set.Add(e);
            }

            for (int i = 1; i <= A.Count; i++)
            {
                if (!set.Contains(i))
                {
                    b = i; break;
                }

            }

            return new List<int> { a, b };

        }
    }

}
