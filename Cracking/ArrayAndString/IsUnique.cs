using System;
namespace Cracking
{
    public static class IsUnique
    {
        public static bool solve(char[] arg) 
        {
            for(int i = 0; i < arg.Length + 1; i++) 
            {
                if (arg[i] != arg[i + 1]) return false;
            }
            return true;
        }
    }
}
