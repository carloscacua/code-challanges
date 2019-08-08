using System;
using Cracking.Graph;
using System.Collections.Generic;

namespace Cracking.DemoTest1
{
    public class MinimunPath
    {
        public static int Solve(Graph<Tuple<int, int>> root, Tuple<int, int> dest)
        {
            if (root == null) return -1;

            var queue = new Queue<Tuple<Graph<Tuple<int, int>>, int>>();

            queue.Enqueue(new Tuple<Graph<Tuple<int, int>>, int>(root, 0));

            while(queue.Count != 0) 
            {
                var first = queue.Dequeue();

                if (first.Item1.Value == dest) return first.Item2;

                if (first.Item1.Visited)
                {
                    continue;
                }
                else 
                {
                    first.Item1.Visited = true;

                    foreach (var neigthboord in first.Item1.Children)
                        if (!neigthboord.Visited)
                        {
                            queue.Enqueue(new Tuple<Graph<Tuple<int, int>>, int>(neigthboord, first.Item2 + 1));
                        }
                }
            }
            return -1;

        }
    }
}