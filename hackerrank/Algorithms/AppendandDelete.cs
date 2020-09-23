using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hackerrank.Algorithms
{
    /*
     * Solve this problem: https://www.hackerrank.com/challenges/append-and-delete/problem
     */
    public static class AppendandDelete
    {
        public static bool solve(string s, string t, int k)
        {
            var min = Math.Min(s.Length, t.Length);

            var newS = s.Substring(0, min).ToCharArray();
            var newT = t.Substring(0, min).ToCharArray();

            var lowerDiff = min;
            for (int i = 0; i < min; i++)
                if (newS[i] != newT[i])
                {
                    lowerDiff = i;
                    break;
                }

            var deletes = s.Length - lowerDiff;
            var appends = t.Length - lowerDiff;

            var remaining = k - (deletes + appends);

            return remaining >= 0 && (remaining >= lowerDiff || remaining % 2 == 0);
        }

        public static void run()
        {
            Console.WriteLine($"AppendandDelete - 'qwerasdf' - 'qwerbsdf - 6 : {solve("qwerasdf", "qwerbsdf", 6)}");
            Console.WriteLine($"AppendandDelete - 'ashley' - 'ash' - 2 : {solve("ashley", "ash", 2)}");
            Console.WriteLine($"AppendandDelete - 'aba' - 'aba - 7 : {solve("aba", "aba", 7)}");
        }


        //First 
        public static int camelcase(string s)
        {
            var arr = s.ToCharArray();
            var num = string.IsNullOrEmpty(s) ? 0 : 1;
            foreach (var i in arr)
                if (Char.IsUpper(i))
                    num++;
            return num;

        }

        public static int beter(int n)
        {
            var best = 1;
            var bestSum = 1;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    var c = getSum(i);
                    if (c > bestSum)
                    {
                        best = i;
                        bestSum = c;
                    }
                        
                }
            }
            return best;
        }

        public static int getSum(int n)
        {
            var result = 0;
            while (n >= 10)
            {
                result += n % 10;
                n = n / 10;
            }
            return result + n;
        }


        //Second

        static int sockMerchant(int n, int[] ar)
        {

            var dict = new Dictionary<int, int>();
            foreach (int i in ar)
                if (dict.ContainsKey(i))
                    dict[i]++;
                else
                    dict[i] = 1;


            var pairs = 0;

            foreach (KeyValuePair<int, int> s in dict)
                pairs += s.Value / 2;

            return pairs;
        }

        public static string isValid(string s)
        {
            var dict = new Dictionary<char, int>();
            var arr = s.ToCharArray();
            foreach (char i in arr)
                if (dict.ContainsKey(i))
                    dict[i]++;
                else
                    dict[i] = 1;

            var map = new Dictionary<int, int>();

            foreach (KeyValuePair<char, int> t in dict)
                if (map.ContainsKey(t.Value))
                    map[t.Value]++;
                else
                    map[t.Value] = 1;

            int min = int.MaxValue;
            int minValu = int.MaxValue;
            if (map.Keys.Count > 2) return "NO";

            foreach (KeyValuePair<int, int> t in map)
            {
                if (t.Key < min)
                {
                    min = t.Key;
                    minValu = t.Value;
                }
                    
            }

            foreach (KeyValuePair<int, int> t in map)
            {

                if (t.Key != min && t.Value > 1) return "NO";
                    
            }

            return "YES";
        }

        public static int prisioner(int n, int m, int s)
        {
            return (s - 1 + m) % n + 1;
        }

        public static int countOfAnagramSubstring(string s)
        {
            int n = s.Length;

            var m = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                List<char> freq = new List<char>();

                for (int j = i; j < n; j++)
                {
                    freq.Add(s[j]);
                    freq.Sort();

                    var freqs = new string(freq.ToArray());
                    if (m.ContainsKey(freqs))
                    {
                        m[freqs]++;
                    }
                    else
                    {
                        m.Add(freqs, 1);
                    }
                }
            }

            int result = 0;
            foreach (KeyValuePair<string, int> t in m)
            {

                result += ((t.Value) * (t.Value - 1)) / 2;
            }
            return result; 
        }

        public static int pickingNumbers(List<int> a)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i <= 101; i++)
            {
                map.Add(i, 0);
            }

            foreach (int i in a)
            {
                map[i]++;
            }

            var result = 0;
            for (int i = 0; i < 100; i++)
            {
                var curre = map[i] + map[i + 1];
                result = Math.Max(curre, result);
            }
            return result;
        }

        public static int minTime(int[][] roads, int[] machines)
        {


        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[][] roads = new int[n - 1][];

            var temp = new Dictionary<int, List<Tuple<int, int>>>();

            for (int i = 0; i < n - 1; i++)
            {
                roads[i] = Array.ConvertAll(Console.ReadLine().Split(' '), roadsTemp => Convert.ToInt32(roadsTemp));

                var t = new List<Tuple<int, int>();

                temp.Add()
            }

            int[] machines = new int[k];

            for (int i = 0; i < k; i++)
            {
                int machinesItem = Convert.ToInt32(Console.ReadLine());
                machines[i] = machinesItem;
            }

            int result = minTime(roads, machines);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
