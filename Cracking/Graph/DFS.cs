using System;
namespace Cracking.Graph
{
    public static class DFS
    {
        public  static void solve<T>(Graph<T> nodo)
        {
            if (nodo == null) return;

            nodo.Visited = true;

            foreach(var child in nodo.Children) 
            {
                if (!child.Visited) 
                {
                    solve(nodo);
                }
            }

        }
    }
}
