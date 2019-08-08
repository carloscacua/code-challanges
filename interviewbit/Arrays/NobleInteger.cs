using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class NobleInteger
    {
        public static int solve(List<int> A)
        {
            A.Sort();
            for (int i = 0; i < A.Count; i++)
                if (A.Count - 1 - i == A[i] && (i == A.Count -1 || A[i+1] > A[i])) 
                {
                    return 1;
                }

            return -1;

            /*
             * wrong solution trying to solve if any integer exits no in array           
            var set = new Dictionary<int, int>();
            foreach(int i in A)
                if (set.ContainsKey(i)) 
                {
                    set[i]++;
                }
                else 
                {
                    set.Add(i, 1); 
                }

            for(int i = 0; i <=A.Count; i++) 
            {
                var lowers = 0;
                for (int j = 0; j < i; j++)
                    if (set.ContainsKey(j))
                        lowers += set[j];
                if (A.Count - lowers == i)
                    return i;
            }
            return -1;
            */           

        }
    }
}
