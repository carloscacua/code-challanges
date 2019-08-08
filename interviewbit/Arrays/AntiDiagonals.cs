using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class AntiDiagonals
    {
        public static List<List<int>> diagonal(List<List<int>> A)
        {
            var result = new List<List<int>>(A.Count);

            for(int i = 0; i < A.Count; i++) 
            {
                var tempResult = new List<int>(i + 1);
                for(int j = 0; j <= i; j++) 
                {
                    tempResult.Add(A[j][i - j]); 
                }
                result.Add(tempResult);
            }

            for (int i = 1; i < A.Count; i++)
            {
                var tempResult = new List<int>(i + 1);
                for (int j = A.Count - 1; j >= i; j--)
                {
                    tempResult.Add(A[i+(A.Count - 1 - j)][j]);
                }
                result.Add(tempResult);
            }
            return result;
        }
    }
}
