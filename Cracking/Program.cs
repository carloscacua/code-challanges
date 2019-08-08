using System.Collections.Generic;
using System.IO;
using System;

class Solution
{
    // Complete the oddNumbers function below.
    static List<int> oddNumbers(int l, int r)
    {
        var res = new List<int>((r - l) / 2);
        if (l % 2 == 0) l++;
        for (int i = l; i < r; i = i + 2)
            res.Add(i);
        return res;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        int r = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> res = oddNumbers(l, r);

        textWriter.WriteLine(String.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
