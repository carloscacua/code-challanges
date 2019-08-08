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

            queue.Enqueue(nodo);

            while (queue.Count == 0) 
            {
                var elem = queue.Dequeue();
                elem.Visited = true;
                foreach(var child in elem.Children) 
                {
                    queue.Enqueue(child);
                }


            }

        }
    }
}
