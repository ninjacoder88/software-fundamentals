using System;
using System.Collections.Generic;

namespace WeightedGraph
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
            bool sourceExists = false;
            bool destinationExits = false;
            foreach (var vertex in Vertexes)
            {
                if (vertex.Name == source.Name)
                    sourceExists = true;
                if (vertex.Name == destination.Name)
                    destinationExits = true;
            }

            if (!sourceExists)
                Vertexes.Add(source);

            if (!destinationExits)
                Vertexes.Add(destination);

            var edge = new Edge() { Source = source, Destination = destination };
            Edges.Add(edge);

            source.AddEdge(edge);
        }

        public void FindPathBFS(Vertex source, Vertex desination)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(source);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                Console.Write(current.Name);

                if (current.Name == desination.Name)
                    return;

                Console.Write(" --> ");

                foreach (var vertex in current.GetDestinations())
                {
                    queue.Enqueue(vertex);
                }
            }
        }

        public void FindPathDFS(Vertex source, Vertex desination)
        {
            Stack<Vertex> stack = new Stack<Vertex>();
            stack.Push(source);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                Console.Write(current.Name);

                if (current.Name == desination.Name)
                    return;

                Console.Write(" --> ");

                foreach (var vertex in current.GetDestinations())
                {
                    stack.Push(vertex);
                }
            }
        }
    }
}