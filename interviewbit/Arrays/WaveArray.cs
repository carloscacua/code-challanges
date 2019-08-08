using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class WaveArray
    {
        public static List<int> wave(List<int> A)
        {
            A.Sort();

            var limit = A.Count % 2 == 0 ? A.Count : A.Count - 1;
            for (int i =0; i < limit; i =i + 2) 
            {
                var temp = A[i];
                A[i] = A[i + 1];
                A[i + 1] = temp; 
            }

            return A;
        }
    }
}
