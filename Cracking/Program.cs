using System.Collections.Generic;
using System.IO;
using System;
using Cracking;

class Solution
{
  
    static void Main(string[] args)
    {
        var text = "asas";
        Console.WriteLine($"Is Uniqie : {text} - {IsUnique.solve(text.ToCharArray())}" );
    }
}
