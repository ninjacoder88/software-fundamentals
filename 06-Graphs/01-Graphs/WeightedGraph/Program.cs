using System;

namespace WeightedGraph
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vertex a = new Vertex() { Name = "A" };
            Vertex b = new Vertex() { Name = "B" };
            Vertex c = new Vertex() { Name = "C" };
            Vertex d = new Vertex() { Name = "D" };
            Vertex e = new Vertex() { Name = "E" };

            Graph g = new Graph();
            g.AddEdge(a, b, 1);
            g.AddEdge(b, c, 1);
            g.AddEdge(b, d, 2);
            g.AddEdge(d, e, 1);
            g.AddEdge(c, e, 1);

            g.FindPathDFS(a, e);
        }
    }
}
