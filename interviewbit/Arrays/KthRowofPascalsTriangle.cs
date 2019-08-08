using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class KthRowofPascalsTriangle
    {
        public static List<int> solve(int A)
        {
            if (A++ < 0) return null;

            List<int> result = Enumerable.Repeat(1, A).ToList();
            List<int> prev = Enumerable.Repeat(1, A).ToList();
            for (int i = 0; i < A; i++) 
            {
                for(int j = 0; j <=i; j++) 
                {
                    if (j == 0 || j == i)
                    {
                        result[j] = 1;
                    }
                    else
                    {
                        result[j] = prev[j - 1] + prev[j];
                    }

                }

                prev = result.ToList();
            }

            return result;
        }
    }
}
