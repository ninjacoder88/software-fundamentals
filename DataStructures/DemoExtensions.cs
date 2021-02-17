using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public static class DemoExtensions
    {
        public static void Print(this int[] array)
        {
            foreach(var item in array)
                Console.WriteLine(item.ToString());
        }

        public static void Print<T>(this Stack<T> stack)
        {
            var array = stack.ToArray();

            foreach(var item in array)
                Console.WriteLine(item.ToString());
        }

        public static void Print<T>(this Queue<T> queue)
        {
            var array = queue.ToArray();

            foreach(var item in array)
                Console.WriteLine(item.ToString());
        }

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