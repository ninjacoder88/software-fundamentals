using System;

namespace BasicGraph
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
            g.AddEdge(a, b);
            g.AddEdge(b, c);
            g.AddEdge(b, d);
            g.AddEdge(d, e);
            g.AddEdge(c, e);

            //g.FindPathDFS(a, e);
            g.FindPathBFS(a, e);
        }
    }
}
