using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Array*/
            int[] array = new int[3];
            array[0] = 5;
            array[1] = 8;

            /*Stack*/
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Pop();
            stack.Push("C");
            stack.Pop();
            stack.Pop();

            /*Queue*/
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Dequeue();
            queue.Enqueue("C");
            queue.Dequeue();
            queue.Dequeue();

            /*Linked List*/
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(new LinkedListNode<int>(7));
            linkedList.AddLast(new LinkedListNode<int>(8));
            linkedList.AddLast(new LinkedListNode<int>(9));
            linkedList.AddLast(new LinkedListNode<int>(10));

            var current = linkedList.First;
            while(current != null)
            {
                Console.WriteLine(current.Value);

                current = current.Next;
            }

            //linkedList.Print();
        }
    }
}
