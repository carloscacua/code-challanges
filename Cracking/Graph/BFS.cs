using System.Collections.Generic;
using Cracking.Graph;

namespace Cracking.Graph
{
    public static class BFS
    {
        public static void solve<T>(Graph<T> nodo)
        {
            if (nodo == null) return;

            var queue = new Queue<Graph<T>>();

            nodo.Visited = true;
            queue.Enqueue(nodo);

            while (queue.Count == 0) 
            {
                var elem = queue.Dequeue();
                foreach(var child in elem.Children) 
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        queue.Enqueue(child);
                    }   
                }


            }

        }
    }
}
