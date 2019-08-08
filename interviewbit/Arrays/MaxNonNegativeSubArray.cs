using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class MaxNonNegativeSubArray
    {
        public static List<int> Solve(List<int> A)
        {
            int localStart = 0, localEnd = 0, start = -1, end = -1, currentLengt = 0, maxLenght = 0;
            ulong currentMax = 0, globalMax = 0;

            for (int i = 0; i < A.Count; i++)
            {
                if(A[i] < 0) 
                {
                    localStart = localEnd = i + 1;
                    currentMax = 0;
                    currentLengt = 0;
                    continue;
                }
                else
                {
                    currentMax = currentMax + (ulong)A[i];
                    localEnd++;
                    currentLengt++;
                }

                if(currentMax > globalMax) 
                {
                    start = localStart;
                    end = localEnd;
                    globalMax = currentMax; 
                }else if (currentMax == globalMax && currentLengt > maxLenght) 
                {
                    start = localStart;
                    end = localEnd;
                    globalMax = currentMax;
                    maxLenght = currentLengt;
                }
                else 
                {
                    var temp = -1; 
                }
            }

            return start >=0 && end >=0 ? A.Skip(start).Take(end -start).ToList() : new List<int>();
        }
    }
}
