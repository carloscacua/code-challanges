using System;
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
    }
}
