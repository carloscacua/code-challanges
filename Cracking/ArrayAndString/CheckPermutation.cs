using System;
using System.Collections.Generic;
using System.Linq;

namespace Cracking.ArrayAndString
{
    /*
     * Check Permutation: Given two strings,
     * write a method to decide if one is a permutation of the other.
     * Hints: #1, #84, #122, #131   
     */   
    public static class CheckPermutation
    {
        public static bool solve(char[] item1, char[] item2)
        {
            var chars = new Dictionary<char, int>();
            foreach(char letter in item1) 
            {
                chars[letter] = chars.ContainsKey(letter) ? chars[letter]+1 : 1;
             }
            foreach (char letter in item2)
            {
                chars[letter] = chars.ContainsKey(letter) ? chars[letter]-1 : -1;
            }
            return chars.All(c => c.Value == 0);
        }
    }
}

