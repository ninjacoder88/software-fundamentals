using System;

namespace Stacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Pop();
            stack.Push("C");
            stack.Pop();
            stack.Pop();

            stack.Print();

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Push(3);
            stack.Pop();
            stack.Pop();

            stack.Print();

        }
    }
}
