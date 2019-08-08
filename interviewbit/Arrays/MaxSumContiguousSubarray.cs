using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class MaxSumContiguousSubarray
    {
        public static int MaxSubArray(List<int> A)
        {
            int max_so_far = A[0];
            int curr_max = A[0];

            for (int i = 1; i < A.Count; i++)
            {
                curr_max = Math.Max(A[i], curr_max + A[i]);
                max_so_far = Math.Max(max_so_far, curr_max);
            }

            return max_so_far;
        }
    }
}
