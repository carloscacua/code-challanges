using System;
using Cracking.Graph;
using System.Collections.Generic;
using System.Linq;

namespace Cracking.DemoTest3
{
    public class BubbleSort
    {
        public static List<int> Sort(List<int> l)
        {
            var temp = 0;
            for(int i = 0; i < l.Count; i++)
                for(int j = i; j < l.Count - 1; j++)
                    if(l[j] > l[j + 1]) 
                    {
                        temp = l[j];
                        l[j] = l[j + 1];
                        l[j + 1] = temp;
                    }

            return l;
        }
    }
}
