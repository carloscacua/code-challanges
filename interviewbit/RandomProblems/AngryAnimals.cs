using System;
using System.Collections.Generic;
using System.Linq;

namespace interviewbit.RandomProblems
{
    public static class AngryAnimals
    {
        /*
         * Complete the 'angryAnimals' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY a
         *  3. INTEGER_ARRAY b
         */

        public static long solve(int n, List<int> a, List<int> b)
        {
            var e = new Dictionary<int,int>();
            for (int i = 0; i < a.Count && i < b.Count; i++)
            {
                addEnemy(e, Math.Max(a[i], b[i]), Math.Min(a[i], b[i]));
            }
            int low = 1, high = 1, result = 0;

            while (low <= n) 
            {
                while (high <= n && !NewElementCreatesConflict(e, low, high)) 
                {
                    high++;
                }

                result += high - low++;
            }

            return result ;
        }

        private static bool NewElementCreatesConflict(Dictionary<int, int> enemies, int low, int high) 
        {
            return enemies.ContainsKey(high) && enemies[high] >= low && enemies[high] < high;
        }

        private static void addEnemy(Dictionary<int, int> enemies, int a, int b)
        {
            if (enemies.ContainsKey(a)) 
            {
                if (enemies[a] < b)
                    enemies[a] = b;
            }
            else 
            {
                enemies.Add(a, b);
            }
        }
    }
}
