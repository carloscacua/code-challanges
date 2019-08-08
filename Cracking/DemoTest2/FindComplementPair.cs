using System.Collections.Generic;
using System;
namespace Cracking.DemoTest2
{
    public class FindComplementPair
    {
        public static (int, int) solveWithHash(int[] arr, int x)
        {
            var dict = new HashSet<int>();

            foreach (int e in arr)
                dict.Add(e);

            foreach (int e in arr)
                if (dict.Contains(x - e)) return (e, x - e);

            return (-1, -1);

        }

        public static (int, int) solveWithBS(int[] arr, int x)
        {
            Array.Sort(arr);
            foreach (int e in arr)
                if (BST(arr, x - e))
                    return (e, x - e);

            return (-1, -1);
        }

        public static bool BST(int[] arr, int e) 
        {
            int l = 0, r = arr.Length - 1; 
            while(l <= r) 
            {
                var mid = r / 2;
                if(mid == e) return true;
                if (arr[mid] < e) l = mid + 1;
                if (arr[mid] > e) r = mid + 1;

            }
            return false;
        }
    }
}
