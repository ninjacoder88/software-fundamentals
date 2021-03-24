using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
        }
    }
}
