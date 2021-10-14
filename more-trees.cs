/*This goes in the executing part of your program, the Main() method*/
public void Main()
{
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
}

public class Node
{
    public int Value {get;set;}

    public Node Left {get;set;}

    public Node Right {get;set;}
}

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
			
			Console.WriteLine(current.Value);
			if(current.Left != null)
				queue.Enqueue(current.Left);

			if(current.Right != null)
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

