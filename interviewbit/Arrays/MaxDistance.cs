using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class MaxDistance
    {
        public static int maximumGap(List<int> A)
        {
            if (A == null || A.Count<=0) return -1;

            int[] left = new int[A.Count];
            int[] right = new int[A.Count];

            left[0] = A[0];
            for (int k = 1; k < A.Count; k++)
                left[k] = A[k] < left[k - 1] ? A[k] : left[k - 1];

            int n = A.Count-1;
            right[n] = A[n];
            for (var k = n-1; k >=0 ; k--)
                right[k] = A[k] > right[k + 1] ? A[k] : right[k + 1];

            int i = 0, j = 0;

            var maxDiff = -1;

            while(i <= n && j <=n) 
            {
                 if(left[i] <= right[j]) 
                 {
                    maxDiff = maxDiff < j - i ? j - i : maxDiff;
                    j++;
                }
                else 
                {
                    i++; 
                }

            }
            return maxDiff;

        }
    }
}
