using System.Collections.Generic;
namespace Cracking.Graph
{
    public class Graph<T>
    {
        public T Value;
        public bool Visited;
        public List<Graph<T>> Children;
    }
}