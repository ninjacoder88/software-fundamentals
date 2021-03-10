using System;
using System.Collections.Generic;

namespace TreesAndSearchAlgorithms
{
    public class Tree<T>
    {
        public TreeNode<T> Root {get;set;}

        public void DisplayBFS()
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);

            while(queue.Count > 0)
            {
                TreeNode<T> current = queue.Dequeue();

                Console.WriteLine(current.Value);
                if(current.Left != null)
                    queue.Enqueue(current.Left);

                if(current.Right != null)
                    queue.Enqueue(current.Right);
            }
        }

        public void DisplayDFS()
        {
            Console.WriteLine($"Start");
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(Root);

            while(stack.Count > 0)
            {
                var current = stack.Pop();

                Console.WriteLine(current.Value);

                if(current.Right != null)
                    stack.Push(current.Right);

                if(current.Left != null)
                    stack.Push(current.Left);
            }
            Console.WriteLine($"Stop");
        }

        public void DisplayDFSRecursive(TreeNode<T> node)
        {
            Console.WriteLine($"Start {node.Value}");

            if(node.Left != null)
                DisplayDFSRecursive(node.Left);
            
            if(node.Right != null)
                DisplayDFSRecursive(node.Right);

            Console.WriteLine($"Stop {node.Value}");
        }
    }
}