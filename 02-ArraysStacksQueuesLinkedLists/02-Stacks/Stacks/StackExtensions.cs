using System;
using System.Collections.Generic;

namespace Stacks
{
    public static class StackExtensions
    {
        public static void Print<T>(this Stack<T> stack)
        {
            var array = stack.ToArray();

            foreach(var item in array)
                Console.Write(item.ToString() + "\t");
        }
    }
}