using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cracking
{
    public static class StringCompression
    {
        public static string solve(string a) 
        {
            StringBuilder result = new StringBuilder();

            int repeatedChar = 0;
            for (int i = 0; i < a.Length; i++) 
            {
                repeatedChar++;
                if(i + 1 == a.Length ||  a[i] != a[i + 1]) 
                {
                    result.Append(a[i].ToString());
                    result.Append(repeatedChar.ToString());
                    repeatedChar = 0;
                 }
            }

            return result.ToString();

        }
    }
}
