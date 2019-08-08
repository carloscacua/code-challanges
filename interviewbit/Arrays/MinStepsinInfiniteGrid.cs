using System;
using System.Collections.Generic;
using System.Linq;

namespace interviewbit.Arrays
{
    public static class MinStepsinInfiniteGrid
    {
        public static int coverPoints(List<int> A, List<int> B)
        {
            var steps = 0;
            int? previousA = A.FirstOrDefault(), previousB = B.FirstOrDefault();
            for (int i = 1; i < A.Count && i < A.Count; i ++) 
            {
                steps += Math.Max(Math.Abs(A[i] - previousA.Value), Math.Abs(B[i] - previousB.Value));
                previousA = A[i];
                previousB = B[i];
            }

            return steps;
        }
    }
}
