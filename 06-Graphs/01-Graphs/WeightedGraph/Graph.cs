using System;
using System.Collections.Generic;
using System.Linq;

namespace WeightedGraph
{
    public class Graph
    {
        public Graph()
        {
            _edges = new List<Edge>();
            _vertexes = new List<Vertex>();
        }

        public void AddEdge(Vertex source, Vertex destination, int weight)
        {
            bool sourceExists = false;
            bool destinationExits = false;
            foreach (var vertex in _vertexes)
            {
                if (vertex.Name == source.Name)
                    sourceExists = true;
                if (vertex.Name == destination.Name)
                    destinationExits = true;
            }

            if (!sourceExists)
                _vertexes.Add(source);

            if (!destinationExits)
                _vertexes.Add(destination);

            var edge = new Edge() { Source = source, Destination = destination, Weight = weight };
            _edges.Add(edge);

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

                var edges = current.GetEdges();

                int min = int.MaxValue;
                Vertex v = null;
                foreach (var edge in edges)
                {
                    if(edge.Weight < min)
                    {
                        min = edge.Weight;
                        v = edge.Destination;
                    }
                }
                
                if(v != null)
                    queue.Enqueue(v);
            }
        }

        public void FindPathDFS(Vertex source, Vertex destination)
        {
            Stack<Vertex> stack = new Stack<Vertex>();
            stack.Push(source);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                Console.Write(current.Name);

                if (current.Name == destination.Name)
                    return;

                Console.Write(" --> ");

                var orderedEdges = current.GetEdges().OrderByDescending(x => x.Weight);

                foreach (var vertex in orderedEdges)
                {
                    stack.Push(vertex.Destination);
                }
            }
        }

        private List<Edge> _edges {get;}
        private List<Vertex> _vertexes {get;}
    }
}