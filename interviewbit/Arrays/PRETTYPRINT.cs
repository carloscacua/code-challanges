using System;
using System.Collections.Generic;
using System.Linq;

namespace interviewbit.Arrays
{
    public static class PRETTYPRINT
    {
        public static List<List<int>> prettyPrint(int A)
        {
            int n = A * 2 - 1;
            var result = new List<List<int>>(n);
            for (int i = 0; i < n; i++)
                result.Add(Enumerable.Repeat(0, n).ToList());

            int l = 0, r = n-1, t = 0, b = n-1, d = 0, val = A;

            while(l <= r && t <= b) 
            {
                switch (d)
                {
                    case 0:
                        {
                            for (int i = l; i <= r; i++)
                                result[t][i] = val;
                            t++;
                            break; 
                        }
                    case 1:
                        {
                            for (int i = t; i <= b; i++)
                                result[i][r] = val;
                            r--;
                            break;
                        }
                    case 2:
                        {
                            for (int i = r; i >= l; i--)
                                result[b][i] = val;
                            b--;
                            break;
                        }
                    default:
                        {
                            for (int i = b; i >= t; i--)
                                result[i][l] = val;
                            l++;
                            break;
                        }
                }

                d = ++d % 4;
                if (d == 0) val--;
            }

            return result; 
        }
    }
}
