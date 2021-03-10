using System;

namespace TreesAndSearchAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree<string> t = new Tree<string>();
	
            var nine = new TreeNode<string>{Value = "9"};
            var seven = new TreeNode<string>{Value = "7"};
            var six = new TreeNode<string>{Value = "6"};
            var five = new TreeNode<string>{Value = "5"};
            var four = new TreeNode<string>{Value = "4", Right = nine};
            var three = new TreeNode<string>{Value = "3", Left = six, Right = seven};
            var two = new TreeNode<string>{Value = "2", Left = four, Right = five};
            var one = new TreeNode<string>{Value = "1", Left = two, Right = three};
            t.Root = one;

            t.DisplayBFS();
            Console.WriteLine();
            t.DisplayDFS();
            Console.WriteLine();
            t.DisplayDFSRecursive(t.Root);

            //Generic<TreeNode> a = new Generic<TreeNode>();
            //a.Process(five);
        }
    }
}
