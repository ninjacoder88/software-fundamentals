using System;
using System.Collections.Generic;

namespace BasicGraph
{
    public class Graph
    {
        public Graph()
        {
            _edges = new List<Edge>();
            _vertexes = new List<Vertex>();
        }

        public void AddEdge(Vertex source, Vertex destination)
        {
            bool sourceExists = false;
            bool destinationExists = false;
            foreach(var vertex in _vertexes)
            {
                if(vertex.Name == source.Name)
                    sourceExists = true;
                if(vertex.Name == destination.Name)
                    destinationExists = true;
            }

            if(!sourceExists)
                _vertexes.Add(source);

            if(!destinationExists)
                _vertexes.Add(destination);

            var edge = new Edge(){Source = source, Destination = destination};
            _edges.Add(edge);

            source.AddEdge(edge);
        }

        public void FindPathBFS(Vertex source, Vertex destination)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(source);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.Write(current.Name);

                if(current.Name == destination.Name)
                    return;

                Console.Write(" --> ");

                foreach(var edge in current.GetEdges())
                {
                    queue.Enqueue(edge.Destination);
                }
            }
        }

        public void FindPathDFS(Vertex source, Vertex desination)
        {
            Stack<Vertex> stack = new Stack<Vertex>();
            stack.Push(source);

            while(stack.Count > 0)
            {
                var current = stack.Pop();
                Console.Write(current.Name);

                if(current.Name == desination.Name)
                    return;

                Console.Write(" --> ");

                foreach(var edge in current.GetEdges())
                {
                    stack.Push(edge.Destination);
                }
            }
        }

        private List<Edge> _edges {get;}
        private List<Vertex> _vertexes {get;}
    }
}