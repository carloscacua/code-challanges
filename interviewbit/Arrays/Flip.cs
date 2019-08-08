using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class Flip
    {
        public static List<int> Solve(string A)
        {
            int localStart = 1, localEnd = 0, start = -1, end = -1,
                currentMax = 0, globalMax = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if(currentMax - (A[i] - '0') < 0) 
                {
                    localStart = i + 2;
                    localEnd = i + 1;
                    currentMax = 0;

                }
                else
                {
                    currentMax = A[i] == '0'? currentMax + 1: currentMax - 1;
                    localEnd++;
                }

                if(currentMax > globalMax) 
                {
                    start = localStart;
                    end = localEnd;
                    globalMax = currentMax; 
                }
            }

            return start >0 && end >0 ? new List<int> {start, end} : new List<int>();
        }
    }
}
