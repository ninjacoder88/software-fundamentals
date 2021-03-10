**What is a graph?**
A graph is a data structure similar to a tree, but it does not necessarily have a starting point. A graph is a group of nodes with connections between the nodes called edges. There are many types of graphs and variations typically depend on the definition of the edges.

# Demo

```
public class Node
{
    public string Value {get;set;}
}

public class Edge
{
    public Edge(Node source, Node destination)
    {
        Source = source;
        Destination = destination
    }

    public Node Source {get;}
    public Node Destination {get;}
}

public class Graph
{
    public Graph()
    {
        Nodes = new List<Node>();
        Edges = new List<Edge>();
    }

    private List<Node> Nodes {get;set;}
    private List<Edge> Edges {get;set;}

    public void AddNode(Node node)
    {
        Nodes.Add(node);
    }

    public void AddEdge(Node source, Node destination)
    {
        Edges.Add(new Edge(source, destination));
    }

    public void AddEdge(string sourceName, string destinationName)
    {
        Node source = null;
        Node destination = null;
        for(int i = 0; i < Nodes.Count; i++)
        {
            if(Nodes[i].Value == sourceName)
                source = Nodes[i];

            if(Nodes[i].Value == destinationName)
                destination = Nodes[i];
        }

        if(source == null || destination == null)
            throw new Exception();

        AddEdge(source, destination);
    }

    public void FindPath(string sourceName, string destinationName)
    {
        Node source;
        for(int i = 0; i < Edges.Count; i++)
        {
            if(Edges[i].Source.Value == sourceName)
            {
                source = Nodes[i];
                break;
            }
        }

        var current = source;
        while(true)
        {
            if
        }
    }
}
```