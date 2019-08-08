// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
using System.Linq;
using System;
public class GCD
{
    // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public int generalizedGCD(int num, int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return 0;
        }
        var gcd = arr.Min();

        foreach (int i in arr)
            gcd = Gcd(gcd, i);

        return gcd;

    }

    private static int Gcd(int a, int b)
    {
        int t = 0;
        while (b != 0)
        {
            t = b;
            b = a % b;
            a = t;
        }
        return Math.Abs(a);
    }
    // METHOD SIGNATURE ENDS
}