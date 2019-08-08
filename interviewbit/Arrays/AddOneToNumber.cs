using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interviewbit.Arrays
{
    public static class AddOneToNumber
    {
        public static List<int> plusOne(List<int> A)
        {
            while (A.Any())
            {
                if (A.First() == 0)
                {
                    A.RemoveAt(0);
                }
                else
                {
                    break;
                }
            }
            A.Reverse();
            var result = new List<int>(A.Count + 1);
            int residue = 1;
            for (int i = 0; i < A.Count; i++)
            {
                var temp = (A[i] + residue) % 10;
                result.Add(temp);
                residue = residue != 0 && temp == 0 ? 1 : 0;
            }
            if (residue == 1)
                result.Add(1);

            result.Reverse();
            return result;
        }
    }
}
