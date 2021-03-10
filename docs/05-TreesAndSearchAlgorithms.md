**What is a tree?**
A tree is a data structure that is used to represent data in some form a hierarchical form. Trees have a single root node and depending on the type of tree each node has between 1 and n number of nodes. 

    root
   /     \
  a       b
 / \     /  \
c   d   e    f

# Demo

```
public class Node
{
    public int Value {get;set;}

    public Node Left {get;set;}

    public Node Right {get;set;}
}

public class Node
{
    public int Value {get;set;}

    public List<Node> Children {get;set;}
}

public class Tree
{
    public Node Root {get;set;}

    //potentially other methods and properties here
}
```

**How do we search in trees?**
There are severval common algorithms that can be used depending on the use case. There are many more specific algorithms that are optimized based on knowledge of the tree

**What is Breadth First Search?**
BFS is a search algorithm where a search is performed across the width of the tree, where the closest nodes are discovered first

**What is Depth First Search**
DFS is a search algorithm where a search is performed to the end of the tree

```
public class Tree
{
    public Node Root {get;set;}

    public void DisplayBFS()
    {
        Queue<Node> queue = new Queue<Node>();
		queue.Enqueue(Root);
		
		while(queue.Count > 0)
		{
			var current = queue.Dequeue();
			
			if(current == null)
				return;
				
			Console.WriteLine(current.Value);
			queue.Enqueue(current.Left);
			queue.Enqueue(current.Right);
		}
    }

    public void DisplayDFS()
    {
        Stack<Node> stack = new Stack<Node>();
        stack.Push(Root);
        
        while(stack.Count > 0)
        {
            var current = stack.Pop();
            
            Console.WriteLine(current.Value);
            
            if(current.Right != null)
                stack.Push(current.Right);

            if (current.Left != null)
                stack.Push(current.Left);
        }
    }
}

Tree t = new Tree();
	
var seven = new Node{Value = 7};
var six = new Node{Value = 6};
var five = new Node{Value = 5};
var four = new Node{Value = 4};
var three = new Node{Value = 3, Left = six, Right = seven};
var two = new Node{Value = 2, Left = four, Right = five};
var one = new Node{Value = 1, Left = two, Right = three};
t.Root = one;

t.DisplayBFS();
t.DisplayDFS();
```

**What is recursion?**
Recursion is a way to break a problem into pieces and solve the individual pieces.
Search algorithms and sorting algorithms are the most frequent users of recursion, most developers typically avoid it.

```
public void DisplayDFSRecursive(Node node)
{
    Console.WriteLine(node.Value);
    if(node.Left != null)
        DisplayDFSRecursive(node.Left);
        
    if(node.Right != null)
        DisplayDFSRecursive(node.Right);
}
```