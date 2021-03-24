using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public static class LinkedListExtensions
    {
        public static void Print<T>(this LinkedList<T> linkedList)
        {
            var node = linkedList.First;
            while(node != null)
            {
                Console.WriteLine(node.Value.ToString());
                node = node.Next;
            }
        }
    }
}