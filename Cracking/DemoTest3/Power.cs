using System;
using Cracking.Graph;
using System.Collections.Generic;


namespace Cracking.DemoTest3
{
    public class Power
    {

        public static int Solve(int x, int n)
        {
            // (A*B)mod C = ((AmodC) * (BmodC))modC;

            var result = x;
            for (int i = 1; i < n; i++)
                result *= x;
            return result;

        }
    }
}
