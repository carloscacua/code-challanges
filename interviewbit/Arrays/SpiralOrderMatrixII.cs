using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class SpiralOrderMatrixII
    {
        public static List<List<int>> generateMatrix(int A)
        {
            List<List<int>> result = new List<List<int>>(A);
            for (int i = 0; i < A; i++)
                result.Add(Enumerable.Repeat(0, A).ToList());
             
            int d = 0, t = 0, l = 0, r = A - 1, b = A - 1, val = 1;
            while (l <= r && t <= b)
            {
                switch (d)
                {
                    case 0:
                        for (int i = l; i <= r; i++)
                            result[t][i] = val++;
                        t++;
                        break;
                    case 1:
                        for (int i = t; i <= b; i++)
                            result[i][r] = val++;
                        r--;
                        break;
                    case 2:
                        for (int i = r; i >= l; i--)
                            result[b][i] = val++;
                        b--;
                        break;
                    default:
                        for (int i = b; i >= t; i--)
                            result[i][l] = val++;
                        l++;
                        break;
                }
                d = (d + 1) % 4;

            }
            return result;


        }
    }
}
