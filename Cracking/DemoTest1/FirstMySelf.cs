using System;
using System.Collections.Generic;

namespace Cracking.DemoTest1
{
    public class FirstMySelf
    {
        public static int solve(GraphExt<int> root, int dest)
        {
            if (root == null) return -1;

            var queue = new Queue<GraphExt<int>>();

            root.Steps = 0;

            while(queue.Count > 0) 
            {
                var node = queue.Dequeue();

                if (node.Visited) 
                {
                    continue;
                }
                else
                {
                    if (node.Value == dest) return node.Steps;
                    node.Visited = true;
                    foreach(var child in node.Children) 
                    {
                        var childExt = child as GraphExt<int>;
                        if (!childExt.Visited) 
                        {
                            childExt.Steps = node.Steps + 1;
                            queue.Enqueue(childExt);
                         } 
                    }


                }
            }

            return -1;


        }
    }
}
