using System;
using Cracking.Graph;
using System.Collections.Generic;


namespace Cracking.DemoTest1
{
    public class GraphExt<T> : Graph<T>
    {
        public int Steps;
    }

    public class MinimunPath2
    {
        public static int Solve(GraphExt<Tuple<int, int>> root, Tuple<int, int> dest)
        {
            if (root == null) return -1;

            var queue = new Queue<GraphExt<Tuple<int, int>>>();

            root.Steps = 0;
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var first = queue.Dequeue();

                if (first.Value == dest) return first.Steps;

                if (first.Visited)
                {
                    continue;
                }
                else
                {
                    first.Visited = true;

                    foreach (var neigthboord in first.Children)
                        if (!neigthboord.Visited)
                        {
                            (neigthboord as GraphExt<Tuple<int, int>>).Steps = first.Steps + 1;
                            queue.Enqueue((neigthboord as GraphExt<Tuple<int, int>>));
                        }
                }
            }
            return -1;

        }
    }
}
