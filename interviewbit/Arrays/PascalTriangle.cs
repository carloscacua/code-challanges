using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class PascalTriangle
    {
        public static List<List<int>> solve(int A)
        {
            if (A < 0) return null;

            List<List<int>> result = new List<List<int>>(A);
            for (int i = 0; i < A; i++) 
            {
                result.Add(new List<int>(i + 1));
                for(int j = 0; j <= i; j++) 
                {
                    if(j == 0|| j == i) 
                    {
                        result[i].Add(1); 
                    }
                    else 
                    {
                        result[i].Add(result[i - 1][j - 1] + result[i - 1][j]); 
                    } 
                } 
            }

            return result;
        }
    }
}
