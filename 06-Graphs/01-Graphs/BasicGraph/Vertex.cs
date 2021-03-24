using System.Collections.Generic;
using System.Linq;

namespace BasicGraph
{
    public class Vertex
    {
        public Vertex()
        {
            Edges = new List<Edge>();
        }

        public string Name {get;set;}

        private List<Edge> Edges {get;set;}

        public IEnumerable<Edge> GetEdges()
        {
            return Edges;
        }

        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }
    }
}