using System;
using System.Collections.Generic;

namespace BasicGraph
{
    public class Graph
    {
        public Graph()
        {
            Edges = new List<Edge>();
            Vertexes = new List<Vertex>();
        }

        private List<Edge> Edges {get;}

        private List<Vertex> Vertexes {get;}

        public void AddEdge(Vertex source, Vertex destination)
        {
            
        }

        public void FindPath(Vertex source, Vertex desination)
        {
            
        }
    }
}