using System;
using System.Collections.Generic;

namespace Cracking.DemoTest2
{
    public class Graph<T>
    {
        private bool Directed;
        private HashSet<T> _visited;
        public Dictionary<T, HashSet<T>> AdjacencyList;

        public Graph(bool directed, int numOfVertices = 1)
        {
            Directed = directed;
            _visited = new HashSet<T>(numOfVertices);
            AdjacencyList = new Dictionary<T, HashSet<T>>(numOfVertices);
        }

        public bool IsVisited(T e) 
        {
            return _visited.Contains(e);
        }

        public void Visit(T e) 
        {
            _visited.Add(e);
        }

        public void AddVertex(T a) 
        {
            if (!AdjacencyList.ContainsKey(a)) AdjacencyList.Add(a, new HashSet<T>());
        }

        public void AddEdge(T a, T b) 
        {
            if (!AdjacencyList.ContainsKey(a)) AdjacencyList.Add(a, new HashSet<T>());

            AdjacencyList[a].Add(b);

            if (!Directed) 
            {
                if (!AdjacencyList.ContainsKey(b)) AdjacencyList.Add(b, new HashSet<T>());

                AdjacencyList[b].Add(a);
            }
        }
    }

    public static class IsATree
    {
        public static bool solve(List<(int, int)> edges, int numOfVertices)
        {
            var graph = new Graph<int>(false, numOfVertices);

            for (int i = 0; i < numOfVertices; i++)
                graph.AddVertex(i);

            foreach (var edge in edges)
                graph.AddEdge(edge.Item1, edge.Item2);

            var isATree = numOfVertices == 0 || !HaveCicles<int>(graph, 0, -1);

            for (int i = 0; i < numOfVertices && isATree; i++)
                isATree = isATree && graph.IsVisited(i);

            return isATree;
        }

        public static bool HaveCicles<T> (Graph<T> graph, T start, T parent) where T : IComparable
        {
            graph.Visit(start);
            foreach (var child in graph.AdjacencyList[start]) 
            {
                if (graph.IsVisited(child) && child.CompareTo(parent) != 0)
                    return true;
                if (!graph.IsVisited(child) && HaveCicles(graph, child, start))
                    return false;
            }
            return false;
        }
    }
}
